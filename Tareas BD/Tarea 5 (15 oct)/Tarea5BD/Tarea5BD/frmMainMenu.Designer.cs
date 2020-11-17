namespace Tarea5BD
{
    partial class frmMainMenu
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
            this.btnUpdates = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdates
            // 
            this.btnUpdates.Location = new System.Drawing.Point(49, 69);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(101, 23);
            this.btnUpdates.TabIndex = 0;
            this.btnUpdates.Text = "Actualizaciones";
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Location = new System.Drawing.Point(228, 69);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(75, 23);
            this.btnQueries.TabIndex = 1;
            this.btnQueries.Text = "Consultas";
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(39, 139);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(123, 23);
            this.btnFunction.TabIndex = 2;
            this.btnFunction.Text = "Funcs. y Procs.";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnArticles
            // 
            this.btnArticles.Location = new System.Drawing.Point(228, 139);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(75, 23);
            this.btnArticles.TabIndex = 3;
            this.btnArticles.Text = "Artículos";
            this.btnArticles.UseVisualStyleBackColor = true;
            this.btnArticles.Click += new System.EventHandler(this.btnArticles_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(136, 202);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrar artículo";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(362, 277);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnArticles);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnQueries);
            this.Controls.Add(this.btnUpdates);
            this.Name = "frmMainMenu";
            this.Text = "Menú principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnRegister;
    }
}

