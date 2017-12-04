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
            this.Hide();
            BuscaCliente bc = new BuscaCliente();
            bc.ShowDialog();
        }

        private void btnBImovel_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscaImovel bi = new BuscaImovel();
            bi.ShowDialog();

        }

        private void btnRltVendasF_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscaFuncionario bf = new BuscaFuncionario();
            bf.ShowDialog();

        }

        private void btnBProprietario_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscaProprietario bp = new BuscaProprietario();
            bp.ShowDialog();
        }

        private void btn_voltarMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            BuscaVendas bv = new BuscaVendas();
            bv.ShowDialog();
        }
    }
}
