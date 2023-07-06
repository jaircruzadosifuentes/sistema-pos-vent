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
using CapaPresentacion.gVarPublicas;
using CapaAplicacion;
using CapaPresentacion.Operaciones;
using CapaPresentacion.Sales;

namespace CapaPresentacion.Contabilidad
{
    public partial class FormOperations : MaterialSkin.Controls.MaterialForm
    {
        private readonly ManagmentOperations _managmentOperations = new ManagmentOperations();
        private readonly ManagmentProducts _managmetProducts = new ManagmentProducts();
        private readonly ManagmentCategoria managmentCategoria = new ManagmentCategoria();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentPresentacion managmentPresentacion = new ManagmentPresentacion();
        private readonly ManagmentUser _managmentUser = new ManagmentUser();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        bool validateData = false;

        DataTable dataTableProducts = new DataTable();
        DataTable dataTableCategorias = new DataTable();
        DataTable dataTablePresentaciones = new DataTable();
        DataTable dataTrabajadorDespedidos = new DataTable();
        public FormOperations()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dataTableProducts = _managmetProducts.GetAllProductsBanned();
            dataTrabajadorDespedidos = _managmentUser.GetAllUsersBanned();
            dataTableCategorias = managmentCategoria.ServiceCategoriasInactivos();
            dataTablePresentaciones = managmentPresentacion.ServicePresentacionesAnuladas();
        }

        private void FormOperations_Load(object sender, EventArgs e)
        {
            GenerateListTree();
            if(validateData)
            {
                LoadData();
            }
        }
        
        public void GenerateListTree()
        {
            {
                TreeNode nodeFather = new TreeNode();
                TreeNode nodeSoon = new TreeNode();
                TreeNode nodeX;
                try
                {
                    tvOperations.Nodes.Clear();
                    List<Operation> listOperations = _managmentOperations.ListOperations(GVarPublicas.GsUserName, 2);
                    if (listOperations.Count > 0)
                    {
                        validateData = true;
                        foreach (Operation list in listOperations)
                        {

                            switch (list.Level)
                            {
                                case 1:
                                    tvOperations.Nodes.Add(list.IdentificationCode + " - " + list.Description);
                                    nodeFather = tvOperations.Nodes[tvOperations.Nodes.Count - 1];
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
                        tvOperations.Nodes[0].Expand();
                    }
                    else
                    {
                        validateData = false;
                        MessageBox.Show("¡No tiene operaciones asignadas, comuniquese con su administrador!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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
            this.Dispose();
        }

        private void tvOperations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        public void SeleccionaNodo()
        {
            string gsOpeCod = tvOperations.SelectedNode.Text;
            string gsCodeOperations = gsOpeCod.Substring(0, 6);
            switch (gsCodeOperations)
            {
                case GVarPublicas.gProductosAnulados:
                    FormBanned formBanned = new FormBanned();
                    formBanned.Inicio("PRODUCTOS ANULADOS", gsCodeOperations, dataTableProducts);
                    formBanned.ShowDialog();
                    break;
                case GVarPublicas.gTrabajadoresAnulados:
                    FormBanned formBannedTraDespedidos = new FormBanned();
                    formBannedTraDespedidos.Inicio("TRABAJADORES ANULADOS", gsCodeOperations, dataTrabajadorDespedidos);
                    formBannedTraDespedidos.ShowDialog();
                    break;
                case GVarPublicas.gCategoriasAnulados:
                    FormBanned formCategoriasAnuladas = new FormBanned();
                    formCategoriasAnuladas.Inicio("CATEGORÍAS ANULADAS", gsCodeOperations, dataTableCategorias);
                    formCategoriasAnuladas.ShowDialog();
                    break;
                case GVarPublicas.gPresentacionesAnuladas:
                    FormBanned formPresentacionesAnuladas = new FormBanned();
                    formPresentacionesAnuladas.Inicio("PRESENTACIONES ANULADAS", gsCodeOperations, dataTablePresentaciones);
                    formPresentacionesAnuladas.ShowDialog();
                    break;
                case GVarPublicas.gRegistroCajas:
                    FormMntCaja formMntCaja = new FormMntCaja();
                    formMntCaja.ShowDialog();
                    break;
                case GVarPublicas.gRegistroSedes:
                    FormMntSede formMntSede = new FormMntSede();
                    formMntSede.ShowDialog();
                    break;
                case GVarPublicas.gAsignacionCajaSede:
                    FormAsigCajaASede formAsigCajaASede = new FormAsigCajaASede();
                    formAsigCajaASede.ShowDialog();
                    break;
                case GVarPublicas.gAperturaCajaChica:
                    FormAperturaCajaChica formAperturaCajaChica = new FormAperturaCajaChica();
                    formAperturaCajaChica.ShowDialog();
                    break;
                case GVarPublicas.gRegistroIngreso:
                    bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
                    if (!state)
                    {
                        FormAperturaCajaChica formOpenCaja = new FormAperturaCajaChica();
                        formOpenCaja.ShowDialog();
                    }
                    else
                    {
                        FormPOS frmSales = FormPOS.GetInstancia();
                        frmSales.ShowDialog();
                    }
                    break;
                case GVarPublicas.gListadoDeIngresosEnCajaChica:
                    FormListadoDeVentas formListadoDeVentasGenerales = new FormListadoDeVentas();
                    formListadoDeVentasGenerales.ShowDialog();
                    break;
                case GVarPublicas.gCierreDeCajaChica:
                    FormCierreCajaChica formCierreCajaChica = new FormCierreCajaChica();
                    formCierreCajaChica.ShowDialog();
                    break;
                case GVarPublicas.gListaoDeCajasAperturadas:
                    FormListadoCajasAperturadas formListadoCajasAperturadas = new FormListadoCajasAperturadas();
                    formListadoCajasAperturadas.ShowDialog();
                    break;
                case GVarPublicas.gRegistroEgresos:
                    FormRegistrarEgresos formRegistroEgresos = new FormRegistrarEgresos();
                    formRegistroEgresos.ShowDialog();
                    break;
                case GVarPublicas.gListadoDeEgresos:
                    FormListadoEgresos formListadoEgresos = new FormListadoEgresos();
                    formListadoEgresos.ShowDialog();
                    break;
                case GVarPublicas.gPagosPendientesPorCobrar:
                    FormVerPagosPendientesXCobrar formVerPagosPendientesXCobrar = new FormVerPagosPendientesXCobrar();
                    formVerPagosPendientesXCobrar.ShowDialog();
                    break;
                case GVarPublicas.gExtornarVenta:
                    FormExtornoVenta formExtornoVenta = new FormExtornoVenta();
                    formExtornoVenta.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void tvOperations_DpiChangedAfterParent(object sender, EventArgs e)
        {

        }

        private void tvOperations_DoubleClick(object sender, EventArgs e)
        {
            SeleccionaNodo();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SeleccionaNodo();
        }
    }
}
