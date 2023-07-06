using CapaAplicacion;
using CapaEntidades;
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

namespace CapaPresentacion.Configuración
{
    public partial class FormConfigurarValoresSistema : MaterialSkin.Controls.MaterialForm
    {
        public ManagmentSystemConfig managmentSystemConfig = new ManagmentSystemConfig();
        string tituloSistema, ruc, razonSocial, stockAlert, show_ruc, email, codigoGabeta, sonidoNotificacion, horaCierreCaja, imprimiTicketFac;
        private readonly ManagmentOperations _managmentOperations = new ManagmentOperations();
        private void btnSalirPermiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormConfigurarValoresSistema()
        {
            InitializeComponent();
        }

        private void txtCodUsuario_TextChanged(object sender, EventArgs e)
        {
            dgViewPermisosOperaciones.DataSource = new ManagmentOperations().ServiceGetAllOperationsForPermiss(txtCodUsuario.Text);
            LoadOperationsOfPermiss(txtCodUsuario.Text);
            int sizeOperations = SizeOperationsOfUsers(txtCodUsuario.Text);
            lblOperaciones.Text = string.Concat("Se han cargado ", sizeOperations, " operaciones ", "para el usuario con código: ", string.IsNullOrEmpty(txtCodUsuario.Text) ? GVarPublicas.GsUserName.ToUpper() : txtCodUsuario.Text.ToUpper());
        }

        public void LoadSetting()
        {
            List<SystemConfig> systemConfigs = managmentSystemConfig.GetAllSystemConfig();
            foreach (SystemConfig systemConfig in systemConfigs)
            {
                switch (systemConfig.Name)
                {
                    case "title":
                        txtTituloSistema.Text = systemConfig.Value;
                        tituloSistema = systemConfig.Value;
                        break;
                    case "ruc":
                        txtRuc.Text = systemConfig.Value;
                        ruc = systemConfig.Value;
                        break;
                    case "razon_social":
                        txtRazonSocial.Text = systemConfig.Value;
                        razonSocial = systemConfig.Value;
                        break;
                    case "stock_alert_product":
                        txtAlertaStock.Text = systemConfig.Value;
                        stockAlert = systemConfig.Value;
                        break;
                    case "show_ruc":
                        if ((systemConfig.Value).Equals("1"))
                        {
                            rbSiRuc.Checked = true;
                        }
                        else if (systemConfig.Value.Equals("0"))
                        {
                            rbNoRuc.Checked = true;
                        }
                        show_ruc = systemConfig.Value;
                        break;
                    case "email":
                        txtEmail.Text = systemConfig.Value;
                        email = systemConfig.Value;
                        break;
                    case "impresora":
                        txtCodGabeta.Text = systemConfig.Value;
                        codigoGabeta = systemConfig.Value;
                        break;
                    case "sonido_notificaciones":
                        if ((systemConfig.Value).Equals("1"))
                        {
                            rbSiSonido.Checked = true;
                        }
                        else if (systemConfig.Value.Equals("0"))
                        {
                            rbNoSonido.Checked = true;
                        }
                        sonidoNotificacion = systemConfig.Value;
                        break;
                    case "hora_cierre_caja":
                        txtHoraCierre.Text = systemConfig.Value;
                        horaCierreCaja = systemConfig.Value;
                        break;
                    case "imprimir_ticket_factura":
                        if ((systemConfig.Value).Equals("1"))
                        {
                            rbImpTickSi.Checked = true;
                        }
                        else if (systemConfig.Value.Equals("0"))
                        {
                            rbImpTickNo.Checked = true;
                        }
                        imprimiTicketFac = systemConfig.Value;
                        break;
                    default:
                        break;
                }
            }
        }
        public void LoadOperations()
        {
            dgViewPermisosOperaciones.DataSource = new ManagmentOperations().ServiceGetAllOperationsForPermiss(GVarPublicas.GsUserName);
        }

        private void txtCodOperacion_TextChanged(object sender, EventArgs e)
        {
            dgViewPermisosOperaciones.DataSource = new ManagmentCaja().ServiceGetOperationForCode(txtCodOperacion.Text);
        }

