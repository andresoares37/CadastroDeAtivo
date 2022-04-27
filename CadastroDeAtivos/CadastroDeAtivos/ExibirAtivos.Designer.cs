namespace CadastroDeAtivos
{
    partial class fmrExibirAtivos
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
            this.ativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativoDataSet = new CadastroDeAtivos.AtivoDataSet();
            this.ativoTableAdapter = new CadastroDeAtivos.AtivoDataSetTableAdapters.AtivoTableAdapter();
            this.btnEditarAtivo = new System.Windows.Forms.Button();
            this.btnExcluirAtivo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ativoDataSet1 = new CadastroDeAtivos.AtivoDataSet();
            this.ativoDataSet2 = new CadastroDeAtivos.AtivoDataSet2();
            this.ativoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ativoTableAdapter1 = new CadastroDeAtivos.AtivoDataSet2TableAdapters.AtivoTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblNomeAtivo = new System.Windows.Forms.Label();
            this.txtNomeAtivo = new System.Windows.Forms.TextBox();
            this.dgvAtivos = new System.Windows.Forms.DataGridView();
            this.btnNovoAtivo = new System.Windows.Forms.Button();
            this.btnInserirAtivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtivos)).BeginInit();
            this.SuspendLayout();
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
            // btnEditarAtivo
            // 
            this.btnEditarAtivo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAtivo.Location = new System.Drawing.Point(198, 281);
            this.btnEditarAtivo.Name = "btnEditarAtivo";
            this.btnEditarAtivo.Size = new System.Drawing.Size(75, 59);
            this.btnEditarAtivo.TabIndex = 0;
            this.btnEditarAtivo.Text = "Editar Ativo";
            this.btnEditarAtivo.UseVisualStyleBackColor = true;
            this.btnEditarAtivo.Click += new System.EventHandler(this.btn_EditarAtivo);
            // 
            // btnExcluirAtivo
            // 
            this.btnExcluirAtivo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAtivo.Location = new System.Drawing.Point(279, 281);
            this.btnExcluirAtivo.Name = "btnExcluirAtivo";
            this.btnExcluirAtivo.Size = new System.Drawing.Size(79, 59);
            this.btnExcluirAtivo.TabIndex = 1;
            this.btnExcluirAtivo.Text = "Excluir Ativo";
            this.btnExcluirAtivo.UseVisualStyleBackColor = true;
            this.btnExcluirAtivo.Click += new System.EventHandler(this.btn_ExcluirAtivo);
            // 
            // ativoDataSet1
            // 
            this.ativoDataSet1.DataSetName = "AtivoDataSet";
            this.ativoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ativoDataSet2
            // 
            this.ativoDataSet2.DataSetName = "AtivoDataSet2";
            this.ativoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ativoBindingSource1
            // 
            this.ativoBindingSource1.DataMember = "Ativo";
            this.ativoBindingSource1.DataSource = this.ativoDataSet2;
            // 
            // ativoTableAdapter1
            // 
            this.ativoTableAdapter1.ClearBeforeFill = true;
            // 
            // lblNomeAtivo
            // 
            this.lblNomeAtivo.AutoSize = true;
            this.lblNomeAtivo.Font = new System.Drawing.Font("Dubai Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAtivo.Location = new System.Drawing.Point(22, 39);
            this.lblNomeAtivo.Name = "lblNomeAtivo";
            this.lblNomeAtivo.Size = new System.Drawing.Size(130, 36);
            this.lblNomeAtivo.TabIndex = 4;
            this.lblNomeAtivo.Text = "Nome Ativo";
            // 
            // txtNomeAtivo
            // 
            this.txtNomeAtivo.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtivo.Location = new System.Drawing.Point(172, 32);
            this.txtNomeAtivo.Name = "txtNomeAtivo";
            this.txtNomeAtivo.Size = new System.Drawing.Size(186, 43);
            this.txtNomeAtivo.TabIndex = 5;
            // 
            // dgvAtivos
            // 
            this.dgvAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtivos.Location = new System.Drawing.Point(28, 98);
            this.dgvAtivos.Name = "dgvAtivos";
            this.dgvAtivos.Size = new System.Drawing.Size(330, 150);
            this.dgvAtivos.TabIndex = 6;
            this.dgvAtivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtivos_CellContentClick);
            // 
            // btnNovoAtivo
            // 
            this.btnNovoAtivo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAtivo.Location = new System.Drawing.Point(28, 281);
            this.btnNovoAtivo.Name = "btnNovoAtivo";
            this.btnNovoAtivo.Size = new System.Drawing.Size(79, 59);
            this.btnNovoAtivo.TabIndex = 7;
            this.btnNovoAtivo.Text = "Novo Ativo";
            this.btnNovoAtivo.UseVisualStyleBackColor = true;
            this.btnNovoAtivo.Click += new System.EventHandler(this.btn_NovoAtivo);
            // 
            // btnInserirAtivo
            // 
            this.btnInserirAtivo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAtivo.Location = new System.Drawing.Point(113, 281);
            this.btnInserirAtivo.Name = "btnInserirAtivo";
            this.btnInserirAtivo.Size = new System.Drawing.Size(79, 59);
            this.btnInserirAtivo.TabIndex = 8;
            this.btnInserirAtivo.Text = "Inserir Ativo";
            this.btnInserirAtivo.UseVisualStyleBackColor = true;
            this.btnInserirAtivo.Click += new System.EventHandler(this.btn_InserirAtivo);
            // 
            // fmrExibirAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 361);
            this.Controls.Add(this.btnInserirAtivo);
            this.Controls.Add(this.btnNovoAtivo);
            this.Controls.Add(this.dgvAtivos);
            this.Controls.Add(this.txtNomeAtivo);
            this.Controls.Add(this.lblNomeAtivo);
            this.Controls.Add(this.btnExcluirAtivo);
            this.Controls.Add(this.btnEditarAtivo);
            this.Name = "fmrExibirAtivos";
            this.Text = "ExibirAtivos";
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ativoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AtivoDataSet ativoDataSet;
        private System.Windows.Forms.BindingSource ativoBindingSource;
        private AtivoDataSetTableAdapters.AtivoTableAdapter ativoTableAdapter;
        private System.Windows.Forms.Button btnEditarAtivo;
        private System.Windows.Forms.Button btnExcluirAtivo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AtivoDataSet ativoDataSet1;
        private AtivoDataSet2 ativoDataSet2;
        private System.Windows.Forms.BindingSource ativoBindingSource1;
        private AtivoDataSet2TableAdapters.AtivoTableAdapter ativoTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Label lblNomeAtivo;
        private System.Windows.Forms.TextBox txtNomeAtivo;
        private System.Windows.Forms.DataGridView dgvAtivos;
        private System.Windows.Forms.Button btnNovoAtivo;
        private System.Windows.Forms.Button btnInserirAtivo;
    }
}