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
    public partial class RelatorioVendaFuncV : Form
    {
        public RelatorioVendaFuncV()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
            RelatoriosV r = new RelatoriosV();
            r.ShowDialog();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            RelatorioContratoscs relatorio = new RelatorioContratoscs();
            relatorio.tipoRelatorio = 2;

            this.Dispose();
            relatorio.Show();
        }
    }
}
