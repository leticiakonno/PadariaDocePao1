namespace PadariaDocePao
{
    partial class ConsultaEncomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEncomendas));
            this.btVisualizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbConsultaEncomendas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbEncomendasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.tbEncomendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbEncomendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEncomendasTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbEncomendasTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bdPadariaDocePaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEncomendasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.codencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsaoencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeencomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btVisualizar
            // 
            this.btVisualizar.Location = new System.Drawing.Point(1072, 681);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(153, 23);
            this.btVisualizar.TabIndex = 17;
            this.btVisualizar.Text = "Visualizar Impressão";
            this.btVisualizar.UseVisualStyleBackColor = true;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(1090, 74);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 16;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(1171, 74);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // lbConsultaEncomendas
            // 
            this.lbConsultaEncomendas.AutoSize = true;
            this.lbConsultaEncomendas.CausesValidation = false;
            this.lbConsultaEncomendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaEncomendas.Location = new System.Drawing.Point(362, 37);
            this.lbConsultaEncomendas.Name = "lbConsultaEncomendas";
            this.lbConsultaEncomendas.Size = new System.Drawing.Size(385, 39);
            this.lbConsultaEncomendas.TabIndex = 18;
            this.lbConsultaEncomendas.Text = "Consulta Encomendas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codencomendaDataGridViewTextBoxColumn,
            this.nomeencomendaDataGridViewTextBoxColumn,
            this.dataencomendaDataGridViewTextBoxColumn,
            this.foneencomendaDataGridViewTextBoxColumn,
            this.endencomendaDataGridViewTextBoxColumn,
            this.totalencomendaDataGridViewTextBoxColumn,
            this.previsaoencomendaDataGridViewTextBoxColumn,
            this.pagamentoencomendaDataGridViewTextBoxColumn,
            this.cpfencomendaDataGridViewTextBoxColumn,
            this.obsencomendaDataGridViewTextBoxColumn,
            this.produtosencomendaDataGridViewTextBoxColumn,
            this.qtdeencomendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbEncomendasBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1237, 547);
            this.dataGridView1.TabIndex = 19;
            // 
            // tbEncomendasBindingSource2
            // 
            this.tbEncomendasBindingSource2.DataMember = "tbEncomendas";
            this.tbEncomendasBindingSource2.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEncomendasBindingSource1
            // 
            this.tbEncomendasBindingSource1.DataMember = "tbEncomendas";
            this.tbEncomendasBindingSource1.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // tbEncomendasBindingSource
            // 
            this.tbEncomendasBindingSource.DataMember = "tbEncomendas";
            this.tbEncomendasBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // tbEncomendasTableAdapter
            // 
            this.tbEncomendasTableAdapter.ClearBeforeFill = true;
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
            // bdPadariaDocePaoDataSetBindingSource
            // 
            this.bdPadariaDocePaoDataSetBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            this.bdPadariaDocePaoDataSetBindingSource.Position = 0;
            // 
            // tbEncomendasBindingSource3
            // 
            this.tbEncomendasBindingSource3.DataMember = "tbEncomendas";
            this.tbEncomendasBindingSource3.DataSource = this.bdPadariaDocePaoDataSetBindingSource;
            // 
            // codencomendaDataGridViewTextBoxColumn
            // 
            this.codencomendaDataGridViewTextBoxColumn.DataPropertyName = "cod_encomenda";
            this.codencomendaDataGridViewTextBoxColumn.HeaderText = "cod_encomenda";
            this.codencomendaDataGridViewTextBoxColumn.Name = "codencomendaDataGridViewTextBoxColumn";
            this.codencomendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeencomendaDataGridViewTextBoxColumn
            // 
            this.nomeencomendaDataGridViewTextBoxColumn.DataPropertyName = "nome_encomenda";
            this.nomeencomendaDataGridViewTextBoxColumn.HeaderText = "nome_encomenda";
            this.nomeencomendaDataGridViewTextBoxColumn.Name = "nomeencomendaDataGridViewTextBoxColumn";
            // 
            // dataencomendaDataGridViewTextBoxColumn
            // 
            this.dataencomendaDataGridViewTextBoxColumn.DataPropertyName = "data_encomenda";
            this.dataencomendaDataGridViewTextBoxColumn.HeaderText = "data_encomenda";
            this.dataencomendaDataGridViewTextBoxColumn.Name = "dataencomendaDataGridViewTextBoxColumn";
            // 
            // foneencomendaDataGridViewTextBoxColumn
            // 
            this.foneencomendaDataGridViewTextBoxColumn.DataPropertyName = "fone_encomenda";
            this.foneencomendaDataGridViewTextBoxColumn.HeaderText = "fone_encomenda";
            this.foneencomendaDataGridViewTextBoxColumn.Name = "foneencomendaDataGridViewTextBoxColumn";
            // 
            // endencomendaDataGridViewTextBoxColumn
            // 
            this.endencomendaDataGridViewTextBoxColumn.DataPropertyName = "end_encomenda";
            this.endencomendaDataGridViewTextBoxColumn.HeaderText = "end_encomenda";
            this.endencomendaDataGridViewTextBoxColumn.Name = "endencomendaDataGridViewTextBoxColumn";
            // 
            // totalencomendaDataGridViewTextBoxColumn
            // 
            this.totalencomendaDataGridViewTextBoxColumn.DataPropertyName = "total_encomenda";
            this.totalencomendaDataGridViewTextBoxColumn.HeaderText = "total_encomenda";
            this.totalencomendaDataGridViewTextBoxColumn.Name = "totalencomendaDataGridViewTextBoxColumn";
            // 
            // previsaoencomendaDataGridViewTextBoxColumn
            // 
            this.previsaoencomendaDataGridViewTextBoxColumn.DataPropertyName = "previsao_encomenda";
            this.previsaoencomendaDataGridViewTextBoxColumn.HeaderText = "previsao_encomenda";
            this.previsaoencomendaDataGridViewTextBoxColumn.Name = "previsaoencomendaDataGridViewTextBoxColumn";
            // 
            // pagamentoencomendaDataGridViewTextBoxColumn
            // 
            this.pagamentoencomendaDataGridViewTextBoxColumn.DataPropertyName = "pagamento_encomenda";
            this.pagamentoencomendaDataGridViewTextBoxColumn.HeaderText = "pagamento_encomenda";
            this.pagamentoencomendaDataGridViewTextBoxColumn.Name = "pagamentoencomendaDataGridViewTextBoxColumn";
            // 
            // cpfencomendaDataGridViewTextBoxColumn
            // 
            this.cpfencomendaDataGridViewTextBoxColumn.DataPropertyName = "cpf_encomenda";
            this.cpfencomendaDataGridViewTextBoxColumn.HeaderText = "cpf_encomenda";
            this.cpfencomendaDataGridViewTextBoxColumn.Name = "cpfencomendaDataGridViewTextBoxColumn";
            // 
            // obsencomendaDataGridViewTextBoxColumn
            // 
            this.obsencomendaDataGridViewTextBoxColumn.DataPropertyName = "obs_encomenda";
            this.obsencomendaDataGridViewTextBoxColumn.HeaderText = "obs_encomenda";
            this.obsencomendaDataGridViewTextBoxColumn.Name = "obsencomendaDataGridViewTextBoxColumn";
            // 
            // produtosencomendaDataGridViewTextBoxColumn
            // 
            this.produtosencomendaDataGridViewTextBoxColumn.DataPropertyName = "produtos_encomenda";
            this.produtosencomendaDataGridViewTextBoxColumn.HeaderText = "produtos_encomenda";
            this.produtosencomendaDataGridViewTextBoxColumn.Name = "produtosencomendaDataGridViewTextBoxColumn";
            // 
            // qtdeencomendaDataGridViewTextBoxColumn
            // 
            this.qtdeencomendaDataGridViewTextBoxColumn.DataPropertyName = "qtde_encomenda";
            this.qtdeencomendaDataGridViewTextBoxColumn.HeaderText = "qtde_encomenda";
            this.qtdeencomendaDataGridViewTextBoxColumn.Name = "qtdeencomendaDataGridViewTextBoxColumn";
            // 
            // ConsultaEncomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbConsultaEncomendas);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Name = "ConsultaEncomendas";
            this.Text = "ConsultaEncomendas";
            this.Load += new System.EventHandler(this.ConsultaEncomendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncomendasBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbConsultaEncomendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbEncomendasBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbEncomendasTableAdapter tbEncomendasTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource tbEncomendasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbEncomendasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsaoencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeencomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbEncomendasBindingSource3;
        private System.Windows.Forms.BindingSource bdPadariaDocePaoDataSetBindingSource;
    }
}