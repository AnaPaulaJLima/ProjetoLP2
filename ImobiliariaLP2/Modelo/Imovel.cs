using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliariaLP2.Modelo
{
    public class Imovel
    {
        private int id;
        private string tipo; // casa/apartamento
        private string categoria; // venda/aluguel
        private float metragem;
        private float frente;
        private float fundo;
        private float valor;
        private string bairro;
        private string rua;
        private string cidade;
        private int numero;
        private int idProprietario;
        private Proprietario p;
        private int vendido;
        private int alugado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public float Fundo
        {
            get { return fundo; }
            set { fundo = value; }
        }

        public float Frente
        {
            get { return frente; }
            set { frente = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public float Metragem
        {
            get { return metragem; }
            set { metragem = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Proprietario P
        {
            get { return p; }
            set { p = value; }
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

        public int Alugado
        {
            get
            {
                return alugado;
            }

            set
            {
                alugado = value;
            }
        }

        public int Vendido
        {
            get
            {
                return vendido;
            }

            set
            {
                vendido = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }
    }
}
