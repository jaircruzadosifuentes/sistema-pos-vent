namespace CapaPresentacion.Mantenimiento
{
    partial class FormMntPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMntPersona));
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("1.-Datos personales");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2.- Credenciales y permisos");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("3.- Asignar Sede & Caja");
            this.tvViewPersonal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbImagenTrabajador = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.tcIngresoDatos = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSeleccioneGenero = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.txtDireccionPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTieneCorreo = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtApellidosConyugue = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonaId = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbHorarioTrabajar = new System.Windows.Forms.ComboBox();
            this.cbCaja = new System.Windows.Forms.ComboBox();
            this.cbSede = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.tvDatos = new System.Windows.Forms.TreeView();
            this.lblPasswordCoincide = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPasswordCoincide2 = new System.Windows.Forms.TextBox();
            this.tvViewPersonal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTrabajador)).BeginInit();
            this.tcIngresoDatos.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvViewPersonal
            // 
            this.tvViewPersonal.Controls.Add(this.tabPage1);
            this.tvViewPersonal.Controls.Add(this.tabPage2);
            this.tvViewPersonal.Location = new System.Drawing.Point(12, 81);
            this.tvViewPersonal.Name = "tvViewPersonal";
            this.tvViewPersonal.SelectedIndex = 0;
            this.tvViewPersonal.Size = new System.Drawing.Size(1118, 594);
            this.tvViewPersonal.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAnular);
            this.tabPage1.Controls.Add(this.lblPersonas);
            this.tabPage1.Controls.Add(this.txtBuscarPersona);
            this.tabPage1.Controls.Add(this.cboTipo);
            this.tabPage1.Controls.Add(this.dgPersonas);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(15, 107);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(132, 22);
            this.chkAnular.TabIndex = 5;
            this.chkAnular.Text = "Anular personal";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.ForeColor = System.Drawing.Color.Maroon;
            this.lblPersonas.Location = new System.Drawing.Point(421, 38);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(161, 18);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "Buscar personas por";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarPersona.Location = new System.Drawing.Point(367, 59);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(395, 24);
            this.txtBuscarPersona.TabIndex = 4;
            this.txtBuscarPersona.TextChanged += new System.EventHandler(this.txtBuscarPersona_TextChanged);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Apellidos",
            "Nombres",
            "Cargo",
            "Código Empleado"});
            this.cboTipo.Location = new System.Drawing.Point(15, 57);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(202, 26);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // dgPersonas
            // 
            this.dgPersonas.AllowUserToAddRows = false;
            this.dgPersonas.AllowUserToDeleteRows = false;
            this.dgPersonas.AllowUserToOrderColumns = true;
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            this.dgPersonas.Location = new System.Drawing.Point(15, 135);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.ReadOnly = true;
            this.dgPersonas.RowHeadersWidth = 51;
            this.dgPersonas.RowTemplate.Height = 24;
            this.dgPersonas.Size = new System.Drawing.Size(1077, 410);
            this.dgPersonas.TabIndex = 0;
            this.dgPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellContentClick);
            this.dgPersonas.DoubleClick += new System.EventHandler(this.dgPersonas_DoubleClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular personal";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbImagenTrabajador);
            this.tabPage2.Controls.Add(this.btnCargarImagen);
            this.tabPage2.Controls.Add(this.tcIngresoDatos);
            this.tabPage2.Controls.Add(this.tvDatos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo/Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbImagenTrabajador
            // 
            this.pbImagenTrabajador.Location = new System.Drawing.Point(6, 198);
            this.pbImagenTrabajador.Name = "pbImagenTrabajador";
            this.pbImagenTrabajador.Size = new System.Drawing.Size(239, 308);
            this.pbImagenTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenTrabajador.TabIndex = 4;
            this.pbImagenTrabajador.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarImagen.Image")));
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarImagen.Location = new System.Drawing.Point(10, 512);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(239, 43);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Visible = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // tcIngresoDatos
            // 
            this.tcIngresoDatos.Controls.Add(this.tabPage3);
            this.tcIngresoDatos.Controls.Add(this.tabPage5);
            this.tcIngresoDatos.Controls.Add(this.tabPage4);
            this.tcIngresoDatos.Location = new System.Drawing.Point(251, 17);
            this.tcIngresoDatos.Name = "tcIngresoDatos";
            this.tcIngresoDatos.SelectedIndex = 0;
            this.tcIngresoDatos.Size = new System.Drawing.Size(828, 542);
            this.tcIngresoDatos.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtApellidoMaterno);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtCelular);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cboTipoDoc);
            this.tabPage3.Controls.Add(this.txtNumeroDoc);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lblSeleccioneGenero);
            this.tabPage3.Controls.Add(this.cboPais);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnAgregarDireccion);
            this.tabPage3.Controls.Add(this.txtDireccionPersona);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.chkTieneCorreo);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.gbGenero);
            this.tabPage3.Controls.Add(this.txtApellidosConyugue);
            this.tabPage3.Controls.Add(this.txtApellidoPaterno);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtNombres);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtPersonaId);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(820, 511);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Datos personales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(441, 77);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(307, 24);
            this.txtApellidoMaterno.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ape. Mat:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(86, 283);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(191, 24);
            this.txtCelular.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tipo Doc:";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(391, 238);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(158, 26);
            this.cboTipoDoc.TabIndex = 22;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboTipoDoc_SelectedIndexChanged);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(603, 241);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(145, 24);
            this.txtNumeroDoc.TabIndex = 21;
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "N°:";
            // 
            // lblSeleccioneGenero
            // 
            this.lblSeleccioneGenero.AutoSize = true;
            this.lblSeleccioneGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneGenero.ForeColor = System.Drawing.Color.Maroon;
            this.lblSeleccioneGenero.Location = new System.Drawing.Point(128, 176);
            this.lblSeleccioneGenero.Name = "lblSeleccioneGenero";
            this.lblSeleccioneGenero.Size = new System.Drawing.Size(127, 15);
            this.lblSeleccioneGenero.TabIndex = 19;
            this.lblSeleccioneGenero.Text = "Seleccione un género";
            this.lblSeleccioneGenero.Visible = false;
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(88, 236);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(193, 26);
            this.cboPais.TabIndex = 16;
            this.cboPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPais_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "País:";
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDireccion.Image")));
            this.btnAgregarDireccion.Location = new System.Drawing.Point(696, 181);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(52, 52);
            this.btnAgregarDireccion.TabIndex = 14;
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // txtDireccionPersona
            // 
            this.txtDireccionPersona.Location = new System.Drawing.Point(88, 195);
            this.txtDireccionPersona.Name = "txtDireccionPersona";
            this.txtDireccionPersona.Size = new System.Drawing.Size(602, 24);
            this.txtDireccionPersona.TabIndex = 13;
            this.txtDireccionPersona.TextChanged += new System.EventHandler(this.txtDireccionPersona_TextChanged);
            this.txtDireccionPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dirección:";
            // 
            // chkTieneCorreo
            // 
            this.chkTieneCorreo.AutoSize = true;
            this.chkTieneCorreo.Location = new System.Drawing.Point(88, 362);
            this.chkTieneCorreo.Name = "chkTieneCorreo";
            this.chkTieneCorreo.Size = new System.Drawing.Size(130, 22);
            this.chkTieneCorreo.TabIndex = 11;
            this.chkTieneCorreo.Text = "¿Tiene correo?";
            this.chkTieneCorreo.UseVisualStyleBackColor = true;
            this.chkTieneCorreo.CheckedChanged += new System.EventHandler(this.chkTieneCorreo_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCorreoElectronico);
            this.groupBox4.Location = new System.Drawing.Point(88, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 84);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Correo electrónico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Enabled = false;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(23, 36);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(648, 24);
            this.txtCorreoElectronico.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Celular:";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(88, 121);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(259, 54);
            this.gbGenero.TabIndex = 7;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(145, 23);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(95, 22);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(33, 23);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(97, 22);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Másculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // txtApellidosConyugue
            // 
            this.txtApellidosConyugue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidosConyugue.Location = new System.Drawing.Point(441, 137);
            this.txtApellidosConyugue.Name = "txtApellidosConyugue";
            this.txtApellidosConyugue.Size = new System.Drawing.Size(307, 24);
            this.txtApellidosConyugue.TabIndex = 5;
            this.txtApellidosConyugue.Visible = false;
            this.txtApellidosConyugue.TextChanged += new System.EventHandler(this.txtApellidosConyugue_TextChanged);
            this.txtApellidosConyugue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidosConyugue_KeyPress);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(88, 77);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(259, 24);
            this.txtApellidoPaterno.TabIndex = 4;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ape. Pat:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(88, 36);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(660, 24);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // txtPersonaId
            // 
            this.txtPersonaId.Location = new System.Drawing.Point(88, 8);
            this.txtPersonaId.Name = "txtPersonaId";
            this.txtPersonaId.Size = new System.Drawing.Size(62, 24);
            this.txtPersonaId.TabIndex = 0;
            this.txtPersonaId.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(820, 511);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Credenciales & Permisos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPasswordCoincide2);
            this.groupBox2.Controls.Add(this.txtPassword2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboRol);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(25, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 138);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cargo:";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(540, 36);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(189, 26);
            this.cboRol.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Confirmar password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(820, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asignar Sede & Caja";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cbHorarioTrabajar);
            this.groupBox3.Controls.Add(this.cbCaja);
            this.groupBox3.Controls.Add(this.cbSede);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNombresCompletos);
            this.groupBox3.Location = new System.Drawing.Point(21, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 203);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignar Sede y Caja";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(514, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Horario";
            // 
            // cbHorarioTrabajar
            // 
            this.cbHorarioTrabajar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioTrabajar.FormattingEnabled = true;
            this.cbHorarioTrabajar.Location = new System.Drawing.Point(517, 135);
            this.cbHorarioTrabajar.Name = "cbHorarioTrabajar";
            this.cbHorarioTrabajar.Size = new System.Drawing.Size(235, 26);
            this.cbHorarioTrabajar.TabIndex = 6;
            // 
            // cbCaja
            // 
            this.cbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaja.FormattingEnabled = true;
            this.cbCaja.Location = new System.Drawing.Point(258, 135);
            this.cbCaja.Name = "cbCaja";
            this.cbCaja.Size = new System.Drawing.Size(156, 26);
            this.cbCaja.TabIndex = 5;
            this.cbCaja.SelectedIndexChanged += new System.EventHandler(this.cbCaja_SelectedIndexChanged);
            // 
            // cbSede
            // 
            this.cbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSede.FormattingEnabled = true;
            this.cbSede.Location = new System.Drawing.Point(29, 135);
            this.cbSede.Name = "cbSede";
            this.cbSede.Size = new System.Drawing.Size(202, 26);
            this.cbSede.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "Caja";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sede";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres completos del personal trabajador";
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.Location = new System.Drawing.Point(29, 58);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.ReadOnly = true;
            this.txtNombresCompletos.Size = new System.Drawing.Size(723, 24);
            this.txtNombresCompletos.TabIndex = 0;
            // 
            // tvDatos
            // 
            this.tvDatos.Location = new System.Drawing.Point(6, 17);
            this.tvDatos.Name = "tvDatos";
            treeNode10.Name = "nodoDatosPersonales";
            treeNode10.Text = "1.-Datos personales";
            treeNode11.Name = "nodoCreYPermisos";
            treeNode11.Text = "2.- Credenciales y permisos";
            treeNode12.Name = "Nodo0";
            treeNode12.Text = "3.- Asignar Sede & Caja";
            this.tvDatos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.tvDatos.Size = new System.Drawing.Size(239, 175);
            this.tvDatos.TabIndex = 0;
            this.tvDatos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDatos_AfterSelect);
            this.tvDatos.DoubleClick += new System.EventHandler(this.tvDatos_DoubleClick);
            // 
            // lblPasswordCoincide
            // 
            this.lblPasswordCoincide.AutoSize = true;
            this.lblPasswordCoincide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordCoincide.Location = new System.Drawing.Point(180, 117);
            this.lblPasswordCoincide.Name = "lblPasswordCoincide";
            this.lblPasswordCoincide.Size = new System.Drawing.Size(66, 15);
            this.lblPasswordCoincide.TabIndex = 1;
            this.lblPasswordCoincide.Text = "passwords";
            this.lblPasswordCoincide.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1149, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 578);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(32, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(32, 370);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 64);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(32, 230);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 64);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(32, 90);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 64);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(32, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 64);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(32, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 64);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiguiente.Location = new System.Drawing.Point(32, 160);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(111, 64);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(32, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 64);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 677);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1114, 11);
            this.pb1.TabIndex = 6;
            this.pb1.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(12, 694);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(1114, 10);
            this.pb2.TabIndex = 7;
            this.pb2.Visible = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(180, 37);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(177, 24);
            this.txtPassword2.TabIndex = 7;
            // 
            // txtPasswordCoincide2
            // 
            this.txtPasswordCoincide2.Location = new System.Drawing.Point(180, 81);
            this.txtPasswordCoincide2.Name = "txtPasswordCoincide2";
            this.txtPasswordCoincide2.PasswordChar = '*';
            this.txtPasswordCoincide2.Size = new System.Drawing.Size(177, 24);
            this.txtPasswordCoincide2.TabIndex = 8;
            // 
            // FormMntPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 716);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvViewPersonal);
            this.MaximizeBox = false;
            this.Name = "FormMntPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Personal ::.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMntPersona_FormClosing);
            this.Load += new System.EventHandler(this.FormMntPersona_Load);
            this.tvViewPersonal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTrabajador)).EndInit();
            this.tcIngresoDatos.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tvViewPersonal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.TabControl tcIngresoDatos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TreeView tvDatos;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtApellidosConyugue;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTieneCorreo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblSeleccioneGenero;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbImagenTrabajador;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboRol;
        public System.Windows.Forms.TextBox txtDireccionPersona;
        private System.Windows.Forms.Label lblPasswordCoincide;
        private Controles.MyTextBoxBorder txtPasswordCoincide;
        private Controles.MyTextBoxBorder txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSede;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbCaja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbHorarioTrabajar;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.TextBox txtPasswordCoincide2;
        private System.Windows.Forms.TextBox txtPassword2;
    }
}