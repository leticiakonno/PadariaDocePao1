using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroEncomendas : Form
    {
        private DataTable itensEncomenda = new DataTable();
        private int idParaAlterar;

        public CadastroEncomendas()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarProdutos();
        }

        public CadastroEncomendas(int idParaAlterar)
        {
            InitializeComponent();
            this.idParaAlterar = idParaAlterar;
            ConfigurarGrid();
            CarregarProdutos();
            // se quiser carregar dados para alterar, implemente aqui
        }

        // ==========================================================
        // CONFIGURAÇÃO DO DATAGRIDVIEW
        // ==========================================================
        private void ConfigurarGrid()
        {
            itensEncomenda.Columns.Clear();
            itensEncomenda.Columns.Add("cod_produto", typeof(int));
            itensEncomenda.Columns.Add("nome_produto", typeof(string));
            itensEncomenda.Columns.Add("qtde_produto", typeof(int));
            itensEncomenda.Columns.Add("valor_produto", typeof(decimal));
            itensEncomenda.Columns.Add("valor_total", typeof(decimal));

            dgvItens.DataSource = itensEncomenda;

            // Ajustes visuais (se colunas ainda não montadas no designer)
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvItens.Columns["cod_produto"] != null)
                dgvItens.Columns["cod_produto"].HeaderText = "Código";
            if (dgvItens.Columns["nome_produto"] != null)
                dgvItens.Columns["nome_produto"].HeaderText = "Produto";
            if (dgvItens.Columns["qtde_produto"] != null)
                dgvItens.Columns["qtde_produto"].HeaderText = "Quantidade";
            if (dgvItens.Columns["valor_produto"] != null)
            {
                dgvItens.Columns["valor_produto"].HeaderText = "Valor Unit.";
                dgvItens.Columns["valor_produto"].DefaultCellStyle.Format = "N2";
            }
            if (dgvItens.Columns["valor_total"] != null)
            {
                dgvItens.Columns["valor_total"].HeaderText = "Total";
                dgvItens.Columns["valor_total"].DefaultCellStyle.Format = "N2";
            }
        }

        // ==========================================================
        // CARREGAR PRODUTOS NO COMBOBOX
        // ==========================================================
        private void CarregarProdutos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "SELECT cod_produto, nome_produto FROM tbProdutos ORDER BY nome_produto";
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cbProduto.DataSource = dt;
                    cbProduto.DisplayMember = "nome_produto";
                    cbProduto.ValueMember = "cod_produto";
                }
            }
        }

        // ==========================================================
        // ADICIONAR PRODUTO À LISTA DE ITENS
        // ==========================================================
        private void btAdicionarProduto_Click_1(object sender, EventArgs e)
        {
            if (cbProduto.SelectedValue == null || string.IsNullOrWhiteSpace(txtQtdeProduto.Text))
            {
                MessageBox.Show("Selecione um produto e informe a quantidade.", "Atenção");
                return;
            }

            if (!int.TryParse(txtQtdeProduto.Text.Trim(), out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.", "Atenção");
                return;
            }

            int codProduto = Convert.ToInt32(cbProduto.SelectedValue);

            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string sql = "SELECT nome_produto, valor_produto, qtde_produto FROM tbProdutos WHERE cod_produto = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", codProduto);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nome = reader["nome_produto"].ToString();
                            decimal valor = Convert.ToDecimal(reader["valor_produto"]);
                            int estoqueAtual = Convert.ToInt32(reader["qtde_produto"]);

                            if (quantidade > estoqueAtual)
                            {
                                MessageBox.Show($"Estoque insuficiente! Estoque atual: {estoqueAtual}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            decimal totalItem = valor * quantidade;

                            // opcional: verificar se produto já está na lista e somar quantidades
                            DataRow existente = null;
                            foreach (DataRow r in itensEncomenda.Rows)
                            {
                                if (Convert.ToInt32(r["cod_produto"]) == codProduto)
                                {
                                    existente = r;
                                    break;
                                }
                            }

                            if (existente != null)
                            {
                                // atualiza quantidade e total do item existente
                                int novaQtde = Convert.ToInt32(existente["qtde_produto"]) + quantidade;
                                existente["qtde_produto"] = novaQtde;
                                existente["valor_total"] = Convert.ToDecimal(existente["valor_produto"]) * novaQtde;
                            }
                            else
                            {
                                itensEncomenda.Rows.Add(codProduto, nome, quantidade, valor, totalItem);
                            }

                            AtualizarTotal();
                            txtQtdeProduto.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // ==========================================================
        // SOMAR TOTAL DA ENCOMENDA (usa valor_total)
        // ==========================================================
        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (DataRow row in itensEncomenda.Rows)
            {
                // soma os subtotais (valor_total)
                total += Convert.ToDecimal(row["valor_total"]);
            }

            txtTotal.Text = total.ToString("F2");
        }

        // ==========================================================
        // REMOVER ITEM (opcional) - botão ou menu de contexto pode chamar esse método
        // ==========================================================
        private void RemoverItemSelecionado()
        {
            if (dgvItens.CurrentRow == null) return;
            DataRowView drv = dgvItens.CurrentRow.DataBoundItem as DataRowView;
            if (drv != null)
            {
                drv.Row.Delete();
                AtualizarTotal();
            }
        }

        // ==========================================================
        // SALVAR ENCOMENDA (AGORA COMPATÍVEL COM SUA TABELA)
        // ==========================================================
        private void btSalvarCadastroEncomendas_Click(object sender, EventArgs e)
        {
            if (itensEncomenda.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto à encomenda!", "Atenção");
                return;
            }

            // validações básicas
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Preencha nome e CPF do cliente.", "Atenção");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    // Cria lista textual de produtos e quantidades (para campos produtos_encomenda e qtde_encomenda)
                    StringBuilder produtosLista = new StringBuilder();
                    StringBuilder qtdeLista = new StringBuilder();

                    foreach (DataRow row in itensEncomenda.Rows)
                    {
                        produtosLista.AppendLine(row["nome_produto"].ToString());
                        qtdeLista.AppendLine(row["qtde_produto"].ToString());
                    }

                    // Inserir encomenda na tbEncomendas (sua tabela)
                    string sqlEncomenda = @"INSERT INTO tbEncomendas
                        (nome_encomenda, data_encomenda, fone_encomenda, end_encomenda, total_encomenda, previsao_encomenda, 
                        pagamento_encomenda, cpf_encomenda, obs_encomenda, produtos_encomenda, qtde_encomenda)
                        VALUES (@nome, GETDATE(), @fone, @endereco, @total, @previsao, @pagamento, @cpf, @obs, @produtos, @qtde)";

                    using (SqlCommand cmd = new SqlCommand(sqlEncomenda, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@fone", txtFone.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@total", txtTotal.Text); // sua coluna é varchar
                        cmd.Parameters.AddWithValue("@previsao", txtPrevisao.Text);
                        cmd.Parameters.AddWithValue("@pagamento", txtPagamento.Text);
                        cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                        cmd.Parameters.AddWithValue("@produtos", produtosLista.ToString());
                        cmd.Parameters.AddWithValue("@qtde", qtdeLista.ToString());
                        cmd.Parameters.AddWithValue("@obs", txtObs.Text);

                        cmd.ExecuteNonQuery();
                    }

                    // Atualizar estoque: usa qtde_produto (quantidade comprada)
                    foreach (DataRow row in itensEncomenda.Rows)
                    {
                        int codProduto = Convert.ToInt32(row["cod_produto"]);
                        int qtde = Convert.ToInt32(row["qtde_produto"]);

                        string sqlEstoque = "UPDATE tbProdutos SET qtde_produto = qtde_produto - @qtde WHERE cod_produto = @id";
                        using (SqlCommand cmdEstoque = new SqlCommand(sqlEstoque, conexao, transacao))
                        {
                            cmdEstoque.Parameters.AddWithValue("@qtde", qtde);
                            cmdEstoque.Parameters.AddWithValue("@id", codProduto);
                            int linhas = cmdEstoque.ExecuteNonQuery();

                            if (linhas == 0)
                            {
                                throw new Exception($"Produto com id {codProduto} não encontrado ao atualizar estoque.");
                            }
                        }
                    }

                    transacao.Commit();
                    MessageBox.Show("Encomenda salva com sucesso e estoque atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    try { transacao.Rollback(); } catch { }
                    MessageBox.Show("Erro ao salvar a encomenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================================
        // BUSCAR CLIENTE AUTOMATICAMENTE PELO CPF
        // ==========================================================
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCPF.Text))
                BuscarClientePorCPF(txtCPF.Text.Trim());
        }

        private void BuscarClientePorCPF(string cpf)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    string sql = "SELECT nome_cliente, fone_cliente, end_cliente FROM tbClientes WHERE cpf_cliente = @cpf";
                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        conexao.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome_cliente"].ToString();
                                txtFone.Text = reader["fone_cliente"].ToString();
                                txtEndereco.Text = reader["end_cliente"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado com esse CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtNome.Clear();
                                txtFone.Clear();
                                txtEndereco.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
