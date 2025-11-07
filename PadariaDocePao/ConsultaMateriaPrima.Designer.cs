namespace PadariaDocePao
{
    partial class ConsultaMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMateriaPrima));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedormpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undmedidampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMateriaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdPadariaDocePaoDataSet = new PadariaDocePao.bdPadariaDocePaoDataSet();
            this.btVisualizarImpressao = new System.Windows.Forms.Button();
            this.btAlterarMP = new System.Windows.Forms.Button();
            this.btExcluirMP = new System.Windows.Forms.Button();
            this.lbConsultarMP = new System.Windows.Forms.Label();
            this.tbMateriaPrimaTableAdapter = new PadariaDocePao.bdPadariaDocePaoDataSetTableAdapters.tbMateriaPrimaTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codmpDataGridViewTextBoxColumn,
            this.nomempDataGridViewTextBoxColumn,
            this.fornecedormpDataGridViewTextBoxColumn,
            this.classificacaompDataGridViewTextBoxColumn,
            this.undmedidampDataGridViewTextBoxColumn,
            this.categoriampDataGridViewTextBoxColumn,
            this.qtdempDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbMateriaPrimaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(97, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 385);
            this.dataGridView1.TabIndex = 21;
            // 
            // codmpDataGridViewTextBoxColumn
            // 
            this.codmpDataGridViewTextBoxColumn.DataPropertyName = "cod_mp";
            this.codmpDataGridViewTextBoxColumn.HeaderText = "cod_mp";
            this.codmpDataGridViewTextBoxColumn.Name = "codmpDataGridViewTextBoxColumn";
            this.codmpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomempDataGridViewTextBoxColumn
            // 
            this.nomempDataGridViewTextBoxColumn.DataPropertyName = "nome_mp";
            this.nomempDataGridViewTextBoxColumn.HeaderText = "nome_mp";
            this.nomempDataGridViewTextBoxColumn.Name = "nomempDataGridViewTextBoxColumn";
            // 
            // fornecedormpDataGridViewTextBoxColumn
            // 
            this.fornecedormpDataGridViewTextBoxColumn.DataPropertyName = "fornecedor_mp";
            this.fornecedormpDataGridViewTextBoxColumn.HeaderText = "fornecedor_mp";
            this.fornecedormpDataGridViewTextBoxColumn.Name = "fornecedormpDataGridViewTextBoxColumn";
            // 
            // classificacaompDataGridViewTextBoxColumn
            // 
            this.classificacaompDataGridViewTextBoxColumn.DataPropertyName = "classificacao_mp";
            this.classificacaompDataGridViewTextBoxColumn.HeaderText = "classificacao_mp";
            this.classificacaompDataGridViewTextBoxColumn.Name = "classificacaompDataGridViewTextBoxColumn";
            // 
            // undmedidampDataGridViewTextBoxColumn
            // 
            this.undmedidampDataGridViewTextBoxColumn.DataPropertyName = "und_medida_mp";
            this.undmedidampDataGridViewTextBoxColumn.HeaderText = "und_medida_mp";
            this.undmedidampDataGridViewTextBoxColumn.Name = "undmedidampDataGridViewTextBoxColumn";
            // 
            // categoriampDataGridViewTextBoxColumn
            // 
            this.categoriampDataGridViewTextBoxColumn.DataPropertyName = "categoria_mp";
            this.categoriampDataGridViewTextBoxColumn.HeaderText = "categoria_mp";
            this.categoriampDataGridViewTextBoxColumn.Name = "categoriampDataGridViewTextBoxColumn";
            // 
            // qtdempDataGridViewTextBoxColumn
            // 
            this.qtdempDataGridViewTextBoxColumn.DataPropertyName = "qtde_mp";
            this.qtdempDataGridViewTextBoxColumn.HeaderText = "qtde_mp";
            this.qtdempDataGridViewTextBoxColumn.Name = "qtdempDataGridViewTextBoxColumn";
            // 
            // tbMateriaPrimaBindingSource
            // 
            this.tbMateriaPrimaBindingSource.DataMember = "tbMateriaPrima";
            this.tbMateriaPrimaBindingSource.DataSource = this.bdPadariaDocePaoDataSet;
            // 
            // bdPadariaDocePaoDataSet
            // 
            this.bdPadariaDocePaoDataSet.DataSetName = "bdPadariaDocePaoDataSet";
            this.bdPadariaDocePaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btVisualizarImpressao
            // 
            this.btVisualizarImpressao.Location = new System.Drawing.Point(686, 568);
            this.btVisualizarImpressao.Name = "btVisualizarImpressao";
            this.btVisualizarImpressao.Size = new System.Drawing.Size(153, 23);
            this.btVisualizarImpressao.TabIndex = 25;
            this.btVisualizarImpressao.Text = "Visualizar Impressão";
            this.btVisualizarImpressao.UseVisualStyleBackColor = true;
            this.btVisualizarImpressao.Click += new System.EventHandler(this.btVisualizarImpressao_Click);
            // 
            // btAlterarMP
            // 
            this.btAlterarMP.Location = new System.Drawing.Point(674, 114);
            this.btAlterarMP.Name = "btAlterarMP";
            this.btAlterarMP.Size = new System.Drawing.Size(75, 23);
            this.btAlterarMP.TabIndex = 24;
            this.btAlterarMP.Text = "ALTERAR";
            this.btAlterarMP.UseVisualStyleBackColor = true;
            this.btAlterarMP.Click += new System.EventHandler(this.btAlterarMP_Click);
            // 
            // btExcluirMP
            // 
            this.btExcluirMP.Location = new System.Drawing.Point(764, 114);
            this.btExcluirMP.Name = "btExcluirMP";
            this.btExcluirMP.Size = new System.Drawing.Size(75, 23);
            this.btExcluirMP.TabIndex = 23;
            this.btExcluirMP.Text = "EXCLUIR";
            this.btExcluirMP.UseVisualStyleBackColor = true;
            this.btExcluirMP.Click += new System.EventHandler(this.btExcluirMP_Click);
            // 
            // lbConsultarMP
            // 
            this.lbConsultarMP.AutoSize = true;
            this.lbConsultarMP.CausesValidation = false;
            this.lbConsultarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarMP.Location = new System.Drawing.Point(265, 50);
            this.lbConsultarMP.Name = "lbConsultarMP";
            this.lbConsultarMP.Size = new System.Drawing.Size(405, 39);
            this.lbConsultarMP.TabIndex = 20;
            this.lbConsultarMP.Text = "Consulta Matéria-Prima";
            // 
            // tbMateriaPrimaTableAdapter
            // 
            this.tbMateriaPrimaTableAdapter.ClearBeforeFill = true;
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
            // ConsultaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(974, 652);
            this.Controls.Add(this.btVisualizarImpressao);
            this.Controls.Add(this.btAlterarMP);
            this.Controls.Add(this.btExcluirMP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbConsultarMP);
            this.Name = "ConsultaMateriaPrima";
            this.Text = "ConsultaMateriaPrima";
            this.Load += new System.EventHandler(this.ConsultaMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPadariaDocePaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVisualizarImpressao;
        private System.Windows.Forms.Button btAlterarMP;
        private System.Windows.Forms.Button btExcluirMP;
        private System.Windows.Forms.Label lbConsultarMP;
        private bdPadariaDocePaoDataSet bdPadariaDocePaoDataSet;
        private System.Windows.Forms.BindingSource tbMateriaPrimaBindingSource;
        private bdPadariaDocePaoDataSetTableAdapters.tbMateriaPrimaTableAdapter tbMateriaPrimaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedormpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn undmedidampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdempDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}