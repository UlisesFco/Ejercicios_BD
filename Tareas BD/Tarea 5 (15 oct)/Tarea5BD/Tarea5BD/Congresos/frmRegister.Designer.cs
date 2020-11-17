namespace Tarea5BD.Congresos
{
    partial class frmRegister
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
            this.btnAltaArt = new System.Windows.Forms.Button();
            this.cbArts = new System.Windows.Forms.ComboBox();
            this.cbCongreso = new System.Windows.Forms.ComboBox();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.tbxExp = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaArt
            // 
            this.btnAltaArt.Location = new System.Drawing.Point(310, 24);
            this.btnAltaArt.Name = "btnAltaArt";
            this.btnAltaArt.Size = new System.Drawing.Size(141, 23);
            this.btnAltaArt.TabIndex = 0;
            this.btnAltaArt.Text = "Registrar articulo";
            this.btnAltaArt.UseVisualStyleBackColor = true;
            this.btnAltaArt.Click += new System.EventHandler(this.btnAltaArt_Click);
            // 
            // cbArts
            // 
            this.cbArts.FormattingEnabled = true;
            this.cbArts.Location = new System.Drawing.Point(12, 24);
            this.cbArts.Name = "cbArts";
            this.cbArts.Size = new System.Drawing.Size(121, 21);
            this.cbArts.TabIndex = 6;
            this.cbArts.Text = "Artículo";
            // 
            // cbCongreso
            // 
            this.cbCongreso.FormattingEnabled = true;
            this.cbCongreso.Location = new System.Drawing.Point(162, 24);
            this.cbCongreso.Name = "cbCongreso";
            this.cbCongreso.Size = new System.Drawing.Size(121, 21);
            this.cbCongreso.TabIndex = 7;
            this.cbCongreso.Text = "Congreso";
            // 
            // dtpExp
            // 
            this.dtpExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExp.Location = new System.Drawing.Point(55, 108);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(200, 20);
            this.dtpExp.TabIndex = 10;
            this.dtpExp.Value = new System.DateTime(2018, 10, 16, 0, 0, 0, 0);
            // 
            // tbxExp
            // 
            this.tbxExp.Location = new System.Drawing.Point(95, 68);
            this.tbxExp.Name = "tbxExp";
            this.tbxExp.Size = new System.Drawing.Size(100, 20);
            this.tbxExp.TabIndex = 9;
            this.tbxExp.Text = "Expositor (nombre)";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(350, 105);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 157);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtpExp);
            this.Controls.Add(this.tbxExp);
            this.Controls.Add(this.cbCongreso);
            this.Controls.Add(this.cbArts);
            this.Controls.Add(this.btnAltaArt);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaArt;
        private System.Windows.Forms.ComboBox cbArts;
        private System.Windows.Forms.ComboBox cbCongreso;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.TextBox tbxExp;
        private System.Windows.Forms.Button btnRegresar;
    }
}