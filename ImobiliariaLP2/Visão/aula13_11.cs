using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImobiliariaLP2.Modelo;
using ImobiliariaLP2.DAO;
using Word = Microsoft.Office.Interop.Word;


namespace ImobiliariaLP2.Visão
{
    public partial class aula13_11 : Form
    {
        public aula13_11()
        {
            InitializeComponent();
            this.EscreveNoForm();
        }

        private void CriaArquivo()
        {
            Stream st = File.Open(@"C:\Users\IFSP\Desktop\Nova pasta\saida1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(st);
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar("");

            foreach(Cliente c in lista)
            {
                sw.Write(c.ToString());
            }

            sw.Close();
            st.Close();

            MessageBox.Show("Arquivo Criado!", "", MessageBoxButtons.OK);
        }

        private void CriaArquivoWord()
        {
            Cliente c = new Cliente();
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar("");

            Word.Application wrdApp = new Word.Application();
            Word.Document doc = wrdApp.Documents.Open(@"C:\Users\IFSP\Desktop\Nova pasta\Doc1.docx");
            Word.Range r = wrdApp.ActiveDocument.Range(0, 0);

            if (doc != null)
            { 
                foreach (Cliente cliente in lista)
                {
                    r.Text = c.ToString();
                }
                doc.Close();
                wrdApp.Quit();
            }
            else
            {
                MessageBox.Show("O arquivo precisa ser aberto!", "", MessageBoxButtons.OK);

            }
        }

        private void EscreveNoForm()
        {
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> lista = cDAO.Buscar("");

            foreach (Cliente c in lista)
            {
                richTextBox1.Text = c.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.CriaArquivo();
            this.CriaArquivoWord();
        }
    }
}
