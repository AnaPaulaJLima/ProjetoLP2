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
    public partial class VisualizarVenda : Form
    {
        public VisualizarVenda()
        {
            InitializeComponent();
        }

        public VisualizarVenda(Venda v)
        {
            InitializeComponent();
            GetDTO(v);
        }

        private void GetDTO(Venda v)
        {
            ClienteDAO cDAO = new ClienteDAO();
            ProprietarioDao pDAO = new ProprietarioDao();
            ImovelDAO iDAO = new ImovelDAO();
            FuncionarioDAO fDAO = new FuncionarioDAO();
            // Venda
            textBoxIDVenda.Text = v.Id.ToString();
            txtBoxTipo.Text = v.Tipo;
            mtbData.Text = v.DataVenda;
            // Proprietario
            Proprietario p = pDAO.BuscarPorId(v.IdProprietario);
            textBoxIDP.Text = p.Id.ToString();
            textBoxNomeP.Text = p.Nome;
            maskedTextBoxCpfP.Text = p.Cpf;
            textBoxRgP.Text = p.Rg;
            textBoxEmailP.Text = p.Email;
            textBoxRuaP.Text = p.Rua;
            textBoxBairroP.Text = p.Bairro;
            textBoxCidadeP.Text = p.Cidade;
            textBoxNumeroP.Text = p.Numero.ToString();
            maskedTextBoxTelefoneP.Text = p.Telefone;
            // Cliente
            Cliente c = cDAO.BuscarPorId(v.IdCliente);
            textBoxIDC.Text = c.Id.ToString();
            textBoxNomeC.Text = c.Nome;
            maskedTextBoxTelefoneC.Text = c.Telefone;
            maskedTextBoxCpfC.Text = c.Cpf;
            textBoxEmailC.Text = c.Email;
            textBoxRgC.Text = c.Rg;
            // Imóvel
            Imovel i = iDAO.BuscaTodosPorId(v.IdImovel);
            textBoxIDI.Text = i.Id.ToString();
            maskedTextBoxCpfPImovel.Text = p.Cpf;
            textBoxCategoria.Text = i.Categoria;
            textBoxTipo.Text = i.Tipo;
            textBoxValorI.Text = i.Valor.ToString();
            textBoxRuaI.Text = i.Rua;
            textBoxNumeroI.Text = i.Numero.ToString();
            textBoxBairroI.Text = i.Bairro;
            textBoxMetragemI.Text = i.Metragem.ToString();
            textBoxFrente.Text = i.Frente.ToString();
            textBoxFundo.Text = i.Fundo.ToString();
            // Funcionario
            Funcionario f = fDAO.BuscarPorId(v.IdFuncionario);
            textBoxID.Text = f.Id.ToString();
            textBoxNomeF.Text = f.Nome;
            textBoxCreci.Text = f.Creci;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Dispose();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
