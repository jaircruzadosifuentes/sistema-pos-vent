namespace CapaPresentacion.Contabilidad
{
    partial class FormAperturaCajaChica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodUser = new System.Windows.Forms.TextBox();
            this.btnAperturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsuarioCompleto = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtCajaId = new System.Windows.Forms.TextBox();
            this.txtSedeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(189, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apertura de Caja Chica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // txtCodUser
            // 
            this.txtCodUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUser.Location = new System.Drawing.Point(133, 177);
            this.txtCodUser.MaxLength = 4;
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.Size = new System.Drawing.Size(95, 22);
            this.txtCodUser.TabIndex = 2;
            this.txtCodUser.TextChanged += new System.EventHandler(this.txtCodUser_TextChanged);
            this.txtCodUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodUser_KeyPress);
            // 
            // btnAperturar
            // 
            this.btnAperturar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAperturar.Location = new System.Drawing.Point(447, 292);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(121, 38);
            this.btnAperturar.TabIndex = 3;
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.UseVisualStyleBackColor = true;
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(574, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsuarioCompleto
            // 
            this.txtUsuarioCompleto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtUsuarioCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCompleto.Location = new System.Drawing.Point(234, 177);
            this.txtUsuarioCompleto.Name = "txtUsuarioCompleto";
            this.txtUsuarioCompleto.ReadOnly = true;
            this.txtUsuarioCompleto.Size = new System.Drawing.Size(459, 22);
            this.txtUsuarioCompleto.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(133, 227);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(95, 24);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sede:";
            // 
            // txtSede
            // 
            this.txtSede.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSede.Location = new System.Drawing.Point(296, 227);
            this.txtSede.Name = "txtSede";
            this.txtSede.ReadOnly = true;
            this.txtSede.Size = new System.Drawing.Size(177, 22);
            this.txtSede.TabIndex = 12;
            // 
            // txtCaja
            // 
            this.txtCaja.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCaja.Location = new System.Drawing.Point(535, 228);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.ReadOnly = true;
            this.txtCaja.Size = new System.Drawing.Size(158, 22);
            this.txtCaja.TabIndex = 13;
            // 
            // txtCajaId
            // 
            this.txtCajaId.Location = new System.Drawing.Point(535, 256);
            this.txtCajaId.Name = "txtCajaId";
            this.txtCajaId.Size = new System.Drawing.Size(59, 22);
            this.txtCajaId.TabIndex = 14;
            this.txtCajaId.Visible = false;
            // 
            // txtSedeId
            // 
            this.txtSedeId.Location = new System.Drawing.Point(296, 256);
            this.txtSedeId.Name = "txtSedeId";
            this.txtSedeId.Size = new System.Drawing.Size(59, 22);
            this.txtSedeId.TabIndex = 15;
            this.txtSedeId.Visible = false;
            // 
            // FormAperturaCajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 371);
            this.Controls.Add(this.txtSedeId);
            this.Controls.Add(this.txtCajaId);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.txtSede);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtUsuarioCompleto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAperturar);
            this.Controls.Add(this.txtCodUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAperturaCajaChica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAperturaCajaChica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodUser;
        private System.Windows.Forms.Button btnAperturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuarioCompleto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtCajaId;
        private System.Windows.Forms.TextBox txtSedeId;
    }
}