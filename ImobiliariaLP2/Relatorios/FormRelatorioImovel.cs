using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaLP2.Relatorios
{
    public partial class FormRelatorioImovel : Form
    {
        public FormRelatorioImovel()
        {
            InitializeComponent();
        }

        private void FormRelatorioImovel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imobiliaria_lp2DataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.imobiliaria_lp2DataSet.imovel);

            this.reportViewer1.RefreshReport();
        }
    }
}
