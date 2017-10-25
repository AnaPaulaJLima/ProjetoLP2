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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Proprietario p = new Proprietario();
                ProprietarioDao pDAO = new ProprietarioDao();

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

                // Passando DTO para o DAO
                pDAO.Salvar(p);

                // Janela de aviso
                MessageBox.Show("Cadastro realizado!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro no cadastro!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VizualizarProprietario vp = new VizualizarProprietario();
            vp.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
