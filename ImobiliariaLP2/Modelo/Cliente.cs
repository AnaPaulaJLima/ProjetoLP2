using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliariaLP2.Modelo
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private string rg;
        private string telefone;
        private string email;

        public override string ToString()
        {
            return id + "\t" + nome + "\t" + cpf + "\t" + rg + "\t" + telefone + "\t" + email+"\n\n";
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}

