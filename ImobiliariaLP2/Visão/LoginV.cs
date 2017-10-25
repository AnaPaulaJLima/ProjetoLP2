using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaLP2.Visão
{
    public partial class LoginV : Form
    {
        public bool logado = false;
        public LoginV()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void efetuarLogin()
        {
            //var user = 
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            this.logado = true;
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();

        }
    }
}
