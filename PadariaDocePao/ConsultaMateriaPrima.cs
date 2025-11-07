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
    public partial class ConsultaMateriaPrima : Form
    {
        private DataTable materiaPrimaParaImprimir;
        private int linhaAtualImpressao = 0;

        public ConsultaMateriaPrima()
        {
            InitializeComponent();
        }

        private void ConsultaMateriaPrima_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdPadariaDocePaoDataSet.tbClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbMateriaPrimaTableAdapter.Fill(this.bdPadariaDocePaoDataSet.tbMateriaPrima);
            CarregarMateriaPrima();
        }

        // ==========================================================
        // CARREGAR CLIENTES NA GRID
        // ==========================================================
        private void CarregarMateriaPrima()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = @"SELECT cod_mp, nome_mp, fornecedor_mp, classificacao_mp, und_medida_mp, categoria_mp, qtde_mp
                                   FROM tbMateriaPrima
                                   ORDER BY nome_mp";

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
                MessageBox.Show("Erro ao carregar as matérias-primas: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // EXCLUIR FUNCIONÁRIO
        // ==========================================================
        private void btExcluirMP_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma matéria-prima para excluir.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a matéria-prima selecionada?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                DataRowView drv = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int idParaExcluir = Convert.ToInt32(drv["cod_mp"]);

                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlDelete = "DELETE FROM tbMateriaPrima WHERE cod_mp = @cod_mp";
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_mp", idParaExcluir);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Matéria-prima excluída com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarMateriaPrima();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma matéria-prima foi excluída.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a matéria-prima: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // ALTERAR FUNCIONÁRIO
        // ==========================================================
        private void btAlterarMP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecione uma matéria-prima para alterar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows.Count > 0
                                        ? dataGridView1.SelectedRows[0]
                                        : dataGridView1.CurrentRow;

                int idParaAlterar;
                if (row.DataBoundItem is DataRowView drv)
                    idParaAlterar = Convert.ToInt32(drv["cod_mp"]);
                else
                    idParaAlterar = Convert.ToInt32(row.Cells["cod_mp"].Value);

                CadastroMateriaPrima formCadastro = new CadastroMateriaPrima(idParaAlterar);
                formCadastro.FormClosed += (s, args) => CarregarMateriaPrima();
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
        private void btVisualizarImpressao_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string SQL = @"SELECT nome_mp, fornecedor_mp, classificacao_mp, und_medida_mp, categoria_mp, qtde_mp
                                   FROM tbMateriaPrima
                                   ORDER BY nome_mp";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, conexao);
                    materiaPrimaParaImprimir = new DataTable();
                    adapter.Fill(materiaPrimaParaImprimir);
                }

                if (materiaPrimaParaImprimir == null || materiaPrimaParaImprimir.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma matéria-prima encontrada para impressão.",
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
            e.Graphics.DrawString("Relatório de Matéria-Prima Cadastradas", fonteTitulo, Brushes.Black, margemEsquerda, yPos);
            yPos += fonteTitulo.GetHeight(e.Graphics) * 2;

            // Cabeçalhos
            e.Graphics.DrawString("Nome", fonteHeader, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString("Fornecedor", fonteHeader, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString("Classificação", fonteHeader, Brushes.Black, margemEsquerda + 350, yPos);
            e.Graphics.DrawString("Quantidade", fonteHeader, Brushes.Black, margemEsquerda + 520, yPos);
            yPos += alturaLinha * 2;

            // Loop para desenhar linhas
            while (linhaAtualImpressao < materiaPrimaParaImprimir.Rows.Count)
            {
                DataRow linha = materiaPrimaParaImprimir.Rows[linhaAtualImpressao];

                e.Graphics.DrawString(linha["nome_mp"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(linha["fornecedor_mp"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(linha["classificacao_mp"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 350, yPos);
                e.Graphics.DrawString(linha["qtde_mp"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 520, yPos);
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

