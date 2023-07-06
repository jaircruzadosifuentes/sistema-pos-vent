using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento
{
    public partial class FormBuscarDireccion : MaterialSkin.Controls.MaterialForm
    {
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public FormBuscarDireccion()
        {
            InitializeComponent();
        }

        private void FormBuscarDireccion_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormMntPersona formMntPersona = FormMntPersona.GetInstancia();
            string direccion = txtDireccion.Text;
            string manzana = txtManzana.Text;
            string lote = txtLote.Text;
            string referencia = txtReferencia.Text;
            formMntPersona.SetDatosDomicilio(direccion, manzana, lote, referencia);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesGenerales.ValidatingNumbers(e);
            if (e.KeyChar == (char)13)
            {
                txtReferencia.Focus();
            }
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtManzana.Focus();
            }
        }

        private void txtManzana_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManzana_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesGenerales.ValidatingLetters(e);
            if (e.KeyChar == (char)13)
            {
                txtLote.Focus();
            }
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregar.Focus();
            }
        }
    }
}
