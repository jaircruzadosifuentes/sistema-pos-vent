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

namespace CapaPresentacion.Configuración
{
    public partial class FormQuitarPermisos : MaterialSkin.Controls.MaterialForm
    {
        public string _codigoUsuario { get; set; }
        public FormQuitarPermisos()
        {
            InitializeComponent();
        }
        public void LoadOperations()
        {
            dgPermisos.DataSource = new ManagmentOperations().ServiceGetOperationForCodUser(_codigoUsuario);
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void RedimensionarColumnas()
        {
            this.dgPermisos.Columns["Codigo_operacion"].Width = 110;
            this.dgPermisos.Columns["Descripcion"].Width = 320;
        }
        private void FormQuitarPermisos_Load(object sender, EventArgs e)
        {
            LoadOperations();
            AlternarColores(dgPermisos);
            RedimensionarColumnas();
        }
        public void Inicio(string codigoUsuario)
        {
            _codigoUsuario = codigoUsuario;
        }
        private void btnSalirPermiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                foreach (DataGridViewRow row in dgPermisos.Rows)
                {
                    row.Cells["item"].Value = 1;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgPermisos.Rows)
                {
                    row.Cells["item"].Value = 0;
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            bool inserto = false;
            DialogResult Opcion;
            Opcion = MessageBox.Show(string.Concat("¿Desea quitar los permisos seleccionados al usuario ", _codigoUsuario.ToUpper(), " ?"), new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgPermisos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        string codeOperation = Convert.ToString(row.Cells[1].Value);
                        string userName = _codigoUsuario;

                        bool anular = new ManagmentAuth().ServiceQuitarPermisos(codeOperation, userName);
                        if (anular)
                        {
                            inserto = true;
                            continue;
                        }
                        else
                        {
                            inserto = false;
                        }
                    }
                }
                if (inserto)
                {
                    LoadOperations();
                    MessageBox.Show("Se ha quitado los permisos correctamente.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna operación.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgPermisos.Columns["Item"].Index)
            {
                DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgPermisos.Rows[e.RowIndex].Cells["Item"];
                CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
            }
        }
    }
}
