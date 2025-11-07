using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroVendas : Form
    {
        private int? _idVendaParaAlterar = null;
        private decimal precoUnitario = 0m;

        public CadastroVendas()
        {
            InitializeComponent();
            CarregarProdutos();

            cbProdutoVenda.SelectedIndexChanged += CbProdutoVenda_SelectedIndexChanged;
            txtQtde.TextChanged += TxtQtde_TextChanged;
        }

        public CadastroVendas(int idVenda) : this()
        {
            _idVendaParaAlterar = idVenda;
            CarregarDadosParaEdicao();
        }

        // ==============================================================
        // 🔹 CARREGAR PRODUTOS NO COMBOBOX
        // ==============================================================
        private void CarregarProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT cod_produto, nome_produto FROM tbProdutos ORDER BY nome_produto";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbProdutoVenda.DataSource = dt;
                        cbProdutoVenda.DisplayMember = "nome_produto";
                        cbProdutoVenda.ValueMember = "cod_produto";
                        cbProdutoVenda.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==============================================================
        // 🔹 AO SELECIONAR PRODUTO → busca o preço unitário
        // ==============================================================
        private void CbProdutoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdutoVenda.SelectedValue == null || cbProdutoVenda.SelectedIndex == -1)
                return;

            int codProduto = Convert.ToInt32(cbProdutoVenda.SelectedValue);
            BuscarPrecoProduto(codProduto);
        }

        private void BuscarPrecoProduto(int codProduto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT valor_produto FROM tbProdutos WHERE cod_produto = @cod";
                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod", codProduto);
                        object result = comando.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal preco))
                        {
                            precoUnitario = preco;
                            CalcularValorTotal();
                        }
                        else
                        {
                            precoUnitario = 0;
                            txtValor.Text = "";
                            MessageBox.Show("Preço do produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar preço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtQtde_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            if (decimal.TryParse(txtQtde.Text, out decimal qtde) && precoUnitario > 0)
            {
                decimal total = qtde * precoUnitario;
                txtValor.Text = total.ToString("N2");
            }
            else
            {
                txtValor.Text = "";
            }
        }

        // ==============================================================
        // 🔹 BOTÃO SALVAR VENDA
        // ==============================================================
        private void btSalvarCadastroVenda_Click(object sender, EventArgs e)
        {
            if (cbProdutoVenda.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQtde.Text) ||
                string.IsNullOrWhiteSpace(txtDataVenda.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text) ||
                string.IsNullOrWhiteSpace(txtPagamento.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql;
                    if (_idVendaParaAlterar == null)
                    {
                        sql = @"INSERT INTO tbVendas 
                        (produto_venda, qtde_venda, data_venda, valor_venda, pagamento_venda)
                        VALUES (@produtoVenda, @quantidade, @data, @valor, @pagamento);
                        SELECT SCOPE_IDENTITY();";
                    }
                    else
                    {
                        sql = @"UPDATE tbVendas 
                        SET produto_venda = @produtoVenda,
                            qtde_venda = @quantidade,
                            data_venda = @data,
                            valor_venda = @valor,
                            pagamento_venda = @pagamento
                        WHERE cod_venda = @cod_venda";
                    }

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@produtoVenda", cbProdutoVenda.Text);
                        comando.Parameters.AddWithValue("@quantidade", txtQtde.Text.Trim());
                        comando.Parameters.AddWithValue("@data", Convert.ToDateTime(txtDataVenda.Text.Trim()));
                        comando.Parameters.AddWithValue("@pagamento", txtPagamento.Text.Trim());
                        comando.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text.Trim()));

                        if (_idVendaParaAlterar != null)
                            comando.Parameters.AddWithValue("@cod_venda", _idVendaParaAlterar);

                        if (_idVendaParaAlterar == null)
                        {
                            object result = comando.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                AtualizarEstoque(cbProdutoVenda.Text, int.Parse(txtQtde.Text.Trim()));
                                MessageBox.Show($"Venda cadastrada com sucesso! (ID: {novoId})",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Venda alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==============================================================
        // 🔹 ATUALIZA ESTOQUE
        // ==============================================================
        private void AtualizarEstoque(string nomeProduto, int quantidadeVendida)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = @"UPDATE tbProdutos 
                                   SET qtde_produto = qtde_produto - @qtd 
                                   WHERE nome_produto = @nome";

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@qtd", quantidadeVendida);
                        comando.Parameters.AddWithValue("@nome", nomeProduto);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==============================================================
        // 🔹 CARREGAR DADOS PARA EDIÇÃO
        // ==============================================================
        private void CarregarDadosParaEdicao()
        {
            this.Text = "Alterar Venda";
            lbCadastroVendas.Text = "Alterar Venda";

            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbVendas WHERE cod_venda = @cod_venda";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_venda", _idVendaParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cbProdutoVenda.Text = reader["produto_venda"].ToString();
                                txtQtde.Text = reader["qtde_venda"].ToString();
                                txtDataVenda.Text = Convert.ToDateTime(reader["data_venda"]).ToString("dd/MM/yyyy");
                                txtValor.Text = reader["valor_venda"].ToString();
                                txtPagamento.Text = reader["pagamento_venda"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
