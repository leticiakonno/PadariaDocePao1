namespace PadariaDocePao
{
    partial class ConsultaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProdutos));
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbConsultaProdutos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.tbProdutosTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbProdutosTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(656, 571);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(153, 23);
            this.btVisualizar.TabIndex = 29;
            this.btVisualizar.Text = "Visualizar Impressão";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(636, 115);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 28;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(726, 115);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 27;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbConsultaProdutos
            // 
            this.lbConsultaProdutos.AutoSize = true;
            this.lbConsultaProdutos.CausesValidation = false;
            this.lbConsultaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaProdutos.Location = new System.Drawing.Point(285, 52);
            this.lbConsultaProdutos.Name = "lbConsultaProdutos";
            this.lbConsultaProdutos.Size = new System.Drawing.Size(319, 39);
            this.lbConsultaProdutos.TabIndex = 26;
            this.lbConsultaProdutos.Text = "Consulta Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprodutoDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.descriprodutoDataGridViewTextBoxColumn,
            this.categoriaprodutoDataGridViewTextBoxColumn,
            this.valorprodutoDataGridViewTextBoxColumn,
            this.qtdeprodutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProdutosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 376);
            this.dataGridView1.TabIndex = 30;
            // 
            // codprodutoDataGridViewTextBoxColumn
            // 
            this.codprodutoDataGridViewTextBoxColumn.DataPropertyName = "cod_produto";
            this.codprodutoDataGridViewTextBoxColumn.HeaderText = "cod_produto";
            this.codprodutoDataGridViewTextBoxColumn.Name = "codprodutoDataGridViewTextBoxColumn";
            this.codprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            // 
            // descriprodutoDataGridViewTextBoxColumn
            // 
            this.descriprodutoDataGridViewTextBoxColumn.DataPropertyName = "descri_produto";
            this.descriprodutoDataGridViewTextBoxColumn.HeaderText = "descri_produto";
            this.descriprodutoDataGridViewTextBoxColumn.Name = "descriprodutoDataGridViewTextBoxColumn";
            // 
            // categoriaprodutoDataGridViewTextBoxColumn
            // 
            this.categoriaprodutoDataGridViewTextBoxColumn.DataPropertyName = "categoria_produto";
            this.categoriaprodutoDataGridViewTextBoxColumn.HeaderText = "categoria_produto";
            this.categoriaprodutoDataGridViewTextBoxColumn.Name = "categoriaprodutoDataGridViewTextBoxColumn";
            // 
            // valorprodutoDataGridViewTextBoxColumn
            // 
            this.valorprodutoDataGridViewTextBoxColumn.DataPropertyName = "valor_produto";
            this.valorprodutoDataGridViewTextBoxColumn.HeaderText = "valor_produto";
            this.valorprodutoDataGridViewTextBoxColumn.Name = "valorprodutoDataGridViewTextBoxColumn";
            // 
            // qtdeprodutoDataGridViewTextBoxColumn
            // 
            this.qtdeprodutoDataGridViewTextBoxColumn.DataPropertyName = "qtde_produto";
            this.qtdeprodutoDataGridViewTextBoxColumn.HeaderText = "qtde_produto";
            this.qtdeprodutoDataGridViewTextBoxColumn.Name = "qtdeprodutoDataGridViewTextBoxColumn";
            // 
            // tbProdutosBindingSource
            // 
            this.tbProdutosBindingSource.DataMember = "tbProdutos";
            this.tbProdutosBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutosTableAdapter
            // 
            this.tbProdutosTableAdapter.ClearBeforeFill = true;
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
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(948, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbConsultaProdutos);
            this.Name = "ConsultaProdutos";
            this.Text = "ConsultaProdutos";
            this.Load += new System.EventHandler(this.ConsultaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbConsultaProdutos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbProdutosBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbProdutosTableAdapter tbProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeprodutoDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}