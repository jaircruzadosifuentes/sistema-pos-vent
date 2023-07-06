using CapaAplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormConsultar : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentProducts managmentProducts = new ManagmentProducts();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();

        public FormConsultar()
        {
            InitializeComponent();
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCodigoBarras;
        }
        public void activarControles(bool estado)
        {
            lblNombre.Visible = estado;
            lblPrecioVenta.Visible = estado;
            lblCategoria.Visible = estado;
            lblStock.Visible = estado;
            lblFechaVenc.Visible = estado;
            lblEstado.Visible = estado;
            lblPresentacion.Visible = estado;
        }
        public void ConsultarProducto()
        {
            DataTable dt = managmentProducts.ServiceGetProductoPorCodigoBarrasConsulta(txtCodigoBarras.Text);
            if (dt.Rows.Count > 0)
            {
                activarControles(true);
                lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
                lblPrecioVenta.Text = dt.Rows[0]["Precio_venta"].ToString();
                lblPresentacion.Text = dt.Rows[0]["UMedida"].ToString();
                lblCategoria.Text = dt.Rows[0]["Categoria"].ToString();
                lblStock.Text = dt.Rows[0]["Stock"].ToString();
                lblStock.ForeColor = dt.Rows[0]["Estado"].ToString().Equals("PRECAUCIÓN") ? Color.DarkRed : Color.Green;
                lblEstado.Text = dt.Rows[0]["Estado"].ToString();
                lblEstado.ForeColor = dt.Rows[0]["Estado"].ToString().Equals("PRECAUCIÓN") ? Color.DarkRed : Color.Green;
                lblFechaVenc.Text = dt.Rows[0]["Fecha_vencimiento"].ToString();
                //Validamos si está activado el bit de notificaciones
                if (funcionesGenerales.GetValueConfig("sonido_notificaciones").Equals("1"))
                {
                    funcionesGenerales.fvSonarNotificacion(1);
                    txtCodigoBarras.Text = "";
                }
            } 
            else
            {
                txtCodigoBarras.Text = "";
                activarControles(false);
                MessageBox.Show("El producto consultado no existe en la base de datos.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                ConsultarProducto();
            }
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarProducto();
        }
    }
}
