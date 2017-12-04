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
    public partial class FormRelatorioFunc : Form
    {
        public FormRelatorioFunc()
        {
            InitializeComponent();
        }

        private void FormRelatorioFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imobiliaria_lp2DataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.imobiliaria_lp2DataSet.funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
