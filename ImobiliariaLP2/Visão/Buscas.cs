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
    public partial class Buscas : Form
    {
        public Buscas()
        {
            InitializeComponent();
        }

        private void RltVendasP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BuscaCliente bc = new BuscaCliente();
            bc.ShowDialog();
        }

        private void btnBImovel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BuscaImovel bi = new BuscaImovel();
            bi.ShowDialog();

        }

        private void btnRltVendasF_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BuscaFuncionario bf = new BuscaFuncionario();
            bf.ShowDialog();

        }

        private void btnBProprietario_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BuscaProprietario bp = new BuscaProprietario();
            bp.ShowDialog();
        }

        private void btn_voltarMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
