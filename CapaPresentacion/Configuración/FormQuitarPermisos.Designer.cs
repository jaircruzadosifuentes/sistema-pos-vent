namespace CapaPresentacion.Configuración
{
    partial class FormQuitarPermisos
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
            this.dgPermisos = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalirPermiss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPermisos
            // 
            this.dgPermisos.AllowUserToAddRows = false;
            this.dgPermisos.AllowUserToDeleteRows = false;
            this.dgPermisos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPermisos.Location = new System.Drawing.Point(43, 142);
            this.dgPermisos.Name = "dgPermisos";
            this.dgPermisos.ReadOnly = true;
            this.dgPermisos.RowHeadersWidth = 51;
            this.dgPermisos.RowTemplate.Height = 24;
            this.dgPermisos.Size = new System.Drawing.Size(712, 308);
            this.dgPermisos.TabIndex = 4;
            this.dgPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPermisos_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 50;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::CapaPresentacion.Properties.Resources.error21;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(533, 467);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(108, 32);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalirPermiss
            // 
            this.btnSalirPermiss.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPermiss.Image = global::CapaPresentacion.Properties.Resources._1484136266_Log_Out3;
            this.btnSalirPermiss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPermiss.Location = new System.Drawing.Point(647, 466);
            this.btnSalirPermiss.Name = "btnSalirPermiss";
            this.btnSalirPermiss.Size = new System.Drawing.Size(108, 33);
            this.btnSalirPermiss.TabIndex = 12;
            this.btnSalirPermiss.Text = "Salir";
            this.btnSalirPermiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirPermiss.UseVisualStyleBackColor = true;
            this.btnSalirPermiss.Click += new System.EventHandler(this.btnSalirPermiss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(169, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quitar permisos de acceso a operaciones";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkTodos.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(43, 467);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(72, 21);
            this.chkTodos.TabIndex = 16;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = false;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // FormQuitarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 526);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSalirPermiss);
            this.Controls.Add(this.dgPermisos);
            this.Name = "FormQuitarPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: QUITAR PERMISOS ::.";
            this.Load += new System.EventHandler(this.FormQuitarPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Item;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalirPermiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}