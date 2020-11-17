namespace Tarea5BD.Congresos
{
    partial class frmArticles
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
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvGen = new System.Windows.Forms.DataGridView();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(27, 224);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(152, 21);
            this.cbAutor.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(247, 225);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // dgvGen
            // 
            this.dgvGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGen.Location = new System.Drawing.Point(12, 12);
            this.dgvGen.Name = "dgvGen";
            this.dgvGen.Size = new System.Drawing.Size(454, 197);
            this.dgvGen.TabIndex = 2;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(175, 269);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Ver datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(391, 290);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 325);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.dgvGen);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbAutor);
            this.Name = "frmArticles";
            this.Text = "frmArticles";
            this.Load += new System.EventHandler(this.frmArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvGen;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnRegresar;
    }
}