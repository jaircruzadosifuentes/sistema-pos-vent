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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Contabilidad
{
    public partial class FormRegistrarEgresos : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        public FormRegistrarEgresos()
        {
            InitializeComponent();
        }
        public void cargarMonto()
        {
            DataTable dataTable = new ManagmentCaja().ServiceGetMontoParaCajaChica(GVarPublicas.GsUserName, GVarPublicas.GsCajaId, GVarPublicas.GsSedeId);
            if (dataTable.Rows.Count > 0)
            {
                txtMontoActual.Text = dataTable.Rows[0]["nMontoEsperado"].ToString();
            }
        }
        private void FormRegistrarEgresos_Load(object sender, EventArgs e)
        {
            cargarSedes();
            cargarMonto();
            this.ActiveControl = txtMonto;
            DateTime date = DateTime.Now;
            txtFecha.Text = new FuncionesGenerales().GetFechaActual();
        }
        public void cargarCajaPorSedeId(int sedeId)
        {
            //cboCaja.DataSource = managmentCaja.ServiceGetCajaPorSedeIdEnCombo(sedeId); 
            //cboCaja.ValueMember = "cajaId";
            //cboCaja.DisplayMember = "name";
        }
        public void cargarSedes()
        {
            //cboSede.DataSource = managmentCaja.ServiceGetSedesParaCombo(); 
            //cboSede.ValueMember = "sedeId";
            //cboSede.DisplayMember = "name";
            txtSede.Text = GVarPublicas.GsSede;
            txtCaja.Text = GVarPublicas.GsCaja;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private const char SignoDecimal = '.'; // Carácter separador decimal
        private string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

            var textBox = (TextBox)sender;
            if (Regex.IsMatch(textBox.Text, @"^(?:\d+\.?\d*)?$"))
            {
                _prevTextBoxValue = textBox.Text;
            }
            else
            {
                var charsAfterCursor = textBox.TextLength - textBox.SelectionStart - textBox.SelectionLength;
                textBox.Text = _prevTextBoxValue;
                textBox.SelectionStart = Math.Max(0, textBox.TextLength - charsAfterCursor);
            }
        }
        public bool validaDatos()
        {
            bool estadoValida = true;
           
            if (string.IsNullOrEmpty(txtMontoActual.Text))
            {
                estadoValida = false;
                MessageBox.Show("El monto aperturado es 0.00, primero debe de apeturar caja chica.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtMonto.Text.TrimEnd()))
            {
                estadoValida = false;
                MessageBox.Show("Debe de ingresar el monto a realizar el egreso.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(string.IsNullOrEmpty(txtDescripcion.Text.TrimEnd()))
            {
                estadoValida = false;
                MessageBox.Show("Debe de ingresar una descripción.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return estadoValida;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validaDatos())
            {
                decimal montoIngresado = Convert.ToDecimal(txtMonto.Text.Trim());
                decimal montoActual = Convert.ToDecimal(txtMontoActual.Text.Trim());
                if(montoIngresado > montoActual)
                {
                    MessageBox.Show("El monto ingresado no puede ser mayor al monto aperturado.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Egreso egreso = new Egreso();
                egreso.Descripcion = txtDescripcion.Text.TrimEnd();
                egreso.Monto = Convert.ToDecimal(txtMonto.Text.TrimEnd());
                egreso.CodigoOperacion = GVarPublicas.gRegistroEgresos;

                User user = new User();
                user.UserId = GVarPublicas.GsUserId;

                Caja caja = new Caja();
                caja.CajaId = Convert.ToInt32(GVarPublicas.GsCajaId);

                Sede sede = new Sede();
                sede.SedeId = Convert.ToInt32(GVarPublicas.GsSedeId);

                egreso.Caja = caja;
                egreso.Sede = sede;
                egreso.Usuario = user;

                bool inserta = new ManagmentCaja().ServiceRegistraEgresosEnCajaChica(egreso, new FuncionesGenerales().GetDateWithUser());
                if(inserta)
                {
                    cargarMonto();
                    MessageBox.Show("Registro realizado correctamente.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles();
                }
                else
                {
                    limpiarControles();
                }
            }
        }
        public void limpiarControles()
        {
            txtMonto.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
            
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarCajaPorSedeId(Convert.ToInt32(cboSede.SelectedValue));
        }

        private void cboSede_SelectedValueChanged(object sender, EventArgs e)
        {
            //veces = veces + 1;
            //if(veces > 3)
            //{
            //    if (Convert.ToInt32(cboSede.SelectedValue) != 0)
            //    {
            //        estadoCargaCombo = true;
            //        cargarCajaPorSedeId(Convert.ToInt32(cboSede.SelectedValue));
            //    }
            //}
        }
    }
}
