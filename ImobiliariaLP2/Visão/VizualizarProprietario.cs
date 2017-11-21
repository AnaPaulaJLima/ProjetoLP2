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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        public void GetDTO(Proprietario p)
        {
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
        }
        public void LimpaCampos()
        {
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
