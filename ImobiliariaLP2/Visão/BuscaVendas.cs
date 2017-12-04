using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaLP2.DAO;
using ImobiliariaLP2.Modelo;

namespace ImobiliariaLP2.Visão
{
    public partial class BuscaVendas : Form
    {
        public BuscaVendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Fill(string s)
        {
            VendaDAO vDAO = new VendaDAO();
            List<Venda> lista = vDAO.Busca(s);

            dgvVenda.Rows.Clear();
            foreach(Venda v in lista)
            {
                dgvVenda.Rows.Add(v.Id, v.I.Id, v.F.Nome, v.C.Nome);
            }
        }

        private void BuscaVendas_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Fill(txtBoxNome.Text);
        }

        private void txtBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
            Fill(txtBoxNome.Text);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvVenda.CurrentRow != null)
            {
                int key = int.Parse(dgvVenda.CurrentRow.Cells[0].Value.ToString());
                VendaDAO vDAO = new VendaDAO();
                VisualizarVenda vv = new VisualizarVenda(vDAO.BuscaPorId(key));
                vv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para vizualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Fill("");
        }
    }
}
