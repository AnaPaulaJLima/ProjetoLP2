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
    public partial class BuscaImovel : Form
    {
        public BuscaImovel()
        {
            InitializeComponent();
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            VisualizarImovelV v = new VisualizarImovelV();
            v.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
