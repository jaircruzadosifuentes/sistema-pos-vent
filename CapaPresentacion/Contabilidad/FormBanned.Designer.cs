namespace CapaPresentacion.Contabilidad
{
    partial class FormBanned
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgDataBanned = new System.Windows.Forms.DataGridView();
            this.chkHabilitar = new System.Windows.Forms.CheckBox();
            this.txtCodigoOperacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Vista = new System.Windows.Forms.TabPage();
            this.chKHabilita = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnHabilita = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataBanned)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Vista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(368, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TITULO DEL FORMULARIO";
            // 
            // dgDataBanned
            // 
            this.dgDataBanned.AllowUserToAddRows = false;
            this.dgDataBanned.AllowUserToDeleteRows = false;
            this.dgDataBanned.AllowUserToOrderColumns = true;
            this.dgDataBanned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataBanned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chKHabilita});
            this.dgDataBanned.Location = new System.Drawing.Point(21, 126);
            this.dgDataBanned.Name = "dgDataBanned";
            this.dgDataBanned.ReadOnly = true;
            this.dgDataBanned.RowHeadersWidth = 51;
            this.dgDataBanned.RowTemplate.Height = 24;
            this.dgDataBanned.Size = new System.Drawing.Size(1059, 278);
            this.dgDataBanned.TabIndex = 1;
            this.dgDataBanned.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDataBanned_CellContentClick);
            // 
            // chkHabilitar
            // 
            this.chkHabilitar.AutoSize = true;
            this.chkHabilitar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkHabilitar.Location = new System.Drawing.Point(21, 98);
            this.chkHabilitar.Name = "chkHabilitar";
            this.chkHabilitar.Size = new System.Drawing.Size(153, 22);
            this.chkHabilitar.TabIndex = 2;
            this.chkHabilitar.Text = "¿Habilitar registro?";
            this.chkHabilitar.UseVisualStyleBackColor = false;
            this.chkHabilitar.CheckedChanged += new System.EventHandler(this.chkHabilitar_CheckedChanged);
            // 
            // txtCodigoOperacion
            // 
            this.txtCodigoOperacion.Enabled = false;
            this.txtCodigoOperacion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoOperacion.Location = new System.Drawing.Point(21, 35);
            this.txtCodigoOperacion.Name = "txtCodigoOperacion";
            this.txtCodigoOperacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoOperacion.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoOperacion.TabIndex = 3;
            this.txtCodigoOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cód. operación";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Vista);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 497);
            this.tabControl1.TabIndex = 5;
            // 
            // Vista
            // 
            this.Vista.Controls.Add(this.btnSalir);
            this.Vista.Controls.Add(this.btnHabilita);
            this.Vista.Controls.Add(this.label1);
            this.Vista.Controls.Add(this.chkHabilitar);
            this.Vista.Controls.Add(this.txtCodigoOperacion);
            this.Vista.Controls.Add(this.dgDataBanned);
            this.Vista.Controls.Add(this.lblTitle);
            this.Vista.Location = new System.Drawing.Point(4, 27);
            this.Vista.Name = "Vista";
            this.Vista.Padding = new System.Windows.Forms.Padding(3);
            this.Vista.Size = new System.Drawing.Size(1103, 466);
            this.Vista.TabIndex = 0;
            this.Vista.Text = "Vista";
            this.Vista.UseVisualStyleBackColor = true;
            // 
            // chKHabilita
            // 
            this.chKHabilita.HeaderText = "Habilitar";
            this.chKHabilita.MinimumWidth = 6;
            this.chKHabilita.Name = "chKHabilita";
            this.chKHabilita.ReadOnly = true;
            this.chKHabilita.Width = 125;
            // 
            // btnHabilita
            // 
            this.btnHabilita.Enabled = false;
            this.btnHabilita.Location = new System.Drawing.Point(818, 420);
            this.btnHabilita.Name = "btnHabilita";
            this.btnHabilita.Size = new System.Drawing.Size(127, 33);
            this.btnHabilita.TabIndex = 5;
            this.btnHabilita.Text = "Habilitar";
            this.btnHabilita.UseVisualStyleBackColor = true;
            this.btnHabilita.Click += new System.EventHandler(this.btnHabilita_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(951, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 33);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormBanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 591);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FormBanned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDataBanned)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Vista.ResumeLayout(false);
            this.Vista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgDataBanned;
        private System.Windows.Forms.CheckBox chkHabilitar;
        private System.Windows.Forms.TextBox txtCodigoOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Vista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chKHabilita;
        private System.Windows.Forms.Button btnHabilita;
        private System.Windows.Forms.Button btnSalir;
    }
}