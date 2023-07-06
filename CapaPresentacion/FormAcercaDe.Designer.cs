namespace CapaPresentacion
{
    partial class FormAcercaDe
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
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCopyright.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopyright.Location = new System.Drawing.Point(33, 132);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(77, 17);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApiKey.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApiKey.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblApiKey.Location = new System.Drawing.Point(31, 88);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(141, 29);
            this.lblApiKey.TabIndex = 4;
            this.lblApiKey.Text = "lblApiKey";
            // 
            // FormAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 218);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.lblCopyright);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: ACERCA DEL SISTEMA ::.";
            this.Load += new System.EventHandler(this.FormAcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblApiKey;
    }
}