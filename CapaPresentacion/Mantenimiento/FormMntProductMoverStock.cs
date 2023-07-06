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

namespace CapaPresentacion.Mantenimiento
{
    public partial class FormMntProductMoverStock : MaterialSkin.Controls.MaterialForm
    {
        public string Producto { get; set; }
        public int ProductoId { get; set; }
        public decimal CantidadAlmacen { get; set; }
        public decimal CantidadVenta { get; set; }

        public FormMntProductMoverStock()
        {
            InitializeComponent();
        }
        public void Inicio(int pProductoId, string pProducto, decimal pCantidadAlm, decimal pCantidadVenta)
        {
            Producto = pProducto;
            ProductoId = pProductoId;
            CantidadAlmacen = pCantidadAlm;
            CantidadVenta = pCantidadVenta;
        }
        public void CargarDatos()
        {
            txtStockAlmacen.Text = CantidadAlmacen.ToString();
            txtStockAMover.Text = CantidadVenta.ToString();
            lblProducto.Text = Producto.ToString();
        }
        private void FormMntProductMoverStock_Load(object sender, EventArgs e)
        {
            CargarDatos();
            this.ActiveControl = txtCantidadMover;
        }

        private void txtCantidadMover_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCantidadMover.Text))
            {
                txtStockAlmacen.Text = Convert.ToString(Convert.ToDecimal(CantidadAlmacen) - (0));
                txtStockAMover.Text = Convert.ToString(Convert.ToDecimal(CantidadVenta) + (0));
            }
            else
            {
                decimal cantidadMover = Convert.ToDecimal(txtCantidadMover.Text);
                if(cantidadMover > CantidadAlmacen)
                {
                    MessageBox.Show("No puede mover un monto mayor a lo almacenado en almacen.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStockAlmacen.Text = Convert.ToString(Convert.ToDecimal(CantidadAlmacen) - (0));
                    txtStockAMover.Text = Convert.ToString(Convert.ToDecimal(CantidadVenta) + (0));
                    txtCantidadMover.Text = "";
                    return;
                }
                txtStockAlmacen.Text = Convert.ToString(Convert.ToDecimal(CantidadAlmacen) - (cantidadMover));
                txtStockAMover.Text = Convert.ToString(Convert.ToDecimal(CantidadVenta) + (cantidadMover));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoverStock_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea mover el stock de almacen a venta?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                decimal cantidadAlmacen = Convert.ToDecimal(txtStockAlmacen.Text);
                decimal cantidadVenta = Convert.ToDecimal(txtStockAMover.Text);
                int productoId = ProductoId;
                if(Convert.ToDecimal(txtCantidadMover.Text) > 0)
                {
                    bool mover = new ManagmentProducts().ServiceMoverStockAlmacenAVenta(productoId, cantidadAlmacen, cantidadVenta);
                    if(mover)
                    {
                        MessageBox.Show("Se ha movido correctamente el stock.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No puede mover un monto con valor cero.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCantidadMover_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnMoverStock.Focus();
            }
        }
    }
}
