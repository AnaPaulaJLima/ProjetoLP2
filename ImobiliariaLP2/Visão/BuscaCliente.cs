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

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
           ClienteDAO c = new ClienteDAO();
           dgvCliente.DataSource = c.Buscar(textBoxNome.Text);
        }

        private void BuscaCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            //List<Cliente> lista = cDAO.BuscarTodos();
            List<Cliente> lista = cDAO.Buscar("");


            dgvCliente.Rows.Clear();
            foreach(Cliente c in lista)
            {
                dgvCliente.Rows.Add(c.Id, c.Nome, c.Cpf);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            Cliente c = new Cliente();

            c = cDAO.BuscarPorId(Convert.ToInt32(dgvCliente.Rows[0]));
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar(textBoxNome.Text);

            dgvCliente.Rows.Clear();
            foreach (Cliente c in lista)
            {
                dgvCliente.Rows.Add(c.Id, c.Nome, c.Cpf);
            }
        }
    }
}
