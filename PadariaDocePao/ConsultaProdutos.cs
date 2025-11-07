using PadariaDocePao;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class ConsultaProdutos : Form
    {
        private DataTable produtosParaImprimir;
        private int linhaAtualImpressao = 0;

        public ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdPadariaDocePaoDataSet.tbClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutosTableAdapter.Fill(this.bdPadariaDocePaoDataSet.tbProdutos);
            CarregarProdutos();
        }

        // ==========================================================
        // CARREGAR CLIENTES NA GRID
        // ==========================================================
        private void CarregarProdutos()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = @"SELECT cod_produto, nome_produto, descri_produto, categoria_produto, valor_produto, qtde_produto
                                   FROM tbProdutos
                                   ORDER BY nome_produto";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // EXCLUIR FUNCIONÁRIO
        // ==========================================================
        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                DataRowView drv = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int idParaExcluir = Convert.ToInt32(drv["cod_produto"]);

                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlDelete = "DELETE FROM tbProdutos WHERE cod_produto = @cod_produto";
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_produto", idParaExcluir);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Produto excluído com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarProdutos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum produto foi excluído.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // ALTERAR FUNCIONÁRIO
        // ==========================================================
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecione um produto para alterar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows.Count > 0
                                        ? dataGridView1.SelectedRows[0]
                                        : dataGridView1.CurrentRow;

                int idParaAlterar;
                if (row.DataBoundItem is DataRowView drv)
                    idParaAlterar = Convert.ToInt32(drv["cod_produto"]);
                else
                    idParaAlterar = Convert.ToInt32(row.Cells["cod_produto"].Value);

                CadastroProdutos formCadastro = new CadastroProdutos(idParaAlterar);
                formCadastro.FormClosed += (s, args) => CarregarProdutos();
                formCadastro.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o formulário de alteração: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // VISUALIZAR IMPRESSÃO
        // ==========================================================
        private void btVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string SQL = @"SELECT nome_produto, descri_produto, categoria_produto, valor_produto, qtde_produto
                                   FROM tbProdutos
                                   ORDER BY nome_produto";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, conexao);
                    produtosParaImprimir = new DataTable();
                    adapter.Fill(produtosParaImprimir);
                }

                if (produtosParaImprimir == null || produtosParaImprimir.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado para impressão.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                linhaAtualImpressao = 0;

                // Garantir que o evento está associado
                printDocument1.PrintPage -= printDocument1_PrintPage;
                printDocument1.PrintPage += printDocument1_PrintPage;

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados para impressão: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // PRINTDOCUMENT - DESENHA NA PÁGINA
        // ==========================================================
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fonteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fonteHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fonteCorpo = new Font("Arial", 10);
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            float alturaLinha = fonteCorpo.GetHeight(e.Graphics);
            float yPos = margemSuperior;

            // Título
            e.Graphics.DrawString("Relatório de Produtos Cadastrados", fonteTitulo, Brushes.Black, margemEsquerda, yPos);
            yPos += fonteTitulo.GetHeight(e.Graphics) * 2;

            // Cabeçalhos
            e.Graphics.DrawString("Nome", fonteHeader, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString("Descrição", fonteHeader, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString("Categoria", fonteHeader, Brushes.Black, margemEsquerda + 350, yPos);
            e.Graphics.DrawString("Quantidade", fonteHeader, Brushes.Black, margemEsquerda + 520, yPos);
            yPos += alturaLinha * 2;

            // Loop para desenhar linhas
            while (linhaAtualImpressao < produtosParaImprimir.Rows.Count)
            {
                DataRow linha = produtosParaImprimir.Rows[linhaAtualImpressao];

                e.Graphics.DrawString(linha["nome_produto"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(linha["descri_produto"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(linha["categoria_produto"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 350, yPos);
                e.Graphics.DrawString(linha["qtde_produto"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 520, yPos);
                yPos += alturaLinha;
                linhaAtualImpressao++;

                // Verifica se precisa quebrar a página
                if (yPos + alturaLinha > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;

        }
    }
}

