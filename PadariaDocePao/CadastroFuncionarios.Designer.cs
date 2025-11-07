namespace PadariaDocePao
{
    partial class CadastroFuncionarios
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
            this.lbCadastroFuncionario = new System.Windows.Forms.Label();
            this.txtDataCad = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNas = new System.Windows.Forms.MaskedTextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbFoneFuncionario = new System.Windows.Forms.Label();
            this.lbCargoFuncionario = new System.Windows.Forms.Label();
            this.lbDataCadCliente = new System.Windows.Forms.Label();
            this.lbDataNasCliente = new System.Windows.Forms.Label();
            this.lbCpfFuncionario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.btSalvarCadastroFuncionario = new System.Windows.Forms.Button();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbCadastroFuncionario
            // 
            this.lbCadastroFuncionario.AutoSize = true;
            this.lbCadastroFuncionario.CausesValidation = false;
            this.lbCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroFuncionario.Location = new System.Drawing.Point(389, 52);
            this.lbCadastroFuncionario.Name = "lbCadastroFuncionario";
            this.lbCadastroFuncionario.Size = new System.Drawing.Size(368, 39);
            this.lbCadastroFuncionario.TabIndex = 1;
            this.lbCadastroFuncionario.Text = "Cadastro Funcionário";
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(329, 425);
            this.txtDataCad.Mask = "00/00/0000";
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(84, 20);
            this.txtDataCad.TabIndex = 26;
            this.txtDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataNas
            // 
            this.txtDataNas.Location = new System.Drawing.Point(331, 365);
            this.txtDataNas.Mask = "00/00/0000";
            this.txtDataNas.Name = "txtDataNas";
            this.txtDataNas.Size = new System.Drawing.Size(82, 20);
            this.txtDataNas.TabIndex = 25;
            this.txtDataNas.ValidatingType = typeof(System.DateTime);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(205, 260);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(297, 20);
            this.txtCargo.TabIndex = 23;
            // 
            // lbFoneFuncionario
            // 
            this.lbFoneFuncionario.AutoSize = true;
            this.lbFoneFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoneFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFoneFuncionario.Location = new System.Drawing.Point(113, 306);
            this.lbFoneFuncionario.Name = "lbFoneFuncionario";
            this.lbFoneFuncionario.Size = new System.Drawing.Size(102, 25);
            this.lbFoneFuncionario.TabIndex = 22;
            this.lbFoneFuncionario.Text = "Telefone:";
            // 
            // lbCargoFuncionario
            // 
            this.lbCargoFuncionario.AutoSize = true;
            this.lbCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargoFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCargoFuncionario.Location = new System.Drawing.Point(113, 255);
            this.lbCargoFuncionario.Name = "lbCargoFuncionario";
            this.lbCargoFuncionario.Size = new System.Drawing.Size(76, 25);
            this.lbCargoFuncionario.TabIndex = 21;
            this.lbCargoFuncionario.Text = "Cargo:";
            // 
            // lbDataCadCliente
            // 
            this.lbDataCadCliente.AutoSize = true;
            this.lbDataCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCadCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataCadCliente.Location = new System.Drawing.Point(113, 422);
            this.lbDataCadCliente.Name = "lbDataCadCliente";
            this.lbDataCadCliente.Size = new System.Drawing.Size(186, 25);
            this.lbDataCadCliente.TabIndex = 20;
            this.lbDataCadCliente.Text = "Data de Cadastro:";
            // 
            // lbDataNasCliente
            // 
            this.lbDataNasCliente.AutoSize = true;
            this.lbDataNasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNasCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataNasCliente.Location = new System.Drawing.Point(113, 362);
            this.lbDataNasCliente.Name = "lbDataNasCliente";
            this.lbDataNasCliente.Size = new System.Drawing.Size(212, 25);
            this.lbDataNasCliente.TabIndex = 19;
            this.lbDataNasCliente.Text = "Data de Nascimento:";
            // 
            // lbCpfFuncionario
            // 
            this.lbCpfFuncionario.AutoSize = true;
            this.lbCpfFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCpfFuncionario.Location = new System.Drawing.Point(113, 205);
            this.lbCpfFuncionario.Name = "lbCpfFuncionario";
            this.lbCpfFuncionario.Size = new System.Drawing.Size(60, 25);
            this.lbCpfFuncionario.TabIndex = 17;
            this.lbCpfFuncionario.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(205, 153);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 16;
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(113, 150);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(74, 25);
            this.lbNomeFuncionario.TabIndex = 15;
            this.lbNomeFuncionario.Text = "Nome:";
            // 
            // btSalvarCadastroFuncionario
            // 
            this.btSalvarCadastroFuncionario.BackColor = System.Drawing.Color.Thistle;
            this.btSalvarCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarCadastroFuncionario.Location = new System.Drawing.Point(846, 552);
            this.btSalvarCadastroFuncionario.Name = "btSalvarCadastroFuncionario";
            this.btSalvarCadastroFuncionario.Size = new System.Drawing.Size(310, 55);
            this.btSalvarCadastroFuncionario.TabIndex = 27;
            this.btSalvarCadastroFuncionario.Text = "Finalizar e Salvar";
            this.btSalvarCadastroFuncionario.UseVisualStyleBackColor = false;
            this.btSalvarCadastroFuncionario.Click += new System.EventHandler(this.btSalvarCadastroFuncionario_Click);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(220, 308);
            this.txtFone.Mask = "(99) 00000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(105, 20);
            this.txtFone.TabIndex = 28;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(186, 209);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(105, 20);
            this.txtCPF.TabIndex = 29;
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1211, 636);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.btSalvarCadastroFuncionario);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.txtDataNas);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lbFoneFuncionario);
            this.Controls.Add(this.lbCargoFuncionario);
            this.Controls.Add(this.lbDataCadCliente);
            this.Controls.Add(this.lbDataNasCliente);
            this.Controls.Add(this.lbCpfFuncionario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.lbCadastroFuncionario);
            this.Name = "CadastroFuncionarios";
            this.Text = "CadastroFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCadastroFuncionario;
        private System.Windows.Forms.MaskedTextBox txtDataCad;
        private System.Windows.Forms.MaskedTextBox txtDataNas;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbFoneFuncionario;
        private System.Windows.Forms.Label lbCargoFuncionario;
        private System.Windows.Forms.Label lbDataCadCliente;
        private System.Windows.Forms.Label lbDataNasCliente;
        private System.Windows.Forms.Label lbCpfFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.Button btSalvarCadastroFuncionario;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}