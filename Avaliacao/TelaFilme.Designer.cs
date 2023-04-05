
namespace Avaliacao
{
    partial class TelaFilme
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.dgvBanco = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sinopse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Classificação";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(117, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(173, 29);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(117, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(291, 29);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopse.Location = new System.Drawing.Point(117, 146);
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(291, 29);
            this.txtSinopse.TabIndex = 7;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(570, 146);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(154, 29);
            this.txtClassificacao.TabIndex = 8;
            // 
            // cbxGenero
            // 
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Terror",
            "Ação",
            "Suspense",
            "Ficção Científica",
            "Documentário",
            "Fantasia",
            "Animação"});
            this.cbxGenero.Location = new System.Drawing.Point(570, 87);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(154, 32);
            this.cbxGenero.TabIndex = 9;
            // 
            // dgvBanco
            // 
            this.dgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanco.Location = new System.Drawing.Point(29, 248);
            this.dgvBanco.Name = "dgvBanco";
            this.dgvBanco.Size = new System.Drawing.Size(695, 179);
            this.dgvBanco.TabIndex = 10;
            this.dgvBanco.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanco_CellContentDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(76, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 36);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(231, 197);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 36);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(400, 197);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 36);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(559, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 36);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // TelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 454);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvBanco);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaFilme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.DataGridView dgvBanco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

