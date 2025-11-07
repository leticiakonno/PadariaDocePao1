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
    public partial class ConsultaFuncionarios : Form
    {
        private DataTable funcionarioParaImprimir;
        private int linhaAtualImpressao = 0;

        public ConsultaFuncionarios()
        {
            InitializeComponent();
        }

        private void ConsultaFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdPadariaDocePaoDataSet.tbClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncionariosTableAdapter.Fill(this.bdPadariaDocePaoDataSet.tbFuncionarios);
            CarregarFuncionarios();
        }

        // ==========================================================
        // CARREGAR CLIENTES NA GRID
        // ==========================================================
        private void CarregarFuncionarios()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = @"SELECT cod_funcionario, nome_funcionario, cargo_funcionario, data_nas_funcionario, cpf_funcionario, data_cad_funcionario, fone_funcionario
                                   FROM tbFuncionarios
                                   ORDER BY nome_funcionario";

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
                MessageBox.Show("Erro ao carregar os funcionários: " + ex.Message,
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
                MessageBox.Show("Por favor, selecione um funcionário para excluir.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o funcionário selecionado?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                DataRowView drv = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int idParaExcluir = Convert.ToInt32(drv["cod_funcionario"]);

                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlDelete = "DELETE FROM tbFuncionarios WHERE cod_funcionario = @cod_funcionario";
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_funcionario", idParaExcluir);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Funcionário excluído com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarFuncionarios();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum funcionário foi excluído.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o funcionário: " + ex.Message,
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
                    MessageBox.Show("Por favor, selecione um funcionário para alterar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows.Count > 0
                                        ? dataGridView1.SelectedRows[0]
                                        : dataGridView1.CurrentRow;

                int idParaAlterar;
                if (row.DataBoundItem is DataRowView drv)
                    idParaAlterar = Convert.ToInt32(drv["cod_funcionario"]);
                else
                    idParaAlterar = Convert.ToInt32(row.Cells["cod_funcionario"].Value);

                CadastroFuncionarios formCadastro = new CadastroFuncionarios(idParaAlterar);
                formCadastro.FormClosed += (s, args) => CarregarFuncionarios();
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
                    string SQL = @"SELECT nome_funcionario, cargo_funcionario, data_nas_funcionario, cpf_funcionario, data_cad_funcionario, fone_funcionario
                                   FROM tbFuncionarios
                                   ORDER BY nome_funcionario";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, conexao);
                    funcionarioParaImprimir = new DataTable();
                    adapter.Fill(funcionarioParaImprimir);
                }

                if (funcionarioParaImprimir == null || funcionarioParaImprimir.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum funcionário encontrado para impressão.",
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
            e.Graphics.DrawString("Relatório de Funcionários Cadastrados", fonteTitulo, Brushes.Black, margemEsquerda, yPos);
            yPos += fonteTitulo.GetHeight(e.Graphics) * 2;

            // Cabeçalhos
            e.Graphics.DrawString("Nome", fonteHeader, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString("Cargo", fonteHeader, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString("CPF", fonteHeader, Brushes.Black, margemEsquerda + 350, yPos);
            e.Graphics.DrawString("Data de Cadastro", fonteHeader, Brushes.Black, margemEsquerda + 520, yPos);
            yPos += alturaLinha * 2;

            // Loop para desenhar linhas
            while (linhaAtualImpressao < funcionarioParaImprimir.Rows.Count)
            {
                DataRow linha = funcionarioParaImprimir.Rows[linhaAtualImpressao];

                e.Graphics.DrawString(linha["nome_funcionario"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(linha["cargo_funcionario"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(linha["cpf_funcionario"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 350, yPos);
                e.Graphics.DrawString(Convert.ToDateTime(linha["data_cad_funcionario"]).ToShortDateString(), fonteCorpo, Brushes.Black, margemEsquerda + 520, yPos);

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

