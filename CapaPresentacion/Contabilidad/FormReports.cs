using System;
using CapaEntidades;
using CapaAplicacion;
using System.Windows.Forms;
using System.Collections.Generic;
using CapaPresentacion.gVarPublicas;

namespace CapaPresentacion
{
    public partial class FormReports : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentOperations _managmentOperations = new ManagmentOperations();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
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
                    tvReports.Nodes.Clear();
                    List<Operation> listOperations = _managmentOperations.ListOperations(GVarPublicas.GsUserName, 1);
                    if(listOperations.Count > 0)
                    {
                        foreach (Operation list in listOperations)
                        {
                        
                            switch (list.Level)
                            {
                                case 1:
                                    tvReports.Nodes.Add(list.IdentificationCode + " - " + list.Description);
                                    nodeFather = tvReports.Nodes[tvReports.Nodes.Count - 1];
                                    break;
                                case 2:
                                    nodeX = new TreeNode
                                    {
                                        Text = list.IdentificationCode + " - " + list.Description
                                    };
                                    nodeFather.Nodes.Add(nodeX);
                                    nodeSoon = tvReports.Nodes[tvReports.Nodes.Count - 1];
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
                        tvReports.Nodes[0].Expand();
                    }
                    else
                    {
                        MessageBox.Show("¡No tiene operaciones asignadas, comuniquese con su administrador!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
