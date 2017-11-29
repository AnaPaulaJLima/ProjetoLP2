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
    public partial class FuncionarioV : Form
    {
        public FuncionarioV()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FuncionarioV_KeyDown(object sender, KeyEventArgs e) /// abilitando o ENTER 
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) // DEIXANDO SÓ LETRAS ENTAR NO NOME, FUNÇÃO E LOGIN 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))/// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e) // para habilitar o botão somento com o preenchimento dos campos obrigatorios
        {
            if (textBoxNome.Text.Trim() == "" || textBoxFuncao.Text.Trim() == "" || textBoxLogin.Text.Trim() == "" || textBoxSenha.Text.Trim() == "" || !maskedTextBoxTelefone.MaskCompleted)
                btnSalvar.Enabled = false; /// se não estiver completa ele não aparece o botão
            else
                btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> lista = fDAO.Buscar(maskedTextBoxCRECI.Text);
            foreach (Funcionario f in lista)
            {
                if (f.Creci == maskedTextBoxCRECI.Text)
                {
                    if (f.Ativo == 1)
                    {
                        DialogResult resultado = MessageBox.Show("CRECI já cadastrado! Ver informações do funcionario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            Dispose();
                           // VisualizarFuncionario vf = new VisualizarFuncionario(f);
                            //vf.Show();
                            return;
                        }
                        else
                        {
                            LimpaCampos();
                            return;
                        }
                    }
                    if (f.Ativo == 0)
                    {
                        DialogResult resultado = MessageBox.Show("Funcionario desativado! Ver informações do funcionario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            //VisualizarFuncionario vf = new VisualizarFuncionario(f);
                            //vf.Show();
                            return;
                        }
                    }
                }
            }

            fDAO.Salvar(SetDTO());
            MessageBox.Show("Cadastro realizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }

        private Funcionario SetDTO ()
        {
            Funcionario f = new Funcionario();

            f.Nome = textBoxNome.Text;
            f.Funcao = textBoxFuncao.Text;
            f.Creci = maskedTextBoxCRECI.Text;
            f.Telefone = maskedTextBoxTelefone.Text;
            f.Email = textBoxEmail.Text;
            f.Login = textBoxLogin.Text;
            f.Senha = textBoxSenha.Text;

            return f; 
        }

        private void LimpaCampos()
        {
            textBoxNome.Clear();
            textBoxFuncao.Clear();
            maskedTextBoxCRECI.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
            textBoxLogin.Clear();
            textBoxSenha.Clear();
        }

    }
}
