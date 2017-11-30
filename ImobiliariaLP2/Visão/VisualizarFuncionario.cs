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
    public partial class VisualizarFuncionario : Form
    {
        public VisualizarFuncionario()
        {
            InitializeComponent();
        }

        public VisualizarFuncionario(Funcionario f)
        {
            InitializeComponent();
            GetDTO(f);
        }

        private void VisualizarFuncionario_KeyDown(object sender, KeyEventArgs e) // HABILITANDO  ENTER 
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) // VALIDANDO SOMENTE LETRAS NO NOME, FUNÇÃO E LOGIN 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))/// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e) /// validando os campos obrigatorios 
        {
            if (textBoxNome.Text.Trim() == "" || textBoxFuncao.Text.Trim() == "" || textBoxLogin.Text.Trim() == "" || textBoxSenha.Text.Trim() == "" || !maskedTextBoxTelefone.MaskCompleted || !maskedTextBoxCRECI.MaskCompleted)
                btnAlterar.Enabled = false; /// se não estiver completa ele não aparece o botão
            else
                btnAlterar.Enabled = true;
        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            fDAO.Atualizar(SetDTO());

            if (MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente EXCLUIR o funcionario? ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                FuncionarioDAO fDAO = new FuncionarioDAO();
                fDAO.Excluir(int.Parse(textBoxID.Text));
                this.Dispose();
            }

            else
                this.Dispose();
        }

        private Funcionario SetDTO()
        {
            Funcionario f = new Funcionario();

            f.Id = int.Parse(textBoxID.Text);
            f.Nome = textBoxNome.Text;
            f.Funcao = textBoxFuncao.Text;
            f.Creci = maskedTextBoxCRECI.Text;
            f.Telefone = maskedTextBoxTelefone.Text;
            f.Email = textBoxEmail.Text;
            f.Login = textBoxLogin.Text;
            f.Senha = textBoxSenha.Text;
            f.Ativo = 1;

            return f;
        }

        private void GetDTO(Funcionario f)
        {
            textBoxID.Text = f.Id.ToString();
            textBoxNome.Text = f.Nome;
            textBoxFuncao.Text = f.Funcao;
            maskedTextBoxCRECI.Text = f.Creci;
            maskedTextBoxTelefone.Text = f.Telefone;
            textBoxEmail.Text = f.Email;
            textBoxLogin.Text = f.Login;
            textBoxSenha.Text = f.Senha;
        }

        
    }
}
