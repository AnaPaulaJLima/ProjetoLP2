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

        private void textBoxRua_KeyPress(object sender, KeyPressEventArgs e)// validando só LETRAS NO CAMPO RUA,BAIRRO e CIDADE
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
                e.Handled = true;
        }

        private void textBoxMetragem_KeyPress(object sender, KeyPressEventArgs e) /// validanndo os campos METRAGEM, METROS-FRENTE, METROS-FUNDO, VALOR E NUMERO só digitar numero
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
                e.Handled = true; // o iscontrol é para conseguir apagar e o isnumber é para aaceitar letra 
        }

        // FALTA VALIDAR OS CAMPOS OBRIGATORIOS
        // METROS DE FUNDO E FRENTE NÃO SÃO OBRIGATORIOS

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Imovel i = new Imovel();
                ImovelDAO iDAO = new ImovelDAO();
                ProprietarioDao pDAO = new ProprietarioDao();
                List<Proprietario> lista = new List<Proprietario>();

                // buscando proprietario
                lista = pDAO.Buscar(maskedTextBoxCpf.Text);
                foreach (Proprietario p in lista)
                {
                    i.P = p;
                }

                // criando DTO
                i.Tipo = comboBoxTipo.Text;
                i.Categoria = comboBoxCategoria.Text;
                i.Metragem = float.Parse(textBoxMetragem.Text);
                i.Frente = float.Parse(textBoxFrente.Text);
                // Se estiverem vazios, salva com o valor 0
                i.Frente = 0;
                if(textBoxFrente.Text != "")
                {
                    i.Frente = float.Parse(textBoxFrente.Text);
                }
                i.Fundo = 0;
                if(textBoxFundo.Text != "")
                {
                    i.Fundo = float.Parse(textBoxFundo.Text);
                }
                i.Valor = float.Parse(textBoxValor.Text);
                i.Bairro = textBoxBairro.Text;
                i.Cidade = textBoxCidade.Text;
                i.Rua = textBoxRua.Text;
                i.Numero = int.Parse(textBoxNumero.Text);
                i.Vendido = 0;
                i.Alugado = 0;
                i.IdProprietario = i.P.Id;

                // Salvando
                iDAO.Salvar(i);
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar imóvel.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpaCampos();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LimpaCampos()
        {
            // limpando os campos
            maskedTextBoxCpf.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;
            textBoxMetragem.Clear();
            textBoxFrente.Clear();
            textBoxFundo.Clear();
            textBoxValor.Clear();
            textBoxRua.Clear();
            textBoxCidade.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
        }

       
    }
}
