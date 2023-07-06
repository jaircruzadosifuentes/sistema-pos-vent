namespace CapaPresentacion.Sales
{
    partial class FormExtornoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgViewComprobantes = new System.Windows.Forms.DataGridView();
            this.selecciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExtornar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodUser = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbSerieNumero = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtGlosa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgViewComprobantes.Location = new System.Drawing.Point(40, 217);
            this.dgViewComprobantes.Name = "dgViewComprobantes";
            this.dgViewComprobantes.ReadOnly = true;
            this.dgViewComprobantes.RowHeadersWidth = 51;
            this.dgViewComprobantes.RowTemplate.Height = 24;
            this.dgViewComprobantes.Size = new System.Drawing.Size(1032, 236);
            this.dgViewComprobantes.TabIndex = 10;
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
            // btnExtornar
            // 
            this.btnExtornar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtornar.Location = new System.Drawing.Point(803, 492);
            this.btnExtornar.Name = "btnExtornar";
            this.btnExtornar.Size = new System.Drawing.Size(129, 38);
            this.btnExtornar.TabIndex = 11;
            this.btnExtornar.Text = "Extornar";
            this.btnExtornar.UseVisualStyleBackColor = true;
            this.btnExtornar.Click += new System.EventHandler(this.btnExtornar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(943, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 38);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.rbCodUser);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.rbSerieNumero);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // rbCodUser
            // 
            this.rbCodUser.AutoSize = true;
            this.rbCodUser.Location = new System.Drawing.Point(322, 33);
            this.rbCodUser.Name = "rbCodUser";
            this.rbCodUser.Size = new System.Drawing.Size(199, 22);
            this.rbCodUser.TabIndex = 3;
            this.rbCodUser.Text = "Cod empleado registro";
            this.rbCodUser.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(36, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(485, 26);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rbSerieNumero
            // 
            this.rbSerieNumero.AutoSize = true;
            this.rbSerieNumero.Checked = true;
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
            this.rbCliente.Location = new System.Drawing.Point(36, 33);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(79, 22);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // txtGlosa
            // 
            this.txtGlosa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.Location = new System.Drawing.Point(40, 483);
            this.txtGlosa.Multiline = true;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGlosa.Size = new System.Drawing.Size(521, 47);
            this.txtGlosa.TabIndex = 14;
            this.txtGlosa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlosa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Justificación";
            // 
            // FormExtornoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExtornar);
            this.Controls.Add(this.dgViewComprobantes);
            this.Name = "FormExtornoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::Extorno - Anulación de venta::.";
            this.Load += new System.EventHandler(this.FormExtornoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewComprobantes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecciona;
        private System.Windows.Forms.Button btnExtornar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCodUser;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbSerieNumero;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.TextBox txtGlosa;
        private System.Windows.Forms.Label label1;
    }
}