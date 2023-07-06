using CapaAplicacion;
using CapaEntidades;
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
    public partial class FormAperturaCajaChica : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentUser managmentUser = new ManagmentUser();
        private readonly ManagmentCategoria managmentCategoria = new ManagmentCategoria();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public FormAperturaCajaChica()
        {
            InitializeComponent();
        }
        private void FormAperturaCajaChica_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                limpiarControles();
                recuperarUsuario();
            }
        }
        public void recuperarUsuario()
        {
            DataTable dt = managmentUser.ServiceGetUsuarioPorCodigo(txtCodUser.Text);
            if (string.IsNullOrEmpty(txtCodUser.Text))
            {
                return;
            }
            if(dt.Rows.Count > 0)
            {
                if(Convert.ToInt32(dt.Rows[0]["nRespuesta"]) == -1)
                {
                    MessageBox.Show(dt.Rows[0]["cDescripcion"].ToString(), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (Convert.ToInt32(dt.Rows[0]["nRespuesta"]) == -2)
                {
                    MessageBox.Show(dt.Rows[0]["cDescripcion"].ToString(), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(Convert.ToInt32(dt.Rows[0]["nRespuesta"]) == -3)
                {
                    MessageBox.Show(dt.Rows[0]["cDescripcion"].ToString(), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (Convert.ToInt32(dt.Rows[0]["nRespuesta"]) == 1)
                {
                    txtUsuarioCompleto.Text = dt.Rows[0]["cUsuario"].ToString();
                    txtCaja.Text = dt.Rows[0]["cCaja"].ToString();
                    txtSede.Text = dt.Rows[0]["cSede"].ToString();
                    txtCajaId.Text = dt.Rows[0]["caja_id"].ToString();
                    txtSedeId.Text = dt.Rows[0]["sede_id"].ToString();
                    txtMonto.Focus();
                }
            }
            else
            {
                MessageBox.Show("El usuario consultado, no existe en la base de datos. Comunicarse con el administrador del sistema.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodUser.Text = "";
            }
        }
        private void txtCodUser_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiarControles()
        {
            txtUsuarioCompleto.Text = "";
            txtCaja.Text = "";
            txtSede.Text = "";
            txtMonto.Text = "";
        }
        private void btnAperturar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Desea aperturar caja para este usuario?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                DateTime fechaApertura = DateTime.Now;
                Apertura apertura = new Apertura();
                apertura.codigoUsuario = txtCodUser.Text;
                apertura.montoApertura = Convert.ToDecimal(txtMonto.Text);
                apertura.fechaApertura = fechaApertura;
                apertura.cajaId = Convert.ToInt32(txtCajaId.Text);
                apertura.sedeId = Convert.ToInt32(txtSedeId.Text);
                bool estadoApertura = managmentCaja.ServiceAperturaCajaChica(apertura);
                if(estadoApertura)
                {
                    MessageBox.Show("Apertura registrada correctamente.\nDebe de dar click en actualizar para reconfigurar valores del sistema.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != SignoDecimal || textBox.SelectionStart == 0 || textBox.Text.Contains(SignoDecimal));
            if(!e.Handled && e.KeyChar == 13)
            {
                btnAperturar.Focus();
            }

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
    }
}
