using CapaAplicacion;
using CapaEntidades;
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
    public partial class FormPagarCreditoEfectivo : MaterialSkin.Controls.MaterialForm
    {
        public decimal montoDeuda { get; set; }
        public decimal montoAmortizado { get; set; }
        public decimal montoCredito { get; set; }
        public string cliente { get; set; }
        public string correlativo { get; set; }
        public int ventaId { get; set; }
        public bool esPagado { get; set; }
        public FormPagarCreditoEfectivo()
        {
            InitializeComponent();
        }
        public void cargarDatosCabecera()
        {
            lblCliente.Text = cliente;
            lblCorrelativo.Text = correlativo;
            lblMontoCredito.Text = Convert.ToString(montoCredito);
            lblMontoDeuda.Text = Convert.ToString(montoDeuda);
            lblMontoAmortizado.Text = Convert.ToString(montoAmortizado);
            txtDescripcion.Text = string.Concat("Se hace la amortización del monto de ", Convert.ToString(txtMontoAmortizar.Text), " nuevos soles, ", 
                "con fecha ", new FuncionesGenerales().GetFechaActual(), ".");
        }
        public void RedimensionarColumnas()
        {
            this.dgDetallePagos.Columns["ID"].Width = 60;
            this.dgDetallePagos.Columns["Usuario_Registro"].Width = 120;
            this.dgDetallePagos.Columns["Monto_Amortizado"].Width = 120;
            this.dgDetallePagos.Columns["Fecha_Pago"].Width = 180;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void cargarDetallePagos()
        {
            dgDetallePagos.DataSource = new ManagmentCaja().ServiceGetPagosPorVentaId(ventaId);
        }
        private void FormPagarCreditoEfectivo_Load(object sender, EventArgs e)
        {
            cargarDetallePagos();
            cargarDatosCabecera();
            RedimensionarColumnas();
            this.ActiveControl = txtMontoAmortizar;
            AlternarColores(dgDetallePagos);
            if(esPagado)
            {
                btnGuardar.Enabled = false;
                btnGuardar.Text = "Pagado";
                txtMontoAmortizar.Enabled = false;
                txtDescripcion.Text = "El comprobante ya no tiene deudas.";
                txtMontoAmortizar.Text = "0.00";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMontoAmortizar_TextChanged(object sender, EventArgs e)
        {
            cargarDatosCabecera();
        }
        public bool validaDatos()
        {
            bool estado = true;
            if(Convert.ToDecimal(txtMontoAmortizar.Text) > Convert.ToDecimal(lblMontoDeuda.Text))
            {
                MessageBox.Show("El monto amortizar, no puede ser mayor a la deuda.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }
            return estado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validaDatos())
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea amortizar el crédito de este comprobante?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    PagarCredito pagarCredito = new PagarCredito();
                    pagarCredito.CodigoOperacion = GVarPublicas.gEmitirPagoPendiente;
                    pagarCredito.Monto = Convert.ToDecimal(txtMontoAmortizar.Text);
                    pagarCredito.Usuario = new FuncionesGenerales().GetDateWithUser();
                    pagarCredito.Descripcion = txtDescripcion.Text;

                    Venta venta = new Venta();
                    venta.ventaId = Convert.ToInt32(ventaId);

                    Sede sede = new Sede();
                    sede.SedeId = Convert.ToInt32(GVarPublicas.GsSedeId);
                    Caja caja = new Caja();
                    caja.CajaId = Convert.ToInt32(GVarPublicas.GsCajaId);

                    pagarCredito.Venta = venta;
                    pagarCredito.Sede = sede;
                    pagarCredito.Caja = caja;

                    bool estadoPago = new ManagmentCaja().ServiceRegistraPagoDeCredito(pagarCredito, new FuncionesGenerales().GetDateWithUser());
                    if (estadoPago)
                    {
                        cargarDatosCabecera();
                        limpiarControles();
                        cargarDetallePagos();
                        MessageBox.Show("Pago registrado con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al pagar crédito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }
        public void limpiarControles()
        {
            txtMontoAmortizar.Text = "";
        }

        private void txtMontoAmortizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }
    }
}
