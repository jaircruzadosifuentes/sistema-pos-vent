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

namespace CapaPresentacion.Sales
{
    public partial class FormListadoDeVentas: MaterialSkin.Controls.MaterialForm
    {
        bool mostrarDetalle = false;
        private readonly ManagmentVenta managmentVenta = new ManagmentVenta();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();

        public FormListadoDeVentas()
        {
            InitializeComponent();
        }
        public void CargarVentas()
        {
            dgViewComprobantes.DataSource = managmentVenta.ServiceGetAllVentas();
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewComprobantes.Rows.Count, " registros.");
        }
        public void VerificarImpresora()
        {
            string strContinuar = Convert.ToString(funcionesGenerales.GetValueConfig("imprimir_ticket_factura"));
            btnImprimir.Enabled = strContinuar.Equals("0") ? false : true;
        }
        private void FormListadoDeVentas_Load(object sender, EventArgs e)
        {
            this.Height = 470;
            AlternarColores(dgViewComprobantes);
            AlternarColores(dgViewDetalleComprobante);
            CargarVentas();
            RedimensionarFilas();
            this.ActiveControl = txtBuscar;
            VerificarImpresora();
        }
        public void RedimensionarFilas()
        {
            //this.dgViewComprobantes.Cel
            this.dgViewComprobantes.Columns["ID"].Width = 30;
            this.dgViewComprobantes.Columns["Cliente"].Width = 250;
            this.dgViewComprobantes.Columns["Fecha"].Width = 150;
            this.dgViewComprobantes.Columns["Documento"].Width = 70;
            this.dgViewComprobantes.Columns["Correlativo"].Width = 140;
            this.dgViewComprobantes.Columns["Estado"].Width = 70;
            this.dgViewComprobantes.Columns["Total"].Width = 60;
            this.dgViewComprobantes.Columns["Vuelto"].Width = 60;
            this.dgViewComprobantes.Columns["TipoPago"].Width = 70;
            this.dgViewComprobantes.Columns["Concepto"].Width = 450;
        }
        public void RedimensionarFilasDetalle()
        {
            //this.dgViewComprobantes.Cel
            this.dgViewDetalleComprobante.Columns["ID"].Width = 30;
            this.dgViewDetalleComprobante.Columns["Producto"].Width = 550;
            this.dgViewDetalleComprobante.Columns["Cantidad"].Width = 60;
            this.dgViewDetalleComprobante.Columns["Total"].Width = 60;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerDetalle_Click_1(object sender, EventArgs e)
        {
            string tipoPago = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["TipoTransaccion"].Value);
            if (tipoPago.Equals("PAGO CRÉDITO"))
            {
                MessageBox.Show("Al ser un PAGO DE UN CRÉDITO, consultar al módulo de 520100 - PAGOS PENDIENTES POR COBRAR / 520102 - VER PAGOS PENDIENTES para más información.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mostrarDetalle = !mostrarDetalle;
                if (!mostrarDetalle)
                {
                    this.Height = 470;
                    btnVerDetalle.Text = "Mostrar detalle";
                    CargarVentas();
                }
                else
                {
                    foreach (DataGridViewRow row in dgViewComprobantes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            this.Height = 670;
                            btnVerDetalle.Text = "Ocultar detalle";
                            int ventaId = Convert.ToInt32(row.Cells[1].Value);
                            dgViewDetalleComprobante.DataSource = managmentVenta.ServiceGetDetalleVentaPorId(ventaId);
                            RedimensionarFilasDetalle();
                        }
                    }
               
            }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgViewComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgViewComprobantes.Columns["selecciona"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgViewComprobantes.Rows[e.RowIndex].Cells["selecciona"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void rbSerieNumero_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSerieNumero.Checked)
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbSerieNumero.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(1, txtBuscar.Text);
            } 
            else if(rbCliente.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(2, txtBuscar.Text);
            }
            else if(rbCodUser.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(3, txtBuscar.Text);
            }
            lblCantidad.Text = string.Concat("Se han cargado ", dgViewComprobantes.Rows.Count, " registros.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgViewComprobantes.Rows.Count > 0)
            {
                Venta venta = new Venta();
                TipoPago tipoPago = new TipoPago();
                Cliente cliente = new Cliente();
                List<DetalleVenta> detalleVentas = new List<DetalleVenta>();
                int ventaId = Convert.ToInt32(this.dgViewComprobantes.CurrentRow.Cells["ID"].Value);
                DataTable dtVenta = managmentVenta.ServiceGetVentaPorId(ventaId);
                venta.Correlativo = dtVenta.Rows[0]["Correlativo"].ToString().Trim();
                venta.FechaRegistro = Convert.ToDateTime(dtVenta.Rows[0]["Fecha"].ToString());
                venta.Hora = Convert.ToString(dtVenta.Rows[0]["Hora"]);
                venta.Usuario = Convert.ToString(dtVenta.Rows[0]["usuario"]);

                venta.subTotal = Convert.ToDecimal(dtVenta.Rows[0]["dSubTotal"].ToString());
                venta.igv = Convert.ToDecimal(dtVenta.Rows[0]["dIgv"].ToString());
                venta.total = Convert.ToDecimal(dtVenta.Rows[0]["dTotal"].ToString());
                venta.vuelto = Convert.ToDecimal(dtVenta.Rows[0]["dVuelto"].ToString());

                tipoPago.nombre = dtVenta.Rows[0]["TipoPago"].ToString();
                cliente.Nombres = dtVenta.Rows[0]["Cliente"].ToString();
                venta.tipoPago = tipoPago;
                venta.Cliente = cliente;

                DataTable dtVentaDetalle = managmentVenta.ServiceGetDetalleVentaPorId(ventaId);
                foreach (DataRow item in dtVentaDetalle.Rows)
                {
                    DetalleVenta detalleVenta = new DetalleVenta();
                    Product product = new Product();
                    detalleVenta.costo = Convert.ToDecimal(item["Total"].ToString());
                    detalleVenta.cantidad = Convert.ToDecimal(item["Cantidad"].ToString());
                    product.Name = item["Producto"].ToString();
                    detalleVenta.producto = product;

                    detalleVentas.Add(detalleVenta);
                    //detalleVenta = null;
                }
                venta.DetalleVentas = detalleVentas;
                if (!venta.tipoPago.nombre.Equals("No aplica"))
                {
                    ImprimirTicket(venta);
                }
                else
                {
                    MessageBox.Show("Al ser un crédito, consultar al módulo de 520100 - PAGOS PENDIENTES POR COBRAR / 520102 - VER PAGOS PENDIENTES para más información.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ImprimirTicket(Venta venta)
        {
            Impresora ticket = new Impresora();
            ticket.TextoCentro(new FuncionesGenerales().GetValueConfig("title").ToUpper());
            ticket.TextoCentro(new FuncionesGenerales().GetValueConfig("direccion"));
            ticket.TextoCentro("Trujillo - Trujillo - La Libertad");
            ticket.TextoCentro(string.Concat("R.U.C:", new FuncionesGenerales().GetValueConfig("ruc")));
            ticket.TextoCentro("BOLETA DE VENTA ELECTRÓNICA");//Es el mio por si me quieren contactar ...
            ticket.TextoCentro(venta.Correlativo.ToUpper());//Es el mio por si me quieren contactar ...
            ticket.lineasGuio();
            ticket.TextoIzquierda(string.Concat("ATENDIÓ: ", venta.Usuario));
            ticket.TextoIzquierda(Strings.Left(string.Concat("CLIENTE: ",venta.Cliente.Nombres), 40));
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + venta.FechaRegistro.ToString("dd/MM/yyyy"), "HORA: " + venta.Hora);
            ticket.lineasGuio();
            ticket.EncabezadoVenta();
            ticket.lineasGuio();
            foreach (DetalleVenta lstVenta in venta.DetalleVentas)//dgvLista es el nombre del datagridview
            {
                ticket.AgregaArticulo(lstVenta.producto.Name.ToUpper().Length >= 20 ? lstVenta.producto.Name.ToUpper().Substring(0, 20) : lstVenta.producto.Name.ToUpper(), lstVenta.cantidad, Convert.ToDecimal(lstVenta.costo / lstVenta.cantidad), Convert.ToDecimal(lstVenta.costo));
            }
            ticket.lineasIgual();
            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL      S/.", venta.subTotal);
            ticket.AgregarTotales("         IGV           S/.", venta.igv);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL         S/.", venta.total);
            ticket.TextoIzquierda("");
            if (venta.tipoPago.nombre.Equals("Efectivo")) //Efectivo
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
        private void button1_Click(object sender, EventArgs e)
        {
            string tipoPago = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["TipoTransaccion"].Value);
            if(tipoPago.Equals("PAGO CRÉDITO"))
            {
                MessageBox.Show("Al ser un PAGO DE UN CRÉDITO, consultar al módulo de 520100 - PAGOS PENDIENTES POR COBRAR / 520102 - VER PAGOS PENDIENTES para más información.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgViewComprobantes.Rows.Count > 0)
                {
                    //FormTicket formTicket = new FormTicket();
                    //formTicket.VentaId = Convert.ToInt32(this.dgViewComprobantes.CurrentRow.Cells["ID"].Value);
                    //formTicket.Text = Convert.ToString(this.dgViewComprobantes.CurrentRow.Cells["Correlativo"].Value);
                    //formTicket.ShowDialog();
                }
            }
        }

        private void rbCodUser_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCodUser.Checked)
            {
                txtBuscar.Text = "";
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCliente.Checked)
            {
                txtBuscar.Text = "";
            }
        }

        private void dgViewComprobantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgViewComprobantes.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[5].Value).Substring(0, 2).Equals("EX"))// Or your condition 
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }
    }
}
