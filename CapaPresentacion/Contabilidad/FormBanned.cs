using CapaAplicacion;
using CapaPresentacion.gVarPublicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Contabilidad
{
    public partial class FormBanned : MaterialSkin.Controls.MaterialForm
    {
        private string cCodigoOperacion;
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentProducts managmentProduct = new ManagmentProducts();

        public FormBanned()
        {
            InitializeComponent();
        }
        public void ColumnsDefault()
        {
            this.dgDataBanned.Columns[0].Visible = false;
        }
        public void CentrarItemsTable()
        {
            this.dgDataBanned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgDataBanned.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void FormBanned_Load(object sender, EventArgs e)
        {
            ColumnsDefault();
            AlternarColores(dgDataBanned);
            CentrarItemsTable();
            HiddenColumns();
            ResizeColumns();
        }
        public void ResizeColumns()
        {
            switch (cCodigoOperacion)
            {
                case GVarPublicas.gProductosAnulados:
                    this.dgDataBanned.Columns["Cod_barras"].Width = 100;
                    this.dgDataBanned.Columns["Nombre"].Width = 200;
                    this.dgDataBanned.Columns["Categoria"].Width = 80;
                    this.dgDataBanned.Columns["UMedida"].Width = 70;
                    this.dgDataBanned.Columns["Stock"].Width = 60;
                    this.dgDataBanned.Columns["StockAlmacen"].Width = 80;
                    this.dgDataBanned.Columns["Fecha_anulacion"].Width = 150;
                    this.dgDataBanned.Columns["Estado"].Width = 70;
                    break;
                case GVarPublicas.gTrabajadoresAnulados:
                    this.dgDataBanned.Columns["Nombres"].Width = 200;
                    this.dgDataBanned.Columns["ApellidoPaterno"].Width = 200;
                    this.dgDataBanned.Columns["ApellidoMaterno"].Width = 200;
                    this.dgDataBanned.Columns["Direccion"].Width = 270;
                    this.dgDataBanned.Columns["CorreoElectronico"].Width = 270;
                    this.dgDataBanned.Columns["Rol"].Width = 130;
                    this.dgDataBanned.Columns["NumeroIdentidad"].Width = 130;
                    break;
                case GVarPublicas.gCategoriasAnulados:
                    this.dgDataBanned.Columns["Nombre"].Width = 235;
                    this.dgDataBanned.Columns["Ultima_modificacion"].Width = 150;
                    this.dgDataBanned.Columns["Estado"].Width = 100;
                    break;
                case GVarPublicas.gPresentacionesAnuladas:
                    this.dgDataBanned.Columns["Nombre"].Width = 235;
                    this.dgDataBanned.Columns["Abreviatura"].Width = 95;
                    this.dgDataBanned.Columns["Fecha_modificación"].Width = 180;
                    this.dgDataBanned.Columns["Estado"].Width = 100;
                    break;
                default:
                    break;
            }


        }
        public void HiddenColumns()
        {
            switch (cCodigoOperacion)
            {
                case GVarPublicas.gProductosAnulados:
                    this.dgDataBanned.Columns["product_id"].Visible = false;
                    break;
                case GVarPublicas.gTrabajadoresAnulados:
                    this.dgDataBanned.Columns[0].Visible = false;
                    this.dgDataBanned.Columns[1].Visible = false;
                    this.dgDataBanned.Columns[6].Visible = false;
                    this.dgDataBanned.Columns[7].Visible = false;
                    break;
                case GVarPublicas.gCategoriasAnulados:
                    this.dgDataBanned.Columns[0].Visible = false;
                    this.dgDataBanned.Columns[1].Visible = false;
                    break;
                case GVarPublicas.gPresentacionesAnuladas:
                    this.dgDataBanned.Columns[0].Visible = false;
                    this.dgDataBanned.Columns[1].Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void Inicio(string title, string codigoOperacion, DataTable dataTable)
        {
            lblTitle.Text = title;
            cCodigoOperacion = codigoOperacion;
            txtCodigoOperacion.Text = codigoOperacion;
            switch (txtCodigoOperacion.Text)
            {
                case GVarPublicas.gProductosAnulados:
                    dgDataBanned.DataSource = dataTable;
                    break;
                case GVarPublicas.gTrabajadoresAnulados:
                    dgDataBanned.DataSource = dataTable;
                    break;
                case GVarPublicas.gCategoriasAnulados:
                    dgDataBanned.DataSource = dataTable;
                    break;
                case GVarPublicas.gPresentacionesAnuladas:
                    dgDataBanned.DataSource = dataTable;
                    break;
                default:
                    break;
            }
        }

        private void chkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHabilitar.Checked)
            {
                this.dgDataBanned.Columns[0].Visible = true;
                this.dgDataBanned.Columns[0].Width = 60;
                btnHabilita.Enabled = true;
            }
            else
            {
                this.dgDataBanned.Columns[0].Visible = false;
                btnHabilita.Enabled = false;
            }
        }

        private void dgDataBanned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgDataBanned.Columns["chKHabilita"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgDataBanned.Rows[e.RowIndex].Cells["chKHabilita"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void btnHabilita_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                int contador = 0;
                bool activaEstadoFinal = false;
                switch (txtCodigoOperacion.Text)
                {
                    case GVarPublicas.gProductosAnulados:
                        Opcion = MessageBox.Show("¿Realmente desea habilitar los productos seleccionados?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            int productoId;
                            foreach (DataGridViewRow row in dgDataBanned.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    productoId = Convert.ToInt32(row.Cells[1].Value);
                                    bool activaProducto = managmentProduct.ServiceActivarProductos(productoId);
                                    if(activaProducto)
                                    {
                                        activaEstadoFinal = true;
                                        contador += 1;
                                    }
                                    else
                                    {
                                        contador = 0;
                                        activaEstadoFinal = false;
                                        MessageBox.Show("Error al activa producto.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            if(activaEstadoFinal)
                            {
                                MessageBox.Show($"{(contador > 1 ? "Productos activados" : "Producto activado")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                chkHabilitar.Checked = false;
                                contador = 0;
                                activaEstadoFinal = false;
                                dgDataBanned.DataSource = managmentProduct.GetAllProductsBanned();
                            }
                        }
                        break;
                    case GVarPublicas.gTrabajadoresAnulados:
                        Opcion = MessageBox.Show("¿Realmente desea habilitar el personal seleccionado?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            int personalId;
                            foreach (DataGridViewRow row in dgDataBanned.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    personalId = Convert.ToInt32(row.Cells[1].Value);
                                    //bool anular = managmentCategoria.ServiceAnularCategoria(Convert.ToInt32(categoriaId));
                                    //if (anular)
                                    //{
                                    //    MessageBox.Show("Categoría anulada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    CargarCategorias();
                                    //    chkAnular.Checked = false;
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("Error al anular Categoría.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //}
                                }
                            }
                        }
                        break;
                    case GVarPublicas.gCategoriasAnulados:
                        Opcion = MessageBox.Show("¿Realmente desea habilitar la categoría seleccionada?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            int categoriaId;
                            foreach (DataGridViewRow row in dgDataBanned.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    categoriaId = Convert.ToInt32(row.Cells[1].Value);
                                    //bool anular = managmentCategoria.ServiceAnularCategoria(Convert.ToInt32(categoriaId));
                                    //if (anular)
                                    //{
                                    //    MessageBox.Show("Categoría anulada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    CargarCategorias();
                                    //    chkAnular.Checked = false;
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("Error al anular Categoría.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //}
                                }
                            }
                        }
                        break;
                    case GVarPublicas.gPresentacionesAnuladas:
                        Opcion = MessageBox.Show("¿Realmente desea habilitar la presentación seleccionada?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            int presentacionId;
                            foreach (DataGridViewRow row in dgDataBanned.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    presentacionId = Convert.ToInt32(row.Cells[1].Value);
                                    //bool anular = managmentCategoria.ServiceAnularCategoria(Convert.ToInt32(categoriaId));
                                    //if (anular)
                                    //{
                                    //    MessageBox.Show("Categoría anulada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    CargarCategorias();
                                    //    chkAnular.Checked = false;
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("Error al anular Categoría.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //}
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
