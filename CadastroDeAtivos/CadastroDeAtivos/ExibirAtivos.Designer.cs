namespace CadastroDeAtivos
{
    partial class ExibirAtivos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativoDataSet = new CadastroDeAtivos.AtivoDataSet();
            this.ativoTableAdapter = new CadastroDeAtivos.AtivoDataSetTableAdapters.AtivoTableAdapter();
            this.btnAtualizarAtivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ativoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // ativoBindingSource
            // 
            this.ativoBindingSource.DataMember = "Ativo";
            this.ativoBindingSource.DataSource = this.ativoDataSet;
            // 
            // ativoDataSet
            // 
            this.ativoDataSet.DataSetName = "AtivoDataSet";
            this.ativoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ativoTableAdapter
            // 
            this.ativoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAtualizarAtivo
            // 
            this.btnAtualizarAtivo.Location = new System.Drawing.Point(12, 179);
            this.btnAtualizarAtivo.Name = "btnAtualizarAtivo";
            this.btnAtualizarAtivo.Size = new System.Drawing.Size(59, 60);
            this.btnAtualizarAtivo.TabIndex = 5;
            this.btnAtualizarAtivo.Text = "Atualizar Ativo";
            this.btnAtualizarAtivo.UseVisualStyleBackColor = true;
            this.btnAtualizarAtivo.Click += new System.EventHandler(this.btn_AtualizarAtivo);
            // 
            // ExibirAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAtualizarAtivo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExibirAtivos";
            this.Text = "ExibirAtivos";
            this.Load += new System.EventHandler(this.ExibirAtivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AtivoDataSet ativoDataSet;
        private System.Windows.Forms.BindingSource ativoBindingSource;
        private AtivoDataSetTableAdapters.AtivoTableAdapter ativoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizarAtivo;
    }
}