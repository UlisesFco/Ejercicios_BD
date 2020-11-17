namespace Tarea5BD.General
{
    partial class frmUpdates
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
            this.components = new System.ComponentModel.Container();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.iDARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICULOT4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsArts = new Tarea5BD.dsArts();
            this.aRTICULO_T4TableAdapter = new Tarea5BD.dsArtsTableAdapters.ARTICULO_T4TableAdapter();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.iDAUTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDORGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMAUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMARTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORT4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAutor = new Tarea5BD.dsAutor();
            this.aUTOR_T4TableAdapter = new Tarea5BD.dsAutorTableAdapters.AUTOR_T4TableAdapter();
            this.btnActArt = new System.Windows.Forms.Button();
            this.btnActAut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOT4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORT4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoGenerateColumns = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDARTDataGridViewTextBoxColumn,
            this.nOMARTDataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn,
            this.iDAUTDataGridViewTextBoxColumn});
            this.dgvArticulos.DataSource = this.aRTICULOT4BindingSource;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 12);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(446, 204);
            this.dgvArticulos.TabIndex = 0;
            // 
            // iDARTDataGridViewTextBoxColumn
            // 
            this.iDARTDataGridViewTextBoxColumn.DataPropertyName = "IDART";
            this.iDARTDataGridViewTextBoxColumn.HeaderText = "IDART";
            this.iDARTDataGridViewTextBoxColumn.Name = "iDARTDataGridViewTextBoxColumn";
            // 
            // nOMARTDataGridViewTextBoxColumn
            // 
            this.nOMARTDataGridViewTextBoxColumn.DataPropertyName = "NOMART";
            this.nOMARTDataGridViewTextBoxColumn.HeaderText = "NOMART";
            this.nOMARTDataGridViewTextBoxColumn.Name = "nOMARTDataGridViewTextBoxColumn";
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            // 
            // iDAUTDataGridViewTextBoxColumn
            // 
            this.iDAUTDataGridViewTextBoxColumn.DataPropertyName = "IDAUT";
            this.iDAUTDataGridViewTextBoxColumn.HeaderText = "IDAUT";
            this.iDAUTDataGridViewTextBoxColumn.Name = "iDAUTDataGridViewTextBoxColumn";
            // 
            // aRTICULOT4BindingSource
            // 
            this.aRTICULOT4BindingSource.DataMember = "ARTICULO_T4";
            this.aRTICULOT4BindingSource.DataSource = this.dsArts;
            // 
            // dsArts
            // 
            this.dsArts.DataSetName = "dsArts";
            this.dsArts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTICULO_T4TableAdapter
            // 
            this.aRTICULO_T4TableAdapter.ClearBeforeFill = true;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AutoGenerateColumns = false;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAUTDataGridViewTextBoxColumn1,
            this.iDORGDataGridViewTextBoxColumn,
            this.nOMAUTDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nUMARTSDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn});
            this.dgvAutores.DataSource = this.aUTORT4BindingSource;
            this.dgvAutores.Location = new System.Drawing.Point(464, 12);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(647, 213);
            this.dgvAutores.TabIndex = 1;
            // 
            // iDAUTDataGridViewTextBoxColumn1
            // 
            this.iDAUTDataGridViewTextBoxColumn1.DataPropertyName = "IDAUT";
            this.iDAUTDataGridViewTextBoxColumn1.HeaderText = "IDAUT";
            this.iDAUTDataGridViewTextBoxColumn1.Name = "iDAUTDataGridViewTextBoxColumn1";
            // 
            // iDORGDataGridViewTextBoxColumn
            // 
            this.iDORGDataGridViewTextBoxColumn.DataPropertyName = "IDORG";
            this.iDORGDataGridViewTextBoxColumn.HeaderText = "IDORG";
            this.iDORGDataGridViewTextBoxColumn.Name = "iDORGDataGridViewTextBoxColumn";
            // 
            // nOMAUTDataGridViewTextBoxColumn
            // 
            this.nOMAUTDataGridViewTextBoxColumn.DataPropertyName = "NOMAUT";
            this.nOMAUTDataGridViewTextBoxColumn.HeaderText = "NOMAUT";
            this.nOMAUTDataGridViewTextBoxColumn.Name = "nOMAUTDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // nUMARTSDataGridViewTextBoxColumn
            // 
            this.nUMARTSDataGridViewTextBoxColumn.DataPropertyName = "NUMARTS";
            this.nUMARTSDataGridViewTextBoxColumn.HeaderText = "NUMARTS";
            this.nUMARTSDataGridViewTextBoxColumn.Name = "nUMARTSDataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // aUTORT4BindingSource
            // 
            this.aUTORT4BindingSource.DataMember = "AUTOR_T4";
            this.aUTORT4BindingSource.DataSource = this.dsAutor;
            // 
            // dsAutor
            // 
            this.dsAutor.DataSetName = "dsAutor";
            this.dsAutor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTOR_T4TableAdapter
            // 
            this.aUTOR_T4TableAdapter.ClearBeforeFill = true;
            // 
            // btnActArt
            // 
            this.btnActArt.Location = new System.Drawing.Point(141, 276);
            this.btnActArt.Name = "btnActArt";
            this.btnActArt.Size = new System.Drawing.Size(185, 23);
            this.btnActArt.TabIndex = 2;
            this.btnActArt.Text = "Actualiza artículo";
            this.btnActArt.UseVisualStyleBackColor = true;
            this.btnActArt.Click += new System.EventHandler(this.btnActArt_Click);
            // 
            // btnActAut
            // 
            this.btnActAut.Location = new System.Drawing.Point(633, 265);
            this.btnActAut.Name = "btnActAut";
            this.btnActAut.Size = new System.Drawing.Size(159, 23);
            this.btnActAut.TabIndex = 3;
            this.btnActAut.Text = "Actualiza autor";
            this.btnActAut.UseVisualStyleBackColor = true;
            this.btnActAut.Click += new System.EventHandler(this.btnActAut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActAut);
            this.Controls.Add(this.btnActArt);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmUpdates";
            this.Text = "frmUpdates";
            this.Load += new System.EventHandler(this.frmUpdates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOT4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTORT4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private dsArts dsArts;
        private System.Windows.Forms.BindingSource aRTICULOT4BindingSource;
        private dsArtsTableAdapters.ARTICULO_T4TableAdapter aRTICULO_T4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAutores;
        private dsAutor dsAutor;
        private System.Windows.Forms.BindingSource aUTORT4BindingSource;
        private dsAutorTableAdapters.AUTOR_T4TableAdapter aUTOR_T4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAUTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMAUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMARTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActArt;
        private System.Windows.Forms.Button btnActAut;
        private System.Windows.Forms.Button button1;
    }
}