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
    public partial class ConsultaClientes : Form
    {
        private DataTable clienteParaImprimir;
        private int linhaAtualImpressao = 0;

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdPadariaDocePaoDataSet.tbClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClientesTableAdapter.Fill(this.bdPadariaDocePaoDataSet.tbClientes);
            CarregarClientes();
        }

        // ==========================================================
        // CARREGAR CLIENTES NA GRID
        // ==========================================================
        private void CarregarClientes()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = @"SELECT cod_cliente, nome_cliente, cpf_cliente, email_cliente, fone_cliente, data_nas_cliente, data_cad_cliente
                                   FROM tbClientes
                                   ORDER BY nome_cliente";

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
                MessageBox.Show("Erro ao carregar os clientes: " + ex.Message,
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
                MessageBox.Show("Por favor, selecione um cliente para excluir.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                DataRowView drv = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int idParaExcluir = Convert.ToInt32(drv["cod_cliente"]);

                string connectionString = ConfigurationManager.ConnectionStrings[
                    "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
                ].ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlDelete = "DELETE FROM tbClientes WHERE cod_cliente = @cod_cliente";
                    using (SqlCommand comando = new SqlCommand(sqlDelete, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_cliente", idParaExcluir);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cliente excluído com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarClientes();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente foi excluído.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o cliente: " + ex.Message,
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
                    MessageBox.Show("Por favor, selecione um cliente para alterar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridView1.SelectedRows.Count > 0
                                        ? dataGridView1.SelectedRows[0]
                                        : dataGridView1.CurrentRow;

                int idParaAlterar;
                if (row.DataBoundItem is DataRowView drv)
                    idParaAlterar = Convert.ToInt32(drv["cod_cliente"]);
                else
                    idParaAlterar = Convert.ToInt32(row.Cells["cod_cliente"].Value);

                CadastroCliente formCadastro = new CadastroCliente(idParaAlterar);
                formCadastro.FormClosed += (s, args) => CarregarClientes();
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
                    string SQL = @"SELECT nome_cliente, cpf_cliente, email_cliente, fone_cliente, data_nas_cliente, data_cad_cliente
                                   FROM tbClientes
                                   ORDER BY nome_cliente";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, conexao);
                    clienteParaImprimir = new DataTable();
                    adapter.Fill(clienteParaImprimir);
                }

                if (clienteParaImprimir == null || clienteParaImprimir.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado para impressão.",
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
            e.Graphics.DrawString("Relatório de Clientes Cadastrados", fonteTitulo, Brushes.Black, margemEsquerda, yPos);
            yPos += fonteTitulo.GetHeight(e.Graphics) * 2;

            // Cabeçalhos
            e.Graphics.DrawString("Nome", fonteHeader, Brushes.Black, margemEsquerda, yPos);
            e.Graphics.DrawString("CPF", fonteHeader, Brushes.Black, margemEsquerda + 200, yPos);
            e.Graphics.DrawString("E-mail", fonteHeader, Brushes.Black, margemEsquerda + 350, yPos);
            e.Graphics.DrawString("Telefone", fonteHeader, Brushes.Black, margemEsquerda + 520, yPos);
            yPos += alturaLinha * 2;

            // Loop para desenhar linhas
            while (linhaAtualImpressao < clienteParaImprimir.Rows.Count)
            {
                DataRow linha = clienteParaImprimir.Rows[linhaAtualImpressao];

                e.Graphics.DrawString(linha["nome_cliente"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda, yPos);
                e.Graphics.DrawString(linha["cpf_cliente"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 200, yPos);
                e.Graphics.DrawString(linha["email_cliente"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 350, yPos);
                e.Graphics.DrawString(linha["fone_cliente"].ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 520, yPos); 
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

