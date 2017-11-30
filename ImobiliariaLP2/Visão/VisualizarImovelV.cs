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
    public partial class VisualizarImovelV : Form
    {
        public VisualizarImovelV()
        {
            InitializeComponent();
        }

        public VisualizarImovelV(Imovel i)
        {
            InitializeComponent();
            GetDTO(i);
        }

        private void VisualizarImovelV_KeyDown(object sender, KeyEventArgs e)// para fazer o ENTER funiconar, e passar por cada texBox
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void textBoxRua_KeyPress(object sender, KeyPressEventArgs e)// validando só LETRAS NO CAMPO RUA E BAIRRO 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))/// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        private void textBoxMetragem_KeyPress(object sender, KeyPressEventArgs e)/// validanndo os campos METRAGEM, METROS-FRENTE, METROS-FUNDO, VALOR E NUMERO só digitar numero
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                e.Handled = true; // o iscontrol é para conseguir apagar e o isnumber é para aaceitar letra 
        }

        private void comboBoxTipo_TextChanged(object sender, EventArgs e)// esta faltando validar os comboBox
        {
            if (!maskedTextBoxCpf.MaskCompleted || textBoxMetragem.Text.Trim() == "" || textBoxFrente.Text.Trim() == "" || textBoxFundo.Text.Trim() == "" || textBoxRua.Text.Trim() == "" || textBoxNumero.Text.Trim() == "" || textBoxBairro.Text.Trim() == "")
                btnAlterar.Enabled = false;
            else
                btnAlterar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ImovelDAO iDAO = new ImovelDAO();
            iDAO.Atualizar(SetDTO());

            if (MessageBox.Show("Cadastro atualizado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente EXCLUIR o imovel? ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                ImovelDAO iDAO = new ImovelDAO();
                iDAO.Excluir(int.Parse(textBoxID.Text));
                this.Dispose();
            }
            else
                this.Dispose();             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void GetDTO(Imovel i)
        {
            textBoxID.Text = i.Id.ToString();
            maskedTextBoxCpf.Text = i.P.Cpf;
            comboBoxCategoria.Text = i.Categoria;
            comboBoxTipo.Text = i.Tipo;
            textBoxMetragem.Text = i.Metragem.ToString();
            textBoxFrente.Text = i.Frente.ToString();
            textBoxFundo.Text = i.Fundo.ToString();
            textBoxValor.Text = i.Valor.ToString();
            textBoxRua.Text = i.Rua;
            textBoxNumero.Text = i.Numero.ToString();
            textBoxBairro.Text = i.Bairro;
        }

        private Imovel SetDTO()
        {
            Imovel i = new Imovel();
            ProprietarioDao pDAO = new ProprietarioDao();
            List<Proprietario> lista = new List<Proprietario>();

            // buscando proprietario
            lista = pDAO.Buscar(maskedTextBoxCpf.Text);
            i.P = pDAO.BuscarPorId(lista[0].Id);

            
            i.Id = int.Parse(textBoxID.Text);
            i.Tipo = comboBoxTipo.Text;
            i.Categoria = comboBoxCategoria.Text;
            i.Metragem = float.Parse(textBoxMetragem.Text);
            i.Frente = float.Parse(textBoxFrente.Text);
            i.Fundo = float.Parse(textBoxFundo.Text);
            i.Valor = float.Parse(textBoxValor.Text);
            i.Bairro = textBoxBairro.Text;
            i.Rua = textBoxRua.Text;
            i.Numero = int.Parse(textBoxNumero.Text);
            i.Vendido = 0;
            i.Alugado = 0;
            i.IdProprietario = i.P.Id;

            return i;
        }

        
    }
}
