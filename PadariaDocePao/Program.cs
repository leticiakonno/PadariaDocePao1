using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaDocePao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tratamento global de exceções
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show($"Erro não tratado: {e.Exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = e.ExceptionObject as Exception;
                MessageBox.Show($"Erro fatal: {ex?.Message}", "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Inicia o formulário principal
            Application.Run(new Login());
        }
    }
}
