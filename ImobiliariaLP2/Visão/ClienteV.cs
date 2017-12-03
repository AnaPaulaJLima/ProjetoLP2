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

        private void ClienteV_KeyDown(object sender, KeyEventArgs e) // para fazer o ENTER funiconar, e passar por cada texBox
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) // validando só com letras o textBox no nome 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))) /// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)// para habilitar o botão somento com o preenchimento dos campos obrigatorios
        {
            if (textBoxNome.Text.Trim() == "" || !maskedTextBoxTelefone.MaskCompleted || !maskedTextBoxCpf.MaskCompleted)
                btnSalvar.Enabled = false; /// se não estiver completa ele não aparece o botão
            else
                btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar(maskedTextBoxCpf.Text);
            foreach (Cliente c in lista)
            {
                if (c.Cpf == maskedTextBoxCpf.Text)
                {
                    if (c.Ativo == 1)
                    {
                        DialogResult resultado = MessageBox.Show("CPF já cadastrado! Ver informações do cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            Dispose();
                            VizualizarCliente vc = new VizualizarCliente(c);
                            vc.Show();
                            return;
                        }
                        else
                        {
                            LimpaCampos();
                            return;
                        }
                    }
                    if (c.Ativo == 0)
                    {
                        DialogResult resultado = MessageBox.Show("Cliente desativado! Ver informações do cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            VizualizarCliente vc = new VizualizarCliente(c);
                            vc.Show();
                            return;
                        }
                    }
                }
            }

            cDAO.Salvar(SetDTO());
            MessageBox.Show("Cadastro realizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }

        private Cliente SetDTO()
        {
            Cliente c = new Cliente();

            c.Nome = textBoxNome.Text;
            c.Cpf = maskedTextBoxCpf.Text;
            c.Rg = textBoxRg.Text;
            c.DataNasc = dateTimePicker1.Value.ToString("ddMMyyyy");
            c.Email = textBoxEmail.Text;
            c.Telefone = maskedTextBoxTelefone.Text;

            return c;
        }

        private void LimpaCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            textBoxRg.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
        }

        private void ClienteV_Load(object sender, EventArgs e)
        {

        }
    }
}
