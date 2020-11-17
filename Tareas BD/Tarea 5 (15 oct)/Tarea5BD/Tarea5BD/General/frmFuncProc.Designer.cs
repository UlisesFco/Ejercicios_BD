namespace Tarea5BD.General
{
    partial class frmFuncProc
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
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(34, 12);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(100, 50);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Ejecuta función";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(180, 12);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(129, 50);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Ejecuta procedimiento";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(130, 92);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmFuncProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 132);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnFunc);
            this.Name = "frmFuncProc";
            this.Text = "frmFuncProc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnRegresar;
    }
}