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
    public partial class BuscaProprietario : Form
    {
        public BuscaProprietario()
        {
            InitializeComponent();
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            if (dgvProprietario.CurrentRow != null)
            {
                int key = int.Parse(dgvProprietario.CurrentRow.Cells[0].Value.ToString());
                ProprietarioDao pDAO = new ProprietarioDao();
                VizualizarProprietario v = new VizualizarProprietario(pDAO.BuscarPorId(key));
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para vizualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Fill("");  
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
                e.Handled = true;
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e) /// É PRA FAZER A PESQUISA DOQUE ESTA DIGITANDO, VAI OLHAR CADA LETRA DIGITADA 
        {
            //ProprietarioDao pDAO = new ProprietarioDao();
            //dgvProprietario.DataSource = pDAO.Buscar(textBoxNome.Text);
            Fill(textBoxNome.Text);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            Fill(textBoxNome.Text);
        }

        private void BuscaProprietario_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Buscas b = new Buscas();
            b.ShowDialog();

        }

        // Método Fill() busca cliente no banco por nome
        // e popula o DataGrid com a lista retornada do DAO
        public void Fill(string s)
        {
            ProprietarioDao pDAO = new ProprietarioDao();
            List<Proprietario> lista = pDAO.Buscar(s);

            dgvProprietario.Rows.Clear();
            foreach (Proprietario p in lista)
            {
                if (p.Ativo == 1)
                    dgvProprietario.Rows.Add(p.Id, p.Nome, p.Cpf);
            }
        } 
    }
}
