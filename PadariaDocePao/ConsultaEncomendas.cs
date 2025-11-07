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
    public partial class ConsultaEncomendas : Form
    {
        private DataTable encomendaParaImprimir;
        private int linhaAtualImpressao = 0;

        public ConsultaEncomendas()
        {
            InitializeComponent();
        }

        private void ConsultaEncomendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdPadariaDocePaoDataSet.tbClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbEncomendasTableAdapter.Fill(this.bdPadariaDocePaoDataSet.tbEncomendas);
            CarregarEncomendas();
        }

        // ==========================================================
        // CARREGAR CLIENTES NA GRID
        // ==========================================================
        private void CarregarEncomendas()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = @"SELECT cod_encomenda, nome_encomenda, data_encomenda, fone_encomenda, end_encomenda, total_encomenda, previsao_encomenda, pagamento_encomenda, cpf_encomenda, obs_encomenda, produtos_encomenda, qtde_encomenda
                                   FROM tbEncomendas
                                   ORDER BY nome_encomenda";

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
                MessageBox.Show("Erro ao carregar as encomendas: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // EXCLUIR FUNCIONÁRIO
        // ==========================================================
        private void btExcluir_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma encomenda para excluir.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a encomenda selecionada?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                DataRowView drv = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int idParaExcluir = Convert.ToInt32(drv["cod_encomenda"]);

                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlDelete = "DELETE FROM tbEncomendas WHERE cod_encomenda = @cod_encomenda";
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_encomenda", idParaExcluir);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Encomenda excluída com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarEncomendas();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma encomenda foi excluída.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a encomenda: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // ALTERAR FUNCIONÁRIO
        // ==========================================================
        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecione uma encomenda para alterar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows.Count > 0
                                        ? dataGridView1.SelectedRows[0]
                                        : dataGridView1.CurrentRow;

                int idParaAlterar;
                if (row.DataBoundItem is DataRowView drv)
                    idParaAlterar = Convert.ToInt32(drv["cod_encomenda"]);
                else
                    idParaAlterar = Convert.ToInt32(row.Cells["cod_encomenda"].Value);

                CadastroEncomendas formCadastro = new CadastroEncomendas(idParaAlterar);
                formCadastro.FormClosed += (s, args) => CarregarEncomendas();
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
        private void btVisualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string SQL = @"SELECT nome_encomenda, data_encomenda, fone_encomenda, end_encomenda, total_encomenda, previsao_encomenda, pagamento_encomenda, cpf_encomenda, obs_encomenda, produtos_encomenda, qtde_encomenda
                                   FROM tbEncomendas
                                   ORDER BY nome_encomenda";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, conexao);
                    encomendaParaImprimir = new DataTable();
                    adapter.Fill(encomendaParaImprimir);
                }

                if (encomendaParaImprimir == null || encomendaParaImprimir.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma encomenda encontrado para impressão.",
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
            e.Graphics.DrawString("Relatório de Encomendas Cadastradas", fonteTitulo, Brushes.Black, margemEsquerda, yPos);
            yPos += fonteTitulo.GetHeight(e.Graphics) * 2;

            // Cabeçalhos
            e.Graphics.DrawString("Nome", fonteHeader, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString("Produtos", fonteHeader, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString("Telefone", fonteHeader, Brushes.Black, margemEsquerda + 350, yPos);
            e.Graphics.DrawString("Data da encomenda", fonteHeader, Brushes.Black, margemEsquerda + 520, yPos);
            yPos += alturaLinha * 2;

            // Loop para desenhar linhas
            while (linhaAtualImpressao < encomendaParaImprimir.Rows.Count)
            {
                DataRow linha = encomendaParaImprimir.Rows[linhaAtualImpressao];

                e.Graphics.DrawString(linha["nome_encomenda"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(linha["produtos_encomenda"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(linha["fone_encomenda"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 350, yPos);
                e.Graphics.DrawString(Convert.ToDateTime(linha["data_encomenda"]).ToShortDateString(), fonteCorpo, Brushes.Black, margemEsquerda + 520, yPos);

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

