namespace CapaPresentacion.Contabilidad
{
    partial class FormPagarCreditoEfectivo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMontoAmortizado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontoDeuda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMontoCredito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMontoAmortizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgDetallePagos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.door_in1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(762, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 63);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblMontoAmortizado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMontoDeuda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMontoCredito);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.lblCorrelativo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 188);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del comprobante";
            // 
            // lblMontoAmortizado
            // 
            this.lblMontoAmortizado.AutoSize = true;
            this.lblMontoAmortizado.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMontoAmortizado.Location = new System.Drawing.Point(158, 156);
            this.lblMontoAmortizado.Name = "lblMontoAmortizado";
            this.lblMontoAmortizado.Size = new System.Drawing.Size(148, 17);
            this.lblMontoAmortizado.TabIndex = 9;
            this.lblMontoAmortizado.Text = "lblMontoAmortizado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto Amort...:";
            // 
            // lblMontoDeuda
            // 
            this.lblMontoDeuda.AutoSize = true;
            this.lblMontoDeuda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMontoDeuda.Location = new System.Drawing.Point(158, 124);
            this.lblMontoDeuda.Name = "lblMontoDeuda";
            this.lblMontoDeuda.Size = new System.Drawing.Size(112, 17);
            this.lblMontoDeuda.TabIndex = 7;
            this.lblMontoDeuda.Text = "lblMontoDeuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto Deuda:";
            // 
            // lblMontoCredito
            // 
            this.lblMontoCredito.AutoSize = true;
            this.lblMontoCredito.Location = new System.Drawing.Point(158, 93);
            this.lblMontoCredito.Name = "lblMontoCredito";
            this.lblMontoCredito.Size = new System.Drawing.Size(118, 17);
            this.lblMontoCredito.TabIndex = 5;
            this.lblMontoCredito.Text = "lblMontoCredito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto Crédito:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(158, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 17);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "lblCliente";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(66, 61);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 17);
            this.label45.TabIndex = 2;
            this.label45.Text = "Cliente:";
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AutoSize = true;
            this.lblCorrelativo.Location = new System.Drawing.Point(158, 33);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(99, 17);
            this.lblCorrelativo.TabIndex = 1;
            this.lblCorrelativo.Text = "lblCorrelativo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Correlativo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(152, 330);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(593, 67);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtMontoAmortizar
            // 
            this.txtMontoAmortizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAmortizar.Location = new System.Drawing.Point(152, 299);
            this.txtMontoAmortizar.Name = "txtMontoAmortizar";
            this.txtMontoAmortizar.Size = new System.Drawing.Size(179, 26);
            this.txtMontoAmortizar.TabIndex = 28;
            this.txtMontoAmortizar.TextChanged += new System.EventHandler(this.txtMontoAmortizar_TextChanged);
            this.txtMontoAmortizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoAmortizar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descripción:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources._1484130522_3floppy_unmount2;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(762, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 63);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgDetallePagos
            // 
            this.dgDetallePagos.AllowUserToAddRows = false;
            this.dgDetallePagos.AllowUserToDeleteRows = false;
            this.dgDetallePagos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetallePagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetallePagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetallePagos.Location = new System.Drawing.Point(36, 446);
            this.dgDetallePagos.Name = "dgDetallePagos";
            this.dgDetallePagos.ReadOnly = true;
            this.dgDetallePagos.RowHeadersWidth = 51;
            this.dgDetallePagos.RowTemplate.Height = 24;
            this.dgDetallePagos.Size = new System.Drawing.Size(709, 206);
            this.dgDetallePagos.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(37, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Detalle de pagos";
            // 
            // FormPagarCreditoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 693);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgDetallePagos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoAmortizar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.Name = "FormPagarCreditoEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: PAGAR CRÉDITO ::.";
            this.Load += new System.EventHandler(this.FormPagarCreditoEfectivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMontoAmortizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label lblMontoCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMontoDeuda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMontoAmortizado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgDetallePagos;
        private System.Windows.Forms.Label label7;
    }
}