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
    public partial class BuscaCliente : Form
    {
        public BuscaCliente()
        {
            InitializeComponent();
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            VizualizarCliente v = new VizualizarCliente();
            v.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Buscas b = new Buscas();
            b.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void BuscaCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();

            dgvCliente.DataSource = cDAO.BuscarTodos();
        }
    }
}
