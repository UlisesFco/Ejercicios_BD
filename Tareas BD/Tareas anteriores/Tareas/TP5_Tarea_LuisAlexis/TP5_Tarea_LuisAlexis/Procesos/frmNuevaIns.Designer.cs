namespace TP5_Tarea_LuisAlexis.Procesos
{
    partial class frmNuevaIns
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
            this.cmbUni = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrC = new System.Windows.Forms.Button();
            this.btnModC = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.cbxCampus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUni
            // 
            this.cmbUni.FormattingEnabled = true;
            this.cmbUni.Location = new System.Drawing.Point(40, 44);
            this.cmbUni.Name = "cmbUni";
            this.cmbUni.Size = new System.Drawing.Size(121, 21);
            this.cmbUni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universidad/Institución";
            // 
            // btnAgrC
            // 
            this.btnAgrC.Location = new System.Drawing.Point(219, 42);
            this.btnAgrC.Name = "btnAgrC";
            this.btnAgrC.Size = new System.Drawing.Size(106, 23);
            this.btnAgrC.TabIndex = 2;
            this.btnAgrC.Text = "Agregar Campus";
            this.btnAgrC.UseVisualStyleBackColor = true;
            // 
            // btnModC
            // 
            this.btnModC.Location = new System.Drawing.Point(411, 42);
            this.btnModC.Name = "btnModC";
            this.btnModC.Size = new System.Drawing.Size(106, 23);
            this.btnModC.TabIndex = 3;
            this.btnModC.Text = "Modificar Campus";
            this.btnModC.UseVisualStyleBackColor = true;
            this.btnModC.Click += new System.EventHandler(this.btnModC_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.Location = new System.Drawing.Point(592, 42);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarC.TabIndex = 4;
            this.btnBorrarC.Text = "Borrar Campus";
            this.btnBorrarC.UseVisualStyleBackColor = true;
            // 
            // cbxCampus
            // 
            this.cbxCampus.FormattingEnabled = true;
            this.cbxCampus.Location = new System.Drawing.Point(40, 135);
            this.cbxCampus.Name = "cbxCampus";
            this.cbxCampus.Size = new System.Drawing.Size(121, 21);
            this.cbxCampus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Campus";
            // 
            // frmNuevaIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCampus);
            this.Controls.Add(this.btnBorrarC);
            this.Controls.Add(this.btnModC);
            this.Controls.Add(this.btnAgrC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUni);
            this.Name = "frmNuevaIns";
            this.Text = "Nuevo Campus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgrC;
        private System.Windows.Forms.Button btnModC;
        private System.Windows.Forms.Button btnBorrarC;
        private System.Windows.Forms.ComboBox cbxCampus;
        private System.Windows.Forms.Label label2;
    }
}