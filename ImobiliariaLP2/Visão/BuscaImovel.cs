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
            Fill("");
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
            //ImovelDAO iDAO = new ImovelDAO();
            //dgvImovel.DataSource = iDAO.Buscar(textBoxNome.Text);
            Fill(textBoxNome.Text);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            Fill(textBoxNome.Text);
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
            Fill("");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Fill(string s)
        {
            ImovelDAO iDAO = new ImovelDAO();
            List<Imovel> lista = iDAO.Buscar(s);

            dgvImovel.Rows.Clear();
            foreach (Imovel i in lista)
            {
                dgvImovel.Rows.Add(i.Id, i.Bairro, i.Metragem, i.Valor);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
