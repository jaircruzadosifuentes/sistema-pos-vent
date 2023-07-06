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

namespace CapaPresentacion.Mantenimiento
{
    public partial class FormMntPresentacion : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentPresentacion managmentPresentacion = new ManagmentPresentacion();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private bool IS_MODIFICATION = false;
        private bool IS_NEW = false;
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        public FormMntPresentacion()
        {
            InitializeComponent();
        }
        public void fvCargarPresentaciones()
        {
            dgPresentaciones.DataSource = managmentPresentacion.GetAllPresentacionesEnDataTable();
        }
        public void DesactivarColumnas()
        {
            this.dgPresentaciones.Columns[0].Visible = false;
            this.dgPresentaciones.Columns[1].Visible = false;
        }
        public void RedimensionarColumnas()
        {
            this.dgPresentaciones.Columns["Nombre"].Width = 170;
            this.dgPresentaciones.Columns["Abreviatura"].Width = 65;
            this.dgPresentaciones.Columns["Fecha_modificación"].Width = 110;
            this.dgPresentaciones.Columns["Estado"].Width = 100;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void CentrarItemsTable()
        {
            this.dgPresentaciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPresentaciones.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void ControlForDefault()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void FormMntPresentacion_Load(object sender, EventArgs e)
        {
            fvCargarPresentaciones();
            ControlForDefault();
            CentrarItemsTable();
            AlternarColores(dgPresentaciones);
            RedimensionarColumnas();
            DesactivarColumnas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgPresentaciones.Columns[0].Visible = true;
                this.dgPresentaciones.Columns[0].Width = 40;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgPresentaciones.Columns[0].Visible = false;
                this.dgPresentaciones.Columns[0].Width = 40;
                this.btnEliminar.Enabled = false;
            }
        }

        private void dgPresentaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgPresentaciones.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgPresentaciones.Rows[e.RowIndex].Cells["Anular"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool estadoAnulado = false;
            bool estadoAnuladoFinal = false;
            int contador = 0;
            try
            {
                foreach(DataGridViewRow rowFila in dgPresentaciones.Rows)
                {
                    if(Convert.ToBoolean(rowFila.Cells[0].Value))
                    {
                        if(rowFila.Cells[4].Value.Equals("INACTIVO"))
                        {
                            estadoAnulado = true;
                            MessageBox.Show("No puede anular la presentación, cuando ya está anulada.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                if(!estadoAnulado)
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Realmente desea anular las presentaciones seleccionadas?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        int presentacionId;
                        foreach (DataGridViewRow row in dgPresentaciones.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                presentacionId = Convert.ToInt32(row.Cells[1].Value);
                                bool anular = managmentPresentacion.ServiceAnularPresentacion(Convert.ToInt32(presentacionId));
                                if (anular)
                                {
                                    contador = contador + 1;
                                    estadoAnuladoFinal = true;
                                }
                                else
                                {
                                    estadoAnuladoFinal = false;
                                    contador = 0;
                                    MessageBox.Show("Error al anular Presentación.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if(estadoAnuladoFinal)
                        {
                            MessageBox.Show($"{(contador > 1 ? "Presentaciones anuladas": "Presentación anulada")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fvCargarPresentaciones();
                            chkAnular.Checked = false;
                            estadoAnuladoFinal = false;
                            contador = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            txtNombre.Enabled = estado;
            txtPresentacionId.Enabled = estado;
            tvPresentacion.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnGuardar.Enabled = IS_MODIFICATION ? !estado : !IS_NEW ? estado: estado;
            this.btnModificar.Enabled = !IS_NEW && estado;
            this.btnCancelar.Visible = estado;
            this.btnExcel.Enabled = !estado;
            this.btnEliminar.Visible = !estado;
        }
        private void dgPresentaciones_DoubleClick(object sender, EventArgs e)
        {
            IS_MODIFICATION = true;
            txtPresentacionId.Text = Convert.ToString(dgPresentaciones.CurrentRow.Cells["presentation_id"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgPresentaciones.CurrentRow.Cells["Nombre"].Value);
            this.txtAbreviatura.Text = Convert.ToString(this.dgPresentaciones.CurrentRow.Cells["Abreviatura"].Value);
            if (Convert.ToString(this.dgPresentaciones.CurrentRow.Cells["Estado"].Value).Equals("ACTIVO"))
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            HabilitarControlesNuevo(true);
        }
        public void ClearControllers()
        {
            txtPresentacionId.Text = "";
            txtNombre.Text = "";
            txtAbreviatura.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IS_MODIFICATION)
            {
                IS_MODIFICATION = false;
                HabilitarControlesNuevo(false);
                ClearControllers();
            }
            else
            {
                IS_NEW = false;
                HabilitarControlesNuevo(false);
                ClearControllers();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IS_NEW = true;
            HabilitarControlesNuevo(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UMedida uMedida = new UMedida();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la presentación", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtAbreviatura.Text))
            {
                MessageBox.Show("Debe de ingresar la abreviatura de la presentación", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea registrar esta presentación?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                rbActivo.Checked = true;
                uMedida.Name = txtNombre.Text;
                uMedida.Abreviatura = txtAbreviatura.Text;
                uMedida.State = Convert.ToInt32(rbActivo.Checked);
                bool inserta = managmentPresentacion.ServiceInsertaPresentacion(uMedida);//managmentCategoria.ServiceInsertaUser(user, "I");
                if (inserta)
                {
                    MessageBox.Show("Presentación registrada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_NEW = false;
                    ClearControllers();
                    fvCargarPresentaciones();
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea modificar esta presentación?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la presentación", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(string.IsNullOrEmpty(txtAbreviatura.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la abreviatura", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Opcion == DialogResult.OK)
            {
                UMedida uMedida = new UMedida();
                uMedida.PresentationId = Convert.ToInt32(txtPresentacionId.Text);
                uMedida.Name = txtNombre.Text;
                uMedida.Abreviatura = txtAbreviatura.Text;
                int estado = 0;
                if(rbActivo.Checked)
                {
                    estado = 1;
                }
                else if(rbInactivo.Checked)
                {
                    estado = 0;
                }
                uMedida.State = estado;
                bool actualiza = managmentPresentacion.ServiceActualizaPresentacion(uMedida);
                if (actualiza)
                {
                    MessageBox.Show("Presentación modificada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_NEW = false;
                    ClearControllers();
                    fvCargarPresentaciones();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtAbreviatura.Focus();
            }
        }

        private void txtAbreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(IS_MODIFICATION)
                {
                    btnModificar.Focus();
                } 
                else if(IS_NEW)
                {
                    btnGuardar.Focus();
                }
            }
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            dgPresentaciones.DataSource = managmentPresentacion.ServiceGetAllPresentacionPorNombre(txtBuscarCategoria.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
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
                xlHoja.Name = "REP_PRESENTACIONES";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_PRESENTACIONES.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraPresentaciones();
                if (GenerarExcelCuerpoPresentaciones())
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
                    MessageBox.Show("No existen datos para mostrar.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool GenerarExcelCuerpoPresentaciones()
        {
            DataTable getAllPresentaciones = managmentPresentacion.GetAllPresentacionesEnDataTable();
            long nFilas = 6;
            long contador = 0;

            pb1.Maximum = getAllPresentaciones.Rows.Count;
            pb1.Value = 1;
            pb2.Maximum = getAllPresentaciones.Rows.Count;
            pb2.Value = 1;

            foreach (DataRow row in getAllPresentaciones.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Nombre"];
                xlHoja.Cells[nFilas, 4] = row["Abreviatura"];
                xlHoja.Cells[nFilas, 5] = row["Estado"];
                xlHoja.Cells[nFilas, 6] = row["Codigo"];
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 6; i <= 6 + getAllPresentaciones.Rows.Count; i++)
            {
                for (int j = 2; j <= 6; j++)
                {
                    xlHoja.Cells[i, j].Borders.LineStyle = true;
                    xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
            }
            bool ExistenRegistros = getAllPresentaciones.Rows.Count > 0 ? true : false;
            return ExistenRegistros;
        }

        private void GenerarExcelCabeceraPresentaciones()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE PRESENTACIONES";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:F2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:F2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:F2"].Font.Size = 14;
            xlHoja.Range["B2:F2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:F2"].Font.Bold = true;
            xlHoja.Range["B3:F3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A6:A6"].ColumnWidth = 4;
            xlHoja.Range["B6:B6"].ColumnWidth = 4;
            xlHoja.Range["C6:C6"].ColumnWidth = 20;
            xlHoja.Range["C6:D6"].ColumnWidth = 15;
            xlHoja.Range["D6:E6"].ColumnWidth = 13;
            xlHoja.Range["E6:F6"].ColumnWidth = 13;

            xlHoja.Range["B6:F6"].Font.Bold = true;
            xlHoja.Range["B6:F6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:F6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:F6"].Borders.LineStyle = true;

            xlHoja.Range["B6:F6"].Font.Color = Color.Black;
            xlHoja.Range["B6:F6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "N°";
            xlHoja.Cells[6, 3] = "Nombre";
            xlHoja.Cells[6, 4] = "Abreviatura";
            xlHoja.Cells[6, 5] = "Estado";
            xlHoja.Cells[6, 6] = "Código";
        }
    }
}
