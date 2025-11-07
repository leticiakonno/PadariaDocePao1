using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroProdutos : Form
    {
        private int? _idProdutoParaAlterar = null;

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        public CadastroProdutos(int idProduto) : this()
        {
            _idProdutoParaAlterar = idProduto;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            this.Text = "Alterar Produto";
            lbCadastroProduto.Text = "Alterar Produto";

            string connectionString = ConfigurationManager.ConnectionStrings[
                "PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"
            ].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbProdutos WHERE cod_produto = @cod_produto";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_produto", _idProdutoParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome_produto"].ToString();
                                txtCategoria.Text = reader["categoria_produto"].ToString();
                                txtQtde.Text = reader["qtde_produto"].ToString();
                                txtDescricao.Text = reader["descri_produto"].ToString();
                                txtValor.Text = reader["valor_produto"].ToString();
                                txtReceita.Text = reader["receita_produto"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Produto: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtQtde.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse de quantidade e valor com tratamento de culturas
            if (!int.TryParse(txtQtde.Text.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out int quantidadeProduto))
            {
                MessageBox.Show("Quantidade do produto inválida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // aceitar tanto 12,34 quanto 12.34 dependendo da cultura do usuário
            if (!decimal.TryParse(txtValor.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valorProduto))
            {
                MessageBox.Show("Valor do produto inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    SqlTransaction transacao = conexao.BeginTransaction();

                    try
                    {
                        string sql;
                        if (_idProdutoParaAlterar == null)
                        {
                            sql = @"INSERT INTO tbProdutos 
                                    (nome_produto, descri_produto, categoria_produto, valor_produto, qtde_produto, receita_produto)
                                    VALUES (@nome, @descricao, @categoria, @valor, @quantidade, @receita);
                                    SELECT SCOPE_IDENTITY();";
                        }
                        else
                        {
                            sql = @"UPDATE tbProdutos 
                                    SET nome_produto = @nome,
                                        descri_produto = @descricao,
                                        categoria_produto = @categoria,
                                        valor_produto = @valor,
                                        qtde_produto = @quantidade,
                                        receita_produto = @receita
                                    WHERE cod_produto = @cod_produto";
                        }

                        using (SqlCommand comando = new SqlCommand(sql, conexao, transacao))
                        {
                            // parâmetros fortemente tipados
                            comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                            comando.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                            comando.Parameters.AddWithValue("@categoria", txtCategoria.Text.Trim());
                            comando.Parameters.AddWithValue("@valor", valorProduto);           // decimal
                            comando.Parameters.AddWithValue("@quantidade", quantidadeProduto); // int
                            comando.Parameters.AddWithValue("@receita", txtReceita.Text.Trim());

                            if (_idProdutoParaAlterar != null)
                                comando.Parameters.AddWithValue("@cod_produto", _idProdutoParaAlterar.Value);

                            object result;
                            if (_idProdutoParaAlterar == null)
                                result = comando.ExecuteScalar(); // retorna novo id
                            else
                            {
                                comando.ExecuteNonQuery();
                                result = _idProdutoParaAlterar.Value;
                            }

                            // Se houve receita, devemos debitar as matérias-primas
                            if (!string.IsNullOrWhiteSpace(txtReceita.Text))
                            {
                                // formato esperado: "Farinha=2; Açúcar=1.5; Ovos=3"
                                string receita = txtReceita.Text;
                                string[] itens = receita.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                                foreach (string item in itens)
                                {
                                    string linha = item.Trim();
                                    if (string.IsNullOrEmpty(linha)) continue;

                                    string[] partes = linha.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                                    if (partes.Length != 2) continue;

                                    string nomeMP = partes[0].Trim();
                                    string quantidadeTexto = partes[1].Trim();

                                    // aceitar , ou . como separador decimal
                                    if (!decimal.TryParse(quantidadeTexto.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal qtdeReceita))
                                    {
                                        // tenta com cultura atual
                                        decimal.TryParse(quantidadeTexto, NumberStyles.Number, CultureInfo.CurrentCulture, out qtdeReceita);
                                    }

                                    // Atualização segura: se coluna qtde_mp for varchar, convertemos com TRY_CONVERT
                                    string sqlUpdateMP = @"
                                        UPDATE tbMateriaPrima
                                        SET qtde_mp = CONVERT(varchar(50),
                                            (ISNULL(TRY_CONVERT(decimal(18,4), qtde_mp), 0) - @qtde)
                                        )
                                        WHERE nome_mp = @nome";

                                    using (SqlCommand cmdMP = new SqlCommand(sqlUpdateMP, conexao, transacao))
                                    {
                                        cmdMP.Parameters.AddWithValue("@qtde", qtdeReceita);
                                        cmdMP.Parameters.AddWithValue("@nome", nomeMP);
                                        int linhasAfetadas = cmdMP.ExecuteNonQuery();

                                        // opcional: se nenhum registro foi atualizado, podemos avisar ou lançar erro
                                        if (linhasAfetadas == 0)
                                        {
                                            // Se preferir: lançar exceção para cancelar tudo
                                            // throw new Exception($"Matéria-prima '{nomeMP}' não encontrada no estoque.");

                                            // ou apenas informar ao usuário (aqui optamos por lançar para chamar rollback)
                                            throw new Exception($"Matéria-prima '{nomeMP}' não encontrada no estoque.");
                                        }
                                    }
                                }
                            }

                            transacao.Commit();

                            if (_idProdutoParaAlterar == null && result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                MessageBox.Show($"Produto cadastrado com sucesso! (ID: {novoId})", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        try { transacao.Rollback(); } catch { }
                        MessageBox.Show("Erro ao salvar o Produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão com o banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
