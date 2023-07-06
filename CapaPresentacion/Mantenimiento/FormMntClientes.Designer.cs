namespace CapaPresentacion.Mantenimiento
{
    partial class FormMntClientes
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1.-Datos personales");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMntClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvDatos = new System.Windows.Forms.TreeView();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tvViewPersonal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcIngresoDatos = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSeleccioneGenero = new System.Windows.Forms.Label();
            this.txtDireccionPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTieneCorreo = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtApellidosConyugue = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonaId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tvViewPersonal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tcIngresoDatos.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDatos
            // 
            this.tvDatos.Location = new System.Drawing.Point(6, 17);
            this.tvDatos.Name = "tvDatos";
            treeNode1.Name = "nodoDatosPersonales";
            treeNode1.Text = "1.-Datos personales";
            this.tvDatos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvDatos.Size = new System.Drawing.Size(188, 175);
            this.tvDatos.TabIndex = 0;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(24, 638);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(1076, 10);
            this.pb2.TabIndex = 11;
            this.pb2.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(24, 624);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1076, 11);
            this.pb1.TabIndex = 10;
            this.pb1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1106, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 524);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(22, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(22, 356);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 64);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(22, 216);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 64);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(22, 76);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 64);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(22, 146);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 64);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(22, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 64);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(22, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 64);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tvViewPersonal
            // 
            this.tvViewPersonal.Controls.Add(this.tabPage1);
            this.tvViewPersonal.Controls.Add(this.tabPage2);
            this.tvViewPersonal.Location = new System.Drawing.Point(24, 83);
            this.tvViewPersonal.Name = "tvViewPersonal";
            this.tvViewPersonal.SelectedIndex = 0;
            this.tvViewPersonal.Size = new System.Drawing.Size(1076, 540);
            this.tvViewPersonal.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPersonas);
            this.tabPage1.Controls.Add(this.txtBuscarPersona);
            this.tabPage1.Controls.Add(this.cboTipo);
            this.tabPage1.Controls.Add(this.dgPersonas);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.txtBuscarPersona.Location = new System.Drawing.Point(367, 59);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(395, 24);
            this.txtBuscarPersona.TabIndex = 4;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos"});
            this.cboTipo.Location = new System.Drawing.Point(15, 57);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(202, 26);
            this.cboTipo.TabIndex = 1;
            // 
            // dgPersonas
            // 
            this.dgPersonas.AllowUserToAddRows = false;
            this.dgPersonas.AllowUserToDeleteRows = false;
            this.dgPersonas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPersonas.Location = new System.Drawing.Point(15, 135);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.ReadOnly = true;
            this.dgPersonas.RowHeadersWidth = 51;
            this.dgPersonas.RowTemplate.Height = 24;
            this.dgPersonas.Size = new System.Drawing.Size(1033, 351);
            this.dgPersonas.TabIndex = 0;
            this.dgPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonas_CellContentClick);
            this.dgPersonas.DoubleClick += new System.EventHandler(this.dgPersonas_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tcIngresoDatos);
            this.tabPage2.Controls.Add(this.tvDatos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo/Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcIngresoDatos
            // 
            this.tcIngresoDatos.Controls.Add(this.tabPage3);
            this.tcIngresoDatos.Location = new System.Drawing.Point(200, 18);
            this.tcIngresoDatos.Name = "tcIngresoDatos";
            this.tcIngresoDatos.SelectedIndex = 0;
            this.tcIngresoDatos.Size = new System.Drawing.Size(853, 487);
            this.tcIngresoDatos.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbCliente);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(845, 456);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Datos personales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtApellidoMaterno);
            this.gbCliente.Controls.Add(this.label12);
            this.gbCliente.Controls.Add(this.label11);
            this.gbCliente.Controls.Add(this.cboTipoDoc);
            this.gbCliente.Controls.Add(this.txtNumeroDoc);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.lblSeleccioneGenero);
            this.gbCliente.Controls.Add(this.txtDireccionPersona);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.chkTieneCorreo);
            this.gbCliente.Controls.Add(this.groupBox4);
            this.gbCliente.Controls.Add(this.gbGenero);
            this.gbCliente.Controls.Add(this.txtApellidosConyugue);
            this.gbCliente.Controls.Add(this.txtApellidoPaterno);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.txtNombres);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.txtPersonaId);
            this.gbCliente.Location = new System.Drawing.Point(6, 6);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(833, 444);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(463, 86);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(307, 24);
            this.txtApellidoMaterno.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "Ape. Mat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tipo Doc:";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(108, 245);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(158, 26);
            this.cboTipoDoc.TabIndex = 43;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(320, 248);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(145, 24);
            this.txtNumeroDoc.TabIndex = 42;
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "N°:";
            // 
            // lblSeleccioneGenero
            // 
            this.lblSeleccioneGenero.AutoSize = true;
            this.lblSeleccioneGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneGenero.ForeColor = System.Drawing.Color.Maroon;
            this.lblSeleccioneGenero.Location = new System.Drawing.Point(150, 185);
            this.lblSeleccioneGenero.Name = "lblSeleccioneGenero";
            this.lblSeleccioneGenero.Size = new System.Drawing.Size(127, 15);
            this.lblSeleccioneGenero.TabIndex = 40;
            this.lblSeleccioneGenero.Text = "Seleccione un género";
            this.lblSeleccioneGenero.Visible = false;
            // 
            // txtDireccionPersona
            // 
            this.txtDireccionPersona.Location = new System.Drawing.Point(110, 204);
            this.txtDireccionPersona.Name = "txtDireccionPersona";
            this.txtDireccionPersona.Size = new System.Drawing.Size(660, 24);
            this.txtDireccionPersona.TabIndex = 38;
            this.txtDireccionPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionPersona_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dirección:";
            // 
            // chkTieneCorreo
            // 
            this.chkTieneCorreo.AutoSize = true;
            this.chkTieneCorreo.Location = new System.Drawing.Point(108, 282);
            this.chkTieneCorreo.Name = "chkTieneCorreo";
            this.chkTieneCorreo.Size = new System.Drawing.Size(130, 22);
            this.chkTieneCorreo.TabIndex = 36;
            this.chkTieneCorreo.Text = "¿Tiene correo?";
            this.chkTieneCorreo.UseVisualStyleBackColor = true;
            this.chkTieneCorreo.CheckedChanged += new System.EventHandler(this.chkTieneCorreo_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCorreoElectronico);
            this.groupBox4.Location = new System.Drawing.Point(108, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 84);
            this.groupBox4.TabIndex = 35;
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
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(110, 130);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(259, 54);
            this.gbGenero.TabIndex = 33;
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
            // 
            // txtApellidosConyugue
            // 
            this.txtApellidosConyugue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidosConyugue.Location = new System.Drawing.Point(463, 146);
            this.txtApellidosConyugue.Name = "txtApellidosConyugue";
            this.txtApellidosConyugue.Size = new System.Drawing.Size(307, 24);
            this.txtApellidosConyugue.TabIndex = 32;
            this.txtApellidosConyugue.Visible = false;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(110, 86);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(259, 24);
            this.txtApellidoPaterno.TabIndex = 31;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ape. Pat:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(110, 45);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(660, 24);
            this.txtNombres.TabIndex = 29;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombres:";
            // 
            // txtPersonaId
            // 
            this.txtPersonaId.Location = new System.Drawing.Point(110, 17);
            this.txtPersonaId.Name = "txtPersonaId";
            this.txtPersonaId.Size = new System.Drawing.Size(62, 24);
            this.txtPersonaId.TabIndex = 27;
            this.txtPersonaId.Visible = false;
            // 
            // FormMntClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 661);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvViewPersonal);
            this.Name = "FormMntClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: CLIENTES ::.";
            this.Load += new System.EventHandler(this.FormMntClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.tvViewPersonal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tcIngresoDatos.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tvDatos;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tvViewPersonal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tcIngresoDatos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSeleccioneGenero;
        public System.Windows.Forms.TextBox txtDireccionPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTieneCorreo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtApellidosConyugue;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonaId;
    }
}