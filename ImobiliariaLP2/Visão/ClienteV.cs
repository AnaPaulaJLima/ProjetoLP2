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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            ClienteDAO cDAO = new ClienteDAO();

            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;

            cDAO.Salvar(c);

            MessageBox.Show("Cadastro realizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            textBoxRg.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Trim() == "")
                btnSalvar.Enabled = false;
            else
                btnSalvar.Enabled = true;
        }

        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
