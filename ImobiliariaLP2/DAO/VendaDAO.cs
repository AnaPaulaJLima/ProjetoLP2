using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImobiliariaLP2.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace ImobiliariaLP2.DAO
{
    class VendaDAO
    {
        public void GetDTO(string query, Venda v)
        {
            Database db = Database.GetInstance();
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar);
            cmd.Parameters["@tipo"].Value = v.Tipo;
            db.ExecuteNonQuery(cmd);
        }

        public void Salvar(Venda v)
        {
            string dt = v.DataVenda.ToString("dd/M/yyyy");
            string query = "INSERT INTO vendas(id, id_proprietario, id_cliente, id_imovel, id_funcionario, dataVenda, tipo) VALUES(" + v.Id + ", " + v.IdProprietario + ", " + v.IdCliente + ", " + v.IdImovel + ", " + v.IdFuncionario + ", " + dt + ", @tipo)";
            GetDTO(query, v);
        }

        public void Busca(Venda v)
        {
            Database db = Database.GetInstance();
            List<Venda> lista = new List<Venda>();
            DataRow dr = null;
            int linhas;

            string query = "";
        }
    }
}
