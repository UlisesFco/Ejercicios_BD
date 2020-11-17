namespace ClienteServidor {
  partial class FrmMenú {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenú));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subProgsAlm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestorBD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSalir});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(96, 22);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlumnos,
            this.Consulta});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            this.tablasToolStripMenuItem.Click += new System.EventHandler(this.tablasToolStripMenuItem_Click);
            // 
            // MnuAlumnos
            // 
            this.MnuAlumnos.Name = "MnuAlumnos";
            this.MnuAlumnos.Size = new System.Drawing.Size(122, 22);
            this.MnuAlumnos.Text = "Alumnos";
            this.MnuAlumnos.Click += new System.EventHandler(this.MnuAlumnos_Click);
            // 
            // Consulta
            // 
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(122, 22);
            this.Consulta.Text = "Consulta";
            this.Consulta.Click += new System.EventHandler(this.alumCalifsToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subProgsAlm,
            this.MnuGestorBD});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // subProgsAlm
            // 
            this.subProgsAlm.Name = "subProgsAlm";
            this.subProgsAlm.Size = new System.Drawing.Size(152, 22);
            this.subProgsAlm.Text = "SubProgsAlm";
            this.subProgsAlm.Click += new System.EventHandler(this.subProgsAlm_Click);
            // 
            // MnuGestorBD
            // 
            this.MnuGestorBD.Name = "MnuGestorBD";
            this.MnuGestorBD.Size = new System.Drawing.Size(152, 22);
            this.MnuGestorBD.Text = "GestorBD";
            this.MnuGestorBD.Click += new System.EventHandler(this.MnuGestorBD_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 357);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem Consulta;
        private System.Windows.Forms.ToolStripMenuItem subProgsAlm;
        private System.Windows.Forms.ToolStripMenuItem MnuGestorBD;
    }
}

