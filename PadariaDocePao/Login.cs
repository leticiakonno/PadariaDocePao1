using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void brEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Gerente" && txtSenha.Text == "1234")
            {
                PaginaGerenciamento telaGerente = new PaginaGerenciamento();
                this.Hide();
                telaGerente.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
        }

        private void brCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
