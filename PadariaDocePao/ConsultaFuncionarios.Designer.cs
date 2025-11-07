namespace PadariaDocePao
{
    partial class ConsultaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFuncionarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargofuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpffuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonefuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFuncionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.tbFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbConsultaFuncionario = new System.Windows.Forms.Label();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbFornecedoresTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbFornecedoresTableAdapter();
            this.tbFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFuncionariosTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbFuncionariosTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codfuncionarioDataGridViewTextBoxColumn,
            this.nomefuncionarioDataGridViewTextBoxColumn,
            this.cargofuncionarioDataGridViewTextBoxColumn,
            this.datanasfuncionarioDataGridViewTextBoxColumn,
            this.cpffuncionarioDataGridViewTextBoxColumn,
            this.datacadfuncionarioDataGridViewTextBoxColumn,
            this.fonefuncionarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbFuncionariosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(132, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // codfuncionarioDataGridViewTextBoxColumn
            // 
            this.codfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.HeaderText = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.Name = "codfuncionarioDataGridViewTextBoxColumn";
            this.codfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefuncionarioDataGridViewTextBoxColumn
            // 
            this.nomefuncionarioDataGridViewTextBoxColumn.DataPropertyName = "nome_funcionario";
            this.nomefuncionarioDataGridViewTextBoxColumn.HeaderText = "nome_funcionario";
            this.nomefuncionarioDataGridViewTextBoxColumn.Name = "nomefuncionarioDataGridViewTextBoxColumn";
            // 
            // cargofuncionarioDataGridViewTextBoxColumn
            // 
            this.cargofuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cargo_funcionario";
            this.cargofuncionarioDataGridViewTextBoxColumn.HeaderText = "cargo_funcionario";
            this.cargofuncionarioDataGridViewTextBoxColumn.Name = "cargofuncionarioDataGridViewTextBoxColumn";
            // 
            // datanasfuncionarioDataGridViewTextBoxColumn
            // 
            this.datanasfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "data_nas_funcionario";
            this.datanasfuncionarioDataGridViewTextBoxColumn.HeaderText = "data_nas_funcionario";
            this.datanasfuncionarioDataGridViewTextBoxColumn.Name = "datanasfuncionarioDataGridViewTextBoxColumn";
            // 
            // cpffuncionarioDataGridViewTextBoxColumn
            // 
            this.cpffuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cpf_funcionario";
            this.cpffuncionarioDataGridViewTextBoxColumn.HeaderText = "cpf_funcionario";
            this.cpffuncionarioDataGridViewTextBoxColumn.Name = "cpffuncionarioDataGridViewTextBoxColumn";
            // 
            // datacadfuncionarioDataGridViewTextBoxColumn
            // 
            this.datacadfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "data_cad_funcionario";
            this.datacadfuncionarioDataGridViewTextBoxColumn.HeaderText = "data_cad_funcionario";
            this.datacadfuncionarioDataGridViewTextBoxColumn.Name = "datacadfuncionarioDataGridViewTextBoxColumn";
            // 
            // fonefuncionarioDataGridViewTextBoxColumn
            // 
            this.fonefuncionarioDataGridViewTextBoxColumn.DataPropertyName = "fone_funcionario";
            this.fonefuncionarioDataGridViewTextBoxColumn.HeaderText = "fone_funcionario";
            this.fonefuncionarioDataGridViewTextBoxColumn.Name = "fonefuncionarioDataGridViewTextBoxColumn";
            // 
            // tbFuncionariosBindingSource1
            // 
            this.tbFuncionariosBindingSource1.DataMember = "tbFuncionarios";
            this.tbFuncionariosBindingSource1.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedoresBindingSource
            // 
            this.tbFornecedoresBindingSource.DataMember = "tbFornecedores";
            this.tbFornecedoresBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // lbConsultaFuncionario
            // 
            this.lbConsultaFuncionario.AutoSize = true;
            this.lbConsultaFuncionario.CausesValidation = false;
            this.lbConsultaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaFuncionario.Location = new System.Drawing.Point(273, 31);
            this.lbConsultaFuncionario.Name = "lbConsultaFuncionario";
            this.lbConsultaFuncionario.Size = new System.Drawing.Size(383, 39);
            this.lbConsultaFuncionario.TabIndex = 19;
            this.lbConsultaFuncionario.Text = "Consulta Funcionários";
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(724, 570);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(153, 23);
            this.btVisualizar.TabIndex = 22;
            this.btVisualizar.Text = "Visualizar Impressão";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(712, 84);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(802, 84);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 20;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbFornecedoresTableAdapter
            // 
            this.tbFornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tbFuncionariosBindingSource
            // 
            this.tbFuncionariosBindingSource.DataMember = "tbFuncionarios";
            this.tbFuncionariosBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // tbFuncionariosTableAdapter
            // 
            this.tbFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(998, 630);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbConsultaFuncionario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaFuncionarios";
            this.Text = "ConsultaFuncionario";
            this.Load += new System.EventHandler(this.ConsultaFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbConsultaFuncionario;
        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbFornecedoresBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbFornecedoresTableAdapter tbFornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbFuncionariosTableAdapter tbFuncionariosTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargofuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpffuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbFuncionariosBindingSource1;
    }
}