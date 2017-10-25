using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaLP2.Visão;

namespace ImobiliariaLP2
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

            LoginV login = new LoginV();
            login.ShowDialog();
            if (login.logado == true)
            {
                Application.Run(new Inicio());
            }
        }
    }
}
