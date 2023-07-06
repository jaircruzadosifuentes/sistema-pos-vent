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
    public partial class FormListadoEgresos : MaterialSkin.Controls.MaterialForm
    {
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        public FormListadoEgresos()
        {
            InitializeComponent();
        }
        public void RedimensionarColumnas()
        {
            this.dgListadoEgresos.Columns["ID"].Width = 60;
            this.dgListadoEgresos.Columns["Descripcion"].Width = 350;
            this.dgListadoEgresos.Columns["Monto"].Width = 80;
            this.dgListadoEgresos.Columns["Caja"].Width = 80;
            this.dgListadoEgresos.Columns["Sede"].Width = 120;
            this.dgListadoEgresos.Columns["Trabajador"].Width = 230;
            this.dgListadoEgresos.Columns["Fecha"].Width = 130;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        private void FormListadoEgresos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;
            this.dgListadoEgresos.DataSource = new ManagmentCaja().ServiceGetAllEgresos();
            RedimensionarColumnas();
            AlternarColores(dgListadoEgresos);
            lblCantidad.Text = string.Concat("Se han cargado ", dgListadoEgresos.Rows.Count, " registros.");
        }

        private void rbFechas_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFechas.Checked)
            {
                txtBuscar.Visible = false;
                lblFechaFin.Visible = true;
                lblFechaInicio.Visible = true;
                dtFechaFin.Visible = true;
                dtFechaInicio.Visible = true;
            }
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if(rbUsuario.Checked)
            {
                lblFechaFin.Visible = false;
                lblFechaInicio.Visible = false;
                dtFechaFin.Visible = false;
                dtFechaInicio.Visible = false;
                txtBuscar.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                xlHoja.Name = "RPT_EGRESOS";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_DE_EGRESOS.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraEgresos();
                if (GenerarExcelCuerpoEgresos())
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
        public int CantidadEgresos()
        {
            return dgListadoEgresos.Rows.Count;
        }
        private bool GenerarExcelCuerpoEgresos()
        {
            DataTable getAllEgresos = new ManagmentCaja().ServiceGetAllEgresos();

            long nFilas = 6;
            long contador = 0;

            pb1.Maximum = CantidadEgresos();
            pb1.Value = 1;
            pb2.Maximum = CantidadEgresos();
            pb2.Value = 1;

            foreach (DataRow row in getAllEgresos.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Descripcion"].ToString();
                xlHoja.Cells[nFilas, 4] = row["Monto"].ToString();
                xlHoja.Cells[nFilas, 4].NumberFormat = "#,##0.00";
                xlHoja.Cells[nFilas, 5] = row["Caja"].ToString();
                xlHoja.Cells[nFilas, 6] = row["Sede"].ToString();
                xlHoja.Cells[nFilas, 7] = row["Trabajador"].ToString();
                xlHoja.Cells[nFilas, 8] = row["Fecha"].ToString();
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 6; i <= 6 + CantidadEgresos(); i++)
            {
                for (int j = 2; j <= 8; j++)
                {
                    if(j == 3)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        xlHoja.Cells[i, j].WrapText = true;
                    }
                    else if (j == 4)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        xlHoja.Cells[i, j].WrapText = true;
                    }
                    else
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].WrapText = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }
            }
            bool ExistenRegistros = CantidadEgresos() > 0;
            return ExistenRegistros;
        }

        private void GenerarExcelCabeceraEgresos()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE EGRESOS";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:L2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:H2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:H2"].Font.Size = 14;
            xlHoja.Range["B2:H2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:P2"].Font.Bold = true;
            xlHoja.Range["B3:P3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A6:A6"].ColumnWidth = 4;
            xlHoja.Range["B6:B6"].ColumnWidth = 4;
            xlHoja.Range["C6:C6"].ColumnWidth = 60;
            xlHoja.Range["D6:D6"].ColumnWidth = 10; //Monto
            xlHoja.Range["E6:E6"].ColumnWidth = 12; //Caja
            xlHoja.Range["F6:F6"].ColumnWidth = 15; //Sede
            xlHoja.Range["G6:G6"].ColumnWidth = 35; //Usuario registro
            xlHoja.Range["H6:H6"].ColumnWidth = 20;
            xlHoja.Range["I6:I6"].ColumnWidth = 4;
            xlHoja.Range["J6:J6"].ColumnWidth = 4;
            xlHoja.Range["K6:K6"].ColumnWidth = 4;
            xlHoja.Range["L6:L6"].ColumnWidth = 4;
            xlHoja.Range["M6:M6"].ColumnWidth = 4;
            xlHoja.Range["N6:N6"].ColumnWidth = 4;

            xlHoja.Range["B6:H6"].Font.Bold = true;
            xlHoja.Range["B6:H6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:H6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:H6"].Borders.LineStyle = true;
            xlHoja.Range["B6:H6"].WrapText = true;

            xlHoja.Range["B6:H6"].Font.Color = Color.Black;
            xlHoja.Range["B6:H6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "ID";
            xlHoja.Cells[6, 3] = "Descripción";
            xlHoja.Cells[6, 4] = "Monto";
            xlHoja.Cells[6, 5] = "Caja";
            xlHoja.Cells[6, 6] = "Sede";
            xlHoja.Cells[6, 7] = "Usuario registro";
            xlHoja.Cells[6, 8] = "Fecha";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgListadoEgresos.DataSource = new ManagmentCaja().ServiceGetAllEgresosPorCodigoUsuario(txtBuscar.Text.Trim());
            lblCantidad.Text = string.Concat("Se han cargado ", dgListadoEgresos.Rows.Count, " registros.");
        }
    }
}
