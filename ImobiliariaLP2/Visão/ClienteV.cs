using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaLP2.Modelo;
using ImobiliariaLP2.DAO;

namespace ImobiliariaLP2.Visão
{
    public partial class ClienteV : Form
    {
        public ClienteV()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VizualizarCliente vc = new VizualizarCliente();
            vc.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;

            ClienteDAO cDAO = new ClienteDAO();
            cDAO.Salvar(c);
        }
    }
}
