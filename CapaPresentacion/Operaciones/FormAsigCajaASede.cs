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
    public partial class FormAsigCajaASede : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentSedes managmentSedes = new ManagmentSedes();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        public FormAsigCajaASede()
        {
            InitializeComponent();
        }
        public void LoadSedes()
        {
            cboSedes.DataSource = managmentSedes.ServiceGetSedesEnCombo();
            cboSedes.ValueMember = "sedeId";
            cboSedes.DisplayMember = "name";
        } 
        public void LoadCajas()
        {
            cboCaja.DataSource = managmentCaja.ServiceGetCajaEnCombo();
            cboCaja.ValueMember = "cajaId";
            cboCaja.DisplayMember = "name";
        }
        private void FormAsigCajaASede_Load(object sender, EventArgs e)
        {
            LoadSedes();
            LoadCajas();
            GenerateListTree();
        }
        public void GenerateListTree()
        {
            {
                TreeNode nodeFather = new TreeNode();
                TreeNode nodeSoon = new TreeNode();
                TreeNode nodeX;
                try
                {
                    tvLista.Nodes.Clear();
                    List<Operation> listOperations = managmentSedes.ServiceListCajasAsignadasASede();
                    if (listOperations.Count > 0)
                    {
                        foreach (Operation list in listOperations)
                        {

                            switch (list.Level)
                            {
                                case 1:
                                    tvLista.Nodes.Add(list.IdentificationCode + " - " + list.Description);
                                    nodeFather = tvLista.Nodes[tvLista.Nodes.Count - 1];
                                    break;
                                case 2:
                                    nodeX = new TreeNode
                                    {
                                        Text = list.IdentificationCode + " - " + list.Description
                                    };
                                    nodeFather.Nodes.Add(nodeX);
                                    nodeSoon = nodeFather.Nodes[nodeFather.Nodes.Count - 1];
                                    break;
                                case 3:
                                    nodeX = new TreeNode
                                    {
                                        Text = list.IdentificationCode + " - " + list.Description
                                    };
                                    nodeSoon.Nodes.Add(nodeX);
                                    break;
                                default:
                                    break;
                            }
                        }
                        tvLista.Nodes[0].Expand();
                    }
                    else
                    {
                        MessageBox.Show("¡No tiene operaciones asignadas, comuniquese con su administrador!", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
