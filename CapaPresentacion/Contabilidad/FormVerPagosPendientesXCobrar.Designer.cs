namespace CapaPresentacion.Contabilidad
{
    partial class FormVerPagosPendientesXCobrar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodUser = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbSerieNumero = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgViewComprobantes = new System.Windows.Forms.DataGridView();
            this.selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPagarCredito = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtAmortizado = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(210, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 118);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // rbCodUser
            // 
            this.rbCodUser.AutoSize = true;
            this.rbCodUser.Location = new System.Drawing.Point(309, 33);
            this.rbCodUser.Name = "rbCodUser";
            this.rbCodUser.Size = new System.Drawing.Size(199, 22);
            this.rbCodUser.TabIndex = 3;
            this.rbCodUser.TabStop = true;
            this.rbCodUser.Text = "Cod empleado registro";
            this.rbCodUser.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(36, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(472, 26);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbSerieNumero
            // 
            this.rbSerieNumero.AutoSize = true;
            this.rbSerieNumero.Location = new System.Drawing.Point(146, 33);
            this.rbSerieNumero.Name = "rbSerieNumero";
            this.rbSerieNumero.Size = new System.Drawing.Size(143, 22);
            this.rbSerieNumero.TabIndex = 1;
            this.rbSerieNumero.TabStop = true;
            this.rbSerieNumero.Text = "Serie y número";
            this.rbSerieNumero.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Location = new System.Drawing.Point(36, 33);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(79, 22);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCantidad.Location = new System.Drawing.Point(207, 242);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 18);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "lblCantidad";
            // 
            // dgViewComprobantes
            // 
            this.dgViewComprobantes.AllowUserToAddRows = false;
            this.dgViewComprobantes.AllowUserToDeleteRows = false;
            this.dgViewComprobantes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecciona});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewComprobantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewComprobantes.Location = new System.Drawing.Point(210, 263);
            this.dgViewComprobantes.Name = "dgViewComprobantes";
            this.dgViewComprobantes.ReadOnly = true;
            this.dgViewComprobantes.RowHeadersWidth = 51;
            this.dgViewComprobantes.RowTemplate.Height = 24;
            this.dgViewComprobantes.Size = new System.Drawing.Size(1115, 335);
            this.dgViewComprobantes.TabIndex = 19;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnPagarCredito);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 509);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::CapaPresentacion.Properties.Resources._32Excel_icon3;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(24, 124);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(117, 76);
            this.btnExcel.TabIndex = 27;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPagarCredito
            // 
            this.btnPagarCredito.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCredito.Image = global::CapaPresentacion.Properties.Resources._1484370611_invoice;
            this.btnPagarCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagarCredito.Location = new System.Drawing.Point(24, 42);
            this.btnPagarCredito.Name = "btnPagarCredito";
            this.btnPagarCredito.Size = new System.Drawing.Size(117, 76);
            this.btnPagarCredito.TabIndex = 26;
            this.btnPagarCredito.Text = "Pagar crédito";
            this.btnPagarCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagarCredito.UseVisualStyleBackColor = true;
            this.btnPagarCredito.Click += new System.EventHandler(this.btnPagarCredito_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.door_in1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(24, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 71);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "CRÉDITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(969, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "AMORTIZADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1164, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "DEUDA";
            // 
            // txtCredito
            // 
            this.txtCredito.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(781, 160);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.Size = new System.Drawing.Size(136, 29);
            this.txtCredito.TabIndex = 31;
            this.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmortizado
            // 
            this.txtAmortizado.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmortizado.Location = new System.Drawing.Point(954, 160);
            this.txtAmortizado.Name = "txtAmortizado";
            this.txtAmortizado.ReadOnly = true;
            this.txtAmortizado.Size = new System.Drawing.Size(136, 29);
            this.txtAmortizado.TabIndex = 32;
            this.txtAmortizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.Location = new System.Drawing.Point(1124, 160);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.ReadOnly = true;
            this.txtDeuda.Size = new System.Drawing.Size(136, 29);
            this.txtDeuda.TabIndex = 33;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(210, 604);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1115, 12);
            this.pb1.TabIndex = 34;
            this.pb1.Visible = false;
            // 
            // FormVerPagosPendientesXCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 628);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtAmortizado);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgViewComprobantes);
            this.MaximizeBox = false;
            this.Name = "FormVerPagosPendientesXCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: PAGOS PENDIENTES POR COBRAR ::.";
            this.Load += new System.EventHandler(this.FormVerPagosPendientesXCobrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCodUser;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbSerieNumero;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgViewComprobantes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecciona;
        private System.Windows.Forms.Button btnPagarCredito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtAmortizado;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ProgressBar pb1;
    }
}