namespace ClienteServidor.Procesos {
  partial class FrmGestorBD {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.cboAlumnos = new System.Windows.Forms.ComboBox();
      this.cboMaterias = new System.Windows.Forms.ComboBox();
      this.btnAltaCalif = new System.Windows.Forms.Button();
      this.cboCalif = new System.Windows.Forms.ComboBox();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.btnRegistrarAlta = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnBajaCalif = new System.Windows.Forms.Button();
      this.btnCambia = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(81, 39);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.RowTemplate.Height = 24;
      this.dtgGeneral.Size = new System.Drawing.Size(652, 156);
      this.dtgGeneral.TabIndex = 0;
      this.dtgGeneral.Click += new System.EventHandler(this.dtgGeneral_Click);
      // 
      // cboAlumnos
      // 
      this.cboAlumnos.FormattingEnabled = true;
      this.cboAlumnos.Location = new System.Drawing.Point(82, 231);
      this.cboAlumnos.Name = "cboAlumnos";
      this.cboAlumnos.Size = new System.Drawing.Size(121, 24);
      this.cboAlumnos.TabIndex = 1;
      this.cboAlumnos.Text = "Alumnos:";
      this.cboAlumnos.SelectedIndexChanged += new System.EventHandler(this.cboAlumnos_SelectedIndexChanged);
      // 
      // cboMaterias
      // 
      this.cboMaterias.FormattingEnabled = true;
      this.cboMaterias.Location = new System.Drawing.Point(81, 343);
      this.cboMaterias.Name = "cboMaterias";
      this.cboMaterias.Size = new System.Drawing.Size(122, 24);
      this.cboMaterias.TabIndex = 2;
      this.cboMaterias.Text = "Materias:";
      this.cboMaterias.Visible = false;
      // 
      // btnAltaCalif
      // 
      this.btnAltaCalif.Location = new System.Drawing.Point(83, 286);
      this.btnAltaCalif.Name = "btnAltaCalif";
      this.btnAltaCalif.Size = new System.Drawing.Size(120, 23);
      this.btnAltaCalif.TabIndex = 3;
      this.btnAltaCalif.Text = "Alta de calif.";
      this.btnAltaCalif.UseVisualStyleBackColor = true;
      this.btnAltaCalif.Click += new System.EventHandler(this.btnAltaCalif_Click);
      // 
      // cboCalif
      // 
      this.cboCalif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCalif.FormattingEnabled = true;
      this.cboCalif.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5"});
      this.cboCalif.Location = new System.Drawing.Point(345, 342);
      this.cboCalif.Name = "cboCalif";
      this.cboCalif.Size = new System.Drawing.Size(121, 24);
      this.cboCalif.TabIndex = 4;
      this.cboCalif.Visible = false;
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(546, 345);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(163, 22);
      this.dtpFecha.TabIndex = 5;
      this.dtpFecha.Visible = false;
      // 
      // btnRegistrarAlta
      // 
      this.btnRegistrarAlta.Location = new System.Drawing.Point(81, 400);
      this.btnRegistrarAlta.Name = "btnRegistrarAlta";
      this.btnRegistrarAlta.Size = new System.Drawing.Size(122, 29);
      this.btnRegistrarAlta.TabIndex = 6;
      this.btnRegistrarAlta.Text = "Registrar alta";
      this.btnRegistrarAlta.UseVisualStyleBackColor = true;
      this.btnRegistrarAlta.Visible = false;
      this.btnRegistrarAlta.Click += new System.EventHandler(this.btnRegistrarAlta_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(284, 345);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 17);
      this.label1.TabIndex = 7;
      this.label1.Text = "Calif:";
      this.label1.Visible = false;
      // 
      // btnBajaCalif
      // 
      this.btnBajaCalif.Location = new System.Drawing.Point(347, 286);
      this.btnBajaCalif.Name = "btnBajaCalif";
      this.btnBajaCalif.Size = new System.Drawing.Size(119, 23);
      this.btnBajaCalif.TabIndex = 8;
      this.btnBajaCalif.Text = "Baja de calif.";
      this.btnBajaCalif.UseVisualStyleBackColor = true;
      this.btnBajaCalif.Click += new System.EventHandler(this.btnBajaCalif_Click);
      // 
      // btnCambia
      // 
      this.btnCambia.Location = new System.Drawing.Point(550, 285);
      this.btnCambia.Name = "btnCambia";
      this.btnCambia.Size = new System.Drawing.Size(159, 23);
      this.btnCambia.TabIndex = 9;
      this.btnCambia.Text = "Cambio de calif.";
      this.btnCambia.UseVisualStyleBackColor = true;
      // 
      // FrmGestorBD
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(828, 496);
      this.Controls.Add(this.btnCambia);
      this.Controls.Add(this.btnBajaCalif);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnRegistrarAlta);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.cboCalif);
      this.Controls.Add(this.btnAltaCalif);
      this.Controls.Add(this.cboMaterias);
      this.Controls.Add(this.cboAlumnos);
      this.Controls.Add(this.dtgGeneral);
      this.Name = "FrmGestorBD";
      this.Text = "Proceso de la BD con una biblioteca dll";
      this.Load += new System.EventHandler(this.FrmGestorBD_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.ComboBox cboAlumnos;
    private System.Windows.Forms.ComboBox cboMaterias;
    private System.Windows.Forms.Button btnAltaCalif;
    private System.Windows.Forms.ComboBox cboCalif;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnRegistrarAlta;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnBajaCalif;
    private System.Windows.Forms.Button btnCambia;
  }
}