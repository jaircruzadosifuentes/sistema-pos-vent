namespace CapaPresentacion
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCopiaDeSeguridadBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolDetailUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAbrirCajon = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnAperturaCaja = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.btnNuevaVentaMain = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.copiaSeguridadToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip_ItemAdded);
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.cancel;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contabilidadToolStripMenuItem.Image")));
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.cc;
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem});
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.compra_b1;
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.pOSToolStripMenuItem.Text = "POS - Venta";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.personasToolStripMenuItem,
            this.categoríaToolStripMenuItem,
            this.presentaciónToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.productos_m1;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.cliente_m1;
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.personasToolStripMenuItem.Text = "Personal";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.categoria;
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.categoríaToolStripMenuItem_Click);
            // 
            // presentaciónToolStripMenuItem
            // 
            this.presentaciónToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.documento;
            this.presentaciónToolStripMenuItem.Name = "presentaciónToolStripMenuItem";
            this.presentaciónToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.presentaciónToolStripMenuItem.Text = "Presentación";
            this.presentaciónToolStripMenuItem.Click += new System.EventHandler(this.presentaciónToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.proveedores_m;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónDeValoresToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.cog;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // actualizaciónDeValoresToolStripMenuItem
            // 
            this.actualizaciónDeValoresToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._1484130735_document_03;
            this.actualizaciónDeValoresToolStripMenuItem.Name = "actualizaciónDeValoresToolStripMenuItem";
            this.actualizaciónDeValoresToolStripMenuItem.Size = new System.Drawing.Size(390, 32);
            this.actualizaciónDeValoresToolStripMenuItem.Text = "Actualización de valores y/o asignación permisos";
            this.actualizaciónDeValoresToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónDeValoresToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelSistemaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.report1;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            this.acercaDelSistemaToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.report2;
            this.acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            this.acercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.acercaDelSistemaToolStripMenuItem.Text = "Acerca del Sistema";
            this.acercaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSistemaToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.refresh1;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // copiaSeguridadToolStripMenuItem
            // 
            this.copiaSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarCopiaDeSeguridadBDToolStripMenuItem});
            this.copiaSeguridadToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.db6;
            this.copiaSeguridadToolStripMenuItem.Name = "copiaSeguridadToolStripMenuItem";
            this.copiaSeguridadToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.copiaSeguridadToolStripMenuItem.Text = "Copia Seguridad";
            this.copiaSeguridadToolStripMenuItem.Click += new System.EventHandler(this.copiaSeguridadToolStripMenuItem_Click);
            // 
            // generarCopiaDeSeguridadBDToolStripMenuItem
            // 
            this.generarCopiaDeSeguridadBDToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.ddb8;
            this.generarCopiaDeSeguridadBDToolStripMenuItem.Name = "generarCopiaDeSeguridadBDToolStripMenuItem";
            this.generarCopiaDeSeguridadBDToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.generarCopiaDeSeguridadBDToolStripMenuItem.Text = "Generar Copia de Seguridad BD";
            this.generarCopiaDeSeguridadBDToolStripMenuItem.Click += new System.EventHandler(this.generarCopiaDeSeguridadBDToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDetailUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 33);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolDetailUser
            // 
            this.toolDetailUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDetailUser.Name = "toolDetailUser";
            this.toolDetailUser.Size = new System.Drawing.Size(51, 17);
            this.toolDetailUser.Text = "Estado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(402, 63);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(720, 46);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "SISTEMA - GESTIÓN COMERCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(48, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nueva venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 511);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Operaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 603);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Consultar Prod..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "F6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 464);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "F9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 561);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "F10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cierre de caja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "F3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "Apertura caja";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 97);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "F2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 655);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "F11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 695);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Calculadora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "F7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(53, 418);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 43;
            this.label9.Text = "Abrir cajón";
            // 
            // btnAbrirCajon
            // 
            this.btnAbrirCajon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirCajon.Image = global::CapaPresentacion.Properties.Resources.caja_b;
            this.btnAbrirCajon.Location = new System.Drawing.Point(23, 358);
            this.btnAbrirCajon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbrirCajon.Name = "btnAbrirCajon";
            this.btnAbrirCajon.Size = new System.Drawing.Size(128, 86);
            this.btnAbrirCajon.TabIndex = 42;
            this.btnAbrirCajon.UseVisualStyleBackColor = true;
            this.btnAbrirCajon.Click += new System.EventHandler(this.btnAbrirCajon_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculadora.Image = global::CapaPresentacion.Properties.Resources.calculator;
            this.btnCalculadora.Location = new System.Drawing.Point(23, 635);
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(128, 89);
            this.btnCalculadora.TabIndex = 37;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnAperturaCaja
            // 
            this.btnAperturaCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAperturaCaja.Image = global::CapaPresentacion.Properties.Resources.unlock;
            this.btnAperturaCaja.Location = new System.Drawing.Point(23, 84);
            this.btnAperturaCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(128, 86);
            this.btnAperturaCaja.TabIndex = 33;
            this.btnAperturaCaja.UseVisualStyleBackColor = true;
            this.btnAperturaCaja.Click += new System.EventHandler(this.btnAperturaCaja_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCierreCaja.Image = global::CapaPresentacion.Properties.Resources.lock2;
            this.btnCierreCaja.Location = new System.Drawing.Point(23, 176);
            this.btnCierreCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(128, 86);
            this.btnCierreCaja.TabIndex = 29;
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnConsultar.Location = new System.Drawing.Point(23, 542);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 89);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperaciones.Image = global::CapaPresentacion.Properties.Resources.cc1;
            this.btnOperaciones.Location = new System.Drawing.Point(23, 448);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(128, 89);
            this.btnOperaciones.TabIndex = 18;
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnNuevaVentaMain
            // 
            this.btnNuevaVentaMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaVentaMain.Image = global::CapaPresentacion.Properties.Resources.compra_b1;
            this.btnNuevaVentaMain.Location = new System.Drawing.Point(23, 266);
            this.btnNuevaVentaMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevaVentaMain.Name = "btnNuevaVentaMain";
            this.btnNuevaVentaMain.Size = new System.Drawing.Size(128, 86);
            this.btnNuevaVentaMain.TabIndex = 7;
            this.btnNuevaVentaMain.UseVisualStyleBackColor = true;
            this.btnNuevaVentaMain.Click += new System.EventHandler(this.btnNuevaVentaMain_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAbrirCajon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAperturaCaja);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCierreCaja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevaVentaMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".::MENU PRINCIPAL";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainMenu_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripStatusLabel toolDetailUser;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDeValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevaVentaMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAperturaCaja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem copiaSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarCopiaDeSeguridadBDToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAbrirCajon;
    }
}



