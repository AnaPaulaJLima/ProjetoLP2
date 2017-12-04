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
    public partial class FormPorprietariocs : Form
    {
        public FormPorprietariocs()
        {
            InitializeComponent();
        }

        private void FormPorprietariocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imobiliaria_lp2DataSet.proprietario' table. You can move, or remove it, as needed.
            this.proprietarioTableAdapter.Fill(this.imobiliaria_lp2DataSet.proprietario);

            this.reportViewer1.RefreshReport();
        }
    }
}
