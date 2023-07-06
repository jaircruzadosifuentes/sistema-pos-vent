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
    public partial class FormListadoCajasAperturadas : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;

        public FormListadoCajasAperturadas()
        {
            InitializeComponent();
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void cargarCajaAperturadas()
        {
            dgViewCajasAperturadas.DataSource = managmentCaja.ServiceGetCajasAperturadasConMonto();
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewCajasAperturadas.Rows.Count, " registros.");
        }
        public void RedimensionarFilas()
        {
            //this.dgViewComprobantes.Cel
            this.dgViewCajasAperturadas.Columns["ID"].Width = 60;
            this.dgViewCajasAperturadas.Columns["FechaAperturada"].Width = 100;
            this.dgViewCajasAperturadas.Columns["MontoAperturado"].Width = 100;
            this.dgViewCajasAperturadas.Columns["MontoEgreso"].Width = 100;
            this.dgViewCajasAperturadas.Columns["MontoEnCajaChica"].Width = 100;
            this.dgViewCajasAperturadas.Columns["Caja"].Width = 80;
            this.dgViewCajasAperturadas.Columns["Empleado"].Width = 300;
            this.dgViewCajasAperturadas.Columns["Sede"].Width = 140;
            this.dgViewCajasAperturadas.Columns["Estado"].Width = 150;
        }

        private void FormListadoCajasAperturadas_Load(object sender, EventArgs e)
        {
            AlternarColores(dgViewCajasAperturadas);
            cargarCajaAperturadas();
            RedimensionarFilas();
            this.ActiveControl = txtBuscarPorCodigo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFechaApertura_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFechaApertura.Checked)
            {
                dtFechaApertura.Visible = true;
                txtBuscarPorCodigo.Visible = false;
                txtBuscarPorCodigo.Text = "";
            }
        }

        private void rbCodUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCodUsuario.Checked)
            {
                dtFechaApertura.Visible = false;
                txtBuscarPorCodigo.Visible = true;
            }
        }

        private void dgViewCajasAperturadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgViewCajasAperturadas.Columns["item"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgViewCajasAperturadas.Rows[e.RowIndex].Cells["item"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea cerrar caja?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                int operationCajaId;
                foreach (DataGridViewRow row in dgViewCajasAperturadas.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        DateTime horaCierre = Convert.ToDateTime(funcionesGenerales.GetValueConfig("hora_cierre_caja"));

                        if((row.Cells[3].Value.ToString().TrimEnd()).Equals("Caja cerrada"))
                        {
                            MessageBox.Show(string.Concat("No puede cerrar esta caja del día ", Convert.ToString(row.Cells[2].Value), " debido a que ya ha sido cerrada."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarCajaAperturadas();
                            return;
                        } 
                        else
                        {
                            if ((Convert.ToDateTime(row.Cells[2].Value) < horaCierre && Convert.ToDateTime(row.Cells[2].Value) == Convert.ToDateTime(funcionesGenerales.GetFechaActual())))
                            {
                                MessageBox.Show(string.Concat("Debido a que ésta caja es del día aperturado, no puede cerrar caja chica hasta la hora ", funcionesGenerales.GetValueConfig("hora_cierre_caja")), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarCajaAperturadas();
                                return;
                            }
                        }

                        operationCajaId = Convert.ToInt32(row.Cells[1].Value);
                        CierreCajaChica closePettyCash = new CierreCajaChica();
                        closePettyCash.CierreCajaChicaId = operationCajaId;
                        closePettyCash.MontoAperturado = Convert.ToDecimal(row.Cells[4].Value);
                        closePettyCash.MontoVendido = Convert.ToDecimal(row.Cells[6].Value);
                        closePettyCash.MontoEgreso = Convert.ToDecimal(row.Cells[5].Value);
                        closePettyCash.MontoEsperoEnCaja = Convert.ToDecimal(row.Cells[7].Value);
                        closePettyCash.UsuarioReg = funcionesGenerales.GetDateWithUser();
                        closePettyCash.OpeCod = GVarPublicas.gCierreDeCajaChica;
                        Caja cash = new Caja();
                        cash.CajaId = Convert.ToInt32(GVarPublicas.GsCajaId);

                        closePettyCash.Caja = cash;

                        bool cancel = managmentCaja.ServiceClosePettyCashForDay(closePettyCash);
                        if(cancel)
                        {
                            MessageBox.Show(string.Concat("Caja chica se ha cerrado exitosamente."), new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarCajaAperturadas();
                        }
                    }
                }
            }
        }

        private void btnImprimirExcel_Click(object sender, EventArgs e)
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
                xlHoja.Name = "RPT_LISTADO_CAJAS_APERTURADAS";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_CAJAS_APERTURADAS.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraListadoCajasAperturadas();
                if (GenerarExcelCuerpoListadoCajasAperturadas())
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

        private bool GenerarExcelCuerpoListadoCajasAperturadas()
        {
            DataTable getAllComprobantes = managmentCaja.ServiceGetCajasAperturadasConMonto();
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
                xlHoja.Cells[nFilas, 3] = row["FechaAperturada"];
                xlHoja.Cells[nFilas, 4] = row["Estado"];
                xlHoja.Cells[nFilas, 5] = row["MontoAperturado"];
                xlHoja.Cells[nFilas, 5].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 6] = row["MontoEgreso"];
                xlHoja.Cells[nFilas, 6].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 7] = Math.Round(Convert.ToDecimal(row["MontoVendido"]), 2);
                xlHoja.Cells[nFilas, 7].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 8] = row["MontoEnCajaChica"];
                xlHoja.Cells[nFilas, 8].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 9] = row["Caja"];
                xlHoja.Cells[nFilas, 10] = row["Empleado"];
                xlHoja.Cells[nFilas, 11] = row["Sede"];
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 9; i <= 9 + getAllComprobantes.Rows.Count; i++)
            {
                for (int j = 2; j <= 11; j++)
                {
                    if (j == 5 || j == 6 || j == 7 || j == 8)
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

        private void GenerarExcelCabeceraListadoCajasAperturadas()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE DE LISTADO DE CAJAS APERTURADAS";
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
            xlHoja.Range["C9:C9"].ColumnWidth = 20; //Fecha
            xlHoja.Range["D9:D9"].ColumnWidth = 20; //Estado
            xlHoja.Range["E9:E9"].ColumnWidth = 20; //Monto aperturado
            xlHoja.Range["F9:F9"].ColumnWidth = 17; //Monto egreso
            xlHoja.Range["G9:G9"].ColumnWidth = 17; //Monto vendido
            xlHoja.Range["H9:H9"].ColumnWidth = 23; //Monto en caja chica
            xlHoja.Range["I9:I9"].ColumnWidth = 16; //Caja
            xlHoja.Range["J9:J9"].ColumnWidth = 35; //Empleado
            xlHoja.Range["K9:K9"].ColumnWidth = 16; //Sede

            xlHoja.Range["B9:K9"].Font.Bold = true;
            xlHoja.Range["B9:K9"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B9:K9"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlHoja.Range["B9:K9"].Font.Color = Color.Black;
            xlHoja.Range["B9:K9"].Interior.Color = Color.Orange;

            xlHoja.Cells[9, 2] = "ID";
            xlHoja.Cells[9, 3] = "Fecha";
            xlHoja.Cells[9, 4] = "Estado";
            xlHoja.Cells[9, 5] = "Monto aperturado";
            xlHoja.Cells[9, 6] = "Monto egreso";
            xlHoja.Cells[9, 7] = "Monto vendido";
            xlHoja.Cells[9, 8] = "Monto en caja chica";
            xlHoja.Cells[9, 9] = "Caja";
            xlHoja.Cells[9, 10] = "Empleado";
            xlHoja.Cells[9, 11] = "Sede";
        }
        public void SearchCashOpenForDate()
        {
            dgViewCajasAperturadas.DataSource = managmentCaja.ServiceGetCajaAperturadaPorFecha(dtFechaApertura.Value);
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewCajasAperturadas.Rows.Count, " registros.");
        }
        private void dtFechaApertura_ValueChanged(object sender, EventArgs e)
        {
            SearchCashOpenForDate();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTodos.Checked)
            {
                cargarCajaAperturadas();
                txtBuscarPorCodigo.Visible = true;
                dtFechaApertura.Visible = false;
            }
        }

        private void txtBuscarPorCodigo_TextChanged(object sender, EventArgs e)
        {
            dgViewCajasAperturadas.DataSource = managmentCaja.ServiceGetCajaAperturadaPorCodigo(txtBuscarPorCodigo.Text);
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewCajasAperturadas.Rows.Count, " registros.");
        }
    }
}
