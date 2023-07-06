using CapaAplicacion;
using CapaPresentacion.Contabilidad;
using CapaPresentacion.gVarPublicas;
using CapaPresentacion.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion.Sales
{
    public partial class FormPOS : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentProducts managmentProducts = new ManagmentProducts();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentVenta managmentVenta = new ManagmentVenta();
        DataTable detalle;
        private decimal ldTotal = 0;
        private decimal ldIgv = 0;
        private decimal ldSubTotal = 0;
        public int clienteId { get; set; }
        public string nombres { get; set; }
        public void SetCliente(string id, string nombres)
        {
            txtIdCliente.Text = id;
            txtEmpresasOPersonas.Text = nombres;
        }

        #region Singleton
        private static FormPOS _instancia;
        public static FormPOS GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FormPOS();
            }
            return _instancia;
        }
        #endregion

        public FormPOS()
        {
            InitializeComponent();
        }
        public void LoadDocument()
        {
            //cboDocumento.DataSource = managmentDocument.ListDouments();
            //cboDocumento.ValueMember = "documentId";
            //cboDocumento.DisplayMember = "name";
        }
        //Permite crear la tabla para el detalle de la venta
        private void CrearTabla()
        {
            this.detalle = new DataTable("detalleventa");
            this.detalle.Columns.Add("iddetalleproducto", System.Type.GetType("System.Int32"));
            this.detalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.detalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.detalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            this.detalle.Columns.Add("Total", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dgSaleProducts.DataSource = this.detalle;
        }
        public void RedimensionarColumnas()
        {
            this.dgSaleProducts.Columns["Producto"].Width = 150;
            this.dgSaleProducts.Columns["Cantidad"].Width = 60;
            this.dgSaleProducts.Columns["Precio"].Width = 60;
            this.dgSaleProducts.Columns["Total"].Width = 60;
            this.dgSaleProducts.Columns["iddetalleproducto"].Visible = false;
        }
        public void cargarControlesPorDefecto()
        {
            txtEmpresasOPersonas.Text = "PUBLICO EN GENERAL - (00000000)";
            txtIdCliente.Text = "1";
            if(rbCodigoBarras.Checked)
            {
                lblNombreEtiqueta.Text = "Cód.Barras";
            }
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void LimpiarControles()
        {
            txtCodigoBarras.Text = "";
            lblIgv.Text = "";
            lblTotal.Text = "";
            lblSubTotal.Text = "";
            this.detalle.Rows.Clear();
            ldSubTotal = 0;
            ldIgv = 0;
            ldTotal = 0;
            lblTotal.Text = "0.00";
            lblIgv.Text = "0.00";
            lblSubTotal.Text = "0.00";
            txtEmpresasOPersonas.Text = "PUBLICO EN GENERAL - (00000000)";
            txtIdCliente.Text = "1";
        }
        private void FormPOS_Load(object sender, EventArgs e)
        {
            LoadDocument();
            LoadProducts();
            CrearTabla();
            RedimensionarColumnas();
            cargarControlesPorDefecto();
            AlternarColores(dgSaleProducts);
            this.KeyPreview = true;
            this.ActiveControl = txtCodigoBarras;
        }
        public bool ValidarAperturaDeCaja()
        {
            return managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
        }
        public void LoadProducts()
        {
            DataTable dataTableProducts = managmentProducts.GetAllProducts();
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }
        public void CalcularMontosYMostrarEnTabla()
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProducts.SelectedItems[0];

                DataRow row = this.detalle.NewRow();
                string[] subs = item.SubItems[0].Text.Split('-');
                row["iddetalleproducto"] = item.SubItems[1].Text;
                row["Producto"] = subs[1];
                row["Cantidad"] = item.SubItems[3].Text;
                row["Precio"] = item.SubItems[4].Text;
                row["Total"] = Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                ldTotal += Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                lblTotal.Text = ldTotal.ToString();
                lblIgv.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                ldIgv += Convert.ToDecimal(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                lblSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                ldSubTotal += Convert.ToDecimal(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                this.detalle.Rows.Add(row);
                //Validamos si está activado el bit de notificaciones
                if(funcionesGenerales.GetValueConfig("sonido_notificaciones").Equals("1"))
                {
                    funcionesGenerales.fvSonarNotificacion(1);
                }
            }
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontosYMostrarEnTabla();
        }

        private void lvProducts_ItemActivate(object sender, EventArgs e)
        {
        }

        private void lvProducts_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _instancia = null;
            this.Close();
        }

        private void dgSaleProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgSaleProducts.CurrentCell = dgSaleProducts.Rows[e.RowIndex].Cells[2];
            dgSaleProducts.BeginEdit(true);
            dgSaleProducts.Columns[2].ReadOnly = false;
        }

        private void dgSaleProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgSaleProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgSaleProducts.CurrentCell = dgSaleProducts[e.ColumnIndex, e.RowIndex];
            dgSaleProducts.BeginEdit(true);
            dgSaleProducts.Columns[2].ReadOnly = false;
        }

        private void dgSaleProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                string cantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad", funcionesGenerales.GetValueConfig("title"));
                DataTable dataTable = (managmentVenta.ServiceValidateStockProduct(Convert.ToInt32(dgSaleProducts.Rows[e.RowIndex].Cells[0].Value), Convert.ToDecimal(cantidad)));
                if(Convert.ToInt32(dataTable.Rows[0]["state_response"]) == -1)
                {
                    MessageBox.Show(dataTable.Rows[0]["description_product"].ToString(), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string precio = dgSaleProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                decimal totalAnt = Convert.ToDecimal(dgSaleProducts.Rows[e.RowIndex].Cells[4].Value);
                dgSaleProducts.Rows[e.RowIndex].Cells[2].Value = cantidad;
                dgSaleProducts.Rows[e.RowIndex].Cells[4].Value = Convert.ToString(Convert.ToDecimal(cantidad) * Convert.ToDecimal(precio));
                decimal totalAux = (Convert.ToDecimal(cantidad) * Convert.ToDecimal(precio));
                ldTotal = (ldTotal - totalAnt) + totalAux;
                lblTotal.Text = ldTotal.ToString();
                lblIgv.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                lblSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
            }
        }

        private void dgSaleProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgSaleProducts.Rows.Count > 0)
                {
                    int indiceFila = this.dgSaleProducts.CurrentCell.RowIndex;
                    {
                        DataRow row = this.detalle.Rows[indiceFila];
                        ldTotal -= Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                        lblTotal.Text = ldTotal.ToString();
                        lblIgv.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                        ldIgv -= Convert.ToDecimal(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                        lblSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                        ldSubTotal -= Convert.ToDecimal(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));

                        this.detalle.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(ldTotal > 0)
            {
                FormPOSPagoDetalle formPOSPagoDetalle = new FormPOSPagoDetalle();
                formPOSPagoDetalle.dTotal = Convert.ToDecimal(lblTotal.Text);
                formPOSPagoDetalle.dIgv = Convert.ToDecimal(lblIgv.Text);
                formPOSPagoDetalle.dSubTotal = Convert.ToDecimal(lblSubTotal.Text);
                formPOSPagoDetalle.cOpeCod = GVarPublicas.gRegistroIngreso;
                formPOSPagoDetalle.cMovNro = funcionesGenerales.GetDateWithUser();
                string[] subs = txtEmpresasOPersonas.Text.Split('-');
                formPOSPagoDetalle.cliente = subs[0];
                formPOSPagoDetalle.nroDocumento = subs[1];
                formPOSPagoDetalle.CargarDataGrid(dgSaleProducts.DataSource);
                formPOSPagoDetalle.tipoTransaccion = "V";
                formPOSPagoDetalle.clienteId = Convert.ToInt32(txtIdCliente.Text);
                formPOSPagoDetalle.ShowDialog();
                LimpiarControles();
                txtCodigoBarras.Focus();
            }
            else
            {
                MessageBox.Show("No puede pagar, si no hay almenos un item seleccionado.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //btn de crédito
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCliente.Text) == 1)
            {
                MessageBox.Show("No puede registrar esta venta como un crédito. Primero debe de seleccionar una persona y/o empresa.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBuscarCliente.Focus();
                return;
            }
            if (ldTotal > 0)
            {
                FormPOSPagoDetalle formPOSPagoDetalle = new FormPOSPagoDetalle();
                formPOSPagoDetalle.dTotal = Convert.ToDecimal(lblTotal.Text);
                formPOSPagoDetalle.dIgv = Convert.ToDecimal(lblIgv.Text);
                formPOSPagoDetalle.dSubTotal = Convert.ToDecimal(lblSubTotal.Text);
                formPOSPagoDetalle.cOpeCod = GVarPublicas.gRegistroIngreso;
                formPOSPagoDetalle.cMovNro = funcionesGenerales.GetDateWithUser();
                string[] subs = txtEmpresasOPersonas.Text.Split('-');
                formPOSPagoDetalle.cliente = subs[0];
                formPOSPagoDetalle.nroDocumento = subs[1];
                formPOSPagoDetalle.CargarDataGrid(dgSaleProducts.DataSource);
                formPOSPagoDetalle.tipoTransaccion = "C";
                formPOSPagoDetalle.clienteId = Convert.ToInt32(txtIdCliente.Text);
                formPOSPagoDetalle.ShowDialog();
                LimpiarControles();
                txtCodigoBarras.Focus();
            }
            else
            {
                MessageBox.Show("No puede pagar, si no hay almenos un item seleccionado.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPOS_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Control:
            //        if(string.IsNullOrEmpty(txtIdCliente.Text))
            //        {
            //            MessageBox.Show("No puede registrar esta venta como un crédito. Primero debe de seleccionar una persona y/o empresa.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            btnBuscarCliente.Focus();
            //        }
            //        break;
            //    case Keys.Alt:
            //        if (ldTotal > 0)
            //        {
            //            FormPOSPagoDetalle formPOSPagoDetalle = new FormPOSPagoDetalle();
            //            formPOSPagoDetalle.dTotal = Convert.ToDecimal(lblTotal.Text);
            //            formPOSPagoDetalle.dIgv = Convert.ToDecimal(lblIgv.Text);
            //            formPOSPagoDetalle.dSubTotal = Convert.ToDecimal(lblSubTotal.Text);
            //            formPOSPagoDetalle.cOpeCod = GVarPublicas.gRegistroIngreso;
            //            formPOSPagoDetalle.cMovNro = funcionesGenerales.GetDateWithUser();
            //            string[] subs = txtEmpresasOPersonas.Text.Split('-');
            //            formPOSPagoDetalle.cliente = subs[0];
            //            formPOSPagoDetalle.nroDocumento = subs[1];
            //            formPOSPagoDetalle.CargarDataGrid(dgSaleProducts.DataSource);
            //            formPOSPagoDetalle.ShowDialog();
            //            LimpiarControles();
            //            txtCodigoBarras.Focus();
            //        }
            //        else
            //        {
            //            MessageBox.Show("No puede pagar, si no hay almenos un item seleccionado.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                DataTable dt = managmentProducts.GetByCodBarrasProduct(txtCodigoBarras.Text);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = this.detalle.NewRow();
                    row["iddetalleproducto"] = Convert.ToInt32(dt.Rows[0]["product_id"].ToString());
                    row["Producto"] = dt.Rows[0]["Nombre"].ToString();
                    row["Cantidad"] = 1.00;
                    row["Precio"] = Math.Round(Convert.ToDecimal(dt.Rows[0]["Precio_venta"].ToString()), 2);
                    row["Total"] = Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                    ldTotal += Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                    lblTotal.Text = ldTotal.ToString();
                    lblIgv.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                    ldIgv += Convert.ToDecimal(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                    lblSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                    ldSubTotal += Convert.ToDecimal(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                    this.detalle.Rows.Add(row);
                    //Validamos si está activado el bit de notificaciones
                    if (funcionesGenerales.GetValueConfig("sonido_notificaciones").Equals("1"))
                    {
                        funcionesGenerales.fvSonarNotificacion(1);
                        txtCodigoBarras.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El producto ingresado, no existe en la base de datos.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(rbCodigoBarras.Checked)
            { 
                dt = managmentProducts.GetByCodBarrasProduct(txtCodigoBarras.Text);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = this.detalle.NewRow();
                    row["iddetalleproducto"] = Convert.ToInt32(dt.Rows[0]["product_id"].ToString());
                    row["Producto"] = dt.Rows[0]["Nombre"].ToString();
                    row["Cantidad"] = 1.00;
                    row["Precio"] = Math.Round(Convert.ToDecimal(dt.Rows[0]["Precio_venta"].ToString()), 2);
                    row["Total"] = Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                    ldTotal += Math.Round((Convert.ToDecimal(row["Cantidad"].ToString()) * Convert.ToDecimal(row["Precio"].ToString())), 2);
                    lblTotal.Text = ldTotal.ToString();
                    lblIgv.Text = Convert.ToString(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                    ldIgv += Convert.ToDecimal(Math.Round(Convert.ToDouble(lblTotal.Text) * 0.18, 2));
                    lblSubTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                    ldSubTotal += Convert.ToDecimal(Math.Round(Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblIgv.Text), 2));
                    this.detalle.Rows.Add(row);
                    //Validamos si está activado el bit de notificaciones
                    if (funcionesGenerales.GetValueConfig("sonido_notificaciones").Equals("1"))
                    {
                        funcionesGenerales.fvSonarNotificacion(1);
                        txtCodigoBarras.Text = "";
                    }
                }
            } 
            else if(rbNombreDesc.Checked)
            {
                lvProducts.Items.Clear();
                DataTable dataTableProducts = managmentProducts.ServiceGetProductoPorNombre(txtCodigoBarras.Text.Trim());
                foreach (DataRow row in dataTableProducts.Rows)
                {
                    ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                    item.SubItems.Add(row["product_id"].ToString());
                    item.SubItems.Add(row["Nombre"].ToString());
                    item.SubItems.Add("1.00");
                    item.SubItems.Add(row["Precio_venta"].ToString());
                }
            }

        }

        private void btnAbarrotes_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            DataTable dataTableProducts = managmentProducts.ServiceGetProductosPorIdCategoria(3);
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            DataTable dataTableProducts = managmentProducts.ServiceGetProductosPorIdCategoria(2);
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }

        private void btnLacteos_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            DataTable dataTableProducts = managmentProducts.ServiceGetProductosPorIdCategoria(1);
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            DataTable dataTableProducts = managmentProducts.ServiceGetProductosPorIdCategoria(6);
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            DataTable dataTableProducts = managmentProducts.ServiceGetProductosPorIdCategoria(7);
            foreach (DataRow row in dataTableProducts.Rows)
            {
                ListViewItem item = lvProducts.Items.Add(string.Concat(row["Cod_Barras"].ToString(), " - ", row["Nombre"].ToString()));
                item.SubItems.Add(row["product_id"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add("1.00");
                item.SubItems.Add(row["Precio_venta"].ToString());
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormMntClientes formMntCliente = new FormMntClientes();
            formMntCliente.iniciaControles(true);
            formMntCliente.ShowDialog();
        }

        private void FormPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {

        }

        private void rbNombreDesc_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNombreDesc.Checked)
            {
                lblNombreEtiqueta.Text = "Nombre y/o descripción:";
            }
        }

        private void rbCodigoBarras_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCodigoBarras.Checked)
            {
                lblNombreEtiqueta.Text = "Cód.barras:";
            }
        }
    }
}
