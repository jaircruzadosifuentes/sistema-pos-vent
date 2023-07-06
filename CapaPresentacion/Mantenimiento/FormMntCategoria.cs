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
    public partial class FormMntCategoria : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCategoria managmentCategoria = new ManagmentCategoria();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public bool IS_NEW = false;
        public bool IS_MODIFICATION = false;
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;

        public FormMntCategoria()
        {
            InitializeComponent();
        }
        public void CargarCategorias()
        {
            dgCategorias.DataSource = managmentCategoria.GetAllCategoriasEnDataTable();
        }
        public void DesactivarColumnas()
        {
            this.dgCategorias.Columns[0].Visible = false;
            this.dgCategorias.Columns[1].Visible = false;
        }
        public void RedimensionarColumnas()
        {
            this.dgCategorias.Columns["Nombre"].Width = 235;
            this.dgCategorias.Columns["Ultima_modificacion"].Width = 110;
            this.dgCategorias.Columns["Estado"].Width = 100;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void CentrarItemsTable()
        {
            this.dgCategorias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgCategorias.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void ControlForDefault()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void FormMntCategoria_Load(object sender, EventArgs e)
        {
            ControlForDefault();
            AlternarColores(dgCategorias);
            CargarCategorias();
            DesactivarColumnas();
            RedimensionarColumnas();
            CentrarItemsTable();
            HabilitarControlesNuevo(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IS_NEW = true;
            HabilitarControlesNuevo(true);
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            txtNombreCategoria.Enabled = estado;
            txtCategoriaId.Enabled = estado;
            tvCategoria.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnGuardar.Enabled = IS_MODIFICATION ? !estado : estado;
            this.btnModificar.Enabled = IS_NEW ? false : estado;
            this.btnCancelar.Visible = estado;
            this.btnExcel.Enabled = !estado;
            this.btnEliminar.Visible = !estado;
        }
        public void ClearControllers()
        {
            txtCategoriaId.Text = "";
            txtNombreCategoria.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IS_MODIFICATION)
            {
                HabilitarControlesNuevo(false);
                IS_MODIFICATION = false;
                ClearControllers();
            }
            else
            {
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                ClearControllers();
            }
        }

        private void dgCategorias_DoubleClick(object sender, EventArgs e)
        {
            IS_MODIFICATION = true;
            txtCategoriaId.Text = Convert.ToString(dgCategorias.CurrentRow.Cells["categoryId"].Value);
            this.txtNombreCategoria.Text = Convert.ToString(this.dgCategorias.CurrentRow.Cells["Nombre"].Value);
            if(Convert.ToString(this.dgCategorias.CurrentRow.Cells["Estado"].Value).Equals("ACTIVO"))
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            HabilitarControlesNuevo(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Category categoria = new Category();
            if(string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la categoría", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea registrar esta categoría?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                rbActivo.Checked = true;
                categoria.Name = txtNombreCategoria.Text;
                categoria.State = Convert.ToInt32(rbActivo.Checked);
                bool inserta = managmentCategoria.DALInsertaCategoria(categoria, "I");//managmentCategoria.ServiceInsertaUser(user, "I");
                if (inserta)
                {
                    MessageBox.Show("Categoría registrada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_NEW = false;
                    ClearControllers();
                    CargarCategorias();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Category categoria = new Category();
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la categoría", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea modificar esta categoría?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                categoria.CategoryId = Convert.ToInt32(txtCategoriaId.Text);
                categoria.Name = txtNombreCategoria.Text;
                int estado = 0;
                if(rbActivo.Checked)
                {
                    estado = 1;
                }
                else if(rbInactivo.Checked)
                {
                    estado = 0;
                }
                categoria.State = estado;
                bool actualiza = managmentCategoria.DALActualizaCategoria(categoria, "A");
                if(actualiza)
                {
                    MessageBox.Show("Categoría modificada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_NEW = false;
                    ClearControllers();
                    CargarCategorias();
                }
            }
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCategorias.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgCategorias.Rows[e.RowIndex].Cells["Anular"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }
        public void GenerarExcelCabeceraCategorias()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE CATEGORÍAS";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:E2"];
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

            xlHoja.Range["A6:A6"].ColumnWidth = 4;
            xlHoja.Range["B6:B6"].ColumnWidth = 4;
            xlHoja.Range["C6:C6"].ColumnWidth = 20;
            xlHoja.Range["D6:D6"].ColumnWidth = 13;
            xlHoja.Range["E6:E6"].ColumnWidth = 13;

            xlHoja.Range["B6:E6"].Font.Bold = true;
            xlHoja.Range["B6:E6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:E6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:E6"].Borders.LineStyle = true;

            xlHoja.Range["B6:E6"].Font.Color = Color.Black;
            xlHoja.Range["B6:E6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "N°";
            xlHoja.Cells[6, 3] = "Nombre";
            xlHoja.Cells[6, 4] = "Estado";
            xlHoja.Cells[6, 5] = "Código";
        }
        public bool GenerarExcelCuerpoCataegorias()
        {
            DataTable getAllCategorias = managmentCategoria.GetAllCategoriasEnDataTable();
            long nFilas = 6;
            long contador = 0;

            pb1.Maximum = getAllCategorias.Rows.Count;
            pb1.Value = 1;
            pb2.Maximum = getAllCategorias.Rows.Count;
            pb2.Value = 1;

            foreach (DataRow row in getAllCategorias.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Nombre"];
                xlHoja.Cells[nFilas, 4] = row["Estado"];
                xlHoja.Cells[nFilas, 5] = row["Codigo"];
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 6; i <= 6 + getAllCategorias.Rows.Count; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    xlHoja.Cells[i, j].Borders.LineStyle = true;
                    xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
            }
            return getAllCategorias.Rows.Count > 0;
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
                xlHoja.Name = "REP_CATEGORÍAS";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_CATEGORIAS.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraCategorias();
                if (GenerarExcelCuerpoCataegorias())
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

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgCategorias.Columns[0].Visible = true;
                this.dgCategorias.Columns[0].Width = 40;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgCategorias.Columns[0].Visible = false;
                this.dgCategorias.Columns[0].Width = 40;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool estadoAnulado = false;
            bool estadoAnuladoFinal = false;
            int contador = 0;
            try
            {
                foreach (DataGridViewRow rowFila in dgCategorias.Rows)
                {
                    if(Convert.ToBoolean(rowFila.Cells[0].Value))
                    {
                        if (rowFila.Cells[3].Value.Equals("INACTIVO"))
                        {
                            estadoAnulado = true;
                            MessageBox.Show("No puede anular la categoría, cuando ya está anulada.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                if(!estadoAnulado)
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Realmente desea anular las categorías seleccionadas?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        int categoriaId;
                        foreach (DataGridViewRow row in dgCategorias.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                categoriaId = Convert.ToInt32(row.Cells[1].Value);
                                bool anular = managmentCategoria.ServiceAnularCategoria(Convert.ToInt32(categoriaId));
                                if (anular)
                                {
                                    contador = contador + 1;
                                    estadoAnuladoFinal = true;
                                }
                                else
                                {
                                    contador = 0;
                                    estadoAnuladoFinal = false;
                                    MessageBox.Show("Error al anular Categoría.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if(estadoAnuladoFinal)
                        {
                            MessageBox.Show($"{(contador > 1 ? "Categorías anuladas": "Categoría anulada")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCategorias();
                            chkAnular.Checked = false;
                            contador = 0;
                            estadoAnuladoFinal = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            dgCategorias.DataSource = managmentCategoria.ServiceGetCategoriaPorNombre(txtBuscarCategoria.Text);
        }

        private void txtNombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (IS_MODIFICATION)
                {
                    btnModificar.Focus();
                }
                else if (IS_NEW)
                {
                    btnGuardar.Focus();
                }
            }
        }
    }
}
