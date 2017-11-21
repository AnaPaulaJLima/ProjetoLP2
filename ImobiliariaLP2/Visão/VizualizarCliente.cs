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
using ImobiliariaLP2.Visão;

namespace ImobiliariaLP2.Visão
{
    public partial class VizualizarCliente : Form
    {
        public VizualizarCliente()
        {
            InitializeComponent();
        }

        public VizualizarCliente(Cliente c)
        {
            InitializeComponent();
            GetDTO(c);
        }

        private void VizualizarCliente_KeyDown(object sender, KeyEventArgs e)// para fazer o ENTER funiconar, e passar por cada texBox
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        // validando só com letras o textBox no nome
        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))/// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        // para habilitar o botão somento com o preenchimento dos campos obrigatorios
        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Trim() == "" || !maskedTextBoxCpf.MaskCompleted || !maskedTextBoxDataN.MaskCompleted || !maskedTextBoxTelefone.MaskCompleted)
                btnAlterar.Enabled = false; /// se não estiver completa ele não aparece o botão
            else
                btnAlterar.Enabled = true;
        }

        private Cliente SetDTO()
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(textBoxID.Text);
            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.DataNasc = maskedTextBoxDataN.Text;
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;
            c.Ativo = 1;

            return c;
        }

        private void GetDTO(Cliente c)
        {
            textBoxID.Text = c.Id.ToString();
            textBoxNome.Text = c.Nome;
            maskedTextBoxCpf.Text = c.Cpf;
            textBoxRg.Text = c.Rg;
            maskedTextBoxDataN.Text = c.DataNasc;
            textBoxEmail.Text = c.Email;
            maskedTextBoxTelefone.Text = c.Telefone;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            cDAO.Atualizar(SetDTO());

            if (MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            cDAO.Excluir(int.Parse(textBoxID.Text));
            if (MessageBox.Show("Cliente excluído!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }

        
    }
}
