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
        private DateTime data;
        private Imovel i; 
        private Proprietario p;
        private Cliente c;
        private Funcionario f;

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

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
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
    }
}
