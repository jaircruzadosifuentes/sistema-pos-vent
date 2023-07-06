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
    public partial class FormExtornoVenta : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentVenta managmentVenta = new ManagmentVenta();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        public FormExtornoVenta()
        {
            InitializeComponent();
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void CargarVentas()
        {
            dgViewComprobantes.DataSource = managmentVenta.ServiceGetAllVentas();
            //lblCantidad.Text = string.Concat("Se han cargado ", dgViewComprobantes.Rows.Count, " registros.");
        }
        private void FormExtornoVenta_Load(object sender, EventArgs e)
        {
            this.Height = 470;
            AlternarColores(dgViewComprobantes);
            CargarVentas();
            RedimensionarFilas();
        }
        public void RedimensionarFilas()
        {
            //this.dgViewComprobantes.Cel
            this.dgViewComprobantes.Columns["ID"].Width = 30;
            this.dgViewComprobantes.Columns["Cliente"].Width = 250;
            this.dgViewComprobantes.Columns["Fecha"].Width = 150;
            this.dgViewComprobantes.Columns["Documento"].Width = 70;
            this.dgViewComprobantes.Columns["Correlativo"].Width = 140;
            this.dgViewComprobantes.Columns["Estado"].Width = 90;
            this.dgViewComprobantes.Columns["Total"].Width = 60;
            this.dgViewComprobantes.Columns["Vuelto"].Visible = false;
            this.dgViewComprobantes.Columns["TipoPago"].Visible = false;
            this.dgViewComprobantes.Columns["Concepto"].Visible = false;
        }

        private void dgViewComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgViewComprobantes.Columns["selecciona"].Index)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgViewComprobantes.Rows[e.RowIndex].Cells["selecciona"];
                    CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
                }
            }
        }

        private void btnExtornar_Click(object sender, EventArgs e)
        {
            string correlativo = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["Correlativo"].Value);
            string cliente = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["Cliente"].Value);
            string tipoPago = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["TipoTransaccion"].Value);
            int ventaId = Convert.ToInt32(dgViewComprobantes.CurrentRow.Cells["ID"].Value);
            string estado = Convert.ToString(dgViewComprobantes.CurrentRow.Cells["Estado"].Value);

            if(estado.Equals("EXTORNADO"))
            {
                MessageBox.Show(string.Concat("El comprobante - ", correlativo, " ya ha sido extornado."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool estadoCaja = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            if(!estadoCaja)
            {
                MessageBox.Show(string.Concat("El comprobante - ", correlativo, " no puede ser extornado. Primero debe de aperturarse caja chica."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            if(txtGlosa.Text.ToString().Length == 0)
            {
                MessageBox.Show(string.Concat("Debe de ingresar una justificación de extorno."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGlosa.Focus();
                return;
            }

            if (tipoPago.Substring(0, 1).Equals("V"))
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show(string.Concat("¿Desea extornar el comprobante - ", correlativo, " del cliente ", cliente), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string motivo = txtGlosa.Text.Trim();
                    bool extorna = managmentVenta.ServiceExtornaVenta(ventaId, funcionesGenerales.GetDateWithUser(), GVarPublicas.GsCajaId, GVarPublicas.GsSedeId, GVarPublicas.GsUserId, motivo);
                    if (extorna)
                    {
                        MessageBox.Show(string.Concat("El comprobante - ", correlativo, " ha sido extornado exitosamente."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGlosa.Text = "";
                        CargarVentas();
                    }
                }
            }
            else
            {
                MessageBox.Show(string.Concat("El tipo de comprobante es ", tipoPago, ", sólo puedes extornar ventas realizadas."), funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbSerieNumero.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(1, txtBuscar.Text);
            }
            else if (rbCliente.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(2, txtBuscar.Text);
            }
            else if (rbCodUser.Checked)
            {
                dgViewComprobantes.DataSource = managmentVenta.ServiceGetVentaPorFiltro(3, txtBuscar.Text);
            }
        }

        private void dgViewComprobantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgViewComprobantes.Rows)
            { 
                if (Convert.ToString(Myrow.Cells[5].Value).Substring(0, 2).Equals("EX"))
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void txtGlosa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnExtornar.Focus();
            }
        }
    }
}
