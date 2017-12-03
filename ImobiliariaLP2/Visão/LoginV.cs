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
    public partial class LoginV : Form
    {
        public bool logado = false;
        public Funcionario funcionario = null;
        public LoginV()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private bool efetuarLogin()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> lista = new List<Funcionario>();
            lista = fDAO.Buscar("");
            foreach(Funcionario f in lista)
            {
                if (f.Login == txt_login.Text && f.Senha == txt_senha.Text)
                {
                    funcionario = f;
                    return true;
                }
            }
            return false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            logado = efetuarLogin();
            if (logado)
            {
                Inicio inicio = new Inicio(funcionario);
                txt_login.Clear();
                txt_senha.Clear();
                inicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro ao fazer login.", "", MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
