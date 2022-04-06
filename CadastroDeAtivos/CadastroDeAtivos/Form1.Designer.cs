namespace CadastroDeAtivos
{
    partial class fmrCadastroAtivo
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
            this.lblNomeAtivo = new System.Windows.Forms.Label();
            this.txtNomeAtivo = new System.Windows.Forms.TextBox();
            this.btnInserirAtivo = new System.Windows.Forms.Button();
            this.btnExcluirAtivo = new System.Windows.Forms.Button();
            this.btnAtualizarAtivo = new System.Windows.Forms.Button();
            this.btnExibirAtivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeAtivo
            // 
            this.lblNomeAtivo.AutoSize = true;
            this.lblNomeAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAtivo.Location = new System.Drawing.Point(22, 22);
            this.lblNomeAtivo.Name = "lblNomeAtivo";
            this.lblNomeAtivo.Size = new System.Drawing.Size(135, 24);
            this.lblNomeAtivo.TabIndex = 0;
            this.lblNomeAtivo.Text = "Nome do Ativo";
            // 
            // txtNomeAtivo
            // 
            this.txtNomeAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtivo.Location = new System.Drawing.Point(25, 61);
            this.txtNomeAtivo.Name = "txtNomeAtivo";
            this.txtNomeAtivo.Size = new System.Drawing.Size(132, 29);
            this.txtNomeAtivo.TabIndex = 1;
            // 
            // btnInserirAtivo
            // 
            this.btnInserirAtivo.Location = new System.Drawing.Point(25, 137);
            this.btnInserirAtivo.Name = "btnInserirAtivo";
            this.btnInserirAtivo.Size = new System.Drawing.Size(59, 60);
            this.btnInserirAtivo.TabIndex = 2;
            this.btnInserirAtivo.Text = "Inserir Ativo";
            this.btnInserirAtivo.UseVisualStyleBackColor = true;
            this.btnInserirAtivo.Click += new System.EventHandler(this.btn_InserirAtivo);
            // 
            // btnExcluirAtivo
            // 
            this.btnExcluirAtivo.Location = new System.Drawing.Point(90, 137);
            this.btnExcluirAtivo.Name = "btnExcluirAtivo";
            this.btnExcluirAtivo.Size = new System.Drawing.Size(59, 60);
            this.btnExcluirAtivo.TabIndex = 3;
            this.btnExcluirAtivo.Text = "Excluir Ativo";
            this.btnExcluirAtivo.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarAtivo
            // 
            this.btnAtualizarAtivo.Location = new System.Drawing.Point(155, 137);
            this.btnAtualizarAtivo.Name = "btnAtualizarAtivo";
            this.btnAtualizarAtivo.Size = new System.Drawing.Size(59, 60);
            this.btnAtualizarAtivo.TabIndex = 4;
            this.btnAtualizarAtivo.Text = "Atualizar Ativo";
            this.btnAtualizarAtivo.UseVisualStyleBackColor = true;
            this.btnAtualizarAtivo.Click += new System.EventHandler(this.btn_AtualizarAtivo);
            // 
            // btnExibirAtivos
            // 
            this.btnExibirAtivos.Location = new System.Drawing.Point(220, 137);
            this.btnExibirAtivos.Name = "btnExibirAtivos";
            this.btnExibirAtivos.Size = new System.Drawing.Size(59, 60);
            this.btnExibirAtivos.TabIndex = 5;
            this.btnExibirAtivos.Text = "Exibir Ativos";
            this.btnExibirAtivos.UseVisualStyleBackColor = true;
            this.btnExibirAtivos.Click += new System.EventHandler(this.btn_ExibirAtivos);
            // 
            // fmrCadastroAtivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 246);
            this.Controls.Add(this.btnExibirAtivos);
            this.Controls.Add(this.btnAtualizarAtivo);
            this.Controls.Add(this.btnExcluirAtivo);
            this.Controls.Add(this.btnInserirAtivo);
            this.Controls.Add(this.txtNomeAtivo);
            this.Controls.Add(this.lblNomeAtivo);
            this.Name = "fmrCadastroAtivo";
            this.Text = "Tela de Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAtivo;
        private System.Windows.Forms.TextBox txtNomeAtivo;
        private System.Windows.Forms.Button btnInserirAtivo;
        private System.Windows.Forms.Button btnExcluirAtivo;
        private System.Windows.Forms.Button btnAtualizarAtivo;
        private System.Windows.Forms.Button btnExibirAtivos;
    }
}

