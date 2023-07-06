using CapaAplicacion;
using CapaEntidades;
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
    public partial class FormCierreCajaChica : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly ManagmentVenta managmentVenta = new ManagmentVenta();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        public FormCierreCajaChica()
        {
            InitializeComponent();
        }
        public void cargarMontos()
        {
            DataTable dataTable = managmentCaja.ServiceGetMontoParaCajaChica(GVarPublicas.GsUserName, GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
            if(dataTable.Rows.Count > 0)
            {
                txtMontoAperturado.Text = dataTable.Rows[0]["nMontoAperturado"].ToString();
                txtMontoVendido.Text = dataTable.Rows[0]["nMontoVendido"].ToString();
                txtEsperadoEnCaja.Text = dataTable.Rows[0]["nMontoEsperado"].ToString();
                txtMontoEgreso.Text = dataTable.Rows[0]["nMontoEgreso"].ToString();
            }
        }
        public void cargarComprobantes()
        {
            dgViewComprobantes.DataSource = managmentVenta.ServiceComprobantesParaCierreCajaChica(GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
            lblCantidad.Text = string.Concat("Se cargaron ", dgViewComprobantes.Rows.Count, " registros.");
        }
        public void RedimensionarFilas()
        {
            this.dgViewComprobantes.Columns["ID"].Width = 30;
            this.dgViewComprobantes.Columns["Cliente"].Width = 250;
            this.dgViewComprobantes.Columns["Fecha"].Width = 150;
            this.dgViewComprobantes.Columns["Documento"].Width = 70;
            this.dgViewComprobantes.Columns["Correlativo"].Width = 140;
            this.dgViewComprobantes.Columns["Estado"].Width = 70;
            this.dgViewComprobantes.Columns["Total"].Width = 60;
            this.dgViewComprobantes.Columns["TipoPago"].Width = 70;
        }
        private void FormCierreCajaChica_Load(object sender, EventArgs e)
        {
            cargarMontos();
            cargarComprobantes();
            AlternarColores(dgViewComprobantes);
            RedimensionarFilas();
            this.ActiveControl = btnCerrarCaja;
            bool cajaEstado = new ManagmentCaja().ServiceVerificaCajaCerrada(GVarPublicas.GsUserName, GVarPublicas.GsCajaId);
            bool estadoCaja = new ManagmentCaja().GetStateOpenCaja(GVarPublicas.GsUserName);
            if(estadoCaja)
            {
                if (cajaEstado)
                {
                    btnCerrarCaja.Enabled = !cajaEstado;
                    btnCerrarCaja.Text = "Caja cerrada";
                }
            }
            else
            {
                btnCerrarCaja.Text = "Pendiente apertura";
                btnCerrarCaja.Enabled = false;
                btnImprimir.Enabled = false;
            }
            //if(!estadoCaja)
            //{
            //}
            this.txtFechaActual.Text = new FuncionesGenerales().GetFechaActual();
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            DateTime horaCierre = Convert.ToDateTime(funcionesGenerales.GetValueConfig("hora_cierre_caja"));

            if(DateTime.Now < horaCierre)
            {
                MessageBox.Show(string.Concat("No puede cerrar caja chica hasta la hora ", funcionesGenerales.GetValueConfig("hora_cierre_caja")), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea cerrar caja chica del día aperturado?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                CierreCajaChica cierreCajaChica = new CierreCajaChica();
                cierreCajaChica.MontoAperturado = Convert.ToDecimal(txtMontoAperturado.Text);
                cierreCajaChica.MontoVendido = Convert.ToDecimal(txtMontoVendido.Text);
                cierreCajaChica.MontoEgreso = Convert.ToDecimal(txtMontoEgreso.Text);
                cierreCajaChica.MontoEsperoEnCaja = Convert.ToDecimal(txtEsperadoEnCaja.Text);
                cierreCajaChica.UsuarioReg = funcionesGenerales.GetDateWithUser();
                cierreCajaChica.OpeCod = GVarPublicas.gCierreDeCajaChica;

                Caja caja = new Caja();
                caja.CajaId = Convert.ToInt32(GVarPublicas.GsCajaId);

                cierreCajaChica.Caja = caja;

                bool cierreCaja = new ManagmentCaja().ServiceCierreCajaChica(cierreCajaChica);
                if(cierreCaja)
                {
                    MessageBox.Show(string.Concat("Caja chica ha sido cerrada exitosamente."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCerrarCaja.Text = "Caja cerrada";
                    btnCerrarCaja.Enabled = false;
                }
                else
                {
                    MessageBox.Show(string.Concat("Error al cerrar caja chica."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void GenerarExcelCabeceraCierreCaja()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE AL CIERRE DE CAJA CHICA";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:L2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:E2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:E2"].Font.Size = 14;
            xlHoja.Range["B2:E2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:P2"].Font.Bold = true;
            xlHoja.Range["B3:P3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A9:A9"].ColumnWidth = 4;
            xlHoja.Range["B9:B9"].ColumnWidth = 4;
            xlHoja.Range["C9:C9"].ColumnWidth = 20;
            xlHoja.Range["D9:D9"].ColumnWidth = 11;
            xlHoja.Range["E9:E9"].ColumnWidth = 20;
            xlHoja.Range["F9:F9"].ColumnWidth = 14;
            xlHoja.Range["G9:G9"].ColumnWidth = 18;
            xlHoja.Range["H9:H9"].ColumnWidth = 32;
            xlHoja.Range["I9:I9"].ColumnWidth = 15;

            xlHoja.Range["B9:L9"].Font.Bold = true;
            xlHoja.Range["B9:L9"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B9:L9"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //
            xlHoja.Range["B6:H6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:L6"].Font.Bold = true;

            xlHoja.Cells[6, 5] = "MONTO APERTURADO";
            xlHoja.Cells[7, 5] = Math.Round(Convert.ToDecimal(txtMontoAperturado.Text), 2);
            xlHoja.Cells[7, 5].NumberFormat = "#,##0.00";
            xlHoja.Cells[6, 6] = "MONTO EGRESO";
            xlHoja.Cells[7, 6] = Math.Round(Convert.ToDecimal(txtMontoEgreso.Text), 2);
            xlHoja.Cells[7, 6].NumberFormat = "#,##0.00";
            xlHoja.Cells[6, 7] = "MONTO VENDIDO";
            xlHoja.Cells[7, 7] = Math.Round(Convert.ToDecimal(txtMontoVendido.Text), 2);
            xlHoja.Cells[7, 7].NumberFormat = "#,##0.00";
            xlHoja.Cells[6, 8] = "MONTO ESPERADO EN CAJA CHICA";
            xlHoja.Cells[7, 8] = Math.Round(Convert.ToDecimal(txtEsperadoEnCaja.Text), 2);
            xlHoja.Cells[7, 8].NumberFormat = "#,##0.00";

            xlHoja.Range["B9:J9"].Font.Bold = true;
            xlHoja.Range["B9:J9"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B9:J9"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B9:J9"].Borders.LineStyle = true;
            xlHoja.Range["B9:J9"].WrapText = true;

            xlHoja.Range["B9:J9"].Font.Color = Color.Black;
            xlHoja.Range["B9:J9"].Interior.Color = Color.Orange;

            xlHoja.Cells[9, 2] = "ID";
            xlHoja.Cells[9, 3] = "Fecha";
            xlHoja.Cells[9, 4] = "Documento";
            xlHoja.Cells[9, 5] = "Correlativo";
            xlHoja.Cells[9, 6] = "Estado";
            xlHoja.Cells[9, 7] = "Total";
            xlHoja.Cells[9, 8] = "Cliente";
            xlHoja.Cells[9, 9] = "Tipo de pago";
            xlHoja.Cells[9, 10] = "Transacción";
        }
        public bool GenerarExcelCuerpoCierreCaja()
        {
            DataTable getAllComprobantes = managmentVenta.ServiceComprobantesParaCierreCajaChica(GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
            long nFilas = 9;
            long contador = 0;

            pb1.Maximum = getAllComprobantes.Rows.Count;
            pb1.Value = 1;
            pb2.Maximum = getAllComprobantes.Rows.Count;
            pb2.Value = 1;

            foreach (DataRow row in getAllComprobantes.Rows)
            {
                nFilas += 1;
                contador += 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Fecha"];
                xlHoja.Cells[nFilas, 4] = row["Documento"];
                xlHoja.Cells[nFilas, 5] = row["Correlativo"];
                xlHoja.Cells[nFilas, 6] = row["Estado"];
                xlHoja.Cells[nFilas, 7] = Math.Round(Convert.ToDecimal(row["Total"]), 2);
                xlHoja.Cells[nFilas, 7].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 8] = row["Cliente"];
                xlHoja.Cells[nFilas, 9] = row["TipoPago"];
                xlHoja.Cells[nFilas, 10] = row["Transaccion"];
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 10; i <= 10 + getAllComprobantes.Rows.Count; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    if(j == 7)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        xlHoja.Cells[i, j].WrapText = true;
                    }
                    else
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlHoja.Cells[i, j].WrapText = true;
                    }
                }
            }
            return getAllComprobantes.Rows.Count > 0;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                xlApplication = new Excel.Application();
                xlApplication.Visible = false;
                //Visible progres bar
                pb2.Visible = true;
                pb1.Visible = true;
                //Get a new workbook.
                xlLibro = xlApplication.Workbooks.Add(Missing.Value);
                xlHoja = (Excel._Worksheet)xlLibro.ActiveSheet;
                xlHoja.Name = "REP_CIERRE_CAJA";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_CIERRE_CAJA.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraCierreCaja();
                if (GenerarExcelCuerpoCierreCaja())
                {
                    xlApplication.Visible = true;
                    xlApplication.UserControl = false;
                    xlLibro.SaveAs(folder + nombre);
                    pb1.Visible = false;
                    pb1.Value = 0;
                    pb2.Visible = false;
                    pb2.Value = 0;
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

        private void dgViewComprobantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgViewComprobantes.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[8].Value).Equals("EGRESO"))// Or your condition 
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if(Convert.ToString(Myrow.Cells[8].Value).Equals("PAGO CRÉDITO"))
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkSlateBlue;
                }
                else
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
