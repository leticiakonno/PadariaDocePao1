namespace PadariaDocePao
{
    partial class ConsultaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFornecedores));
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbConsultaFornecedor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonefornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscestadualfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.tbFornecedoresTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbFornecedoresTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(771, 517);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(153, 23);
            this.btVisualizar.TabIndex = 18;
            this.btVisualizar.Text = "Visualizar Impressão";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(759, 92);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 17;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(849, 92);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbConsultaFornecedor
            // 
            this.lbConsultaFornecedor.AutoSize = true;
            this.lbConsultaFornecedor.CausesValidation = false;
            this.lbConsultaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaFornecedor.Location = new System.Drawing.Point(355, 32);
            this.lbConsultaFornecedor.Name = "lbConsultaFornecedor";
            this.lbConsultaFornecedor.Size = new System.Drawing.Size(359, 39);
            this.lbConsultaFornecedor.TabIndex = 15;
            this.lbConsultaFornecedor.Text = "Consulta Fornecedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codfornecedorDataGridViewTextBoxColumn,
            this.nomefornecedorDataGridViewTextBoxColumn,
            this.cnpjfornecedorDataGridViewTextBoxColumn,
            this.fonefornecedorDataGridViewTextBoxColumn,
            this.datacadfornecedorDataGridViewTextBoxColumn,
            this.razaosocialfornecedorDataGridViewTextBoxColumn,
            this.inscestadualfornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbFornecedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 346);
            this.dataGridView1.TabIndex = 19;
            // 
            // codfornecedorDataGridViewTextBoxColumn
            // 
            this.codfornecedorDataGridViewTextBoxColumn.DataPropertyName = "cod_fornecedor";
            this.codfornecedorDataGridViewTextBoxColumn.HeaderText = "cod_fornecedor";
            this.codfornecedorDataGridViewTextBoxColumn.Name = "codfornecedorDataGridViewTextBoxColumn";
            this.codfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefornecedorDataGridViewTextBoxColumn
            // 
            this.nomefornecedorDataGridViewTextBoxColumn.DataPropertyName = "nome_fornecedor";
            this.nomefornecedorDataGridViewTextBoxColumn.HeaderText = "nome_fornecedor";
            this.nomefornecedorDataGridViewTextBoxColumn.Name = "nomefornecedorDataGridViewTextBoxColumn";
            // 
            // cnpjfornecedorDataGridViewTextBoxColumn
            // 
            this.cnpjfornecedorDataGridViewTextBoxColumn.DataPropertyName = "cnpj_fornecedor";
            this.cnpjfornecedorDataGridViewTextBoxColumn.HeaderText = "cnpj_fornecedor";
            this.cnpjfornecedorDataGridViewTextBoxColumn.Name = "cnpjfornecedorDataGridViewTextBoxColumn";
            // 
            // fonefornecedorDataGridViewTextBoxColumn
            // 
            this.fonefornecedorDataGridViewTextBoxColumn.DataPropertyName = "fone_fornecedor";
            this.fonefornecedorDataGridViewTextBoxColumn.HeaderText = "fone_fornecedor";
            this.fonefornecedorDataGridViewTextBoxColumn.Name = "fonefornecedorDataGridViewTextBoxColumn";
            // 
            // datacadfornecedorDataGridViewTextBoxColumn
            // 
            this.datacadfornecedorDataGridViewTextBoxColumn.DataPropertyName = "data_cad_fornecedor";
            this.datacadfornecedorDataGridViewTextBoxColumn.HeaderText = "data_cad_fornecedor";
            this.datacadfornecedorDataGridViewTextBoxColumn.Name = "datacadfornecedorDataGridViewTextBoxColumn";
            // 
            // razaosocialfornecedorDataGridViewTextBoxColumn
            // 
            this.razaosocialfornecedorDataGridViewTextBoxColumn.DataPropertyName = "razao_social_fornecedor";
            this.razaosocialfornecedorDataGridViewTextBoxColumn.HeaderText = "razao_social_fornecedor";
            this.razaosocialfornecedorDataGridViewTextBoxColumn.Name = "razaosocialfornecedorDataGridViewTextBoxColumn";
            // 
            // inscestadualfornecedorDataGridViewTextBoxColumn
            // 
            this.inscestadualfornecedorDataGridViewTextBoxColumn.DataPropertyName = "insc_estadual_fornecedor";
            this.inscestadualfornecedorDataGridViewTextBoxColumn.HeaderText = "insc_estadual_fornecedor";
            this.inscestadualfornecedorDataGridViewTextBoxColumn.Name = "inscestadualfornecedorDataGridViewTextBoxColumn";
            // 
            // tbFornecedoresBindingSource
            // 
            this.tbFornecedoresBindingSource.DataMember = "tbFornecedores";
            this.tbFornecedoresBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedoresTableAdapter
            // 
            this.tbFornecedoresTableAdapter.ClearBeforeFill = true;
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
            // ConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1113, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbConsultaFornecedor);
            this.Name = "ConsultaFornecedores";
            this.Text = "ConsultaFornecedores";
            this.Load += new System.EventHandler(this.ConsultaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbConsultaFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbFornecedoresBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbFornecedoresTableAdapter tbFornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonefornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscestadualfornecedorDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}