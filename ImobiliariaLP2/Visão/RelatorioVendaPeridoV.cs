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
    public partial class RelatorioVendaPeridoV : Form
    {
        public RelatorioVendaPeridoV()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
            RelatoriosV r = new RelatoriosV();
            r.ShowDialog();
        }
    }
}
