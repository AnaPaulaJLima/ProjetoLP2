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
            textBoxValor.Text = i.Valor.ToString();
            textBoxRua.Text = i.Rua;
            textBoxNumero.Text = i.Numero.ToString();
            textBoxBairro.Text = i.Bairro;
        }
    }
}
