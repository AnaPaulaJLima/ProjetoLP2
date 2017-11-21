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
    public partial class ProprietariosV : Form
    {
        public ProprietariosV()
        {
            InitializeComponent();
        }

        // para fazer o ENTER funcionar passando por cada texBox
        private void ProprietariosV_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) // verifica se o keys que é o lugar onde esta é igual ou enter 
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        // valida o textBox nome para nao digitar letra 
        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))) // se oque foi digitado for diferente de letra ele entra
                e.Handled = true; // Separador para poder colocar espaço e Control para poder apagar 
        }

        //valçidação do campos obrigatorios, se não preenxer todos o botao salvar não é habilitado
        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Trim() == "" || !maskedTextBoxCpf.MaskCompleted || !maskedTextBoxDataN.MaskCompleted || !maskedTextBoxTelefone.MaskCompleted)
                btnSalvar.Enabled = false; // se não tiver nada no nome e as masked não estiver completa, o botão continua desabilitado
            else
                btnSalvar.Enabled = true; // caso contrario, habilita o botão 
        }

        private Proprietario SetDTO()
        {
            Proprietario p = new Proprietario();
            // Criando DTO
            p.Nome = textBoxNome.Text;
            p.Cpf = maskedTextBoxCpf.Text;
            p.Rg = textBoxRg.Text;
            p.Telefone = maskedTextBoxTelefone.Text;
            p.Email = textBoxEmail.Text;
            p.Rua = textBoxRua.Text;
            p.Numero = int.Parse(textBoxNumero.Text);
            p.Bairro = textBoxBairro.Text;
            p.Cidade = textBoxCidade.Text;
            return p;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProprietarioDao pDAO = new ProprietarioDao();
            List<Proprietario> lista = pDAO.Buscar(maskedTextBoxCpf.Text);
            foreach (Proprietario p in lista)
            {
                if (p.Cpf == maskedTextBoxCpf.Text)
                {
                    if (p.Ativo == 1)
                    {
                        DialogResult resultado = MessageBox.Show("CPF já cadastrado! Ver informações do proprietário?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            Dispose();
                            VizualizarProprietario vp = new VizualizarProprietario(p);
                            vp.Show();
                            return;
                        }
                        else
                        {
                            LimpaCampos();
                            return;
                        }
                    }
                    if (p.Ativo == 0)
                    {
                        DialogResult resultado = MessageBox.Show("Proprietário desativado! Ver informações do proprietário?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            VizualizarProprietario vp = new VizualizarProprietario(p);
                            vp.Show();
                            return;
                        }
                    }
                }
            }

            pDAO.Salvar(SetDTO());
            MessageBox.Show("Cadastro realizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VizualizarProprietario vp = new VizualizarProprietario();
            vp.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LimpaCampos()
        {
            // Limpando os campos
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxRg.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCpf.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
        }
    }
}
