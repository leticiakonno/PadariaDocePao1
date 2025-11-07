using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroFornecedores : Form
    {
        // Define se está cadastrando (null) ou alterando (possui ID)
        private int? _idFornecedoresParaAlterar = null;

        public CadastroFornecedores()
        {
            InitializeComponent();
        }

        // Construtor usado quando queremos editar um cliente existente
        // ==============================================================
        // MÉTODO PARA CARREGAR DADOS DE UM CLIENTE EXISTENTE
        // ==============================================================
        public CadastroFornecedores(int idFornecedor) : this()
        {
            _idFornecedoresParaAlterar = idFornecedor;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            MessageBox.Show($"Carregando dados do fornecedor ID: {_idFornecedoresParaAlterar}", "Debug");

            this.Text = "Alterar Fornecedor";
            lbCadastroFornecedor.Text = "Alterar Fornecedor";

            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbFornecedores WHERE cod_fornecedor = @cod_fornecedor";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_fornecedor", _idFornecedoresParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txtNome.Text = reader["nome_fornecedor"].ToString();
                                txtCNPJ.Text = reader["cnpj_fornecedor"].ToString();
                                txtFone.Text = reader["fone_fornecedor"].ToString();
                                txtRazaoSocial.Text = reader["razao_social_fornecedor"].ToString();
                                txtInscEstadual.Text = reader["insc_estadual_fornecedor"].ToString();
                                txtDataCad.Text = Convert.ToDateTime(reader["data_cad_fornecedor"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("Fornecedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do fornecedor: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // ==============================================================
        // BOTÃO FINALIZAR (INSERIR OU ALTERAR)
        // ==============================================================
        private void btSalvarCadastroFornecedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCNPJ.Text) ||
                string.IsNullOrWhiteSpace(txtFone.Text) ||
                string.IsNullOrWhiteSpace(txtRazaoSocial.Text) ||
                string.IsNullOrWhiteSpace(txtInscEstadual.Text) ||
                string.IsNullOrWhiteSpace(txtDataCad.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txtDataCad.Text, out DateTime dataCadastro))
            {
                MessageBox.Show("Data de Cadastro inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (_idFornecedoresParaAlterar == null)
                    {
                        // 🟢 INSERT — retorna o ID gerado automaticamente
                        sql = @"INSERT INTO tbFornecedores 
                        (nome_fornecedor, cnpj_fornecedor, fone_fornecedor, data_cad_fornecedor, razao_social_fornecedor, insc_estadual_fornecedor)
                        VALUES (@nome, @cnpj, @fone, @dataCad, @razaoSocial, @inscEstadual);
                        SELECT SCOPE_IDENTITY();";  // <- Retorna o ID real
                    }
                    else
                    {
                        // 🟡 UPDATE
                        sql = @"UPDATE tbFornecedores 
                        SET nome_fornecedor = @nome,
                            cnpj_fornecedor = @cnpj,
                            fone_fornecedor = @fone,
                            data_cad_fornecedor = @dataCad,
                            razao_social_fornecedor = @razaoSocial,
                            insc_estadual_fornecedor = @inscEstadual
                        WHERE cod_fornecedor = @cod_fornecedor";
                    }

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        comando.Parameters.AddWithValue("@cnpj", txtCNPJ.Text.Trim());
                        comando.Parameters.AddWithValue("@fone", txtFone.Text.Trim());
                        comando.Parameters.AddWithValue("@razaoSocial", txtRazaoSocial.Text.Trim());
                        comando.Parameters.AddWithValue("@inscEstadual", txtInscEstadual.Text.Trim());
                        comando.Parameters.AddWithValue("@dataCad", dataCadastro);

                        if (_idFornecedoresParaAlterar != null)
                            comando.Parameters.AddWithValue("@cod_fornecedor", _idFornecedoresParaAlterar);

                        if (_idFornecedoresParaAlterar == null)
                        {
                            // 🔹 INSERT → obtém o ID correto
                            object result = comando.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                MessageBox.Show($"Fornecedor cadastrado com sucesso! (ID: {novoId})",
                                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Fornecedor cadastrado, mas não foi possível obter o ID.",
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // 🔹 UPDATE
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                                MessageBox.Show("Fornecedor alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Nenhuma alteração realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao salvar o fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

