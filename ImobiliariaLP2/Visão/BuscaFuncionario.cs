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
    public partial class BuscaFuncionario : Form
    {
        public BuscaFuncionario()
        {
            InitializeComponent();
        }

        private void btnAlterarDeletar_Click(object sender, EventArgs e)
        {
            if(dgvFuncioario.CurrentRow != null)
            {
                int key = int.Parse(dgvFuncioario.CurrentRow.Cells[0].Value.ToString());
                FuncionarioDAO fDAO = new FuncionarioDAO();
                VisualizarFuncionario v = new VisualizarFuncionario(fDAO.BuscarPorId(key));
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
            this.Dispose();
            Buscas b = new Buscas();
            b.ShowDialog();
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {

            //FuncionarioDAO fDAO = new FuncionarioDAO();
            //dgvFuncioario.DataSource = fDAO.Buscar(textBoxNome.Text);
            Fill(textBoxNome.Text);
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e) // validando só letra no textBox 
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
                e.Handled = true;
        }

        private void BuscaFuncionario_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            Fill(textBoxNome.Text);
        }

        private void Fill(string s)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> lista = fDAO.Buscar(s);

            dgvFuncioario.Rows.Clear();
            foreach(Funcionario f in lista)
            {
                if (f.Ativo == 1)
                    dgvFuncioario.Rows.Add(f.Id, f.Nome, f.Funcao);
            }
        }

       
    }
}
