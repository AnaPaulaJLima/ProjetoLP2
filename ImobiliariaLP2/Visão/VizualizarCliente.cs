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
    public partial class VizualizarCliente : Form
    {
        public VizualizarCliente()
        {
            InitializeComponent();
        }

        public VizualizarCliente(Cliente c )
        {
            InitializeComponent();
            //SetDTO(c);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            ClienteDAO cDAO = new ClienteDAO();

            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;

            cDAO.Atualizar(c);

            MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            textBoxRg.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();

        }
    }
}
