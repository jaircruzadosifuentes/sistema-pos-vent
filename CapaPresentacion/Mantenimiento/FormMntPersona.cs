using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.Controles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using CapaPresentacion.gVarPublicas;

namespace CapaPresentacion.Mantenimiento
{
    public partial class FormMntPersona : MaterialSkin.Controls.MaterialForm
    {
        public bool IS_NEW = false;
        public bool IS_MODIFICATION = false;
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentPais managmentPais = new ManagmentPais();
        private readonly ManagmentUser managmentUser = new ManagmentUser();
        private readonly ManagmentCliente managmentCliente = new ManagmentCliente();
        private readonly ManagmentRol managmentRol = new ManagmentRol();
        private readonly ManagmentOperadorCelular managmentOperadorCelular = new ManagmentOperadorCelular();
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        public void SetDatosDomicilio(string domicilio, string manzana, string lote, string referencia)
        {
            txtDireccionPersona.Text = domicilio + " - " + manzana + " " + lote + " - " + referencia;
        }
        #region Singleton
        private static FormMntPersona _instancia;
        public static FormMntPersona GetInstancia()
        { 
            if (_instancia == null)
            {
                _instancia = new FormMntPersona();
            }
            return _instancia;
        }
        #endregion
        public FormMntPersona()
        {
            InitializeComponent();
        }
        public void ControlForDefault()
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboTipo.SelectedIndex = 0;
            //cboTipoDoc.SelectedIndex = 0;
        }
        public void LoadPaises()
        {
            cboPais.DataSource = managmentPais.GetPaises();
            cboPais.ValueMember = "paisId";
            cboPais.DisplayMember = "name";
            cboPais.SelectedIndex = 0;
        }
        public void LoadRol()
        {
            cboRol.DataSource = managmentRol.getAllRol();
            cboRol.ValueMember = "rolId";
            cboRol.DisplayMember = "name";
        }
        public void LoadDocumentType()
        {
            cboTipoDoc.DataSource = managmentCliente.ServiceGetDocumentsTypeInCombo();
            cboTipoDoc.ValueMember = "tipoDocumentoId";
            cboTipoDoc.DisplayMember = "abreviatura";
        }
        public string ShowDocumentType(int value)
        {
            string valor = "";
            switch (value)
            {
                case 0:
                    valor = "DNI";
                    break;
                case 1:
                    valor = "RUC";
                    break;
                case 2:
                    valor = "Carnet Ext.";
                    break;
                default:
                    break;
            }
            return valor;
        }
        public void LoadDataUserInDG()
        {
            dgPersonas.DataSource = managmentUser.GetAllUser();
        }
        public void CentrarItemsTable()
        {
            this.dgPersonas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPersonas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void ClearControl()
        {
            txtCelular.Text = "";
            txtApellidoPaterno.Text = "";
            txtNombres.Text = "";
            txtApellidosConyugue.Text = "";
            txtNumeroDoc.Text = "";
            txtDireccionPersona.Text = "";
            txtCorreoElectronico.Text = "";
            txtPassword2.Text = "";
            txtPasswordCoincide2.Text = "";
        }
        public void DesactivarColumnas()
        {
            this.dgPersonas.Columns[0].Visible = false;
            this.dgPersonas.Columns[1].Visible = false;
            this.dgPersonas.Columns["password"].Visible = false;
            this.dgPersonas.Columns["sedeId"].Visible = false;
            this.dgPersonas.Columns["cajaId"].Visible = false;
            this.dgPersonas.Columns["tipoDocumentoId"].Visible = false;
            this.dgPersonas.Columns["ArquetipoName"].Visible = false;
            this.dgPersonas.Columns["Arquetipo"].Visible = false;
            this.dgPersonas.Columns["horarioId"].Visible = false;
            
        }
        public void RedimensionarColumnas()
        {
            this.dgPersonas.Columns["Nombres"].Width = 150;
            this.dgPersonas.Columns["Apellido_Paterno"].Width = 150;
            this.dgPersonas.Columns["Apellido_Materno"].Width = 150;
            this.dgPersonas.Columns["Sede"].Width = 150;
            this.dgPersonas.Columns["Direccion"].Width = 380;
            this.dgPersonas.Columns["Direccion_Email"].Width = 350;
            this.dgPersonas.Columns["Numero_documento"].Width = 120;
            this.dgPersonas.Columns["tipoDocumentoId"].Width = 1;
        }
        public void LoadSedes()
        {
            cbSede.DataSource = new ManagmentSedes().ServiceGetSedesEnCombo();
            cbSede.ValueMember = "sedeId";
            cbSede.DisplayMember = "name";
        }
        public void LoadCaja(int sedeId)
        {
            cbCaja.DataSource = new ManagmentCaja().ServiceGetCajaPorSedeIdEnCombo(sedeId);
            cbCaja.ValueMember = "cajaId";
            cbCaja.DisplayMember = "name";
        }   
        public void LoadHorarios()
        {
            cbHorarioTrabajar.DataSource = new ManagmentCliente().ServiceGetHorarioEnCombo();
            cbHorarioTrabajar.ValueMember = "horarioId";
            cbHorarioTrabajar.DisplayMember = "nombre";
        }
        private void FormMntPersona_Load(object sender, EventArgs e)
        {
            LoadSedes();
            ControlForDefault();
            LoadPaises();
            LoadRol();
            LoadDataUserInDG();
            CentrarItemsTable();
            AlternarColores(dgPersonas);
            DesactivarColumnas();
            RedimensionarColumnas();
            LoadDocumentType();
            LoadCaja(Convert.ToInt32(cbSede.SelectedValue));
            LoadHorarios();
            txtPassword2.PasswordChar = Convert.ToChar("*");
            txtPasswordCoincide2.PasswordChar = Convert.ToChar("*");
        }
        public string MostrarValoresCombo(int value)
        {
            string valor = "";
            switch (value)
            {
                case 0:
                    valor = "Apellidos";
                    return valor;
                case 1:
                    valor = "Nombres";
                    return valor;
                case 2:
                    valor = "Cargo";
                    return valor;
                case 3:
                    valor = "Código Cliente";
                    return valor;
                default:
                    break;
            }
            return valor;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            bool estadoAnulado = false;
            int contador = 0;
            bool estadoAnuladoFinal = false;
            try
            {
                foreach (DataGridViewRow rowFila in dgPersonas.Rows)
                {
                    if (Convert.ToBoolean(rowFila.Cells[0].Value))
                    {
                        if (rowFila.Cells[16].Value.Equals("INACTIVO"))
                        {
                            estadoAnulado = true;
                            MessageBox.Show("No puede anular este personal, cuando ya está anulada.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                if (!estadoAnulado)
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Realmente desea dar de baja a los trabajadores seleccionados?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        int trabajadorId;
                        foreach (DataGridViewRow row in dgPersonas.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                trabajadorId = Convert.ToInt32(row.Cells[1].Value);
                                bool anular = managmentUser.ServiceDarDeBajaTrabajador(trabajadorId);
                                if (anular)
                                {
                                    contador = contador + 1;
                                    estadoAnuladoFinal = true;
                                }
                                else
                                {
                                    contador = 0;
                                    estadoAnuladoFinal = false;
                                    MessageBox.Show("Error al anular Presentación.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        if(estadoAnuladoFinal)
                        {
                            MessageBox.Show($"{(contador > 1 ? "Trabajadores dados de baja" : "Trabajador dado de baja")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataUserInDG();
                            chkAnular.Checked = false;
                            contador = 0;
                            estadoAnuladoFinal = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            tvViewPersonal.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnSiguiente.Visible = estado;
            this.btnGuardar.Visible = !estado;
            this.btnCancelar.Visible = estado;
            this.btnExcel.Enabled = !estado;
            this.btnEliminar.Visible = !estado;
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControlesNuevo(true);
            IS_NEW = true;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            _instancia = null;
            this.Dispose();
        }
        public void SeleccionaNodo()
        {
            string gsOpeCod = tvDatos.SelectedNode.Text;
            string gsCodeOperations = gsOpeCod.Substring(0, 1);
            switch (gsCodeOperations)
            {
                case "1":
                    tcIngresoDatos.SelectedIndex = 0;
                    break;
                case "2":
                    tcIngresoDatos.SelectedIndex = 1;
                    break;
                case "3":
                    tcIngresoDatos.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }
        private void tvDatos_DoubleClick(object sender, EventArgs e)
        {
            SeleccionaNodo();
        }

        private void tvDatos_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if(IS_MODIFICATION)
            {
                HabilitarControlesNuevo(false);
                ClearControl();
                IS_MODIFICATION = false;
            }
            else
            {
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                ClearControl();
            }
        }
        //Validamos datos
        public int ValidatePersonalData()
        {
            int positionNextValidate = 0;
            switch (tcIngresoDatos.SelectedIndex)
            {
                case 0:
                    if (txtNombres.Text == string.Empty)
                    {
                        txtNombres.Focus();
                        positionNextValidate = -1;
                    }
                    else if (txtApellidoPaterno.Text == string.Empty)
                    {
                        txtApellidoPaterno.Focus();
                        positionNextValidate = -1;
                    }
                    else if (!rbFemenino.Checked && !rbMasculino.Checked)
                    {
                        positionNextValidate = -1;
                        lblSeleccioneGenero.Visible = true;
                    }
                    else if(txtNumeroDoc.Text == string.Empty)
                    {
                        positionNextValidate = -1;
                        txtNumeroDoc.Focus();
                    }
                    else if (cboPais.SelectedIndex == -1)
                    {
                        positionNextValidate = -1;
                        MessageBox.Show("¡Debe de seleccionar un país!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboPais.Focus();
                    }
                    else if (txtCelular.Text == String.Empty)
                    {
                        positionNextValidate = -1;
                        MessageBox.Show("¡Debe de agregar almenos un número telefónico de referencia!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lblSeleccioneGenero.Visible = false;
                        positionNextValidate = 1;
                    }
                    break;
                case 1:
                    if(txtPassword2.Text == string.Empty)
                    {
                        positionNextValidate = -1;
                        txtPassword2.Focus();
                    }
                    else if(txtPasswordCoincide2.Text == string.Empty)
                    {
                        positionNextValidate = -1;
                        txtPasswordCoincide2.Focus();
                    }
                    else
                    {
                        positionNextValidate = 2;
                    }
                    break;
                case 2:
                    positionNextValidate = 3;
                    break;
                default:
                    break;
            }
            
            return positionNextValidate;
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            Rol rol = new Rol();
            Pais pais = new Pais();

            string names = txtNombres.Text;
            string lastFather = txtApellidoPaterno.Text;
            string lastMother = txtApellidoMaterno.Text;
            string address = txtDireccionPersona.Text;
            int paisId = Convert.ToInt32(cboPais.SelectedValue);
            int prmTipoDocId = Convert.ToInt32(cboTipoDoc.SelectedValue);
            string numeroDoc = txtNumeroDoc.Text;
            string celular = txtCelular.Text;
            Boolean bTieneCorreo = chkTieneCorreo.Checked;
            string email = txtCorreoElectronico.Text;
            string password = txtPassword2.Text;
            string passwordCoincide = txtPasswordCoincide2.Text;
            int cargoId = Convert.ToInt32(cboRol.SelectedValue);
            string sexo = "";
            if(rbFemenino.Checked)
            {
                sexo = "F";
            }
            else if(rbMasculino.Checked)
            {
                sexo = "M";
            }

            user.Names = names;
            user.LastPatern = lastFather;
            user.LastMother = lastMother;
            user.Direction = address;
            user.NumeroDoc = numeroDoc;
            user.Cellphone = celular;
            user.EmailAddress = email;
            user.TieneCorreoBit = bTieneCorreo;
            user.TipoDocumentoId = prmTipoDocId;
            user.Sexo = sexo;
            if(password == passwordCoincide)
            {
                user.Password = password;
            }
            else
            {
                MessageBox.Show("¡Password no coinciden, verifique por favor!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Caja caja = new Caja();
            caja.CajaId = Convert.ToInt32(cbCaja.SelectedValue);
            Sede sede = new Sede();
            sede.SedeId = Convert.ToInt32(cbSede.SelectedValue);
            Horario horario = new Horario();
            horario.HorarioId = Convert.ToInt32(cbHorarioTrabajar.SelectedValue);

            rol.RolId = cargoId;
            pais.PaisId = paisId;
            user.Pais = pais;
            user.Rol = rol;
            user.Caja = caja;
            user.Sede = sede;
            user.Horario = horario;

            bool inserta = managmentUser.ServiceInsertaUser(user, "I");
            if (inserta)
            {
                MessageBox.Show("Usuario registrado con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                ClearControl();
                LoadDataUserInDG();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(IS_NEW)
            {
                switch (ValidatePersonalData())
                {
                    //Datos personales
                    case 1:
                        tcIngresoDatos.SelectedIndex = 1;
                        break;
                    //Credenciales de acceso - habilitamos el boton guardar
                    case 2:
                        tcIngresoDatos.SelectedIndex = 2;
                        txtNombresCompletos.Text = String.Concat(txtApellidoPaterno.Text, " ", txtApellidoMaterno.Text, ", ", txtNombres.Text);
                        break;
                    case 3:
                        btnSiguiente.Visible = false;
                        btnGuardar.Visible = true;

                        btnGuardar.Enabled = true;
                        break;
                    default:
                        break;
                }

            } 
            else if(IS_MODIFICATION)
            {
                switch (ValidatePersonalData())
                {
                    //Datos personales
                    case 1:
                        tcIngresoDatos.SelectedIndex = 1;
                        break;
                    //Credenciales de acceso - habilitamos el boton guardar
                    case 2:
                        tcIngresoDatos.SelectedIndex = 2;
                        break;
                    case 3:
                        btnSiguiente.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnModificar.Visible = true;
                        btnModificar.Enabled = true;
                        btnModificar.Focus();
                        break;
                    default:
                        break;
                }

            }
        }

        private void chkTieneCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTieneCorreo.Checked)
            {
                txtCorreoElectronico.Enabled = true;
                txtCorreoElectronico.Focus();
            }
            else
            {
                txtCorreoElectronico.Enabled = false;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtApellidoPaterno.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void txtApellidosConyugue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregarDireccion .Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cboPais.Focus();
            }
        }

        private void cboPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                chkTieneCorreo.Focus();
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pbImagenTrabajador.Image = Image.FromFile(imagen);
                    pbImagenTrabajador.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgPersonas.Columns["Anular"].Index)
            {
                if(e.RowIndex != -1)
                {
                    DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgPersonas.Rows[e.RowIndex].Cells["Anular"];
                    CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
                }
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonas.Text = "Buscar personas por " + MostrarValoresCombo(cboTipo.SelectedIndex);
        }
        public void HabilitarControlesModificar(bool estado)
        {
            tvViewPersonal.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnSiguiente.Visible = estado;
            this.btnGuardar.Visible = !estado;
            this.btnModificar.Visible = estado;
            this.btnCancelar.Visible = estado;
            this.btnEliminar.Visible = !estado;
            this.btnExcel.Enabled = !estado;
           
        }
        private void dgPersonas_DoubleClick(object sender, EventArgs e)
        {
            txtPersonaId.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["id"].Value);
            this.txtNombres.Text = Convert.ToString(this.dgPersonas.CurrentRow.Cells["Nombres"].Value);
            this.txtApellidoPaterno.Text = Convert.ToString(this.dgPersonas.CurrentRow.Cells["Apellido_Paterno"].Value);
            this.txtApellidoMaterno.Text = Convert.ToString(this.dgPersonas.CurrentRow.Cells["Apellido_Materno"].Value);
            string sexo = Convert.ToString(dgPersonas.CurrentRow.Cells["Genero"].Value).Substring(0, 1);
            if(sexo == "M")
            {
                this.rbMasculino.Checked = true;    
            }
            else
            {
                this.rbFemenino.Checked = true;
            }
            string direction = Convert.ToString(dgPersonas.CurrentRow.Cells["Direccion"].Value);
            txtDireccionPersona.Text = direction;
            string emailAddress = Convert.ToString(dgPersonas.CurrentRow.Cells["Direccion_Email"].Value);
            if(emailAddress.Length > 0)
            {
                chkTieneCorreo.Checked = true;
                txtCorreoElectronico.Text = emailAddress;
            }
            cboPais.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["Pais"].Value);
            string numeroDoc = Convert.ToString(dgPersonas.CurrentRow.Cells["Numero_documento"].Value);
            txtCelular.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["Celular"].Value);
            txtNumeroDoc.Text = numeroDoc;
            cboTipoDoc.SelectedValue = Convert.ToInt32(dgPersonas.CurrentRow.Cells["tipoDocumentoId"].Value);
            cboRol.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["Cargo"].Value);
            txtPassword2.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["password"].Value);
            txtPasswordCoincide2.Text = Convert.ToString(dgPersonas.CurrentRow.Cells["password"].Value);

            int cajaId = Convert.ToInt32(dgPersonas.CurrentRow.Cells["cajaId"].Value);
            int sedeId = Convert.ToInt32(dgPersonas.CurrentRow.Cells["sedeId"].Value);
            int horarioId = Convert.ToInt32(dgPersonas.CurrentRow.Cells["horarioId"].Value);
            if(cajaId != 0)
            {
                cbCaja.SelectedValue = cajaId;
            }
            else
            {
                cbCaja.SelectedValue = 0;
            }
            if(sedeId != 0)
            {
                cbSede.SelectedValue = sedeId;
            }
            else
            {
                cbSede.SelectedValue = 0;
            }
            if(horarioId != 0)
            {
                cbHorarioTrabajar.SelectedValue = horarioId;
            }
            else
            {
                cbHorarioTrabajar.SelectedValue = 0;
            }
            txtNombresCompletos.Text = string.Concat(txtNombres.Text, " ", txtApellidoPaterno.Text, " ", txtApellidoMaterno.Text);

            IS_MODIFICATION = true;
            HabilitarControlesModificar(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }
      
        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            FormBuscarDireccion formBuscarDireccion = new FormBuscarDireccion();
            formBuscarDireccion.ShowDialog();
        }
       

        private void FormMntPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void txtDireccionPersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidosConyugue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if(IS_MODIFICATION)
            {
                User user = new User();
                Rol rol = new Rol();
                Pais pais = new Pais();
                int personaId = Convert.ToInt32(txtPersonaId.Text);
                string names = txtNombres.Text;
                string lastFather = txtApellidoPaterno.Text;
                string lastMother = txtApellidoMaterno.Text;
                string address = txtDireccionPersona.Text;
                int paisId = Convert.ToInt32(cboPais.SelectedValue);
                int prmTipoDocId = Convert.ToInt32(cboTipoDoc.SelectedValue);
                string numeroDoc = txtNumeroDoc.Text;
                string celular = txtCelular.Text;
                Boolean bTieneCorreo = chkTieneCorreo.Checked;
                string email = txtCorreoElectronico.Text;
                string password = txtPassword2.Text;
                string passwordCoincide = txtPasswordCoincide2.Text;
                int cargoId = Convert.ToInt32(cboRol.SelectedValue);
                string sexo = "";
                if (rbFemenino.Checked)
                {
                    sexo = "F";
                }
                else if (rbMasculino.Checked)
                {
                    sexo = "M";
                }
                user.UserId = personaId;
                user.Names = names;
                user.LastPatern = lastFather;
                user.LastMother = lastMother;
                user.Direction = address;
                user.NumeroDoc = numeroDoc;
                user.Cellphone = celular;
                user.EmailAddress = email;
                user.TieneCorreoBit = bTieneCorreo;
                user.TipoDocumentoId = prmTipoDocId;
                user.Sexo = sexo;
                if (password == passwordCoincide)
                {
                    user.Password = password;
                }
                else
                {
                    MessageBox.Show("Password no coinciden, verifique por favor.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Caja caja = new Caja();
                caja.CajaId = Convert.ToInt32(cbCaja.SelectedValue);
                Sede sede = new Sede();
                sede.SedeId = Convert.ToInt32(cbSede.SelectedValue);
                Horario horario = new Horario();
                horario.HorarioId = Convert.ToInt32(cbHorarioTrabajar.SelectedValue);

                rol.RolId = cargoId;
                pais.PaisId = paisId;
                user.Pais = pais;
                user.Rol = rol;
                user.Caja = caja;
                user.Sede = sede;
                user.Horario = horario;
                bool inserta = managmentUser.ServiceInsertaUser(user, "U");
                if (inserta)
                {
                    MessageBox.Show("¡Usuario actualizado con éxito!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarControlesNuevo(false);
                    IS_MODIFICATION = false;
                    ClearControl();
                    //LoadUsers();
                    LoadDataUserInDG();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtPasswordCoincide2_TextChanged_2(object sender, EventArgs e)
        {
            string password = txtPassword2.Text;
            string passwordCoincide = txtPasswordCoincide2.Text;

            if (password == passwordCoincide)
            {
                lblPasswordCoincide.Visible = true;
                lblPasswordCoincide.Text = "¡Los passwords coincide correctamente!";
                lblPasswordCoincide.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordCoincide.Visible = true;
                lblPasswordCoincide.Text = "¡Los passwords no coinciden!";
                lblPasswordCoincide.ForeColor = Color.Maroon;
            }
        }

        private void txtPasswordCoincide2_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword2.Text;
            string passwordCoincide = txtPasswordCoincide2.Text;

            if (password == passwordCoincide)
            {
                lblPasswordCoincide.Visible = true;
                lblPasswordCoincide.Text = "¡Los passwords coincide correctamente!";
                lblPasswordCoincide.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordCoincide.Visible = true;
                lblPasswordCoincide.Text = "¡Los passwords no coinciden!";
                lblPasswordCoincide.ForeColor = Color.Maroon;
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorTipoDoc = cboTipoDoc.SelectedIndex;
            switch (valorTipoDoc)
            {
                case 0:
                    txtNumeroDoc.MaxLength = 8;
                    break;
                case 1:
                    txtNumeroDoc.MaxLength = 11;
                    break;
                case 2:
                    txtNumeroDoc.MaxLength = 11;
                    break;
                default:
                    break;
            }
        }

        private void dgComunicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgComunicaciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cmd = e.Control as ComboBox;
            if(cmd != null)
            {
                DataTable dataTable = managmentUser.GetCellphoneNumber(Convert.ToInt32(txtPersonaId.Text));
                foreach (DataRow row in dataTable.Rows)
                {
                    cmd.SelectedIndex = GetIndex(Convert.ToInt32(row["operador_id"].ToString()));
                }
            }
        }
        public int GetIndex(int index)
        {
            int value = 0;
            switch (index)
            {
                case 1:
                    value = 0;
                    break;
                case 2:
                    value = 1;
                    break;
                case 3:
                    value = 2;
                    break;
                case 4:
                    value = 3;
                    break;
                default:
                    break;
            }
            return value;
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtCelular.Focus();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void GenerarExcelCabeceraPersonal()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE PERSONAL";
            if (showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:L2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:K2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:K2"].Font.Size = 14;
            xlHoja.Range["B2:K2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:P2"].Font.Bold = true;
            xlHoja.Range["B3:P3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A6:A6"].ColumnWidth = 4;
            xlHoja.Range["B6:B6"].ColumnWidth = 4;
            xlHoja.Range["C6:C6"].ColumnWidth = 27;
            xlHoja.Range["D6:D6"].ColumnWidth = 27;
            xlHoja.Range["E6:E6"].ColumnWidth = 18;
            xlHoja.Range["F6:F6"].ColumnWidth = 16;
            xlHoja.Range["G6:G6"].ColumnWidth = 35;
            xlHoja.Range["H6:H6"].ColumnWidth = 12;
            xlHoja.Range["I6:I6"].ColumnWidth = 18;
            xlHoja.Range["J6:J6"].ColumnWidth = 12;
            xlHoja.Range["K6:K6"].ColumnWidth = 10;

            xlHoja.Range["B6:K6"].Font.Bold = true;
            xlHoja.Range["B6:D6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:D6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:K6"].Borders.LineStyle = true;
            xlHoja.Range["B6:K6"].WrapText = true;

            xlHoja.Range["B6:K6"].Font.Color = Color.Black;
            xlHoja.Range["B6:K6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "N°";
            xlHoja.Cells[6, 3] = "Nombres";
            xlHoja.Cells[6, 4] = "Apellidos";
            xlHoja.Cells[6, 5] = "N° Documento";
            xlHoja.Cells[6, 6] = "Codigo Usuario";
            xlHoja.Cells[6, 7] = "Email";
            xlHoja.Cells[6, 8] = "Perfil";
            xlHoja.Cells[6, 9] = "Sede";
            xlHoja.Cells[6, 10] = "Caja";
            xlHoja.Cells[6, 11] = "Estado";
        }
        public bool GenerarExcelCuerpoPersonal()
        {
            DataTable getAllPersonal = managmentUser.GetAllUser();

            long nFilas = 6;
            long contador = 0;

            pb1.Maximum = CantidadPersonal();
            pb1.Value = 1;
            pb2.Maximum = CantidadPersonal();
            pb2.Value = 1;

            foreach (DataRow row in getAllPersonal.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Nombres"].ToString();
                xlHoja.Cells[nFilas, 4] = String.Concat(row["Apellido_Paterno"].ToString(), " ", row["Apellido_Materno"].ToString());
                xlHoja.Cells[nFilas, 5] = row["Numero_documento"].ToString();
                xlHoja.Cells[nFilas, 6] = row["Cod_usuario"].ToString();
                xlHoja.Cells[nFilas, 7] = row["Direccion_Email"].ToString();
                xlHoja.Cells[nFilas, 8] = row["Cargo"].ToString();
                xlHoja.Cells[nFilas, 9] = row["Sede"].ToString();
                xlHoja.Cells[nFilas, 10] = row["Caja"].ToString();
                xlHoja.Cells[nFilas, 11] = row["Estado"].ToString();
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 6; i <= 6 + CantidadPersonal(); i++)
            {
                for (int j = 2; j <= 11; j++)
                {
                    xlHoja.Cells[i, j].Borders.LineStyle = true;
                    xlHoja.Cells[i, j].WrapText = true;
                    xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
            }
            bool ExistenRegistros = CantidadPersonal() > 0;
            return ExistenRegistros;
        }
        public int CantidadPersonal()
        {
            return managmentUser.GetAllUser().Rows.Count;
        }
        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            try
            {
                xlApplication = new Excel.Application();
                xlApplication.Visible = false;
                //Visible progres bar
                pb2.Visible = true;
                pb1.Visible = true;
                //Get a new workbook.
                xlLibro = xlApplication.Workbooks.Add(Missing.Value);
                xlHoja = (Excel._Worksheet)xlLibro.ActiveSheet;
                xlHoja.Name = "REP_PERSONAL";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_PERSONAL_GENERAL.xlsx";
                if (File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraPersonal();
                if (GenerarExcelCuerpoPersonal())
                {
                    xlApplication.Visible = true;
                    xlApplication.UserControl = false;
                    xlLibro.SaveAs(folder + nombre);
                    pb1.Visible = false;
                    pb1.Value = 0;
                    pb2.Visible = false;
                    pb2.Value = 0;
                }
                else
                {
                    MessageBox.Show("¡No existen datos para mostrar!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void txtBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0://Apellidos
                    dgPersonas.DataSource = managmentUser.GetEmpleadosPorApellidos(txtBuscarPersona.Text);
                    break;
                case 1://Nombres
                    dgPersonas.DataSource = managmentUser.GetEmpleadosPorNombres(txtBuscarPersona.Text);
                    break;
                case 2://Cargo
                    dgPersonas.DataSource = managmentUser.GetEmpleadosPorCargo(txtBuscarPersona.Text);
                    break;
                case 3:
                    dgPersonas.DataSource = managmentUser.GetEmpleadosPorCodigo(txtBuscarPersona.Text);
                    break;
                default:
                    break;
            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgPersonas.Columns[0].Visible = true;
                this.dgPersonas.Columns[0].Width = 80;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgPersonas.Columns[0].Visible = false;
                this.dgPersonas.Columns[0].Width = 80;
                this.btnEliminar.Enabled = false;
            }
        }

        private void cbCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IS_MODIFICATION)
            {
                int cajaId = Convert.ToInt32(cbCaja.SelectedValue);
                int sedeId = Convert.ToInt32(cbSede.SelectedValue);
                DataTable dataTable = new ManagmentCaja().ServiceVerificaCajasAsignadasASede(sedeId, cajaId);
                if(dataTable.Rows.Count > 0)
                {
                    if(Convert.ToInt32(dataTable.Rows[0]["hayDatos"]) != 0)
                    {
                        MessageBox.Show("La caja seleccionada, ya ha sido asignada a otro empleado.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else if(IS_NEW)
            {
                int cajaId = Convert.ToInt32(cbCaja.SelectedValue);
                int sedeId = Convert.ToInt32(cbSede.SelectedValue);
                DataTable dataTable = new ManagmentCaja().ServiceVerificaCajasAsignadasASede(sedeId, cajaId);
                if (dataTable.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dataTable.Rows[0]["hayDatos"]) != 0)
                    {
                        MessageBox.Show("La caja seleccionada, ya ha sido asignada a otro empleado.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void btnVerClase_Click(object sender, EventArgs e)
        {
        }
    }
}
