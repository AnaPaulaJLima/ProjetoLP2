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
    public partial class ImovelV : Form
    {
        public ImovelV()
        {
            InitializeComponent();
        }

        private void ImovelV_KeyDown(object sender, KeyEventArgs e) // para fazer o ENTER funiconar, e passar por cada texBox
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void textBoxRua_KeyPress(object sender, KeyPressEventArgs e) // validando só LETRAS NO CAMPO RUA E BAIRRO 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar)))/// só deixa digitar letras no textBox 
                e.Handled = true; // isSeparador é para consegui usar o espaça e o iscontrol é para conseguir apagar 
        }

        private void textBoxMetragem_KeyPress(object sender, KeyPressEventArgs e) /// validanndo os campos METRAGEM, METROS-FRENTE, METROS-FUNDO, VALOR E NUMERO só digitar numero
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                e.Handled = true; // o iscontrol é para conseguir apagar e o isnumber é para aaceitar letra 
        }

        private void comboBoxTipo_TextChanged(object sender, EventArgs e) // esta faltando validar os comboBox
        {
            if (!maskedTextBoxCpf.MaskCompleted || textBoxMetragem.Text.Trim() == "" || textBoxFrente.Text.Trim() == "" || textBoxFundo.Text.Trim() == "" || textBoxRua.Text.Trim() == "" || textBoxNumero.Text.Trim() == "" || textBoxBairro.Text.Trim() == "")
                btnSalvar.Enabled = false;
            else
                btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imovel i = new Imovel();
            ImovelDAO iDAO = new ImovelDAO();
            ProprietarioDao pDAO = new ProprietarioDao();
            List<Proprietario> lista = new List<Proprietario>();

            // buscando proprietario
            lista = pDAO.Buscar(maskedTextBoxCpf.Text);
            i.P = pDAO.BuscarPorId(lista[0].Id);

            // criando DTO
            
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

            // Salvando
            iDAO.Salvar(i);

            // limpando os campos
            maskedTextBoxCpf.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;
            textBoxMetragem.Clear();
            textBoxFrente.Clear();
            textBoxFundo.Clear();
            textBoxValor.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        } 
    }
}
