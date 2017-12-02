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
    public partial class BuscaImovel : Form
    {
        public BuscaImovel()
        {
            InitializeComponent();
        }

        private void BuscaImovel_Load(object sender, EventArgs e)
        {
            Fill("", 0, 0);
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
            //ImovelDAO iDAO = new ImovelDAO();
            //dgvImovel.DataSource = iDAO.Buscar(textBoxNome.Text);
            //Fill("", 0, 0);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            //Fill("", 0, 0);
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            if (dgvImovel.CurrentRow != null)
            {
                int key = int.Parse(dgvImovel.CurrentRow.Cells[0].Value.ToString());
                ImovelDAO iDAO = new ImovelDAO();
                ProprietarioDao pDAO = new ProprietarioDao();
                Proprietario p = new Proprietario();
                Imovel i = iDAO.BuscaPorId(key);
                i.P = pDAO.BuscarPorId(i.IdProprietario);

                VisualizarImovelV v = new VisualizarImovelV(i);
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para vizualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Fill("", 0, 0);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Passando 0 como parametro para os valores ele busca somente pelo bairro
        // Ou seja, desconsidera os valores para a busca
        public void Fill(string s, float vIni, float vFinal)
        {
            ImovelDAO iDAO = new ImovelDAO();
            List<Imovel> lista = iDAO.Buscar(s, vIni, vFinal);

            dgvImovel.Rows.Clear();
            foreach (Imovel i in lista)
            {
                dgvImovel.Rows.Add(i.Id, i.Bairro, i.Metragem, i.Valor);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string bairro = "";
                float valorIni = 0;
                float valorFinal = 0;

                if (textBoxNome.Text != "")
                    bairro = textBoxNome.Text;
                if (tbValorIni.Text != "")
                    valorIni = float.Parse(tbValorIni.Text);
                if (tbValorFinal.Text != "")
                    valorIni = float.Parse(tbValorFinal.Text);

                if (valorFinal > valorIni && valorFinal != 0)
                {
                    MessageBox.Show("Valores não permitidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (valorFinal < 0 || valorIni < 0)
                {
                    MessageBox.Show("Valores não permitidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Fill(bairro, valorIni, valorFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbValorFinal.Clear();
                tbValorIni.Clear();
            }
        }
    }
}
