using CapaAplicacion;
using CapaPresentacion.gVarPublicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CapaPresentacion.Contabilidad
{
    public partial class FormVerPagosPendientesXCobrar : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        public FormVerPagosPendientesXCobrar()
        {
            InitializeComponent();
        }
        public void cargarComprobantesVentasConCredito()
        {
            dgViewComprobantes.DataSource = managmentCaja.ServiceGetAllVentasConCreditos(GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
        }
        public void RedimensionarColumnas()
        {
            this.dgViewComprobantes.Columns["ID"].Width = 60;
            this.dgViewComprobantes.Columns["Fecha"].Width = 150;
            this.dgViewComprobantes.Columns["Documento"].Width = 100;
            this.dgViewComprobantes.Columns["Correlativo"].Width = 100;
            this.dgViewComprobantes.Columns["Estado"].Width = 90;
            this.dgViewComprobantes.Columns["Cliente"].Width = 350;
            this.dgViewComprobantes.Columns["Transaccion"].Width = 120;
            this.dgViewComprobantes.Columns["Total_Credito"].Width = 120;
            this.dgViewComprobantes.Columns["Total_Pagado"].Width = 120;
            this.dgViewComprobantes.Columns["Deuda"].Width = 80;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void cargarMontoCreditoDeudas()
        {
            DataTable montoCredito = managmentCaja.ServiceGetMontoCreditoDeudas();
            if(montoCredito.Rows.Count > 0)
            {
                txtAmortizado.Text = Convert.ToString(montoCredito.Rows[0]["Amortizado"]);
                txtCredito.Text = Convert.ToString(montoCredito.Rows[0]["Credito"]);
                txtDeuda.Text = Convert.ToString(montoCredito.Rows[0]["Deuda"]);
            }
        }
        private void FormVerPagosPendientesXCobrar_Load(object sender, EventArgs e)
        {
            cargarMontoCreditoDeudas();
            cargarComprobantesVentasConCredito();
            RedimensionarColumnas();
            AlternarColores(dgViewComprobantes);
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewComprobantes.Rows.Count, " registros.");
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagarCredito_Click(object sender, EventArgs e)
        {
            int ventaId;
            foreach (DataGridViewRow row in dgViewComprobantes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    ventaId = Convert.ToInt32(row.Cells[1].Value);
                    FormPagarCreditoEfectivo formPagarCreditoEfectivo = new FormPagarCreditoEfectivo();
                    formPagarCreditoEfectivo.correlativo = Convert.ToString(row.Cells[4].Value);
                    formPagarCreditoEfectivo.cliente = Convert.ToString(row.Cells[9].Value);
                    formPagarCreditoEfectivo.montoCredito = Convert.ToDecimal(row.Cells[6].Value);
                    formPagarCreditoEfectivo.montoAmortizado = Convert.ToDecimal(row.Cells[7].Value);
                    formPagarCreditoEfectivo.montoDeuda = Convert.ToDecimal(row.Cells[8].Value);
                    formPagarCreditoEfectivo.ventaId = ventaId;
                    formPagarCreditoEfectivo.esPagado = Convert.ToString(row.Cells[10].Value).Equals("PAGADO");
                    formPagarCreditoEfectivo.ShowDialog();
                    cargarComprobantesVentasConCredito();
                    cargarMontoCreditoDeudas();
                }
            }
        }

        private void dgViewComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgViewComprobantes.Columns["selecciona"].Index)
            {
                if(e.RowIndex != -1)
                {
                    DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgViewComprobantes.Rows[e.RowIndex].Cells["selecciona"];
                    CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
                    cargarMontoCreditoDeudas();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(rbCliente.Checked)
            {
                dgViewComprobantes.DataSource = new ManagmentVenta().ServiceGetVentaCreditoPorFiltro(1, txtBuscar.Text);
            }
            else if(rbSerieNumero.Checked)
            {
                dgViewComprobantes.DataSource = new ManagmentVenta().ServiceGetVentaCreditoPorFiltro(2, txtBuscar.Text);
            }
            else if(rbCodUser.Checked)
            {
                dgViewComprobantes.DataSource = new ManagmentVenta().ServiceGetVentaCreditoPorFiltro(3, txtBuscar.Text);
            }
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewComprobantes.Rows.Count, " registros.");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApplication = new Excel.Application();
                xlApplication.Visible = false;
                //Visible progres bar
                pb1.Visible = true;
                //Get a new workbook.
                xlLibro = xlApplication.Workbooks.Add(Missing.Value);
                xlHoja = (Excel._Worksheet)xlLibro.ActiveSheet;
                xlHoja.Name = "REP_PAGOS_PENDIENTES";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_GENERAL_DEUDORES.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraPagosPendientes();
                if (GenerarExcelCuerpoPagosPendientes())
                {
                    xlApplication.Visible = true;
                    xlApplication.UserControl = false;
                    xlLibro.SaveAs(folder + nombre);
                    pb1.Visible = false;
                    pb1.Value = 0;
                }
                else
                {
                    MessageBox.Show("¡No existen datos para mostrar!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        private bool GenerarExcelCuerpoPagosPendientes()
        {
            DataTable getAllPagosPendientes = managmentCaja.ServiceGetAllVentasConCreditos(GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
            long nFilas = 6;
            long contador = 0;

            pb1.Maximum = getAllPagosPendientes.Rows.Count;
            pb1.Value = 1;

            foreach (DataRow row in getAllPagosPendientes.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Fecha"];
                xlHoja.Cells[nFilas, 4] = row["Documento"];
                xlHoja.Cells[nFilas, 5] = row["Correlativo"];
                xlHoja.Cells[nFilas, 6] = row["Cod_Trabajador"];
                xlHoja.Cells[nFilas, 6].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 7] = row["Total_Credito"];
                xlHoja.Cells[nFilas, 7].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 8] = row["Total_Pagado"];
                xlHoja.Cells[nFilas, 8].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 9] = row["Deuda"];
                xlHoja.Cells[nFilas, 9].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 10] = row["Cliente"];
                xlHoja.Cells[nFilas, 11] = row["Estado"];
                pb1.PerformStep();
            }
            for (long i = 6; i <= 6 + getAllPagosPendientes.Rows.Count; i++)
            {
                for (int j = 2; j <= 11; j++)
                {
                    if (j >= 7 && j <= 9)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    }
                    else if (j == 5)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    }
                    else
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }
            }
            bool ExistenRegistros = getAllPagosPendientes.Rows.Count > 0 ? true : false;
            return ExistenRegistros;
        }

        private void GenerarExcelCabeceraPagosPendientes()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE DEUDORES - PAGOS PENDIENTES";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:K2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:K2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:K2"].Font.Size = 14;
            xlHoja.Range["B2:K2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:P2"].Font.Bold = true;
            xlHoja.Range["B3:P3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A6:A6"].ColumnWidth = 4;

            xlHoja.Range["B6:B6"].ColumnWidth = 4; //Nro
            xlHoja.Range["C6:C6"].ColumnWidth = 18; //Fecha
            xlHoja.Range["D6:D6"].ColumnWidth = 12; //Documento
            xlHoja.Range["E6:E6"].ColumnWidth = 16; //Correlativo
            xlHoja.Range["F6:F6"].ColumnWidth = 12; //Usuario reg
            xlHoja.Range["G6:G6"].ColumnWidth = 15; //Total crédito
            xlHoja.Range["H6:H6"].ColumnWidth = 15;
            xlHoja.Range["I6:I6"].ColumnWidth = 15;
            xlHoja.Range["J6:J6"].ColumnWidth = 40;
            xlHoja.Range["K6:K6"].ColumnWidth = 14;

            xlHoja.Range["B6:K6"].Font.Bold = true;
            xlHoja.Range["B6:D6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:D6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:K6"].Borders.LineStyle = true;

            xlHoja.Range["B6:K6"].Font.Color = Color.Black;
            xlHoja.Range["B6:K6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "N°";
            xlHoja.Cells[6, 3] = "Fecha";
            xlHoja.Cells[6, 4] = "Documento";
            xlHoja.Cells[6, 5] = "Correlativo";
            xlHoja.Cells[6, 6] = "Usuario Reg";
            xlHoja.Cells[6, 7] = "Total Crédito";
            xlHoja.Cells[6, 8] = "Total Pagado";
            xlHoja.Cells[6, 9] = "Total Deuda";
            xlHoja.Cells[6, 10] = "Cliente";
            xlHoja.Cells[6, 11] = "Estado";
        }

        private void dgViewComprobantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgViewComprobantes.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDecimal(Myrow.Cells[8].Value) > 0)// Or your condition 
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
