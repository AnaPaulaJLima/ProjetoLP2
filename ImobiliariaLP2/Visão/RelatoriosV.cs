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
using ImobiliariaLP2.Relatorios;

namespace ImobiliariaLP2.Visão
{
    public partial class RelatoriosV : Form
    {
        public RelatoriosV()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        public RelatoriosV(Funcionario f)
        {
            InitializeComponent();
            button1.Visible = false;
            if(f.Acesso != 1)
            {
                btnRltVendasF.Enabled = false;
                RltVendasP.Enabled = false;
            }
        }

        private void RltVendasP_Click(object sender, EventArgs e)
        {
            FormRelatorioVendas rv = new FormRelatorioVendas();
            rv.ShowDialog();
            /*this.Dispose();
            RelatorioVendaPeridoV rvp = new RelatorioVendaPeridoV();
            rvp.ShowDialog();   */
        }

        private void btnRltVendasF_Click(object sender, EventArgs e)
        {
            FormRelatorioFunc rf = new FormRelatorioFunc();
            rf.ShowDialog();
            /*this.Dispose();
            RelatorioVendaFuncV rvf = new RelatorioVendaFuncV();
            rvf.ShowDialog();*/
        }

        private void btnRltImoveisDisp_Click(object sender, EventArgs e)
        {
            FormRelatorioImovel fri = new FormRelatorioImovel();
            fri.ShowDialog();
            /*this.Dispose();
            RelatorioImoveisDisponivelV rid = new RelatorioImoveisDisponivelV();
            rid.ShowDialog();*/
        }

        private void btn_voltarMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aula13_11 a = new aula13_11();
            a.ShowDialog();
        }

        private void btnProprietarios_Click(object sender, EventArgs e)
        {
            FormPorprietariocs p = new FormPorprietariocs();
            p.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes c = new FormClientes();
            c.ShowDialog();
        }
    }
}
