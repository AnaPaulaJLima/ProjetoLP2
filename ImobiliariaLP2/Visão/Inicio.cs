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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnProprietarios_Click(object sender, EventArgs e)
        {
            ProprietariosV p = new ProprietariosV();
            p.ShowDialog();
        }

        private void btnImoveis_Click(object sender, EventArgs e)
        {
            ImovelV i = new ImovelV();
            i.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteV c = new ClienteV();
            c.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioV f = new FuncionarioV();
            f.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            VendaV v = new VendaV();
            v.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioVendaPeridoV rvp = new RelatorioVendaPeridoV();
            rvp.ShowDialog();
        }

        private void btnRltVendasF_Click(object sender, EventArgs e)
        {
            RelatorioVendaFuncV rvf = new RelatorioVendaFuncV();
            rvf.ShowDialog();
        }

        private void btnRltImoveisDisp_Click(object sender, EventArgs e)
        {
            RelatorioImoveisDisponivelV rid = new RelatorioImoveisDisponivelV();
            rid.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            RelatoriosV r = new RelatoriosV();
            r.ShowDialog();
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteV c = new ClienteV();
            c.ShowDialog();
        }

        private void imoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImovelV i = new ImovelV();
            i.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioV f = new FuncionarioV();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Dispose();
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void vendaAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProprietariosV p = new ProprietariosV();
            p.ShowDialog();
        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaProprietario b = new BuscaProprietario();
            b.ShowDialog();
        }

        private void buscaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscaCliente b = new BuscaCliente();
            b.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteV c = new ClienteV();
            c.ShowDialog();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ImovelV i = new ImovelV();
            i.ShowDialog();
        }

        private void buscaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuscaImovel b = new BuscaImovel();
            b.ShowDialog();
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FuncionarioV f = new FuncionarioV();
            f.ShowDialog();
        }

        private void buscaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BuscaFuncionario b = new BuscaFuncionario();
            b.ShowDialog();
        }
    }
}
