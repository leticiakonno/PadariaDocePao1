using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class CadastroCliente : Form
    {
        // Define se está cadastrando (null) ou alterando (possui ID)
        private int? _idClienteParaAlterar = null;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        // Construtor usado quando queremos editar um cliente existente
        // ==============================================================
        // MÉTODO PARA CARREGAR DADOS DE UM CLIENTE EXISTENTE
        // ==============================================================
        public CadastroCliente(int idCliente) : this()
        {
            _idClienteParaAlterar = idCliente;
            CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            MessageBox.Show($"Carregando dados do cliente ID: {_idClienteParaAlterar}", "Debug");

            this.Text = "Alterar Cliente";
            lbCadastroCliente.Text = "Alterar Cliente";

            string connectionString = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.bdPadariaDocePaoConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT * FROM tbClientes WHERE cod_cliente = @cod_cliente";

                    using (SqlCommand comando = new SqlCommand(sqlSelect, conexao))
                    {
                        comando.Parameters.AddWithValue("@cod_cliente", _idClienteParaAlterar);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNome.Text = reader["nome_cliente"].ToString();
                                txtEmail.Text = reader["email_cliente"].ToString();
                                txtFone.Text = reader["fone_cliente"].ToString();
                                txtCPF.Text = reader["cpf_cliente"].ToString();
                                txtEndereco.Text = reader["end_cliente"].ToString();
                                txtmDataNas.Text = Convert.ToDateTime(reader["data_nas_cliente"]).ToString("dd/MM/yyyy");
                                txtmDataCad.Text = Convert.ToDateTime(reader["data_cad_cliente"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // ==============================================================
        // BOTÃO FINALIZAR (INSERIR OU ALTERAR)
        // ==============================================================
        private void btSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFone.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtmDataNas.Text) ||
                string.IsNullOrWhiteSpace(txtmDataCad.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txtmDataNas.Text, out DateTime dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (_idClienteParaAlterar == null)
                    {
                        // 🟢 INSERT — retorna o ID gerado automaticamente
                        sql = @"INSERT INTO tbClientes 
                        (nome_cliente, email_cliente, fone_cliente, cpf_cliente, data_nas_cliente, data_cad_cliente, end_cliente)
                        VALUES (@nome, @email, @fone, @cpf, @dataNas, @dataCad, @endereco);
                        SELECT SCOPE_IDENTITY();";  // <- Retorna o ID real
                    }
                    else
                    {
                        // 🟡 UPDATE
                        sql = @"UPDATE tbClientes 
                        SET nome_cliente = @nome, 
                            email_cliente = @email,
                            fone_cliente = @fone,
                            cpf_cliente = @cpf,
                            data_nas_cliente = @dataNas,
                            data_cad_cliente = @dataCad
                            end_cliente = @endereco
                        WHERE cod_cliente = @cod_cliente";
                    }

                    using (SqlCommand comando = new SqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        comando.Parameters.AddWithValue("@fone", txtFone.Text.Trim());
                        comando.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());
                        comando.Parameters.AddWithValue("@endereco", txtEndereco.Text.Trim());
                        comando.Parameters.AddWithValue("@dataNas", dataNascimento);
                        comando.Parameters.AddWithValue("@dataCad", DateTime.Now);

                        if (_idClienteParaAlterar != null)
                            comando.Parameters.AddWithValue("@cod_cliente", _idClienteParaAlterar);

                        if (_idClienteParaAlterar == null)
                        {
                            // 🔹 INSERT → obtém o ID correto
                            object result = comando.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int novoId))
                            {
                                MessageBox.Show($"Cliente cadastrado com sucesso! (ID: {novoId})",
                                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cliente cadastrado, mas não foi possível obter o ID.",
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // 🔹 UPDATE
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                                MessageBox.Show("Cliente alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Erro ao salvar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