        private void txtCodUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtCodOperacion.Focus();
            }
        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarcarTodos.Checked)
            {
                int cantidadOperaciones = 0;
                foreach (DataGridViewRow row in dgViewPermisosOperaciones.Rows)
                {
                    DataTable dataTable = new ManagmentAuth().DALVerificaOperacionesExistentes(row.Cells["Codigo_operacion"].Value.ToString(), txtCodUsuario.Text);
                    if(Convert.ToInt32(dataTable.Rows[0]["hayDatos"]) == 0)
                    {
                        row.Cells["item"].Value = 1;
                    }
                    else
                    {
                        cantidadOperaciones = cantidadOperaciones + 1;
                    }
                }
                if(cantidadOperaciones > 0)
                {
                    MessageBox.Show(string.Concat("Se detectaron ", cantidadOperaciones, " operaciones ya asignadas, sólo se registrarán las marcadas."), new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgViewPermisosOperaciones.Rows)
                {
                    row.Cells["item"].Value = 0;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgViewPermisosOperaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgViewPermisosOperaciones.Columns["Item"].Index)
            {
                string codigoOperacion = dgViewPermisosOperaciones.Rows[e.RowIndex].Cells["Codigo_operacion"].Value.ToString();
                DataTable dataTable = new ManagmentAuth().DALVerificaOperacionesExistentes(codigoOperacion, txtCodUsuario.Text);
                if (Convert.ToInt32(dataTable.Rows[0]["hayDatos"]) == 0)
                {
                    DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgViewPermisosOperaciones.Rows[e.RowIndex].Cells["Item"];
                    CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
                }
                else
                {
                    MessageBox.Show("El permiso de la operación seleccionada, ya ha sido asignada al usuario.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool validateData()
        {
            bool valida = true;
            if(string.IsNullOrEmpty(txtCodUsuario.Text))
            {
                MessageBox.Show("Debe de ingresar el código del usuario para darle permisos.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }
            return valida;
        }
        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if(!validateData())
            {
                return;
            }
            bool inserto = false;
            DialogResult Opcion;
            Opcion = MessageBox.Show(string.Concat("¿Desea agregar los permisos seleccionados al usuario ", txtCodUsuario.Text.ToUpper(), " ?"), new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgViewPermisosOperaciones.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        string codeOperation = Convert.ToString(row.Cells[1].Value);
                        string userName = txtCodUsuario.Text;

                        bool anular = new ManagmentAuth().ServiceInsertPermisoOperacion(codeOperation, userName);
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
                    else
                    {
                        inserto = false;
                    }
                }
                if(inserto)
                {
                    LoadOperationsOfPermiss(GVarPublicas.GsUserName);
                    int sizeOperations = SizeOperationsOfUsers(GVarPublicas.GsUserName);
                    txtCodUsuario.Text = GVarPublicas.GsUserName;
                    lblOperaciones.Text = string.Concat("Se han cargado ", sizeOperations, " operaciones ", "para el usuario con código: ", string.IsNullOrEmpty(txtCodUsuario.Text) ? GVarPublicas.GsUserName.ToUpper() : txtCodUsuario.Text.ToUpper());
                    MessageBox.Show("Asignación de permisos realizado correctamente", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario ya tiene todos los permisos asignados, por favor sólo se registrarán los marcados. El sistema lo detecta automáticamente.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            FormQuitarPermisos formQuitarPermisos = new FormQuitarPermisos();
            formQuitarPermisos.Inicio(txtCodUsuario.Text);
            formQuitarPermisos.ShowDialog();
            formQuitarPermisos.Text = string.Concat(".:: QUITAR PERMISOS ::. ", " Usuario: ", txtCodUsuario.Text.ToUpper());
            LoadOperationsOfPermiss(GVarPublicas.GsUserName);
            int sizeOperations = SizeOperationsOfUsers(GVarPublicas.GsUserName);
            txtCodUsuario.Text = GVarPublicas.GsUserName;
            lblOperaciones.Text = string.Concat("Se han cargado ", sizeOperations, " operaciones ", "para el usuario con código: ", string.IsNullOrEmpty(txtCodUsuario.Text) ? GVarPublicas.GsUserName.ToUpper() : txtCodUsuario.Text.ToUpper());
        }

        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void RedimensionarColumnas()
        {
            this.dgViewPermisosOperaciones.Columns["Codigo_operacion"].Width = 110;
            this.dgViewPermisosOperaciones.Columns["Descripcion"].Width = 320;
        }
        public int SizeOperationsOfUsers(string userCode)
        {
            return _managmentOperations.ListOperations(userCode, 3).Count;
        }
        public void LoadOperationsOfPermiss(string userCode)
        {
            TreeNode nodeFather = new TreeNode();
            TreeNode nodeSoon = new TreeNode();
            TreeNode nodeX;
            try
            {
                tvOperaciones.Nodes.Clear();
                List<Operation> listOperations = _managmentOperations.ListOperations(userCode, 3);
                if (listOperations.Count > 0)
                {
                    foreach (Operation list in listOperations)
                    {

                        switch (list.Level)
                        {
                            case 1:
                                tvOperaciones.Nodes.Add(list.IdentificationCode + " - " + list.Description);
                                nodeFather = tvOperaciones.Nodes[tvOperaciones.Nodes.Count - 1];
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
                    tvOperaciones.Nodes[0].Expand();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void FormConfigurarValoresSistema_Load(object sender, EventArgs e)
        {
            LoadSetting();
            LoadOperations();
            AlternarColores(dgViewPermisosOperaciones);
            RedimensionarColumnas();
            LoadOperationsOfPermiss(GVarPublicas.GsUserName);
            int sizeOperations = SizeOperationsOfUsers(GVarPublicas.GsUserName);
            txtCodUsuario.Text = GVarPublicas.GsUserName;
            lblOperaciones.Text = string.Concat("Se han cargado ", sizeOperations, " operaciones ", "para el usuario con código: ", string.IsNullOrEmpty(txtCodUsuario.Text) ? GVarPublicas.GsUserName.ToUpper(): txtCodUsuario.Text.ToUpper());
            this.ActiveControl = txtCodUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public List<Configuraciones> getLstConfiguraciones()
        {
            List<Configuraciones> listConfiguraciones = new List<Configuraciones>();
            List<SystemConfig> systemConfigs = managmentSystemConfig.GetAllSystemConfig();

            foreach (SystemConfig systemConfig in systemConfigs)
            {
                Configuraciones configuracion = new Configuraciones();
                switch (systemConfig.Name)
                {
                    case "title":
                        if (txtTituloSistema.Text != tituloSistema)
                        {
                            configuracion.Titulo = "title";
                            configuracion.Valor = txtTituloSistema.Text;
                        }
                        break;
                    case "ruc":
                        if (txtRuc.Text != ruc)
                        {
                            configuracion.Titulo = "ruc";
                            configuracion.Valor = txtRuc.Text;
                        }
                        break;
                    case "razon_social":
                        if (txtRazonSocial.Text != razonSocial)
                        {
                            configuracion.Titulo = "razon_social";
                            configuracion.Valor = txtRazonSocial.Text;
                        }
                        break;
                    case "stock_alert_product":
                        if (txtAlertaStock.Text != stockAlert)
                        {
                            configuracion.Titulo = "stock_alert_product";
                            configuracion.Valor = txtAlertaStock.Text;
                        }
                        break;
                    case "show_ruc":
                        if (show_ruc != (rbSiRuc.Checked ? "1" : "0"))
                        {
                            configuracion.Titulo = "show_ruc";
                            configuracion.Valor = rbSiRuc.Checked ? "1" : "0";
                        }
                        break;
                    case "email":
                        if (txtEmail.Text != email)
                        {
                            configuracion.Titulo = "email";
                            configuracion.Valor = txtEmail.Text;
                        }
                        break;
                    case "impresora":
                        if (txtCodGabeta.Text != codigoGabeta)
                        {
                            configuracion.Titulo = "impresora";
                            configuracion.Valor = txtCodGabeta.Text;
                        }
                        break;
                    case "sonido_notificaciones":
                        if (sonidoNotificacion != (rbSiSonido.Checked ? "1": "0"))
                        {
                            configuracion.Titulo = "sonido_notificaciones";
                            configuracion.Valor = rbSiSonido.Checked ? "1": "0";
                        }
                        break;
                    case "hora_cierre_caja":
                        if (txtHoraCierre.Text != horaCierreCaja)
                        {
                            configuracion.Titulo = "hora_cierre_caja";
                            configuracion.Valor = txtHoraCierre.Text;
                        }
                        break;
                    case "imprimir_ticket_factura":
                        if (imprimiTicketFac != (rbImpTickSi.Checked ? "1": "0"))
                        {
                            configuracion.Titulo = "imprimir_ticket_factura";
                            configuracion.Valor = rbImpTickSi.Checked ? "1": "0";
                        }
                        break;
                    default:
                        break;
                }
                if(!string.IsNullOrEmpty(configuracion.Valor))
                {
                    listConfiguraciones.Add(configuracion);
                    configuracion = null;
                }
            }
            return listConfiguraciones;
        }
        public bool validaDatos()
        {
            bool valida = true;
            if(string.IsNullOrEmpty(txtTituloSistema.Text))
            {
                MessageBox.Show("Debe de ingresar el título del sistema.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }
            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                MessageBox.Show("Debe de ingresar la razón social", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }
            return valida;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaDatos())
            {
                return;
            }
            bool saveState = false;
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea actualizar los valores del sistema?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                foreach (Configuraciones setting in getLstConfiguraciones())
                {
                    bool save = managmentSystemConfig.ServiceSettingUpdate(setting);
                    if(save)
                    {
                        saveState = true;
                    }
                }
                if(saveState)
                {
                    MessageBox.Show("Configuraciones actualizadas con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSetting();
                }
            }
        }
    }
}
