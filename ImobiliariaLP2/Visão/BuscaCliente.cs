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
            if (dgvCliente.CurrentRow != null)
            {
                int key = int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString());
                ClienteDAO cDAO = new ClienteDAO();
                VizualizarCliente v = new VizualizarCliente(cDAO.BuscarPorId(key));
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para vizualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Fill("");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Buscas b = new Buscas();
            b.ShowDialog();
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
           ClienteDAO cDAO = new ClienteDAO();
           dgvCliente.DataSource = cDAO.Buscar(textBoxNome.Text);
        }

        private void BuscaCliente_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            Fill(textBoxNome.Text);
        }

        // Método Fill() busca cliente no banco por nome
        // e popula o DataGrid com a lista retornada do DAO
        public void Fill(string s)
        {
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar(s);

            dgvCliente.Rows.Clear();
            foreach (Cliente c in lista)
            {
                dgvCliente.Rows.Add(c.Id, c.Nome, c.Cpf);
            }
        }
    }
}
