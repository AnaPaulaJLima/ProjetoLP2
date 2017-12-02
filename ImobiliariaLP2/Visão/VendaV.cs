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
    public partial class VendaV : Form
    {
        Venda v = null;
        public VendaV()
        {
            InitializeComponent();
            v = new Venda();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GetDtoP(Proprietario p)
        {
            textBoxIDP.Text = p.Id.ToString();
            textBoxNomeP.Text = p.Nome;
            maskedTextBoxTelefoneP.Text = p.Telefone;
            maskedTextBoxCpfP.Text = p.Cpf;
            textBoxRgP.Text = p.Rg;
            textBoxEmailP.Text = p.Email;
            textBoxRuaP.Text = p.Rua;
            textBoxBairroP.Text = p.Bairro;
            textBoxNumeroP.Text = p.Numero.ToString();
            textBoxCidadeP.Text = p.Cidade;
        }

        private void GetDtoC(Cliente c)
        {
            textBoxIDC.Text = c.Id.ToString();
            textBoxNomeC.Text = c.Nome;
            maskedTextBoxTelefoneC.Text = c.Telefone;
            maskedTextBoxCpfC.Text = c.Cpf;
            textBoxRgC.Text = c.Rg;
            textBoxEmailC.Text = c.Email;
        }

        private void GetDtoI(Imovel i)
        {
            maskedTextBoxCpfPImovel.Text = i.P.Cpf;
            textBoxTipo.Text = i.Tipo;
            textBoxCategoria.Text = i.Categoria;
            textBoxValorI.Text = i.Valor.ToString(); ;
            textBoxRuaI.Text = i.Rua;
            textBoxBairroI.Text = i.Bairro;
            textBoxCidade.Text = i.Cidade;
            textBoxNumeroI.Text = i.Numero.ToString();
            textBoxMetragemI.Text = i.Metragem.ToString();
            textBoxFrente.Text = i.Frente.ToString();
            textBoxFundo.Text = i.Fundo.ToString();
        }

        // Esse metodo de click não está sendo usado
        // Por isso comentei ele
        private void btnBuscarP_Click(object sender, EventArgs e)
        {/*
            try
            {
                ProprietarioDao pDAO = new ProprietarioDao();
                List<Proprietario> lista = new List<Proprietario>();
                lista = pDAO.Buscar(maskedTextBoxCpfProprietario.Text);
                foreach(Proprietario x in lista)
                {
                    GetDtoP(x);
                    // Passa o proprietario para a venda
                    v.P = x;
                    v.IdProprietario = v.P.Id;
                }
            }
            catch
            {
                MessageBox.Show("Erro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                maskedTextBoxCpfProprietario.Clear();
            }*/
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO cDAO = new ClienteDAO();
                List<Cliente> lista = new List<Cliente>();
                lista = cDAO.Buscar(maskedTextBoxCpfCliente.Text);
                foreach (Cliente x in lista)
                {
                    GetDtoC(x);
                    // Passa o cliente para a venda
                    v.C = x;
                    v.IdCliente = v.C.Id;
                }
            }
            catch
            {
                MessageBox.Show("Erro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                maskedTextBoxCpfCliente.Clear();
            }
        }

        private void btnBuscarI_Click(object sender, EventArgs e)
        {
            try
            {
                ImovelDAO iDAO = new ImovelDAO();
                ProprietarioDao pDAO = new ProprietarioDao();
                Imovel i = iDAO.BuscaPorId(int.Parse(textBoxIDI.Text));
                // Busca o proprietario do imovel pelo idProprietario do objeto imovel
                i.P = pDAO.BuscarPorId(i.IdProprietario);
                GetDtoP(i.P);
                GetDtoI(i);
                // Passa o imovel para a venda
                v.I = i;
                v.IdImovel = v.I.Id;
                // Passa o proprietario do imovel para a venda
                v.P = i.P;
                v.IdProprietario = i.P.Id;
            }
            catch
            {
                MessageBox.Show("Erro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxIDI.Clear();
            }
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO fDAO = new FuncionarioDAO();
                Funcionario f = fDAO.BuscarPorId(int.Parse(textBoxID.Text));

                if(f == null)
                    MessageBox.Show("Funcionario não encontrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    textBoxNomeF.Text = f.Nome;
                    textBoxCreci.Text = f.Creci;
                    // Passa o funcionario para a venda
                    v.F = f;
                    v.IdFuncionario = v.F.Id;
                }      
            }
            catch
            {
                MessageBox.Show("Erro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxID.Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VendaDAO vDAO = new VendaDAO();
                ImovelDAO iDAO = new ImovelDAO();
                if (comboBox1.Text == "Venda")
                {
                    // Se vender, não pode alugar
                    v.I.Vendido = 1;
                    v.I.Alugado = 1;
                }
                else
                {
                    // Se alugar, pode vender
                    v.I.Alugado = 1;
                }
                // Mando atualizar o imovel no banco
                iDAO.Atualizar(v.I);
                v.Tipo = comboBox1.Text;
                v.DataVenda = DateTime.Parse(dateTimePickerDATA.Text);
                vDAO.Salvar(v);
                MessageBox.Show("cadastrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Erro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
