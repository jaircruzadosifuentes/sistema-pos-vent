namespace CapaPresentacion.Sales
{
    partial class FormListadoDeVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodUser = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbSerieNumero = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.dgViewDetalleComprobante = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgViewComprobantes = new System.Windows.Forms.DataGridView();
            this.selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDetalleComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.rbCodUser);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.rbSerieNumero);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(422, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // rbCodUser
            // 
            this.rbCodUser.AutoSize = true;
            this.rbCodUser.Location = new System.Drawing.Point(242, 27);
            this.rbCodUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCodUser.Name = "rbCodUser";
            this.rbCodUser.Size = new System.Drawing.Size(169, 18);
            this.rbCodUser.TabIndex = 3;
            this.rbCodUser.Text = "Cod empleado registro";
            this.rbCodUser.UseVisualStyleBackColor = true;
            this.rbCodUser.CheckedChanged += new System.EventHandler(this.rbCodUser_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(27, 60);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(365, 22);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbSerieNumero
            // 
            this.rbSerieNumero.AutoSize = true;
            this.rbSerieNumero.Checked = true;
            this.rbSerieNumero.Location = new System.Drawing.Point(110, 27);
            this.rbSerieNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSerieNumero.Name = "rbSerieNumero";
            this.rbSerieNumero.Size = new System.Drawing.Size(120, 18);
            this.rbSerieNumero.TabIndex = 1;
            this.rbSerieNumero.TabStop = true;
            this.rbSerieNumero.Text = "Serie y número";
            this.rbSerieNumero.UseVisualStyleBackColor = true;
            this.rbSerieNumero.CheckedChanged += new System.EventHandler(this.rbSerieNumero_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(27, 27);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 18);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // dgViewDetalleComprobante
            // 
            this.dgViewDetalleComprobante.AllowUserToAddRows = false;
            this.dgViewDetalleComprobante.AllowUserToDeleteRows = false;
            this.dgViewDetalleComprobante.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewDetalleComprobante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewDetalleComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewDetalleComprobante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewDetalleComprobante.Location = new System.Drawing.Point(16, 470);
            this.dgViewDetalleComprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgViewDetalleComprobante.Name = "dgViewDetalleComprobante";
            this.dgViewDetalleComprobante.ReadOnly = true;
            this.dgViewDetalleComprobante.RowHeadersWidth = 51;
            this.dgViewDetalleComprobante.RowTemplate.Height = 24;
            this.dgViewDetalleComprobante.Size = new System.Drawing.Size(774, 156);
            this.dgViewDetalleComprobante.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCantidad.Location = new System.Drawing.Point(14, 396);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(78, 14);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "lblCantidad";
            // 
            // dgViewComprobantes
            // 
            this.dgViewComprobantes.AllowUserToAddRows = false;
            this.dgViewComprobantes.AllowUserToDeleteRows = false;
            this.dgViewComprobantes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgViewComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecciona});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewComprobantes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgViewComprobantes.Location = new System.Drawing.Point(16, 207);
            this.dgViewComprobantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgViewComprobantes.Name = "dgViewComprobantes";
            this.dgViewComprobantes.ReadOnly = true;
            this.dgViewComprobantes.RowHeadersWidth = 51;
            this.dgViewComprobantes.RowTemplate.Height = 24;
            this.dgViewComprobantes.Size = new System.Drawing.Size(774, 185);
            this.dgViewComprobantes.TabIndex = 9;
            this.dgViewComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewComprobantes_CellContentClick);
            this.dgViewComprobantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgViewComprobantes_CellFormatting);
            // 
            // selecciona
            // 
            this.selecciona.HeaderText = "Item";
            this.selecciona.MinimumWidth = 6;
            this.selecciona.Name = "selecciona";
            this.selecciona.ReadOnly = true;
            this.selecciona.Width = 60;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.Ver_recibo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(622, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Visualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(449, 111);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 53);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Actualizar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.door_in1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(708, 111);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 53);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Image = global::CapaPresentacion.Properties.Resources.Buscar_p3;
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerDetalle.Location = new System.Drawing.Point(678, 407);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(112, 51);
            this.btnVerDetalle.TabIndex = 12;
            this.btnVerDetalle.Text = "Mostrar detalle";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources._1484132302_document_print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(536, 111);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 53);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir ";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormListadoDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgViewDetalleComprobante);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgViewComprobantes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormListadoDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: LISTADO DE VENTAS ::.";
            this.Load += new System.EventHandler(this.FormListadoDeVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDetalleComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCodUser;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbSerieNumero;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgViewDetalleComprobante;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgViewComprobantes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecciona;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}