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
    public partial class VizualizarProprietario : Form
    {
        public VizualizarProprietario()
        {
            InitializeComponent();
        }
        public VizualizarProprietario(Proprietario p)
        {
            InitializeComponent();
            GetDTO(p);
        }

        // para fazer o ENTER funcionar passando por cada texBox
        private void VizualizarProprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // verifica se o keys que é o lugar onde esta é igual ou enter 
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        // valida o textBox nome, rua e cidade para nao digitar letra 
        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true; // Separador para poder colocar espaço e Control para poder apagar 
        }

        //valçidação do campos obrigatorios, se não preenxer todos o botao salvar não é habilitado
        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Trim() == "" || !maskedTextBoxCpf.MaskCompleted || !maskedTextBoxDataN.MaskCompleted || !maskedTextBoxTelefone.MaskCompleted)
                btnAlterar.Enabled = false; // se não tiver nada no nome e as masked não estiver completa, o botão continua desabilitado
            else
                btnAlterar.Enabled = true; // caso contrario, habilita o botão 
        }

        private Proprietario SetDTO()
        {
            Proprietario p = new Proprietario();
            // Criando DTO
            p.Id = int.Parse(textBoxID.Text);
            p.Nome = textBoxNome.Text;
            p.Cpf = maskedTextBoxCpf.Text;
            p.Rg = textBoxRg.Text;
            p.DataNasc = maskedTextBoxDataN.Text;
            p.Telefone = maskedTextBoxTelefone.Text;
            p.Email = textBoxEmail.Text;
            p.Rua = textBoxRua.Text;
            p.Numero = int.Parse(textBoxNumero.Text);
            p.Bairro = textBoxBairro.Text;
            p.Cidade = textBoxCidade.Text;
            p.Ativo = 1;

            return p;
        }

        public void GetDTO(Proprietario p)
        {
            textBoxID.Text = p.Id.ToString();
            textBoxNome.Text = p.Nome;
            maskedTextBoxCpf.Text = p.Cpf;
            textBoxRg.Text = p.Rg;
            maskedTextBoxDataN.Text = p.DataNasc;
            textBoxRua.Text = p.Rua;
            textBoxNumero.Text = p.Numero.ToString();
            textBoxBairro.Text = p.Bairro;
            textBoxCidade.Text = p.Cidade;
            maskedTextBoxTelefone.Text = p.Telefone;
            textBoxEmail.Text = p.Email; 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProprietarioDao pDAO = new ProprietarioDao();
            pDAO.Atualizar(SetDTO());

            if (MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }
        
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            ProprietarioDao pDAO = new ProprietarioDao();
            pDAO.Excluir(int.Parse(textBoxID.Text));

            if (MessageBox.Show("Cliente excluído!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }
    }
}
