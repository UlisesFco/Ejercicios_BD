namespace TP5_Tarea_LuisAlexis
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.institucionesYCarrerrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.institucionesYCarrerrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // institucionesYCarrerrasToolStripMenuItem
            // 
            this.institucionesYCarrerrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVer,
            this.btnAgregar});
            this.institucionesYCarrerrasToolStripMenuItem.Name = "institucionesYCarrerrasToolStripMenuItem";
            this.institucionesYCarrerrasToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.institucionesYCarrerrasToolStripMenuItem.Text = "Instituciones y carrerras";
            // 
            // btnVer
            // 
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(152, 22);
            this.btnVer.Text = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 394);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem institucionesYCarrerrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVer;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
    }
}

