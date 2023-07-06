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
    public partial class FormMntSede : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentSedes managmentSedes = new ManagmentSedes();
        private bool IS_MODIFICATION = false;
        private bool IS_NEW = false;
        public FormMntSede()
        {
            InitializeComponent();
        }
        public void LoadSedes()
        {
            dgSedes.DataSource = managmentSedes.ServiceGetAllSedes();
        }
        public void RedimensionarColumnas()
        {
            this.dgSedes.Columns["ID"].Width = 60;
            this.dgSedes.Columns["Nombre"].Width = 130;
            this.dgSedes.Columns["Direccion"].Width = 250;
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
            txtDireccion.Enabled = false;
            txtNombreSede.Enabled = false;
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
        }
        public void DesactivarColumnas()
        {
            this.dgSedes.Columns[0].Visible = false;
        }
        private void FormMntSede_Load(object sender, EventArgs e)
        {
            LoadSedes();
            RedimensionarColumnas();
            AlternarColores(dgSedes);
            ControlForDefault();
            DesactivarColumnas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            txtNombreSede.Enabled = estado;
            txtDireccion.Enabled = estado;
            rbActivo.Enabled = estado;
            rbInactivo.Enabled = estado;
            tvSede.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnCancelar.Visible = estado;
            this.btnEliminar.Visible = !estado;
            this.btnGuardar.Enabled = IS_NEW ? estado : IS_MODIFICATION ? false : estado;
            this.btnModificar.Enabled = IS_NEW ? false : IS_MODIFICATION ? estado : false;
            this.txtNombreSede.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IS_NEW = true;
            HabilitarControlesNuevo(true);
        }
        public void ClearControllers()
        {
            txtNombreSede.Text = "";
            txtDireccion.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
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

        private void dgSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgSedes.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgSedes.Rows[e.RowIndex].Cells["Anular"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }

        private void dgSedes_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombreSede.Text = Convert.ToString(this.dgSedes.CurrentRow.Cells["Nombre"].Value);
            this.txtSedeId.Text = Convert.ToString(this.dgSedes.CurrentRow.Cells["ID"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dgSedes.CurrentRow.Cells["Direccion"].Value);
            string estado = Convert.ToString(this.dgSedes.CurrentRow.Cells["Estado"].Value);
            if (estado.Equals("ACTIVO"))
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

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgSedes.Columns[0].Visible = true;
                this.dgSedes.Columns[0].Width = 40;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgSedes.Columns[0].Visible = false;
                this.dgSedes.Columns[0].Width = 40;
                this.btnEliminar.Enabled = false;
            }
        }
        public bool fbValidate()
        {
            bool validate = true;
            if(string.IsNullOrEmpty(txtNombreSede.Text))
            {

                validate = false;
            }
            return validate;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!fbValidate())
                {
                    return;
                }
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea guardar datos?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Sede sede = new Sede();
                    sede.Name = txtNombreSede.Text;
                    sede.Address = txtDireccion.Text;
                    int estado = 0;
                    if(rbActivo.Checked)
                    {
                        estado = 1;
                    }
                    else if(rbInactivo.Checked)
                    {
                        estado = 0;
                    }
                    sede.State = estado;
                    bool insert = new ManagmentSedes().ServiceInsertSede(sede, "I");
                    if (insert)
                    {
                        HabilitarControlesNuevo(false);
                        IS_NEW = false;
                        ClearControllers();
                        LoadSedes();
                        MessageBox.Show("Sede registrada con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNombreSede_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                rbActivo.Checked = true;
            }
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
                Opcion = MessageBox.Show("¿Realmente desea modificar datos?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Sede sede = new Sede();
                    sede.SedeId = Convert.ToInt32(txtSedeId.Text);
                    sede.Name = txtNombreSede.Text;
                    sede.Address = txtDireccion.Text;
                    int estado = 0;
                    if (rbActivo.Checked)
                    {
                        estado = 1;
                    }
                    else if (rbInactivo.Checked)
                    {
                        estado = 0;
                    }
                    sede.State = estado;
                    bool insert = new ManagmentSedes().ServiceInsertSede(sede, "E");
                    if (insert)
                    {
                        HabilitarControlesNuevo(false);
                        IS_NEW = false;
                        ClearControllers();
                        LoadSedes();
                        MessageBox.Show("Sede registrada con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarSede_TextChanged(object sender, EventArgs e)
        {
            dgSedes.DataSource = managmentSedes.ServiceGetSedePorNombre(txtBuscarSede.Text);
        }
    }
}
