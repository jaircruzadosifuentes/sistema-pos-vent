using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.Sales;
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
    public partial class FormMntClientes : MaterialSkin.Controls.MaterialForm
    {
        public bool IS_NEW = false;
        public bool IS_MODIFICATION = false;
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentUser managmentUser = new ManagmentUser();
        private readonly ManagmentCliente managmentCliente = new ManagmentCliente();
        public bool bConsultaClientesDesdeVentas = false;
        public FormMntClientes()
        {
            InitializeComponent();
        }
        public void cargarClientes()
        {
            this.dgPersonas.DataSource = managmentUser.ServiceGetClientes();
        }
        public void iniciaControles(bool estadoConsultaClientesDesdeVentas)
        {
            bConsultaClientesDesdeVentas = estadoConsultaClientesDesdeVentas;
        }
        public void RedimensionarColumnas()
        {
            this.dgPersonas.Columns["ID"].Width = 60;
            this.dgPersonas.Columns["Cliente"].Width = 300;
            this.dgPersonas.Columns["Documento"].Width = 120;
            this.dgPersonas.Columns["NroDocumento"].Width = 120;
            this.dgPersonas.Columns["Sexo"].Width = 70;
            this.dgPersonas.Columns["Correo"].Width = 200;
        }
        public void cargarTipoDocumentos()
        {
            cboTipoDoc.DataSource = new ManagmentDocuments().ServiceGetTipoDocumentoEnCombo();
            cboTipoDoc.ValueMember = "tipoDocumentoId";
            cboTipoDoc.DisplayMember = "abreviatura";
        }
        private void FormMntClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
            RedimensionarColumnas();
            AlternarColores(dgPersonas);
            ControlForDefault();
            cargarTipoDocumentos();
            // Bit para mostrar defrente los controles para insertar
            if(bConsultaClientesDesdeVentas)
            {
                IS_NEW = true;
                HabilitarControlesNuevo(bConsultaClientesDesdeVentas);
                this.ActiveControl = txtNombres;
            }
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            gbCliente.Enabled = estado;
            tvViewPersonal.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnGuardar.Enabled = estado;
            this.btnCancelar.Visible = estado;
            this.btnModificar.Enabled = IS_NEW ? false: estado;
            this.btnExcel.Enabled = !estado;
            this.btnEliminar.Visible = !estado;
        }
        public bool fbValidaDatosCliente()
        {
            bool valida = true;
            if(string.IsNullOrEmpty(txtNombres.Text))
            {
                valida = false;
                MessageBox.Show("Debe de ingresar los nombres del cliente.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombres.Focus();
            }
            else if(string.IsNullOrEmpty(txtApellidoPaterno.Text))
            {
                valida = false;
                MessageBox.Show("Debe de ingresar el apellido paterno del cliente.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellidoPaterno.Focus();
            }
            else if(string.IsNullOrEmpty(txtApellidoMaterno.Text))
            {
                valida = false;
                MessageBox.Show("Debe de ingresar el apellido materno del cliente.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellidoMaterno.Focus();
            }
            else if(Convert.ToInt32(cboTipoDoc.SelectedValue) == 0)
            {
                valida = false;
                MessageBox.Show("Debe de seleccionar el tipo de documento.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTipoDoc.Focus();
            }
            else if(string.IsNullOrEmpty(txtNumeroDoc.Text))
            {
                valida = false;
                MessageBox.Show("Debe de ingresar el nro de documento.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroDoc.Focus();
            }
            return valida;
        }
        public void limpiarControles()
        {
            txtApellidoPaterno.Text = "";
            txtNombres.Text = "";
            txtApellidosConyugue.Text = "";
            txtNumeroDoc.Text = "";
            txtDireccionPersona.Text = "";
            txtCorreoElectronico.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if(fbValidaDatosCliente())
            {
                cliente.Nombres = txtNombres.Text;
                cliente.Apellidos = string.Concat(txtApellidoPaterno.Text, " ", txtApellidoMaterno.Text);
                if(chkTieneCorreo.Checked)
                {
                    cliente.Email = txtCorreoElectronico.Text;
                    cliente.TieneCorreo = true;
                }
                cliente.NroDocumento = txtNumeroDoc.Text;
                TipoDocumento tipoDocumento = new TipoDocumento();
                tipoDocumento.TipoDocumentoId = Convert.ToInt32(cboTipoDoc.SelectedValue);
                if(rbMasculino.Checked)
                {
                    cliente.Sexo = 'M';
                }
                else
                {
                    cliente.Sexo = 'F';
                }
                cliente.DireccionFiscal = txtDireccionPersona.Text;
                cliente.TipoDocumento = tipoDocumento;
                bool inserta = managmentCliente.ServiceInsertaCliente(cliente, "I");
                if (inserta)
                {
                    MessageBox.Show("Cliente registrado con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_NEW = false;
                    limpiarControles();
                    cargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al registrar cliente", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IS_NEW = true;
            HabilitarControlesNuevo(true);
            txtNombres.Focus();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtApellidoPaterno.Focus();
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void ControlForDefault()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboTipo.SelectedIndex = 0;
            gbCliente.Enabled = false;
        }
        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorTipoDoc = cboTipoDoc.SelectedIndex;
            switch (valorTipoDoc)
            {
                case 0:
                    txtNumeroDoc.MaxLength = 8;
                    break;
                case 1:
                    txtNumeroDoc.MaxLength = 11;
                    break;
                case 2:
                    txtNumeroDoc.MaxLength = 11;
                    break;
                default:
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IS_MODIFICATION)
            {
                HabilitarControlesNuevo(false);
                IS_MODIFICATION = false;
                limpiarControles();
            }
            else
            {
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                limpiarControles();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccionPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cboTipoDoc.Focus();
            }
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                chkTieneCorreo.Focus();
            }
        }

        private void chkTieneCorreo_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreoElectronico.Enabled = chkTieneCorreo.Checked;
        }

        private void txtNombres_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApellidoPaterno.Focus();
            }
        }

        private void txtApellidoPaterno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void dgPersonas_DoubleClick(object sender, EventArgs e)
        {
            if(bConsultaClientesDesdeVentas)
            {
                FormPOS formPOS = FormPOS.GetInstancia();
                string nombres = Convert.ToString(this.dgPersonas.CurrentRow.Cells["Cliente"].Value);
                string dni = Convert.ToString(this.dgPersonas.CurrentRow.Cells["NroDocumento"].Value);
                string id = Convert.ToString(this.dgPersonas.CurrentRow.Cells["ID"].Value);
                formPOS.SetCliente(id, string.Concat(nombres.ToUpper(), " - (", dni, ")"));
                this.Close();
            }
        }

        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
