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

namespace CapaPresentacion.Sales
{
    public partial class FormOpenCaja : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private readonly ManagmentAuth managmentAuth = new ManagmentAuth();
        public FormOpenCaja()
        {
            InitializeComponent();
        }
        public string GetStateCaja()
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            string respuesta = "";
            if(!state)
            {
                respuesta = ">>> Debe de habilitar caja <<<";
            }
            return respuesta;
        }
        public void PermisoEspecial()
        {
            //Código 2 es para activar el permiso de habilitar caja
            bool auth = managmentAuth.PermisoEspecial(GVarPublicas.GsUserName, "2");
            if(!auth)
            {
                lblPermisoEspecial.Visible = true;
                this.Enabled = false;
            }
            else
            {
                lblPermisoEspecial.Visible = false;
                this.Enabled = true;
            }
        }
        private void FormOpenCaja_Load(object sender, EventArgs e)
        {
            lblEstado.Text = GetStateCaja();
            PermisoEspecial();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtValorCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAceptar.Focus();
            }
        }

        private void txtValorCaja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
