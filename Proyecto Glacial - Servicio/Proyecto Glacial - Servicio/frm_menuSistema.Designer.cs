namespace Proyecto_Glacial___Servicio
{
    partial class frm_menuSistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ordenesServicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ordenesServicio
            // 
            this.btn_ordenesServicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ordenesServicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordenesServicio.Location = new System.Drawing.Point(337, 24);
            this.btn_ordenesServicio.Name = "btn_ordenesServicio";
            this.btn_ordenesServicio.Size = new System.Drawing.Size(193, 54);
            this.btn_ordenesServicio.TabIndex = 0;
            this.btn_ordenesServicio.Text = "Orden de Servicio";
            this.btn_ordenesServicio.UseVisualStyleBackColor = false;
            this.btn_ordenesServicio.Click += new System.EventHandler(this.btn_ordenesServicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.wat;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_menuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.btn_ordenesServicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_menuSistema";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frm_menuSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ordenesServicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

