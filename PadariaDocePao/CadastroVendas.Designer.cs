namespace PadariaDocePao
{
    partial class CadastroVendas
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
            this.lbCadastroVendas = new System.Windows.Forms.Label();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbQtdVenda = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lbDataVenda = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.lbValorVenda = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbPagamento = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.btSalvarCadastroVenda = new System.Windows.Forms.Button();
            this.cbProdutoVenda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCadastroVendas
            // 
            this.lbCadastroVendas.AutoSize = true;
            this.lbCadastroVendas.CausesValidation = false;
            this.lbCadastroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroVendas.Location = new System.Drawing.Point(445, 59);
            this.lbCadastroVendas.Name = "lbCadastroVendas";
            this.lbCadastroVendas.Size = new System.Drawing.Size(299, 39);
            this.lbCadastroVendas.TabIndex = 2;
            this.lbCadastroVendas.Text = "Cadastro Vendas";
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeProduto.Location = new System.Drawing.Point(92, 136);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(178, 25);
            this.lbNomeProduto.TabIndex = 17;
            this.lbNomeProduto.Text = "Produto Vendido:";
            // 
            // lbQtdVenda
            // 
            this.lbQtdVenda.AutoSize = true;
            this.lbQtdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbQtdVenda.Location = new System.Drawing.Point(92, 205);
            this.lbQtdVenda.Name = "lbQtdVenda";
            this.lbQtdVenda.Size = new System.Drawing.Size(129, 25);
            this.lbQtdVenda.TabIndex = 19;
            this.lbQtdVenda.Text = "Quantidade:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(234, 205);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(175, 20);
            this.txtQtde.TabIndex = 20;
            // 
            // lbDataVenda
            // 
            this.lbDataVenda.AutoSize = true;
            this.lbDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataVenda.Location = new System.Drawing.Point(92, 277);
            this.lbDataVenda.Name = "lbDataVenda";
            this.lbDataVenda.Size = new System.Drawing.Size(161, 25);
            this.lbDataVenda.TabIndex = 21;
            this.lbDataVenda.Text = "Data da Venda:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(269, 281);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(76, 20);
            this.txtDataVenda.TabIndex = 22;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // lbValorVenda
            // 
            this.lbValorVenda.AutoSize = true;
            this.lbValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValorVenda.Location = new System.Drawing.Point(92, 346);
            this.lbValorVenda.Name = "lbValorVenda";
            this.lbValorVenda.Size = new System.Drawing.Size(166, 25);
            this.lbValorVenda.TabIndex = 23;
            this.lbValorVenda.Text = "Valor da Venda:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(278, 350);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(176, 20);
            this.txtValor.TabIndex = 24;
            // 
            // lbPagamento
            // 
            this.lbPagamento.AutoSize = true;
            this.lbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPagamento.Location = new System.Drawing.Point(92, 423);
            this.lbPagamento.Name = "lbPagamento";
            this.lbPagamento.Size = new System.Drawing.Size(224, 25);
            this.lbPagamento.TabIndex = 25;
            this.lbPagamento.Text = "Forma de Pagamento:";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(324, 426);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(176, 20);
            this.txtPagamento.TabIndex = 26;
            // 
            // btSalvarCadastroVenda
            // 
            this.btSalvarCadastroVenda.BackColor = System.Drawing.Color.Thistle;
            this.btSalvarCadastroVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCadastroVenda.Location = new System.Drawing.Point(867, 542);
            this.btSalvarCadastroVenda.Name = "btSalvarCadastroVenda";
            this.btSalvarCadastroVenda.Size = new System.Drawing.Size(310, 55);
            this.btSalvarCadastroVenda.TabIndex = 28;
            this.btSalvarCadastroVenda.Text = "Finalizar e Salvar";
            this.btSalvarCadastroVenda.UseVisualStyleBackColor = false;
            this.btSalvarCadastroVenda.Click += new System.EventHandler(this.btSalvarCadastroVenda_Click);
            // 
            // cbProdutoVenda
            // 
            this.cbProdutoVenda.FormattingEnabled = true;
            this.cbProdutoVenda.Location = new System.Drawing.Point(282, 138);
            this.cbProdutoVenda.Name = "cbProdutoVenda";
            this.cbProdutoVenda.Size = new System.Drawing.Size(191, 21);
            this.cbProdutoVenda.TabIndex = 29;
            // 
            // CadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1231, 636);
            this.Controls.Add(this.cbProdutoVenda);
            this.Controls.Add(this.btSalvarCadastroVenda);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.lbPagamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbValorVenda);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.lbDataVenda);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.lbQtdVenda);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.lbCadastroVendas);
            this.Name = "CadastroVendas";
            this.Text = "CadastroVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCadastroVendas;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbQtdVenda;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lbDataVenda;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.Label lbValorVenda;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbPagamento;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button btSalvarCadastroVenda;
        private System.Windows.Forms.ComboBox cbProdutoVenda;
    }
}