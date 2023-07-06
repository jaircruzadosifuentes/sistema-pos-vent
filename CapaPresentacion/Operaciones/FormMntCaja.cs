using CapaAplicacion;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Operaciones
{
    public partial class FormMntCaja : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private bool IS_MODIFICATION = false;
        private bool IS_NEW = false;
        public readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public FormMntCaja()
        {
            InitializeComponent();
        }
        public void LoadCajas()
        {
            dgCajas.DataSource = managmentCaja.ServiceGetAllCajas();
        }
        public void RedimensionarColumnas()
        {
            this.dgCajas.Columns["ID"].Width = 60;
            this.dgCajas.Columns["Nombre"].Width = 280;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void ControlForDefault()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreCaja.Enabled = false;
        }
        public void DesactivarColumnas()
        {
            this.dgCajas.Columns[0].Visible = false;
        }
        private void FormMntCaja_Load(object sender, EventArgs e)
        {
            LoadCajas();
            AlternarColores(dgCajas);
            RedimensionarColumnas();
            ControlForDefault();
            DesactivarColumnas();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            txtNombreCaja.Enabled = estado;
            tvCaja.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnCancelar.Visible = estado;
            this.btnEliminar.Visible = !estado;
            this.btnGuardar.Enabled = IS_NEW ? estado : IS_MODIFICATION ? false : estado;
            this.btnModificar.Enabled = IS_NEW ? false : IS_MODIFICATION ? estado : false;
            this.txtNombreCaja.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IS_NEW = true;
            HabilitarControlesNuevo(true);
        }
        public void ClearControllers()
        {
            txtNombreCaja.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IS_MODIFICATION)
            {
                HabilitarControlesNuevo(false);
                IS_MODIFICATION = false;
                ClearControllers();
            }
            else
            {
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                ClearControllers();
            }
        }
        public bool fbValidate()
        {
            bool validate = true;
            if(string.IsNullOrEmpty(txtNombreCaja.Text))
            {
                MessageBox.Show("Debe de ingresar el nombre de la caja.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                validate = false;
            }
            return validate;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!fbValidate())
                {
                    return;
                }
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea guardar datos?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Caja caja = new Caja();
                    caja.Name = txtNombreCaja.Text;

                    bool insert = managmentCaja.ServiceInsertCaja(caja, "I");
                    if(insert)
                    {
                        HabilitarControlesNuevo(false);
                        IS_NEW = false;
                        ClearControllers();
                        LoadCajas();
                        MessageBox.Show("Caja registrada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNombreCaja_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNombreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(IS_NEW)
                {
                    btnGuardar.Focus();
                } 
                else
                {
                    btnModificar.Focus();
                }
            }
        }

        private void dgCajas_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombreCaja.Text = Convert.ToString(this.dgCajas.CurrentRow.Cells["Nombre"].Value);
            this.txtCajaId.Text = Convert.ToString(this.dgCajas.CurrentRow.Cells["ID"].Value);
            string estado = Convert.ToString(this.dgCajas.CurrentRow.Cells["Estado"].Value);
            if(estado.Equals("ACTIVO"))
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            IS_MODIFICATION = true;
            HabilitarControlesNuevo(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!fbValidate())
                {
                    return;
                }
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea modificar datos?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Caja caja = new Caja();
                    caja.CajaId = Convert.ToInt32(txtCajaId.Text);
                    caja.Name = txtNombreCaja.Text;
                    int estado = 0;
                    if(rbActivo.Checked)
                    {
                        estado = 1;
                    }
                    else if(rbInactivo.Checked)
                    {
                        estado = 0;
                    }
                    caja.State = estado;
                    bool insert = managmentCaja.ServiceInsertCaja(caja, "E");
                    if (insert)
                    {
                        HabilitarControlesNuevo(false);
                        IS_NEW = false;
                        ClearControllers();
                        LoadCajas();
                        MessageBox.Show("Caja modificada con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNombreCaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCaja_TextChanged(object sender, EventArgs e)
        {
            dgCajas.DataSource = managmentCaja.ServiceGetCajaPorNombre(txtBuscarCaja.Text);
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgCajas.Columns[0].Visible = true;
                this.dgCajas.Columns[0].Width = 40;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgCajas.Columns[0].Visible = false;
                this.dgCajas.Columns[0].Width = 40;
                this.btnEliminar.Enabled = false;
            }
        }

        private void dgCajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCajas.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgCajas.Rows[e.RowIndex].Cells["Anular"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                int contador = 0;
                bool estadoAnulado = false;
                Opcion = MessageBox.Show("¿Realmente desea anular las cajas seleccionados?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int cajaId;
                    foreach (DataGridViewRow row in dgCajas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            cajaId = Convert.ToInt32(row.Cells[1].Value);
                            bool anular = managmentCaja.ServiceDarDeBajaCaja(Convert.ToInt32(cajaId));
                            if (anular)
                            {
                                contador = contador + 1;
                                estadoAnulado = true;
                                continue;
                            }
                            else
                            {
                                contador = 0;
                                estadoAnulado = false;
                                MessageBox.Show("¡Error al anular Caja!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    if (estadoAnulado)
                    {
                        MessageBox.Show($"{(contador > 1 ? "Cajas anuladas" : "Caja anulada")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCajas();
                        chkAnular.Checked = false;
                        contador = 0;
                        estadoAnulado = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
