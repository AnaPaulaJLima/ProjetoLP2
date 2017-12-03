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
    public partial class RelatorioContratoscs : Form
    {
        public int tipoRelatorio; 

        public RelatorioContratoscs()
        {
            InitializeComponent();
        }

        private void RelatorioContratoscs_Load(object sender, EventArgs e)
        {
            if (tipoRelatorio == 1)
            {
                RelatorioContratoVenda rcv = new RelatorioContratoVenda();
                crvRelatorio.ReportSource = rcv;
                crvRelatorio.Refresh();
            }

            if(tipoRelatorio == 2)
            {
                RelatorioVendaFuncV rvf = new RelatorioVendaFuncV();
                crvRelatorio.ReportSource = rvf;
                crvRelatorio.Refresh();
            }
            
        }
    }
}
