using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.gVarPublicas;
//using CapaPresentacion.Report;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interactivity;

namespace CapaPresentacion.Sales
{
    public partial class FormPOSPagoDetalle : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentTipoPago managmentTipoPago = new ManagmentTipoPago();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentVenta managmentVenta = new ManagmentVenta();

        public decimal dTotal { get; set; }
        public decimal dSubTotal { get; set; }
        public decimal dIgv { get; set; }
        public string cOpeCod { get; set; }
        public string cMovNro { get; set; }
        public string cliente { get; set; }
        public string nroDocumento { get; set; }
        public string tipoTransaccion { get; set; }
        public int clienteId { get; set; }
        bool tieneConcepto = false;
        public FormPOSPagoDetalle()
        {
            InitializeComponent();
        }
        public void CargarDataGrid(object dataGridView)
        {
            dgViewDetallePago.DataSource = dataGridView;
            lblCantidadRegistro.Text = string.Concat("Nro items: ", Convert.ToString(dgViewDetallePago.Rows.Count));
        }
        public void CargarTipoPago()
        {
            cboTipoPago.DataSource = managmentTipoPago.ServiceGetTipoPagoEnCombo();
            cboTipoPago.ValueMember = "tipoPagoId";
            cboTipoPago.DisplayMember = "nombre";
            cboTipoPago.SelectedIndex = 1;
        }
        public void RedimensionarColumnas()
        {
            this.dgViewDetallePago.Columns["Producto"].Width = 150;
            this.dgViewDetallePago.Columns["Cantidad"].Width = 60;
            this.dgViewDetallePago.Columns["Precio"].Width = 60;
            this.dgViewDetallePago.Columns["Total"].Width = 60;
            this.dgViewDetallePago.Columns["iddetalleproducto"].Visible = false;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        private void FormPOSPagoDetalle_Load(object sender, EventArgs e)
        {
            CargarTipoPago();
            this.ActiveControl = txtMonto;
            txtIgv.Text = Convert.ToString(dIgv);
            txtSubTotal.Text = Convert.ToString(dSubTotal);
            txtTotal.Text = Convert.ToString(dTotal);
            lblCliente.Text = string.Concat("Cliente: ", cliente);
            lblNroDocumento.Text = string.Concat("Nro documento: ", nroDocumento);
            RedimensionarColumnas();
            AlternarColores(dgViewDetallePago);
            if(tipoTransaccion == "C")
            {
                lblVuelto.Visible = false;
                txtVuelto.Visible = false;
                cboTipoPago.Visible = false;
                txtMonto.Visible = false;
                txtConcepto.Visible = false;
                lblMensajeCredito.Visible = true;
                lblEfectivo.Visible = false;
                txtEfectivo.Visible = false;
                lblTipoPago.Visible = false;
                lblMonto.Visible = false;
                this.ActiveControl = btnGuardar;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoPagoId = Convert.ToInt32(cboTipoPago.SelectedIndex);
            switch (tipoPagoId)
            {
                case 1:
                    tieneConcepto = false;
                    txtConcepto.Visible = false;
                    lblConcepto.Visible = false;
                    lblEfectivo.Visible = true;
                    lblVuelto.Visible = true;
                    txtEfectivo.Visible = true;
                    txtVuelto.Visible = true;
                    txtMonto.Visible = true;
                    lblMonto.Visible = true;
                    break;
                case 2:
                    tieneConcepto = true;
                    txtConcepto.Visible = true;
                    lblConcepto.Visible = true;
                    lblEfectivo.Visible = false;
                    lblVuelto.Visible = false;
                    txtEfectivo.Visible = false;
                    txtVuelto.Visible = false;
                    txtMonto.Visible = false;
                    lblMonto.Visible = false;
                    break;
                case 0:
                    tieneConcepto = true;
                    txtConcepto.Visible = true;
                    lblConcepto.Visible = true;
                    lblEfectivo.Visible = false;
                    lblVuelto.Visible = false;
                    txtEfectivo.Visible = false;
                    txtVuelto.Visible = false;
                    txtMonto.Visible = false;
                    lblMonto.Visible = false;
                    break;
                case 3:
                    tieneConcepto = true;
                    txtConcepto.Visible = true;
                    lblConcepto.Visible = true;
                    lblEfectivo.Visible = false;
                    lblVuelto.Visible = false;
                    txtEfectivo.Visible = false;
                    txtVuelto.Visible = false;
                    txtMonto.Visible = false;
                    lblMonto.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtEfectivo.Text = Convert.ToString(Math.Round(Convert.ToDouble(txtMonto.Text), 2));
                if(Convert.ToDecimal(txtEfectivo.Text) >= Convert.ToDecimal(dTotal))
                {
                    txtVuelto.Text = Convert.ToString(Math.Round(Convert.ToDecimal(txtEfectivo.Text) - Convert.ToDecimal(dTotal), 2));
                    btnGuardar.Focus();
                }
                else
                {
                    txtVuelto.Text = "";
                    txtEfectivo.Text = "";
                    MessageBox.Show("El efectivo no puede ser menor al monto a pagar.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Primero validamos si la impresora está okey, para poder realizar la venta.
            DialogResult Opcion;
            bool blnContinuar = false;
            string strContinuar = Convert.ToString(funcionesGenerales.GetValueConfig("imprimir_ticket_factura"));
            if(strContinuar.Equals("0"))
            {
                Opcion = MessageBox.Show("¿La opción de imprimir en la ticketera está no disponible, por favor verifique la configuración del sistema sólo si tiene disponible su ticketera? ¿Desea generar la venta de todos modos?. Tener en cuenta que no se emitirá ningún ticket físico.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcion == DialogResult.OK)
                {
                    blnContinuar = true;
                }
            }

            Opcion = MessageBox.Show("¿Realmente desea guardar esta venta?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                TipoPago tipoPago = new TipoPago
                {
                    tipoPagoId = Convert.ToInt32(cboTipoPago.SelectedValue)
                };
                VentaConcepto ventaConcepto = new VentaConcepto
                {
                    concepto = txtConcepto.Text
                    
                };
                Caja caja = new Caja();
                caja.CajaId = GVarPublicas.GsCajaId;
                Sede sede = new Sede();
                sede.SedeId = GVarPublicas.GsSedeId;
                Cliente cliente = new Cliente();
                cliente.ClienteId = Convert.ToInt32(clienteId);
                cliente.Nombres = lblCliente.Text;
                Venta venta;
                if (tipoTransaccion.Equals("V"))
                {
                    venta = new Venta
                    {
                        total = dTotal,
                        igv = dIgv,
                        subTotal = dSubTotal,
                        vuelto = tieneConcepto ? 0: Convert.ToDecimal(txtVuelto.Text),
                        tipoPago = tipoPago,
                        tieneConcepto = tieneConcepto,
                        tipoTransaccion = tipoTransaccion
                    };
                }
                else
                {
                    venta = new Venta
                    {
                        total = dTotal,
                        igv = dIgv,
                        subTotal = dSubTotal,
                        vuelto = Convert.ToDecimal(0),
                        tipoPago = tipoPago,
                        tieneConcepto = tieneConcepto,
                        tipoTransaccion = tipoTransaccion
                    };
                }

                List<DetalleVenta> detalleVenta = new List<DetalleVenta>();
                foreach (DataGridViewRow row in dgViewDetallePago.Rows)
                {
                    DetalleVenta detalleVent = new DetalleVenta();
                    Product product = new Product
                    {
                        ProductId = Convert.ToInt32(row.Cells["iddetalleproducto"].Value.ToString()),
                        Name = Convert.ToString(row.Cells["Producto"].Value.ToString())
                    };
                    detalleVent.cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                    detalleVent.costo = Convert.ToDecimal(row.Cells["Total"].Value.ToString());

                    detalleVent.producto = product;
                    detalleVenta.Add(detalleVent);
                }
                venta.DetalleVentas = detalleVenta;
                venta.ventaConcepto = ventaConcepto;
                venta.Caja = caja;
                venta.Sede = sede;
                venta.Cliente = cliente;
                string inserta = managmentVenta.InsertaVenta(venta, GVarPublicas.gRegistroIngreso, funcionesGenerales.GetDateWithUser());
                if(inserta.Length > 0)
                {
                    if (!blnContinuar) ImprimirTicket(venta, inserta);
                    MessageBox.Show("Registro de venta exitosamante.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar una nueva venta.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
        }
        public void ImprimirTicket(Venta venta, string serie)
        {
            Impresora ticket = new Impresora();
            ticket.AbreCajon();//Para abrir el cajon de dinero.
            ticket.TextoCentro(new FuncionesGenerales().GetValueConfig("title").ToUpper());
            ticket.TextoCentro(new FuncionesGenerales().GetValueConfig("direccion"));
            ticket.TextoCentro("Trujillo - Trujillo - La Libertad");
            ticket.TextoCentro(string.Concat("R.U.C:", new FuncionesGenerales().GetValueConfig("ruc")));
            ticket.TextoCentro("BOLETA DE VENTA ELECTRÓNICA");//Es el mio por si me quieren contactar ...
            ticket.TextoCentro(serie.ToUpper());//Es el mio por si me quieren contactar ...
            ticket.lineasGuio();
            ticket.TextoIzquierda(string.Concat("ATENDIÓ: ", GVarPublicas.GsUserName.ToUpper()));
            ticket.TextoIzquierda(Strings.Left(string.Concat(venta.Cliente.Nombres), 40));
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasGuio();
            ticket.EncabezadoVenta();
            ticket.lineasGuio();
            foreach (DetalleVenta lstVenta in venta.DetalleVentas)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(lstVenta.producto.Name.ToUpper().Length >= 20 ? lstVenta.producto.Name.ToUpper().Substring(0, 20): lstVenta.producto.Name.ToUpper(), lstVenta.cantidad, Convert.ToDecimal(lstVenta.costo / lstVenta.cantidad), Convert.ToDecimal(lstVenta.costo));
            }
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL      S/.", venta.subTotal);
            ticket.AgregarTotales("         IGV           S/.", venta.igv);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL         S/.", venta.total);
            ticket.TextoIzquierda("");
            if(Convert.ToInt32(cboTipoPago.SelectedIndex) == 1) //Efectivo
            {
                ticket.AgregarTotales("         EFECTIVO      S/.", Convert.ToDecimal(venta.total + venta.vuelto));
                ticket.AgregarTotales("         CAMBIO        S/.", venta.vuelto);
            }

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoCentro("GRACIAS POR SU COMPRA.");
            ticket.TextoCentro("VUELVA PRONTO.");
            ticket.CortaTicket();
            ticket.ImprimirTicket(funcionesGenerales.GetValueConfig("impresora"));//Nombre de la impresora ticketera
        }
        public void imprimirComprobante(int ventaId)
        {
            //FormTicket formTicket = new FormTicket();
            //formTicket.VentaId = ventaId;
            //formTicket.ShowDialog();
        }
        public void LimpiarControles()
        {
            txtConcepto.Text = "";
            txtMonto.Text = "";
            txtIgv.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            lblCliente.Text = "";
            lblNroDocumento.Text = "";
        }

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }
    }
}
