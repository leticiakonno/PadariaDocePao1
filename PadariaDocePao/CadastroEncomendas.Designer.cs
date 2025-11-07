namespace PadariaDocePao
{
    partial class CadastroEncomendas
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
            this.lbCadastroEncomendas = new System.Windows.Forms.Label();
            this.btSalvarCadastroEncomendas = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEncomenda = new System.Windows.Forms.MaskedTextBox();
            this.lbDataEncomenda = new System.Windows.Forms.Label();
            this.txtPrevisao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFone = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txtQtdeProduto = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.lbPagamento = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lbObs = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCadastroEncomendas
            // 
            this.lbCadastroEncomendas.AutoSize = true;
            this.lbCadastroEncomendas.CausesValidation = false;
            this.lbCadastroEncomendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroEncomendas.Location = new System.Drawing.Point(316, 32);
            this.lbCadastroEncomendas.Name = "lbCadastroEncomendas";
            this.lbCadastroEncomendas.Size = new System.Drawing.Size(389, 39);
            this.lbCadastroEncomendas.TabIndex = 22;
            this.lbCadastroEncomendas.Text = "Cadastro Encomendas";
            // 
            // btSalvarCadastroEncomendas
            // 
            this.btSalvarCadastroEncomendas.BackColor = System.Drawing.Color.Thistle;
            this.btSalvarCadastroEncomendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCadastroEncomendas.Location = new System.Drawing.Point(852, 634);
            this.btSalvarCadastroEncomendas.Name = "btSalvarCadastroEncomendas";
            this.btSalvarCadastroEncomendas.Size = new System.Drawing.Size(310, 55);
            this.btSalvarCadastroEncomendas.TabIndex = 21;
            this.btSalvarCadastroEncomendas.Text = "Finalizar e Salvar";
            this.btSalvarCadastroEncomendas.UseVisualStyleBackColor = false;
            this.btSalvarCadastroEncomendas.Click += new System.EventHandler(this.btSalvarCadastroEncomendas_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNome.Location = new System.Drawing.Point(79, 91);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(177, 25);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome do Cliente:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCPF.Location = new System.Drawing.Point(79, 136);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(163, 25);
            this.lbCPF.TabIndex = 25;
            this.lbCPF.Text = "CPF do Cliente:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(263, 141);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 26;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtDataEncomenda
            // 
            this.txtDataEncomenda.Location = new System.Drawing.Point(310, 178);
            this.txtDataEncomenda.Mask = "00/00/0000";
            this.txtDataEncomenda.Name = "txtDataEncomenda";
            this.txtDataEncomenda.Size = new System.Drawing.Size(73, 20);
            this.txtDataEncomenda.TabIndex = 28;
            this.txtDataEncomenda.ValidatingType = typeof(System.DateTime);
            // 
            // lbDataEncomenda
            // 
            this.lbDataEncomenda.AutoSize = true;
            this.lbDataEncomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataEncomenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataEncomenda.Location = new System.Drawing.Point(79, 178);
            this.lbDataEncomenda.Name = "lbDataEncomenda";
            this.lbDataEncomenda.Size = new System.Drawing.Size(213, 25);
            this.lbDataEncomenda.TabIndex = 27;
            this.lbDataEncomenda.Text = "Data da Encomenda:";
            // 
            // txtPrevisao
            // 
            this.txtPrevisao.Location = new System.Drawing.Point(317, 426);
            this.txtPrevisao.Mask = "00/00/0000";
            this.txtPrevisao.Name = "txtPrevisao";
            this.txtPrevisao.Size = new System.Drawing.Size(73, 20);
            this.txtPrevisao.TabIndex = 30;
            this.txtPrevisao.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label1.Location = new System.Drawing.Point(86, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Previsão de Entrega:";
            // 
            // lbFone
            // 
            this.lbFone.AutoSize = true;
            this.lbFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFone.Location = new System.Drawing.Point(79, 220);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(102, 25);
            this.lbFone.TabIndex = 31;
            this.lbFone.Text = "Telefone:";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(200, 220);
            this.txtFone.Mask = "(99) 00000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.ReadOnly = true;
            this.txtFone.Size = new System.Drawing.Size(108, 20);
            this.txtFone.TabIndex = 32;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(312, 267);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(297, 20);
            this.txtEndereco.TabIndex = 34;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEndereco.Location = new System.Drawing.Point(79, 264);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(221, 25);
            this.lbEndereco.TabIndex = 33;
            this.lbEndereco.Text = "Endereço de Entrega:";
            // 
            // txtQtdeProduto
            // 
            this.txtQtdeProduto.Location = new System.Drawing.Point(466, 316);
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.Size = new System.Drawing.Size(125, 20);
            this.txtQtdeProduto.TabIndex = 36;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbQuantidade.Location = new System.Drawing.Point(335, 311);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(129, 25);
            this.lbQuantidade.TabIndex = 35;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(319, 529);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(297, 20);
            this.txtPagamento.TabIndex = 38;
            // 
            // lbPagamento
            // 
            this.lbPagamento.AutoSize = true;
            this.lbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPagamento.Location = new System.Drawing.Point(86, 526);
            this.lbPagamento.Name = "lbPagamento";
            this.lbPagamento.Size = new System.Drawing.Size(224, 25);
            this.lbPagamento.TabIndex = 37;
            this.lbPagamento.Text = "Forma de Pagamento:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbProduto.Location = new System.Drawing.Point(79, 311);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(93, 25);
            this.lbProduto.TabIndex = 39;
            this.lbProduto.Text = "Produto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(262, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 42;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(247, 587);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(678, 20);
            this.txtObs.TabIndex = 44;
            // 
            // lbObs
            // 
            this.lbObs.AutoSize = true;
            this.lbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbObs.Location = new System.Drawing.Point(86, 582);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(145, 25);
            this.lbObs.TabIndex = 43;
            this.lbObs.Text = "Observações:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(178, 314);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(146, 21);
            this.cbProduto.TabIndex = 45;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(167, 477);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(297, 20);
            this.txtTotal.TabIndex = 47;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotal.Location = new System.Drawing.Point(86, 475);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(66, 25);
            this.lbTotal.TabIndex = 46;
            this.lbTotal.Text = "Total:";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.BackColor = System.Drawing.Color.Pink;
            this.btAdicionarProduto.Location = new System.Drawing.Point(84, 360);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(507, 27);
            this.btAdicionarProduto.TabIndex = 48;
            this.btAdicionarProduto.Text = "Adicionar Produto";
            this.btAdicionarProduto.UseVisualStyleBackColor = false;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click_1);
            // 
            // dgvItens
            // 
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(679, 105);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(442, 273);
            this.dgvItens.TabIndex = 49;
            // 
            // CadastroEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1182, 710);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.btAdicionarProduto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lbObs);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.lbPagamento);
            this.Controls.Add(this.txtQtdeProduto);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.lbFone);
            this.Controls.Add(this.txtPrevisao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataEncomenda);
            this.Controls.Add(this.lbDataEncomenda);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCadastroEncomendas);
            this.Controls.Add(this.btSalvarCadastroEncomendas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CadastroEncomendas";
            this.Text = "CadastroEncomendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCadastroEncomendas;
        private System.Windows.Forms.Button btSalvarCadastroEncomendas;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtDataEncomenda;
        private System.Windows.Forms.Label lbDataEncomenda;
        private System.Windows.Forms.MaskedTextBox txtPrevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFone;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox txtQtdeProduto;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Label lbPagamento;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lbObs;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.DataGridView dgvItens;
    }
}