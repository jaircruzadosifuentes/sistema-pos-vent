namespace CapaPresentacion.Contabilidad
{
    partial class FormCierreCajaChica
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
            this.txtEsperadoEnCaja = new System.Windows.Forms.TextBox();
            this.txtMontoVendido = new System.Windows.Forms.TextBox();
            this.txtMontoEgreso = new System.Windows.Forms.TextBox();
            this.txtMontoAperturado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgViewComprobantes = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtEsperadoEnCaja);
            this.groupBox1.Controls.Add(this.txtMontoVendido);
            this.groupBox1.Controls.Add(this.txtMontoEgreso);
            this.groupBox1.Controls.Add(this.txtMontoAperturado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de monto al día aperturado";
            // 
            // txtEsperadoEnCaja
            // 
            this.txtEsperadoEnCaja.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsperadoEnCaja.Location = new System.Drawing.Point(566, 81);
            this.txtEsperadoEnCaja.Multiline = true;
            this.txtEsperadoEnCaja.Name = "txtEsperadoEnCaja";
            this.txtEsperadoEnCaja.ReadOnly = true;
            this.txtEsperadoEnCaja.Size = new System.Drawing.Size(139, 39);
            this.txtEsperadoEnCaja.TabIndex = 7;
            this.txtEsperadoEnCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoVendido
            // 
            this.txtMontoVendido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoVendido.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMontoVendido.Location = new System.Drawing.Point(362, 81);
            this.txtMontoVendido.Multiline = true;
            this.txtMontoVendido.Name = "txtMontoVendido";
            this.txtMontoVendido.ReadOnly = true;
            this.txtMontoVendido.Size = new System.Drawing.Size(139, 39);
            this.txtMontoVendido.TabIndex = 6;
            this.txtMontoVendido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoEgreso
            // 
            this.txtMontoEgreso.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoEgreso.ForeColor = System.Drawing.Color.DarkRed;
            this.txtMontoEgreso.Location = new System.Drawing.Point(198, 81);
            this.txtMontoEgreso.Multiline = true;
            this.txtMontoEgreso.Name = "txtMontoEgreso";
            this.txtMontoEgreso.ReadOnly = true;
            this.txtMontoEgreso.Size = new System.Drawing.Size(139, 39);
            this.txtMontoEgreso.TabIndex = 5;
            this.txtMontoEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMontoAperturado
            // 
            this.txtMontoAperturado.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAperturado.Location = new System.Drawing.Point(28, 81);
            this.txtMontoAperturado.Multiline = true;
            this.txtMontoAperturado.Name = "txtMontoAperturado";
            this.txtMontoAperturado.ReadOnly = true;
            this.txtMontoAperturado.Size = new System.Drawing.Size(139, 39);
            this.txtMontoAperturado.TabIndex = 4;
            this.txtMontoAperturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto esperado en caja chica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(359, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto vendido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(195, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mongo egreso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto aperturado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(800, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha actual: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidad.Location = new System.Drawing.Point(23, 317);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 17);
            this.lblCantidad.TabIndex = 4;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewComprobantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewComprobantes.Location = new System.Drawing.Point(26, 347);
            this.dgViewComprobantes.Name = "dgViewComprobantes";
            this.dgViewComprobantes.ReadOnly = true;
            this.dgViewComprobantes.RowHeadersWidth = 51;
            this.dgViewComprobantes.RowTemplate.Height = 24;
            this.dgViewComprobantes.Size = new System.Drawing.Size(1081, 251);
            this.dgViewComprobantes.TabIndex = 5;
            this.dgViewComprobantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgViewComprobantes_CellFormatting);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources._32Excel_icon;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(829, 224);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 70);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Excel";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources._1484136266_Log_Out2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(966, 609);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 61);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Image = global::CapaPresentacion.Properties.Resources._lock;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarCaja.Location = new System.Drawing.Point(970, 224);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(137, 70);
            this.btnCerrarCaja.TabIndex = 3;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(26, 612);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(924, 10);
            this.pb1.TabIndex = 8;
            this.pb1.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(26, 628);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(924, 10);
            this.pb2.TabIndex = 9;
            this.pb2.Visible = false;
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaActual.Location = new System.Drawing.Point(922, 95);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.ReadOnly = true;
            this.txtFechaActual.Size = new System.Drawing.Size(185, 26);
            this.txtFechaActual.TabIndex = 10;
            // 
            // FormCierreCajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 682);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgViewComprobantes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormCierreCajaChica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: CIERRE DE CAJA - CUADRE DE CAJA CHICA ::.";
            this.Load += new System.EventHandler(this.FormCierreCajaChica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEsperadoEnCaja;
        private System.Windows.Forms.TextBox txtMontoVendido;
        private System.Windows.Forms.TextBox txtMontoEgreso;
        private System.Windows.Forms.TextBox txtMontoAperturado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgViewComprobantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.TextBox txtFechaActual;
    }
}