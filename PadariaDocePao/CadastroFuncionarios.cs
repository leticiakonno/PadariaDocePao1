using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroFuncionarios : Form
    {
        // Define se está cadastrando (null) ou alterando (possui ID)
        private int? _idFuncionariosParaAlterar = null;

        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        // Construtor usado quando queremos editar um cliente existente
        // ==============================================================
        // MÉTODO PARA CARREGAR DADOS DE UM CLIENTE EXISTENTE
        // ==============================================================
        public CadastroFuncionarios(int idFuncionario) : this()
        {
            _idFuncionariosParaAlterar = idFuncionario;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            MessageBox.Show($"Carregando dados do funcionário ID: {_idFuncionariosParaAlterar}", "Debug");

            this.Text = "Alterar funcionário";
            lbCadastroFuncionario.Text = "Alterar funcionário";

            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbFuncionarios WHERE cod_funcionario = @cod_funcionario";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_funcionario", _idFuncionariosParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txtNome.Text = reader["nome_funcionario"].ToString();
                                txtCPF.Text = reader["cpf_funcionario"].ToString();
                                txtFone.Text = reader["fone_funcionario"].ToString();
                                txtCargo.Text = reader["cargo_funcionario"].ToString();
                                txtDataNas.Text = Convert.ToDateTime(reader["data_nas_funcionario"]).ToString("dd/MM/yyyy");
                                txtDataCad.Text = Convert.ToDateTime(reader["data_cad_funcionario"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do funcionário: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // ==============================================================
        // BOTÃO FINALIZAR (INSERIR OU ALTERAR)
        // ==============================================================
        private void btSalvarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtFone.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtDataNas.Text) ||
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
                    if (_idFuncionariosParaAlterar == null)
                    {
                        // 🟢 INSERT — retorna o ID gerado automaticamente
                        sql = @"INSERT INTO tbFuncionarios 
                        (nome_funcionario, cargo_funcionario, data_nas_funcionario, cpf_funcionario, data_cad_funcionario, fone_funcionario)
                        VALUES (@nome, @cargo, @dataNas, @cpf, @dataCad, @fone);
                        SELECT SCOPE_IDENTITY();";  // <- Retorna o ID real
                    }
                    else
                    {
                        // 🟡 UPDATE
                        sql = @"UPDATE tbFuncionarios 
                        SET nome_funcionario = @nome,
                            cargo_funcionario = @cargo,
                            data_nas_funcionario = @dataNas,
                            cpf_funcionario = @cpf,
                            data_cad_funcionario = @dataCad,
                            fone_funcionario = @fone
                        WHERE cod_funcionario = @cod_funcionario";
                    }

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        comando.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());
                        comando.Parameters.AddWithValue("@fone", txtFone.Text.Trim());
                        comando.Parameters.AddWithValue("@cargo", txtCargo.Text.Trim());
                        comando.Parameters.AddWithValue("@dataNas", DateTime.Parse(txtDataNas.Text.Trim()));
                        comando.Parameters.AddWithValue("@dataCad", dataCadastro);

                        if (_idFuncionariosParaAlterar != null)
                            comando.Parameters.AddWithValue("@cod_funcionario", _idFuncionariosParaAlterar);

                        if (_idFuncionariosParaAlterar == null)
                        {
                            // 🔹 INSERT → obtém o ID correto
                            object result = comando.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                MessageBox.Show($"Funcionário cadastrado com sucesso! (ID: {novoId})",
                                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Funcionário cadastrado, mas não foi possível obter o ID.",
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // 🔹 UPDATE
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                                MessageBox.Show("Funcionário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Nenhuma alteração realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("O CPF informado já está cadastrado.", "Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
