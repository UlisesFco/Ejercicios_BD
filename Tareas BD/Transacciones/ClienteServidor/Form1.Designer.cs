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
            this.MnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOtrasConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSubprogsAlm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestorBD = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransact = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MnuConsulta,
            this.MnuOtrasConsultas});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tablasToolStripMenuItem.Text = "TablasCons";
            // 
            // MnuAlumnos
            // 
            this.MnuAlumnos.Name = "MnuAlumnos";
            this.MnuAlumnos.Size = new System.Drawing.Size(122, 22);
            this.MnuAlumnos.Text = "Alumnos";
            this.MnuAlumnos.Click += new System.EventHandler(this.MnuAlumnos_Click);
            // 
            // MnuConsulta
            // 
            this.MnuConsulta.Name = "MnuConsulta";
            this.MnuConsulta.Size = new System.Drawing.Size(122, 22);
            this.MnuConsulta.Text = "Consulta";
            this.MnuConsulta.Click += new System.EventHandler(this.MnuConsulta_Click);
            // 
            // MnuOtrasConsultas
            // 
            this.MnuOtrasConsultas.Name = "MnuOtrasConsultas";
            this.MnuOtrasConsultas.Size = new System.Drawing.Size(122, 22);
            this.MnuOtrasConsultas.Text = "OtrasBD";
            this.MnuOtrasConsultas.Click += new System.EventHandler(this.MnuOtrasConsultas_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSubprogsAlm,
            this.MnuGestorBD,
            this.MnuTransact});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // MnuSubprogsAlm
            // 
            this.MnuSubprogsAlm.Name = "MnuSubprogsAlm";
            this.MnuSubprogsAlm.Size = new System.Drawing.Size(155, 22);
            this.MnuSubprogsAlm.Text = "Subprogs. Alm.";
            this.MnuSubprogsAlm.Click += new System.EventHandler(this.MnuSubprogsAlm_Click);
            // 
            // MnuGestorBD
            // 
            this.MnuGestorBD.Name = "MnuGestorBD";
            this.MnuGestorBD.Size = new System.Drawing.Size(155, 22);
            this.MnuGestorBD.Text = "Gestor  BD";
            this.MnuGestorBD.Click += new System.EventHandler(this.MnuGestorBD_Click);
            // 
            // MnuTransact
            // 
            this.MnuTransact.Name = "MnuTransact";
            this.MnuTransact.Size = new System.Drawing.Size(155, 22);
            this.MnuTransact.Text = "Transacciones";
            this.MnuTransact.Click += new System.EventHandler(this.MnuTransact_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
    private System.Windows.Forms.ToolStripMenuItem MnuConsulta;
    private System.Windows.Forms.ToolStripMenuItem MnuSubprogsAlm;
    private System.Windows.Forms.ToolStripMenuItem MnuGestorBD;
        private System.Windows.Forms.ToolStripMenuItem MnuOtrasConsultas;
        private System.Windows.Forms.ToolStripMenuItem MnuTransact;
    }
}

