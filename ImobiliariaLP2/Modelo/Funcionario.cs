using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliariaLP2.Modelo
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string telefone;
        private string email;
        private string funcao;
        private string creci;
        private string login;
        private string senha;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Funcao
        {
            get
            {
                return funcao;
            }

            set
            {
                funcao = value;
            }
        }

        public string Creci
        {
            get
            {
                return creci;
            }

            set
            {
                creci = value;
            }
        }
    }
}
