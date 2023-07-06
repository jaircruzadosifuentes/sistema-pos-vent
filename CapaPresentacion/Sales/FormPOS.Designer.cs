namespace CapaPresentacion.Sales
{
    partial class FormPOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblIgv = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresasOPersonas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgSaleProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnLacteos = new System.Windows.Forms.Button();
            this.btnGaseosas = new System.Windows.Forms.Button();
            this.btnAbarrotes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreEtiqueta = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.Cod_Barras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.rbNombreDesc = new System.Windows.Forms.RadioButton();
            this.rbCodigoBarras = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblIgv);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtEmpresasOPersonas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCredito);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.dgSaleProducts);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de ventas - POS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(420, 32);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(55, 23);
            this.txtIdCliente.TabIndex = 23;
            this.txtIdCliente.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(378, 553);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ReadOnly = true;
            this.lblTotal.Size = new System.Drawing.Size(113, 26);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIgv
            // 
            this.lblIgv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgv.Location = new System.Drawing.Point(378, 500);
            this.lblIgv.Name = "lblIgv";
            this.lblIgv.ReadOnly = true;
            this.lblIgv.Size = new System.Drawing.Size(114, 26);
            this.lblIgv.TabIndex = 20;
            this.lblIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(378, 465);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.ReadOnly = true;
            this.lblSubTotal.Size = new System.Drawing.Size(115, 26);
            this.lblSubTotal.TabIndex = 19;
            this.lblSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Empresas y/o personas:";
            // 
            // txtEmpresasOPersonas
            // 
            this.txtEmpresasOPersonas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresasOPersonas.Location = new System.Drawing.Point(20, 61);
            this.txtEmpresasOPersonas.Name = "txtEmpresasOPersonas";
            this.txtEmpresasOPersonas.Size = new System.Drawing.Size(455, 26);
            this.txtEmpresasOPersonas.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sub total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "IGV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "S/. Total:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 538);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 55);
            this.textBox1.TabIndex = 5;
            // 
            // dgSaleProducts
            // 
            this.dgSaleProducts.AllowUserToAddRows = false;
            this.dgSaleProducts.AllowUserToOrderColumns = true;
            this.dgSaleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleProducts.Location = new System.Drawing.Point(20, 149);
            this.dgSaleProducts.Name = "dgSaleProducts";
            this.dgSaleProducts.ReadOnly = true;
            this.dgSaleProducts.RowHeadersWidth = 51;
            this.dgSaleProducts.RowTemplate.Height = 24;
            this.dgSaleProducts.Size = new System.Drawing.Size(503, 299);
            this.dgSaleProducts.TabIndex = 0;
            this.dgSaleProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleProducts_CellContentClick);
            this.dgSaleProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleProducts_CellDoubleClick);
            this.dgSaleProducts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaleProducts_CellEnter);
            this.dgSaleProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgSaleProducts_RowsAdded);
            this.dgSaleProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgSaleProducts_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.rbCodigoBarras);
            this.groupBox2.Controls.Add(this.rbNombreDesc);
            this.groupBox2.Controls.Add(this.btnGeneral);
            this.groupBox2.Controls.Add(this.btnPan);
            this.groupBox2.Controls.Add(this.btnLacteos);
            this.groupBox2.Controls.Add(this.btnGaseosas);
            this.groupBox2.Controls.Add(this.btnAbarrotes);
            this.groupBox2.Controls.Add(this.btnBuscarProductos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNombreEtiqueta);
            this.groupBox2.Controls.Add(this.txtCodigoBarras);
            this.groupBox2.Controls.Add(this.lvProducts);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(572, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 680);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnGeneral
            // 
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneral.Location = new System.Drawing.Point(755, 118);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(138, 41);
            this.btnGeneral.TabIndex = 9;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnPan
            // 
            this.btnPan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPan.Location = new System.Drawing.Point(574, 118);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(149, 41);
            this.btnPan.TabIndex = 8;
            this.btnPan.Text = "Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnLacteos
            // 
            this.btnLacteos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLacteos.Location = new System.Drawing.Point(394, 118);
            this.btnLacteos.Name = "btnLacteos";
            this.btnLacteos.Size = new System.Drawing.Size(149, 41);
            this.btnLacteos.TabIndex = 7;
            this.btnLacteos.Text = "Lácteos";
            this.btnLacteos.UseVisualStyleBackColor = true;
            this.btnLacteos.Click += new System.EventHandler(this.btnLacteos_Click);
            // 
            // btnGaseosas
            // 
            this.btnGaseosas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGaseosas.Location = new System.Drawing.Point(205, 118);
            this.btnGaseosas.Name = "btnGaseosas";
            this.btnGaseosas.Size = new System.Drawing.Size(149, 41);
            this.btnGaseosas.TabIndex = 6;
            this.btnGaseosas.Text = "Gaseosas";
            this.btnGaseosas.UseVisualStyleBackColor = true;
            this.btnGaseosas.Click += new System.EventHandler(this.btnGaseosas_Click);
            // 
            // btnAbarrotes
            // 
            this.btnAbarrotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbarrotes.Location = new System.Drawing.Point(20, 118);
            this.btnAbarrotes.Name = "btnAbarrotes";
            this.btnAbarrotes.Size = new System.Drawing.Size(149, 41);
            this.btnAbarrotes.TabIndex = 5;
            this.btnAbarrotes.Text = "Abarrotes";
            this.btnAbarrotes.UseVisualStyleBackColor = true;
            this.btnAbarrotes.Click += new System.EventHandler(this.btnAbarrotes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo de búsqueda:";
            // 
            // lblNombreEtiqueta
            // 
            this.lblNombreEtiqueta.AutoSize = true;
            this.lblNombreEtiqueta.Location = new System.Drawing.Point(118, 52);
            this.lblNombreEtiqueta.Name = "lblNombreEtiqueta";
            this.lblNombreEtiqueta.Size = new System.Drawing.Size(93, 17);
            this.lblNombreEtiqueta.TabIndex = 2;
            this.lblNombreEtiqueta.Text = "Cód.Barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(121, 72);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(772, 24);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lvProducts
            // 
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod_Barras,
            this.Producto,
            this.Cantidad,
            this.Precio});
            this.lvProducts.HideSelection = false;
            this.lvProducts.LabelEdit = true;
            this.lvProducts.LargeImageList = this.imgList;
            this.lvProducts.Location = new System.Drawing.Point(20, 182);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(873, 481);
            this.lvProducts.SmallImageList = this.imgList;
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.ItemActivate += new System.EventHandler(this.lvProducts_ItemActivate);
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            this.lvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseClick);
            this.lvProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDoubleClick);
            // 
            // Cod_Barras
            // 
            this.Cod_Barras.Text = "Cod_Barras";
            this.Cod_Barras.Width = 90;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 90;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 90;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "15390730_1148819508505315_2204003316119906720_n.jpg");
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscarProductos.Location = new System.Drawing.Point(20, 61);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(45, 34);
            this.btnBuscarProductos.TabIndex = 4;
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::CapaPresentacion.Properties.Resources.error2;
            this.btnQuitar.Location = new System.Drawing.Point(20, 107);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 36);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources._1484136266_Log_Out;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(360, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 47);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(481, 54);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(42, 35);
            this.btnBuscarCliente.TabIndex = 10;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Image = global::CapaPresentacion.Properties.Resources.coins_add1;
            this.btnCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.Location = new System.Drawing.Point(20, 616);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(163, 47);
            this.btnCredito.TabIndex = 4;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Image = global::CapaPresentacion.Properties.Resources._1484370701_Sales_by_Payment_Method_rep;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(189, 616);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(165, 47);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar ";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // rbNombreDesc
            // 
            this.rbNombreDesc.AutoSize = true;
            this.rbNombreDesc.Location = new System.Drawing.Point(383, 22);
            this.rbNombreDesc.Name = "rbNombreDesc";
            this.rbNombreDesc.Size = new System.Drawing.Size(195, 21);
            this.rbNombreDesc.TabIndex = 10;
            this.rbNombreDesc.Text = "Nombre y/o descripción";
            this.rbNombreDesc.UseVisualStyleBackColor = true;
            this.rbNombreDesc.CheckedChanged += new System.EventHandler(this.rbNombreDesc_CheckedChanged);
            // 
            // rbCodigoBarras
            // 
            this.rbCodigoBarras.AutoSize = true;
            this.rbCodigoBarras.Checked = true;
            this.rbCodigoBarras.Location = new System.Drawing.Point(239, 22);
            this.rbCodigoBarras.Name = "rbCodigoBarras";
            this.rbCodigoBarras.Size = new System.Drawing.Size(128, 21);
            this.rbCodigoBarras.TabIndex = 11;
            this.rbCodigoBarras.TabStop = true;
            this.rbCodigoBarras.Text = "Código barras";
            this.rbCodigoBarras.UseVisualStyleBackColor = true;
            this.rbCodigoBarras.CheckedChanged += new System.EventHandler(this.rbCodigoBarras_CheckedChanged);
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 793);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Venta POS ::.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPOS_FormClosing);
            this.Load += new System.EventHandler(this.FormPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPOS_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgSaleProducts;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label lblNombreEtiqueta;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.Button btnAbarrotes;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnLacteos;
        private System.Windows.Forms.Button btnGaseosas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cod_Barras;
        private System.Windows.Forms.TextBox lblSubTotal;
        private System.Windows.Forms.TextBox lblIgv;
        private System.Windows.Forms.TextBox lblTotal;
        public System.Windows.Forms.TextBox txtEmpresasOPersonas;
        public System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.RadioButton rbCodigoBarras;
        private System.Windows.Forms.RadioButton rbNombreDesc;
    }
}