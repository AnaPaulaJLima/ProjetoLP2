using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaLP2.Visão
{
    public partial class BuscaFuncionario : Form
    {
        public BuscaFuncionario()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Buscas b = new Buscas();
            b.ShowDialog();
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            VisualizarFuncionario v = new VisualizarFuncionario();
            v.ShowDialog();
        }
    }
}
