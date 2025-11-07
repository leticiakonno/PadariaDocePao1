namespace PadariaDocePao
{
    partial class ConsultaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVendas));
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbConsultaVendas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.tbVendasTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbVendasTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(622, 612);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(153, 23);
            this.btVisualizar.TabIndex = 33;
            this.btVisualizar.Text = "Visualizar Impressão";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(609, 117);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 32;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(699, 117);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 31;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // lbConsultaVendas
            // 
            this.lbConsultaVendas.AutoSize = true;
            this.lbConsultaVendas.CausesValidation = false;
            this.lbConsultaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaVendas.Location = new System.Drawing.Point(295, 57);
            this.lbConsultaVendas.Name = "lbConsultaVendas";
            this.lbConsultaVendas.Size = new System.Drawing.Size(295, 39);
            this.lbConsultaVendas.TabIndex = 30;
            this.lbConsultaVendas.Text = "Consulta Vendas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codvendaDataGridViewTextBoxColumn,
            this.produtovendaDataGridViewTextBoxColumn,
            this.qtdevendaDataGridViewTextBoxColumn,
            this.datavendaDataGridViewTextBoxColumn,
            this.valorvendaDataGridViewTextBoxColumn,
            this.pagamentovendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbVendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 415);
            this.dataGridView1.TabIndex = 34;
            // 
            // codvendaDataGridViewTextBoxColumn
            // 
            this.codvendaDataGridViewTextBoxColumn.DataPropertyName = "cod_venda";
            this.codvendaDataGridViewTextBoxColumn.HeaderText = "cod_venda";
            this.codvendaDataGridViewTextBoxColumn.Name = "codvendaDataGridViewTextBoxColumn";
            this.codvendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtovendaDataGridViewTextBoxColumn
            // 
            this.produtovendaDataGridViewTextBoxColumn.DataPropertyName = "produto_venda";
            this.produtovendaDataGridViewTextBoxColumn.HeaderText = "produto_venda";
            this.produtovendaDataGridViewTextBoxColumn.Name = "produtovendaDataGridViewTextBoxColumn";
            // 
            // qtdevendaDataGridViewTextBoxColumn
            // 
            this.qtdevendaDataGridViewTextBoxColumn.DataPropertyName = "qtde_venda";
            this.qtdevendaDataGridViewTextBoxColumn.HeaderText = "qtde_venda";
            this.qtdevendaDataGridViewTextBoxColumn.Name = "qtdevendaDataGridViewTextBoxColumn";
            // 
            // datavendaDataGridViewTextBoxColumn
            // 
            this.datavendaDataGridViewTextBoxColumn.DataPropertyName = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.HeaderText = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.Name = "datavendaDataGridViewTextBoxColumn";
            // 
            // valorvendaDataGridViewTextBoxColumn
            // 
            this.valorvendaDataGridViewTextBoxColumn.DataPropertyName = "valor_venda";
            this.valorvendaDataGridViewTextBoxColumn.HeaderText = "valor_venda";
            this.valorvendaDataGridViewTextBoxColumn.Name = "valorvendaDataGridViewTextBoxColumn";
            // 
            // pagamentovendaDataGridViewTextBoxColumn
            // 
            this.pagamentovendaDataGridViewTextBoxColumn.DataPropertyName = "pagamento_venda";
            this.pagamentovendaDataGridViewTextBoxColumn.HeaderText = "pagamento_venda";
            this.pagamentovendaDataGridViewTextBoxColumn.Name = "pagamentovendaDataGridViewTextBoxColumn";
            // 
            // tbVendasBindingSource
            // 
            this.tbVendasBindingSource.DataMember = "tbVendas";
            this.tbVendasBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVendasTableAdapter
            // 
            this.tbVendasTableAdapter.ClearBeforeFill = true;
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
            // ConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(902, 668);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbConsultaVendas);
            this.Name = "ConsultaVendas";
            this.Text = "ConsultaVendas";
            this.Load += new System.EventHandler(this.ConsultaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbConsultaVendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbVendasBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbVendasTableAdapter tbVendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdevendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentovendaDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}