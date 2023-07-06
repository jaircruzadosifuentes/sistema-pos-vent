using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.gVarPublicas;

namespace CapaPresentacion
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentLogin managmentLogin = new ManagmentLogin();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();

        //EJCS. 26-08-2020
        public void GetAllConfig()
        {
            //EnableControl();
            lblCopyright.Text = funcionesGenerales.GetValueConfig("copyright");
            lblTitle.Text = funcionesGenerales.GetValueConfig("title");
            //picbLogo.Load(funcionesGenerales.GetValueConfig("image"));
        }
        public void DisabledControler()
        {

        }
        //EJCS. 06-09-2020
        //Desactivamos el formulario al ver que está en mantenimiento
        public void DisabledApp()
        {
            string stateType = funcionesGenerales.GetValueConfig("maintenance");
            string apiKeyLicence = funcionesGenerales.GetValueConfig("api_key_license");
            if (stateType.Equals("1"))
            {
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
                btnAceptar.Enabled = false;
                btnSalir.Enabled = false;
                //picbLogo.Enabled = false;
                lblCopyright.Enabled = false;
                lblTitle.Enabled = false;
                MessageBox.Show("Sistema en mantenimiento, intente más tarde.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(apiKeyLicence.Equals(""))
            {
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
                btnAceptar.Enabled = false;
                btnSalir.Enabled = false;
                //picbLogo.Enabled = false;
                lblCopyright.Enabled = false;
                lblTitle.Enabled = false;
                MessageBox.Show("Por favor comuniquese con el encargado del Sistema, debido a qué su sistema le falta el código de licencia.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FormLogin()
        {
            InitializeComponent();
        }
        private void MessageError(string message)
        {
            MessageBox.Show(message, funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void EnableControlErrorLogin()
        {
            //lblEstadoAcceso.Visible = true;
        }
        public string GetStateApp()
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            string respuesta;
            if (!state)
            {
                respuesta =  "SISTEMA FALLIDO - ";
            }
            else
            {
                respuesta = "SISTEMA OK - ";
            }
            return respuesta;
        }
        public string GetStateMessage()
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            return !state ? ">>> DEBE DE HABILITAR " + GVarPublicas.GsCaja + " <<<" : ">>> " + GVarPublicas.GsCaja + " APERTURADA <<<               -               " + "***SERVIDOR PRODUCCIÓN***";
        }
        public string ShowInfoUserLogin(User user)
        {
            GVarPublicas.GsUserId = user.UserId;
            GVarPublicas.GsUserName = user.UserName;
            GVarPublicas.GsCaja = user.Caja.Name;
            GVarPublicas.GsSede = user.Sede.Name;
            GVarPublicas.GsCajaId = user.Caja.CajaId;
            GVarPublicas.GsSedeId = user.Sede.SedeId;
            GVarPublicas.GsCargo = user.Rol.Name;
            GVarPublicas.GsMonedaDefault = funcionesGenerales.GetValueConfig("moneda_default");
            return GVarPublicas.GsCargo.ToUpper() + " - " + " [" + (GVarPublicas.GsUserName).ToUpper() + "]" + " - " + user.Sede.Name + " - " + (user.Caja.Name).PadRight(45) + " " + funcionesGenerales.GetValueConfig("title").ToUpper() + " - Versión: " + funcionesGenerales.GetValueConfig("version");
        }
        public void AccessToSystem()
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string message = "";
                User user = managmentLogin.AccessVerify(userName, password, out message);
                if (txtUserName.Text == string.Empty && txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("¡Complete los campos vacios!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    if (message.Equals(""))
                    {
                        FormMainMenu formMainMenu = new FormMainMenu();
                        formMainMenu.Text = string.Concat(ShowInfoUserLogin(user));
                        formMainMenu.toolDetailUser.Text = GetStateApp() + " | " + GetStateMessage();
                        formMainMenu.toolDetailUser.ForeColor = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName) ? Color.Green: Color.DarkRed;
                        formMainMenu.Show();
                        Hide();
                    }
                    else
                    {
                        MessageError(message);
                        EnableControlErrorLogin();
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            GetAllConfig();
            DisabledApp();
            this.ActiveControl = txtUserName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccessToSystem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AccessToSystem();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbImagen_DoubleClick(object sender, EventArgs e)
        {
            //bool validaAdministrador = false;
            //string claveAdministrador = "";
            //DataTable dataTable = new ManagmentUser().ServiceValidarSiEsAdmiYRecuperaClave(txtUserName.Text.Trim());
            //if(dataTable.Rows.Count > 0)
            //{
            //    if(Convert.ToInt32(dataTable.Rows[0]["is_admi"]) == 1)
            //    {
            //        validaAdministrador = true;
            //        claveAdministrador = dataTable.Rows[0]["password"].ToString();
            //    }
            //}
            //if (validaAdministrador)
            //{
            //    string motivo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese motivo", funcionesGenerales.GetValueConfig("title"));
            //    txtPassword.Enabled = false;
            //    txtPassword.Text = claveAdministrador;
            //    btnAceptar.Focus();
            //}
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
