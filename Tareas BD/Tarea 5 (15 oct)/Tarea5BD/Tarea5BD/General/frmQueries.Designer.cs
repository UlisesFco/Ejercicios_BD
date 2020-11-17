namespace Tarea5BD.General
{
    partial class frmQueries
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
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.btnCantArts = new System.Windows.Forms.Button();
            this.btnNomInst = new System.Windows.Forms.Button();
            this.btnAutsCong = new System.Windows.Forms.Button();
            this.btnEmpFin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AllowUserToAddRows = false;
            this.dgvGeneral.AllowUserToDeleteRows = false;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Location = new System.Drawing.Point(12, 12);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.ReadOnly = true;
            this.dgvGeneral.Size = new System.Drawing.Size(693, 242);
            this.dgvGeneral.TabIndex = 0;
            // 
            // btnCantArts
            // 
            this.btnCantArts.Location = new System.Drawing.Point(35, 286);
            this.btnCantArts.Name = "btnCantArts";
            this.btnCantArts.Size = new System.Drawing.Size(90, 52);
            this.btnCantArts.TabIndex = 1;
            this.btnCantArts.Text = "Cantidad de arts. por año";
            this.btnCantArts.UseVisualStyleBackColor = true;
            this.btnCantArts.Click += new System.EventHandler(this.btnCantArts_Click);
            // 
            // btnNomInst
            // 
            this.btnNomInst.Location = new System.Drawing.Point(206, 286);
            this.btnNomInst.Name = "btnNomInst";
            this.btnNomInst.Size = new System.Drawing.Size(144, 52);
            this.btnNomInst.TabIndex = 2;
            this.btnNomInst.Text = "Nombre y país de instituciones";
            this.btnNomInst.UseVisualStyleBackColor = true;
            this.btnNomInst.Click += new System.EventHandler(this.btnNomInst_Click);
            // 
            // btnAutsCong
            // 
            this.btnAutsCong.Location = new System.Drawing.Point(445, 285);
            this.btnAutsCong.Name = "btnAutsCong";
            this.btnAutsCong.Size = new System.Drawing.Size(100, 53);
            this.btnAutsCong.TabIndex = 3;
            this.btnAutsCong.Text = "Autores en más congresos";
            this.btnAutsCong.UseVisualStyleBackColor = true;
            this.btnAutsCong.Click += new System.EventHandler(this.btnAutsCong_Click);
            // 
            // btnEmpFin
            // 
            this.btnEmpFin.Location = new System.Drawing.Point(614, 286);
            this.btnEmpFin.Name = "btnEmpFin";
            this.btnEmpFin.Size = new System.Drawing.Size(91, 55);
            this.btnEmpFin.TabIndex = 4;
            this.btnEmpFin.Text = "Empresas de financiamiento";
            this.btnEmpFin.UseVisualStyleBackColor = true;
            this.btnEmpFin.Click += new System.EventHandler(this.btnEmpFin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEmpFin);
            this.Controls.Add(this.btnAutsCong);
            this.Controls.Add(this.btnNomInst);
            this.Controls.Add(this.btnCantArts);
            this.Controls.Add(this.dgvGeneral);
            this.Name = "frmQueries";
            this.Text = "frmQueries";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.Button btnCantArts;
        private System.Windows.Forms.Button btnNomInst;
        private System.Windows.Forms.Button btnAutsCong;
        private System.Windows.Forms.Button btnEmpFin;
        private System.Windows.Forms.Button button1;
    }
}