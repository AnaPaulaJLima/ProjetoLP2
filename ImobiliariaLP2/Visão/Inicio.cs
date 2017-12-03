using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaLP2.Modelo;

namespace ImobiliariaLP2.Visão
{
    public partial class Inicio : Form
    {
        public Funcionario funcionario = null;
        public Inicio()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        public Inicio(Funcionario f)
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
            if(f.Acesso != 1)
            {
                btnFuncionario.Enabled = false;
                funcionariosToolStripMenuItem.Enabled = false;
                funcionariosToolStripMenuItem1.Enabled = false;
                vendasPorFuncionarioToolStripMenuItem.Enabled = false;
                vendasPorPeriodoToolStripMenuItem.Enabled = false;
            }
            funcionario = f;
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
            RelatoriosV r = new RelatoriosV(funcionario);
            r.ShowDialog();
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

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscas b = new Buscas();
            b.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proprietáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void imóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imoveisDisponiveisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasPorFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
