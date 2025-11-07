using PadariaDocePao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class PaginaGerenciamento : Form
    {
        public PaginaGerenciamento()
        {
            InitializeComponent();

        }
        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente btCadastrarCliente = new CadastroCliente();
            btCadastrarCliente.ShowDialog();

        }

        private void btCadastrarFuncionario_Click_1(object sender, EventArgs e)
        {
            CadastroFuncionarios btCadastrarFuncionario = new CadastroFuncionarios();
            btCadastrarFuncionario.ShowDialog();

        }

        private void btCadastrarVenda_Click(object sender, EventArgs e)
        {
            CadastroVendas btCadastrarVenda = new CadastroVendas();
            btCadastrarVenda.ShowDialog();
        }

        private void btCadastrarMP_Click(object sender, EventArgs e)
        {
            CadastroMateriaPrima btCadastrarMP = new CadastroMateriaPrima();
            btCadastrarMP.ShowDialog();
        }

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroProdutos btCadastrarProduto = new CadastroProdutos();
            btCadastrarProduto.ShowDialog();
        }

        private void btCadastrarEncomendas_Click(object sender, EventArgs e)
        {
            CadastroEncomendas btCadastrarEncomendas = new CadastroEncomendas();
            btCadastrarEncomendas.ShowDialog();
        }

        private void btCadastrarFornecedores_Click(object sender, EventArgs e)
        {
            CadastroFornecedores btCadastrarFornecedores = new CadastroFornecedores();
            btCadastrarFornecedores.ShowDialog();
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultaClientes btConsultarCliente = new ConsultaClientes();
            btConsultarCliente.ShowDialog();
        }

        private void btConsultarFuncionario_Click(object sender, EventArgs e)
        {
            ConsultaFuncionarios btConsultarFuncionario = new ConsultaFuncionarios();
            btConsultarFuncionario.ShowDialog();
        }

        private void btConsultarVenda_Click(object sender, EventArgs e)
        {
            ConsultaVendas btConsultarVenda = new ConsultaVendas();
            btConsultarVenda.ShowDialog();
        }

        private void btConsultarMP_Click(object sender, EventArgs e)
        {
            ConsultaMateriaPrima btConsultarMP = new ConsultaMateriaPrima();
            btConsultarMP.ShowDialog();
        }

        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            ConsultaProdutos btConsultarProduto = new ConsultaProdutos();
            btConsultarProduto.ShowDialog();
        }

        private void btConsultarEncomendas_Click(object sender, EventArgs e)
        {
            ConsultaEncomendas btConsultarEncomendas = new ConsultaEncomendas();
            btConsultarEncomendas.ShowDialog();
        }

        private void btConsultarFornecedor_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores btConsultarFornecedor = new ConsultaFornecedores();
            btConsultarFornecedor.ShowDialog();
        }

        private void gpProdutos_Enter(object sender, EventArgs e)
        {

        }
    }
}
