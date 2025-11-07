namespace PadariaDocePao
{
    partial class CadastroFornecedores
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
            this.btSalvarCadastroFornecedor = new System.Windows.Forms.Button();
            this.lbCadastroFornecedor = new System.Windows.Forms.Label();
            this.txtDataCad = new System.Windows.Forms.MaskedTextBox();
            this.lbFoneFornecedor = new System.Windows.Forms.Label();
            this.lbDataCadFornecedor = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.lbInscEstadual = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btSalvarCadastroFornecedor
            // 
            this.btSalvarCadastroFornecedor.BackColor = System.Drawing.Color.Thistle;
            this.btSalvarCadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCadastroFornecedor.Location = new System.Drawing.Point(681, 533);
            this.btSalvarCadastroFornecedor.Name = "btSalvarCadastroFornecedor";
            this.btSalvarCadastroFornecedor.Size = new System.Drawing.Size(310, 55);
            this.btSalvarCadastroFornecedor.TabIndex = 17;
            this.btSalvarCadastroFornecedor.Text = "Finalizar e Salvar";
            this.btSalvarCadastroFornecedor.UseVisualStyleBackColor = false;
            this.btSalvarCadastroFornecedor.Click += new System.EventHandler(this.btSalvarCadastroFornecedor_Click);
            // 
            // lbCadastroFornecedor
            // 
            this.lbCadastroFornecedor.AutoSize = true;
            this.lbCadastroFornecedor.CausesValidation = false;
            this.lbCadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroFornecedor.Location = new System.Drawing.Point(308, 55);
            this.lbCadastroFornecedor.Name = "lbCadastroFornecedor";
            this.lbCadastroFornecedor.Size = new System.Drawing.Size(363, 39);
            this.lbCadastroFornecedor.TabIndex = 16;
            this.lbCadastroFornecedor.Text = "Cadastro Fornecedor";
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(333, 328);
            this.txtDataCad.Mask = "00/00/0000";
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(63, 20);
            this.txtDataCad.TabIndex = 25;
            this.txtDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // lbFoneFornecedor
            // 
            this.lbFoneFornecedor.AutoSize = true;
            this.lbFoneFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoneFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFoneFornecedor.Location = new System.Drawing.Point(125, 269);
            this.lbFoneFornecedor.Name = "lbFoneFornecedor";
            this.lbFoneFornecedor.Size = new System.Drawing.Size(102, 25);
            this.lbFoneFornecedor.TabIndex = 23;
            this.lbFoneFornecedor.Text = "Telefone:";
            // 
            // lbDataCadFornecedor
            // 
            this.lbDataCadFornecedor.AutoSize = true;
            this.lbDataCadFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataCadFornecedor.Location = new System.Drawing.Point(125, 325);
            this.lbDataCadFornecedor.Name = "lbDataCadFornecedor";
            this.lbDataCadFornecedor.Size = new System.Drawing.Size(186, 25);
            this.lbDataCadFornecedor.TabIndex = 22;
            this.lbDataCadFornecedor.Text = "Data de Cadastro:";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCNPJ.Location = new System.Drawing.Point(126, 208);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(73, 25);
            this.lbCNPJ.TabIndex = 20;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(217, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 19;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeCliente.Location = new System.Drawing.Point(125, 149);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(74, 25);
            this.lbNomeCliente.TabIndex = 18;
            this.lbNomeCliente.Text = "Nome:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(289, 384);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(297, 20);
            this.txtRazaoSocial.TabIndex = 27;
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRazaoSocial.Location = new System.Drawing.Point(125, 383);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(145, 25);
            this.lbRazaoSocial.TabIndex = 26;
            this.lbRazaoSocial.Text = "Razão Social:";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(331, 440);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(297, 20);
            this.txtInscEstadual.TabIndex = 29;
            // 
            // lbInscEstadual
            // 
            this.lbInscEstadual.AutoSize = true;
            this.lbInscEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInscEstadual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInscEstadual.Location = new System.Drawing.Point(125, 438);
            this.lbInscEstadual.Name = "lbInscEstadual";
            this.lbInscEstadual.Size = new System.Drawing.Size(194, 25);
            this.lbInscEstadual.TabIndex = 28;
            this.lbInscEstadual.Text = "Inscrição Estadual:";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(233, 273);
            this.txtFone.Mask = "(99) 00000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(119, 20);
            this.txtFone.TabIndex = 30;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(210, 209);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(133, 20);
            this.txtCNPJ.TabIndex = 31;
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1050, 626);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.lbInscEstadual);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lbRazaoSocial);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.lbFoneFornecedor);
            this.Controls.Add(this.lbDataCadFornecedor);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.btSalvarCadastroFornecedor);
            this.Controls.Add(this.lbCadastroFornecedor);
            this.Name = "CadastroFornecedor";
            this.Text = "CadastroFornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvarCadastroFornecedor;
        private System.Windows.Forms.Label lbCadastroFornecedor;
        private System.Windows.Forms.MaskedTextBox txtDataCad;
        private System.Windows.Forms.Label lbFoneFornecedor;
        private System.Windows.Forms.Label lbDataCadFornecedor;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lbRazaoSocial;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label lbInscEstadual;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
    }
}