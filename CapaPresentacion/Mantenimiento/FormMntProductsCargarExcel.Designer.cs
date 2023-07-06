namespace CapaPresentacion.Mantenimiento
{
    partial class FormMntProductsCargarExcel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegistrosBad = new System.Windows.Forms.Label();
            this.rbActualiza = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgViewInventario = new System.Windows.Forms.DataGridView();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.txtArchivoRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogErrores = new System.Windows.Forms.Button();
            this.btnFormato = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnLogErrores);
            this.groupBox1.Controls.Add(this.lblRegistrosBad);
            this.groupBox1.Controls.Add(this.rbActualiza);
            this.groupBox1.Controls.Add(this.rbIngreso);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblItems);
            this.groupBox1.Controls.Add(this.dgViewInventario);
            this.groupBox1.Controls.Add(this.btnCargarArchivo);
            this.groupBox1.Controls.Add(this.txtArchivoRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar archivo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRegistrosBad
            // 
            this.lblRegistrosBad.AutoSize = true;
            this.lblRegistrosBad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRegistrosBad.Location = new System.Drawing.Point(28, 154);
            this.lblRegistrosBad.Name = "lblRegistrosBad";
            this.lblRegistrosBad.Size = new System.Drawing.Size(117, 17);
            this.lblRegistrosBad.TabIndex = 10;
            this.lblRegistrosBad.Text = "lblRegistrosBad";
            this.lblRegistrosBad.Visible = false;
            this.lblRegistrosBad.Click += new System.EventHandler(this.lblRegistrosBad_Click);
            // 
            // rbActualiza
            // 
            this.rbActualiza.AutoSize = true;
            this.rbActualiza.Location = new System.Drawing.Point(209, 35);
            this.rbActualiza.Name = "rbActualiza";
            this.rbActualiza.Size = new System.Drawing.Size(215, 21);
            this.rbActualiza.TabIndex = 8;
            this.rbActualiza.Text = "Actualización de inventario";
            this.rbActualiza.UseVisualStyleBackColor = true;
            this.rbActualiza.CheckedChanged += new System.EventHandler(this.rbActualiza_CheckedChanged);
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Checked = true;
            this.rbIngreso.Location = new System.Drawing.Point(31, 35);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(147, 21);
            this.rbIngreso.TabIndex = 7;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Nuevo inventario";
            this.rbIngreso.UseVisualStyleBackColor = true;
            this.rbIngreso.CheckedChanged += new System.EventHandler(this.rbIngreso_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFormato);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnProcesar);
            this.groupBox2.Location = new System.Drawing.Point(839, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 322);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.ForeColor = System.Drawing.Color.DarkRed;
            this.lblItems.Location = new System.Drawing.Point(31, 404);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(63, 17);
            this.lblItems.TabIndex = 4;
            this.lblItems.Text = "lblItems";
            this.lblItems.Visible = false;
            // 
            // dgViewInventario
            // 
            this.dgViewInventario.AllowUserToAddRows = false;
            this.dgViewInventario.AllowUserToDeleteRows = false;
            this.dgViewInventario.AllowUserToOrderColumns = true;
            this.dgViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInventario.Location = new System.Drawing.Point(31, 177);
            this.dgViewInventario.Name = "dgViewInventario";
            this.dgViewInventario.ReadOnly = true;
            this.dgViewInventario.RowHeadersWidth = 51;
            this.dgViewInventario.RowTemplate.Height = 24;
            this.dgViewInventario.Size = new System.Drawing.Size(778, 222);
            this.dgViewInventario.TabIndex = 3;
            this.dgViewInventario.Visible = false;
            this.dgViewInventario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgViewInventario_CellFormatting);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCargarArchivo.Location = new System.Drawing.Point(693, 78);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(116, 43);
            this.btnCargarArchivo.TabIndex = 2;
            this.btnCargarArchivo.Text = "Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // txtArchivoRuta
            // 
            this.txtArchivoRuta.Location = new System.Drawing.Point(100, 88);
            this.txtArchivoRuta.Name = "txtArchivoRuta";
            this.txtArchivoRuta.ReadOnly = true;
            this.txtArchivoRuta.Size = new System.Drawing.Size(567, 23);
            this.txtArchivoRuta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo:";
            // 
            // btnLogErrores
            // 
            this.btnLogErrores.Location = new System.Drawing.Point(693, 142);
            this.btnLogErrores.Name = "btnLogErrores";
            this.btnLogErrores.Size = new System.Drawing.Size(116, 29);
            this.btnLogErrores.TabIndex = 11;
            this.btnLogErrores.Text = "Ver errores";
            this.btnLogErrores.UseVisualStyleBackColor = true;
            this.btnLogErrores.Visible = false;
            this.btnLogErrores.Click += new System.EventHandler(this.btnLogErrores_Click);
            // 
            // btnFormato
            // 
            this.btnFormato.Image = global::CapaPresentacion.Properties.Resources._32Excel_icon2;
            this.btnFormato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFormato.Location = new System.Drawing.Point(37, 92);
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(113, 65);
            this.btnFormato.TabIndex = 8;
            this.btnFormato.Text = "Formato";
            this.btnFormato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormato.UseVisualStyleBackColor = true;
            this.btnFormato.Click += new System.EventHandler(this.btnFormato_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources._1484136266_Log_Out8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(37, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 65);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources._1484130522_3floppy_unmount3;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(37, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 65);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::CapaPresentacion.Properties.Resources.ok1;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcesar.Location = new System.Drawing.Point(37, 22);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(113, 65);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // FormMntProductsCargarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 549);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMntProductsCargarExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Cargar Excel - Inventario Masivo ::.";
            this.Load += new System.EventHandler(this.FormMntProductsCargarExcel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivoRuta;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.DataGridView dgViewInventario;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnFormato;
        private System.Windows.Forms.RadioButton rbActualiza;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.Label lblRegistrosBad;
        private System.Windows.Forms.Button btnLogErrores;
    }
}