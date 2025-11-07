using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroMateriaPrima : Form
    {
        // Define se está cadastrando (null) ou alterando (possui ID)
        private int? _idMateriaPrimaParaAlterar = null;

        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        // Construtor usado quando queremos editar um cliente existente
        // ==============================================================
        // MÉTODO PARA CARREGAR DADOS DE UM CLIENTE EXISTENTE
        // ==============================================================
        public CadastroMateriaPrima(int idMateriaPrima) : this()
        {
            _idMateriaPrimaParaAlterar = idMateriaPrima;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            MessageBox.Show($"Carregando dados da Matéria-Prima ID: {_idMateriaPrimaParaAlterar}", "Debug");

            this.Text = "Alterar Matéria-Prima";
            lbCadastroMP.Text = "Alterar Matéria-Prima";

            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbMateriaPrima WHERE cod_mp = @cod_mp";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_mp", _idMateriaPrimaParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txtNome.Text = reader["nome_mp"].ToString();
                                txtCategoria.Text = reader["categoria_mp"].ToString();
                                txtQtde.Text = reader["qtde_mp"].ToString();
                                txtFornecedorMP.Text = reader["fornecedor_mp"].ToString();
                                txtClassificacao.Text = reader["classificacao_mp"].ToString();
                                txtUndMed.Text = reader["und_medida_mp"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Matéria-Prima não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da Matéria-Prima: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // ==============================================================
        // BOTÃO FINALIZAR (INSERIR OU ALTERAR)
        // ==============================================================
        private void btSalvarCadastroMP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtQtde.Text) ||
                string.IsNullOrWhiteSpace(txtFornecedorMP.Text) ||
                string.IsNullOrWhiteSpace(txtClassificacao.Text) ||
                string.IsNullOrWhiteSpace(txtUndMed.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // ✅ VERIFICA SE O FORNECEDOR EXISTE ANTES DE CADASTRAR
                    string sqlVerificaFornecedor = "SELECT COUNT(*) FROM tbFornecedores WHERE nome_fornecedor = @nomeFornecedor";

                    using (SqlCommand cmdVerifica = new SqlCommand(sqlVerificaFornecedor, conexao))
                    {
                        cmdVerifica.Parameters.AddWithValue("@nomeFornecedor", txtFornecedorMP.Text.Trim());

                        int existeFornecedor = Convert.ToInt32(cmdVerifica.ExecuteScalar());

                        if (existeFornecedor == 0)
                        {
                            MessageBox.Show($"O fornecedor \"{txtFornecedorMP.Text}\" não está cadastrado no sistema.\n" +
                                            "Cadastre o fornecedor antes de cadastrar a matéria-prima.",
                                            "Fornecedor não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Interrompe o cadastro
                        }
                    }

                    // ✅ Se chegou aqui, fornecedor existe → continua o cadastro normalmente
                    string sql;
                    if (_idMateriaPrimaParaAlterar == null)
                    {
                        sql = @"INSERT INTO tbMateriaPrima 
                        (nome_mp, fornecedor_mp, qtde_mp, classificacao_mp, und_medida_mp, categoria_mp)
                        VALUES (@nome, @fornecedor, @quantidade, @classificacao, @unidadeMedida, @categoria);
                        SELECT SCOPE_IDENTITY();";
                    }
                    else
                    {
                        sql = @"UPDATE tbMateriaPrima 
                        SET nome_mp = @nome,
                            fornecedor_mp = @fornecedor,
                            qtde_mp = @quantidade,
                            classificacao_mp = @classificacao,
                            und_medida_mp = @unidadeMedida,
                            categoria_mp = @categoria
                        WHERE cod_mp = @cod_mp";
                    }

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        comando.Parameters.AddWithValue("@fornecedor", txtFornecedorMP.Text.Trim());
                        comando.Parameters.AddWithValue("@quantidade", txtQtde.Text.Trim());
                        comando.Parameters.AddWithValue("@classificacao", txtClassificacao.Text.Trim());
                        comando.Parameters.AddWithValue("@unidadeMedida", txtUndMed.Text.Trim());
                        comando.Parameters.AddWithValue("@categoria", txtCategoria.Text.Trim());

                        if (_idMateriaPrimaParaAlterar != null)
                            comando.Parameters.AddWithValue("@cod_mp", _idMateriaPrimaParaAlterar);

                        if (_idMateriaPrimaParaAlterar == null)
                        {
                            object result = comando.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                MessageBox.Show($"Matéria-Prima cadastrada com sucesso! (ID: {novoId})",
                                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Matéria-Prima cadastrada, mas não foi possível obter o ID.",
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                                MessageBox.Show("Matéria-Prima alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Nenhuma alteração realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a Matéria-Prima: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
