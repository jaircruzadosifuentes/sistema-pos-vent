namespace CapaPresentacion
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.tbPanelProducto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargarExcel = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgTableProductos = new System.Windows.Forms.DataGridView();
            this.anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUMedida = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtStockAlmacen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthAnular = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoverStock = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.lblMensajeProceso = new System.Windows.Forms.Label();
            this.tbPanelProducto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbDatosProducto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPanelProducto
            // 
            this.tbPanelProducto.Controls.Add(this.tabPage1);
            this.tbPanelProducto.Controls.Add(this.tabPage2);
            this.tbPanelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPanelProducto.Location = new System.Drawing.Point(12, 82);
            this.tbPanelProducto.Name = "tbPanelProducto";
            this.tbPanelProducto.SelectedIndex = 0;
            this.tbPanelProducto.Size = new System.Drawing.Size(950, 509);
            this.tbPanelProducto.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAnular);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgTableProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(6, 153);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(134, 22);
            this.chkAnular.TabIndex = 2;
            this.chkAnular.Text = "Anular producto";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargarExcel);
            this.groupBox2.Controls.Add(this.lblBuscar);
            this.groupBox2.Controls.Add(this.cboTipoBusqueda);
            this.groupBox2.Controls.Add(this.txtBuscarProducto);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnCargarExcel
            // 
            this.btnCargarExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarExcel.Image = global::CapaPresentacion.Properties.Resources.add_folder;
            this.btnCargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarExcel.Location = new System.Drawing.Point(720, 37);
            this.btnCargarExcel.Name = "btnCargarExcel";
            this.btnCargarExcel.Size = new System.Drawing.Size(161, 39);
            this.btnCargarExcel.TabIndex = 3;
            this.btnCargarExcel.Text = "Reg. Inventario";
            this.btnCargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarExcel.UseVisualStyleBackColor = true;
            this.btnCargarExcel.Click += new System.EventHandler(this.btnCargarExcel_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Maroon;
            this.lblBuscar.Location = new System.Drawing.Point(340, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(160, 18);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar producto por";
            // 
            // cboTipoBusqueda
            // 
            this.cboTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoBusqueda.FormattingEnabled = true;
            this.cboTipoBusqueda.Items.AddRange(new object[] {
            "CodigoBarras",
            "Nombre",
            "Categoria",
            "Presentacion"});
            this.cboTipoBusqueda.Location = new System.Drawing.Point(22, 50);
            this.cboTipoBusqueda.Name = "cboTipoBusqueda";
            this.cboTipoBusqueda.Size = new System.Drawing.Size(165, 26);
            this.cboTipoBusqueda.TabIndex = 1;
            this.cboTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboTipoBusqueda_SelectedIndexChanged);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(283, 52);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(360, 24);
            this.txtBuscarProducto.TabIndex = 0;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // dgTableProductos
            // 
            this.dgTableProductos.AllowUserToAddRows = false;
            this.dgTableProductos.AllowUserToDeleteRows = false;
            this.dgTableProductos.AllowUserToOrderColumns = true;
            this.dgTableProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTableProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anular});
            this.dgTableProductos.Location = new System.Drawing.Point(6, 181);
            this.dgTableProductos.Name = "dgTableProductos";
            this.dgTableProductos.ReadOnly = true;
            this.dgTableProductos.RowHeadersWidth = 51;
            this.dgTableProductos.RowTemplate.Height = 24;
            this.dgTableProductos.Size = new System.Drawing.Size(930, 286);
            this.dgTableProductos.TabIndex = 0;
            this.dgTableProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTableProductos_CellContentClick);
            this.dgTableProductos.DoubleClick += new System.EventHandler(this.dgTableProductos_DoubleClick);
            // 
            // anular
            // 
            this.anular.HeaderText = "Anular";
            this.anular.MinimumWidth = 6;
            this.anular.Name = "anular";
            this.anular.ReadOnly = true;
            this.anular.Width = 135;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbDatosProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo/Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.txtIdProducto);
            this.gbDatosProducto.Controls.Add(this.label12);
            this.gbDatosProducto.Controls.Add(this.dtpDueDate);
            this.gbDatosProducto.Controls.Add(this.label11);
            this.gbDatosProducto.Controls.Add(this.txtPrecioVenta);
            this.gbDatosProducto.Controls.Add(this.txtPrecioCosto);
            this.gbDatosProducto.Controls.Add(this.label10);
            this.gbDatosProducto.Controls.Add(this.label9);
            this.gbDatosProducto.Controls.Add(this.label8);
            this.gbDatosProducto.Controls.Add(this.cboUMedida);
            this.gbDatosProducto.Controls.Add(this.cboCategoria);
            this.gbDatosProducto.Controls.Add(this.label7);
            this.gbDatosProducto.Controls.Add(this.txtUtilidad);
            this.gbDatosProducto.Controls.Add(this.label6);
            this.gbDatosProducto.Controls.Add(this.txtDescripcion);
            this.gbDatosProducto.Controls.Add(this.label1);
            this.gbDatosProducto.Controls.Add(this.label5);
            this.gbDatosProducto.Controls.Add(this.txtCodigoBarras);
            this.gbDatosProducto.Controls.Add(this.txtStockAlmacen);
            this.gbDatosProducto.Controls.Add(this.label4);
            this.gbDatosProducto.Controls.Add(this.label3);
            this.gbDatosProducto.Controls.Add(this.txtStock);
            this.gbDatosProducto.Controls.Add(this.txtNombre);
            this.gbDatosProducto.Controls.Add(this.label2);
            this.gbDatosProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatosProducto.Location = new System.Drawing.Point(23, 14);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(887, 419);
            this.gbDatosProducto.TabIndex = 0;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "Datos del producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(242, 35);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(56, 24);
            this.txtIdProducto.TabIndex = 23;
            this.txtIdProducto.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha. ven:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(577, 66);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(150, 24);
            this.dtpDueDate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(18, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(552, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "El precio de venta tiene que ser mayor que el precio de costo, para que se pueda " +
    "calcular la utilidad.";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(577, 324);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(150, 24);
            this.txtPrecioVenta.TabIndex = 19;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(577, 278);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(150, 24);
            this.txtPrecioCosto.TabIndex = 18;
            this.txtPrecioCosto.TextChanged += new System.EventHandler(this.txtPrecioCosto_TextChanged);
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Precio venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio costo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "U.Medida:";
            // 
            // cboUMedida
            // 
            this.cboUMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUMedida.FormattingEnabled = true;
            this.cboUMedida.Location = new System.Drawing.Point(577, 227);
            this.cboUMedida.Name = "cboUMedida";
            this.cboUMedida.Size = new System.Drawing.Size(150, 26);
            this.cboUMedida.TabIndex = 14;
            this.cboUMedida.SelectedIndexChanged += new System.EventHandler(this.cboUMedida_SelectedIndexChanged);
            this.cboUMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUMedida_KeyPress);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(242, 227);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(139, 26);
            this.cboCategoria.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoría:";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUtilidad.Enabled = false;
            this.txtUtilidad.Location = new System.Drawing.Point(577, 373);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(79, 24);
            this.txtUtilidad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Utilidad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(242, 166);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(485, 39);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cód.Barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(242, 65);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(220, 24);
            this.txtCodigoBarras.TabIndex = 6;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // txtStockAlmacen
            // 
            this.txtStockAlmacen.Location = new System.Drawing.Point(242, 324);
            this.txtStockAlmacen.Name = "txtStockAlmacen";
            this.txtStockAlmacen.Size = new System.Drawing.Size(139, 24);
            this.txtStockAlmacen.TabIndex = 5;
            this.txtStockAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAlmacen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock almac:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(242, 279);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(139, 24);
            this.txtStock.TabIndex = 2;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            this.txtStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStock_KeyUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(242, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(485, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // lblAuthAnular
            // 
            this.lblAuthAnular.AutoSize = true;
            this.lblAuthAnular.Enabled = false;
            this.lblAuthAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthAnular.ForeColor = System.Drawing.Color.Maroon;
            this.lblAuthAnular.Location = new System.Drawing.Point(13, 627);
            this.lblAuthAnular.Name = "lblAuthAnular";
            this.lblAuthAnular.Size = new System.Drawing.Size(299, 17);
            this.lblAuthAnular.TabIndex = 3;
            this.lblAuthAnular.Text = "No tiene autorización para anular un producto";
            this.lblAuthAnular.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnMoverStock);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(968, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnMoverStock
            // 
            this.btnMoverStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverStock.Image = global::CapaPresentacion.Properties.Resources.folder_open;
            this.btnMoverStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoverStock.Location = new System.Drawing.Point(36, 329);
            this.btnMoverStock.Name = "btnMoverStock";
            this.btnMoverStock.Size = new System.Drawing.Size(111, 64);
            this.btnMoverStock.TabIndex = 3;
            this.btnMoverStock.Text = "Mover Stock";
            this.btnMoverStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoverStock.UseVisualStyleBackColor = true;
            this.btnMoverStock.Click += new System.EventHandler(this.btnMoverStock_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(36, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 64);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(36, 471);
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
            this.btnExcel.Location = new System.Drawing.Point(36, 401);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 64);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(36, 49);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 64);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(36, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 64);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(36, 189);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 64);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(36, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 64);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 601);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(946, 10);
            this.pb1.TabIndex = 4;
            this.pb1.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(12, 614);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(946, 10);
            this.pb2.TabIndex = 5;
            this.pb2.Visible = false;
            this.pb2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // lblMensajeProceso
            // 
            this.lblMensajeProceso.AutoSize = true;
            this.lblMensajeProceso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensajeProceso.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeProceso.Location = new System.Drawing.Point(708, 631);
            this.lblMensajeProceso.Name = "lblMensajeProceso";
            this.lblMensajeProceso.Size = new System.Drawing.Size(135, 17);
            this.lblMensajeProceso.TabIndex = 6;
            this.lblMensajeProceso.Text = "lblMensajeProceso";
            this.lblMensajeProceso.Visible = false;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 657);
            this.Controls.Add(this.lblMensajeProceso);
            this.Controls.Add(this.lblAuthAnular);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.tbPanelProducto);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormProducts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Productos ::.";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.tbPanelProducto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPanelProducto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgTableProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cboTipoBusqueda;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.Label lblAuthAnular;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUMedida;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.Button btnMoverStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anular;
        private System.Windows.Forms.Button btnCargarExcel;
        private System.Windows.Forms.Label lblMensajeProceso;
    }
}