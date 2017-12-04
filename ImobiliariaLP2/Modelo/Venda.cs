using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliariaLP2.Modelo
{
    public class Venda
    {
        private int id;
        private string tipo; //é pra saber se vai ser aluguel ou venda (combo box)
        private string dataVenda;
        private Imovel i = new Imovel(); 
        private Proprietario p = new Proprietario();
        private Cliente c = new Cliente();
        private Funcionario f = new Funcionario();
        private int idImovel;
        private int idProprietario;
        private int idCliente;
        private int idFuncionario;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string DataVenda
        {
            get
            {
                return dataVenda;
            }

            set
            {
                dataVenda = value;
            }
        }

        public Imovel I
        {
            get
            {
                return i;
            }

            set
            {
                i = value;
            }
        }

        public Proprietario P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }

        public Cliente C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public Funcionario F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        public int IdImovel
        {
            get
            {
                return idImovel;
            }

            set
            {
                idImovel = value;
            }
        }

        public int IdProprietario
        {
            get
            {
                return idProprietario;
            }

            set
            {
                idProprietario = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public int IdFuncionario
        {
            get
            {
                return idFuncionario;
            }

            set
            {
                idFuncionario = value;
            }
        }
    }
}
