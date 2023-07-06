namespace CapaPresentacion.Mantenimiento
{
    partial class FormMntProductMoverStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMntProductMoverStock));
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockAlmacen = new System.Windows.Forms.TextBox();
            this.txtStockAMover = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadMover = new System.Windows.Forms.TextBox();
            this.btnMoverStock = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mover Stock de Almacen > Stock Venta";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.lblProducto.Location = new System.Drawing.Point(144, 126);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 17);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "lblProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock a venta";
            // 
            // txtStockAlmacen
            // 
            this.txtStockAlmacen.Location = new System.Drawing.Point(41, 188);
            this.txtStockAlmacen.Name = "txtStockAlmacen";
            this.txtStockAlmacen.ReadOnly = true;
            this.txtStockAlmacen.Size = new System.Drawing.Size(170, 22);
            this.txtStockAlmacen.TabIndex = 4;
            // 
            // txtStockAMover
            // 
            this.txtStockAMover.Location = new System.Drawing.Point(369, 188);
            this.txtStockAMover.Name = "txtStockAMover";
            this.txtStockAMover.ReadOnly = true;
            this.txtStockAMover.Size = new System.Drawing.Size(160, 22);
            this.txtStockAMover.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad a mover:";
            // 
            // txtCantidadMover
            // 
            this.txtCantidadMover.Location = new System.Drawing.Point(244, 279);
            this.txtCantidadMover.Name = "txtCantidadMover";
            this.txtCantidadMover.Size = new System.Drawing.Size(121, 22);
            this.txtCantidadMover.TabIndex = 8;
            this.txtCantidadMover.TextChanged += new System.EventHandler(this.txtCantidadMover_TextChanged);
            this.txtCantidadMover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadMover_KeyPress);
            // 
            // btnMoverStock
            // 
            this.btnMoverStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverStock.Image = global::CapaPresentacion.Properties.Resources.folder_open;
            this.btnMoverStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoverStock.Location = new System.Drawing.Point(301, 348);
            this.btnMoverStock.Name = "btnMoverStock";
            this.btnMoverStock.Size = new System.Drawing.Size(111, 64);
            this.btnMoverStock.TabIndex = 9;
            this.btnMoverStock.Text = "Mover ";
            this.btnMoverStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoverStock.UseVisualStyleBackColor = true;
            this.btnMoverStock.Click += new System.EventHandler(this.btnMoverStock_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(418, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 64);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMntProductMoverStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 424);
            this.Controls.Add(this.btnMoverStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidadMover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockAMover);
            this.Controls.Add(this.txtStockAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormMntProductMoverStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: MOVER STOCK DE ALMACEN A VENTAS ::.";
            this.Load += new System.EventHandler(this.FormMntProductMoverStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockAlmacen;
        private System.Windows.Forms.TextBox txtStockAMover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadMover;
        private System.Windows.Forms.Button btnMoverStock;
        private System.Windows.Forms.Button btnSalir;
    }
}