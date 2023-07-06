namespace CapaPresentacion.Contabilidad
{
    partial class FormListadoCajasAperturadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgViewCajasAperturadas = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodUsuario = new System.Windows.Forms.RadioButton();
            this.rbFechaApertura = new System.Windows.Forms.RadioButton();
            this.txtBuscarPorCodigo = new System.Windows.Forms.TextBox();
            this.dtFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimirExcel = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCajasAperturadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewCajasAperturadas
            // 
            this.dgViewCajasAperturadas.AllowUserToAddRows = false;
            this.dgViewCajasAperturadas.AllowUserToDeleteRows = false;
            this.dgViewCajasAperturadas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewCajasAperturadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgViewCajasAperturadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCajasAperturadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewCajasAperturadas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgViewCajasAperturadas.Location = new System.Drawing.Point(27, 260);
            this.dgViewCajasAperturadas.Name = "dgViewCajasAperturadas";
            this.dgViewCajasAperturadas.ReadOnly = true;
            this.dgViewCajasAperturadas.RowHeadersWidth = 51;
            this.dgViewCajasAperturadas.RowTemplate.Height = 24;
            this.dgViewCajasAperturadas.Size = new System.Drawing.Size(1161, 267);
            this.dgViewCajasAperturadas.TabIndex = 0;
            this.dgViewCajasAperturadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewCajasAperturadas_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbCodUsuario);
            this.groupBox1.Controls.Add(this.rbFechaApertura);
            this.groupBox1.Controls.Add(this.dtFechaApertura);
            this.groupBox1.Controls.Add(this.txtBuscarPorCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // rbCodUsuario
            // 
            this.rbCodUsuario.AutoSize = true;
            this.rbCodUsuario.Checked = true;
            this.rbCodUsuario.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodUsuario.Location = new System.Drawing.Point(33, 30);
            this.rbCodUsuario.Name = "rbCodUsuario";
            this.rbCodUsuario.Size = new System.Drawing.Size(129, 21);
            this.rbCodUsuario.TabIndex = 3;
            this.rbCodUsuario.TabStop = true;
            this.rbCodUsuario.Text = "Cód empleado";
            this.rbCodUsuario.UseVisualStyleBackColor = true;
            this.rbCodUsuario.CheckedChanged += new System.EventHandler(this.rbCodUsuario_CheckedChanged);
            // 
            // rbFechaApertura
            // 
            this.rbFechaApertura.AutoSize = true;
            this.rbFechaApertura.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaApertura.Location = new System.Drawing.Point(197, 30);
            this.rbFechaApertura.Name = "rbFechaApertura";
            this.rbFechaApertura.Size = new System.Drawing.Size(134, 21);
            this.rbFechaApertura.TabIndex = 2;
            this.rbFechaApertura.TabStop = true;
            this.rbFechaApertura.Text = "Fecha apertura";
            this.rbFechaApertura.UseVisualStyleBackColor = true;
            this.rbFechaApertura.CheckedChanged += new System.EventHandler(this.rbFechaApertura_CheckedChanged);
            // 
            // txtBuscarPorCodigo
            // 
            this.txtBuscarPorCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarPorCodigo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorCodigo.Location = new System.Drawing.Point(33, 66);
            this.txtBuscarPorCodigo.Name = "txtBuscarPorCodigo";
            this.txtBuscarPorCodigo.Size = new System.Drawing.Size(410, 23);
            this.txtBuscarPorCodigo.TabIndex = 1;
            this.txtBuscarPorCodigo.TextChanged += new System.EventHandler(this.txtBuscarPorCodigo_TextChanged);
            // 
            // dtFechaApertura
            // 
            this.dtFechaApertura.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaApertura.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaApertura.Location = new System.Drawing.Point(33, 66);
            this.dtFechaApertura.Name = "dtFechaApertura";
            this.dtFechaApertura.Size = new System.Drawing.Size(281, 23);
            this.dtFechaApertura.TabIndex = 4;
            this.dtFechaApertura.Visible = false;
            this.dtFechaApertura.ValueChanged += new System.EventHandler(this.dtFechaApertura_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCantidad.Location = new System.Drawing.Point(24, 541);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 18);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "lblCantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(903, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Se listarán todas las cajas aperturadas.";
            // 
            // btnImprimirExcel
            // 
            this.btnImprimirExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirExcel.Image = global::CapaPresentacion.Properties.Resources._32Excel_icon1;
            this.btnImprimirExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimirExcel.Location = new System.Drawing.Point(906, 119);
            this.btnImprimirExcel.Name = "btnImprimirExcel";
            this.btnImprimirExcel.Size = new System.Drawing.Size(135, 70);
            this.btnImprimirExcel.TabIndex = 12;
            this.btnImprimirExcel.Text = "Imprimir Excel";
            this.btnImprimirExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirExcel.UseVisualStyleBackColor = true;
            this.btnImprimirExcel.Click += new System.EventHandler(this.btnImprimirExcel_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Image = global::CapaPresentacion.Properties.Resources.lock1;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Location = new System.Drawing.Point(27, 206);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(153, 44);
            this.btnCerrarCaja.TabIndex = 11;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources._1484136266_Log_Out2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1047, 119);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 70);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(27, 572);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1161, 10);
            this.pb1.TabIndex = 13;
            this.pb1.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(27, 588);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(1161, 10);
            this.pb2.TabIndex = 14;
            this.pb2.Visible = false;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(372, 30);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(71, 21);
            this.rbTodos.TabIndex = 5;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // FormListadoCajasAperturadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 614);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnImprimirExcel);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgViewCajasAperturadas);
            this.MaximizeBox = false;
            this.Name = "FormListadoCajasAperturadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: CAJAS APERTURADAS ::.";
            this.Load += new System.EventHandler(this.FormListadoCajasAperturadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCajasAperturadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewCajasAperturadas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarPorCodigo;
        private System.Windows.Forms.RadioButton rbCodUsuario;
        private System.Windows.Forms.RadioButton rbFechaApertura;
        private System.Windows.Forms.DateTimePicker dtFechaApertura;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnImprimirExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Item;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}