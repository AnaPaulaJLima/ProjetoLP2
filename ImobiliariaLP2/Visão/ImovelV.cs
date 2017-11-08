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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imovel i = new Imovel();
            ImovelDAO iDAO = new ImovelDAO();
            ProprietarioDao pDAO = new ProprietarioDao();

            // buscando proprietario
            i.P = pDAO.Buscar(maskedTextBoxCpf.Text);

            // criando DTO
            i.Tipo = comboBoxTipo.Text;
            i.Categoria = comboBoxCategoria.Text;
            i.Metragem = float.Parse(textBoxMetragem.Text);
            i.Valor = float.Parse(textBoxValor.Text);
            i.Bairro = textBoxBairro.Text;
            i.Rua = textBoxRua.Text;
            i.Numero = int.Parse(textBoxNumero.Text);

            // Salvando
            iDAO.Salvar(i);

            // limpando os campos
            maskedTextBoxCpf.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;
            textBoxMetragem.Clear();
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
