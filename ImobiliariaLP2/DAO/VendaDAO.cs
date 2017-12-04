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
            db.ExecuteNonQuery(cmd);
        }

        public Venda SetDTO(DataRow dr)
        {
            Venda v = new Venda();

            v.Id = int.Parse(dr["id"].ToString());
            v.IdProprietario = v.P.Id = int.Parse(dr["id_proprietario"].ToString());
            v.P.Nome = dr["nome_proprietario"].ToString();
            v.P.Cpf = dr["cpf_proprietario"].ToString();
            v.P.Rg = dr["rg_proprietario"].ToString();
            v.P.Telefone = dr["telefone_proprietario"].ToString();
            v.P.Email = dr["email_proprietario"].ToString();
            v.IdCliente = v.C.Id = int.Parse(dr["id_cliente"].ToString());
            v.C.Nome = dr["nome_cliente"].ToString();
            v.C.Cpf = dr["cpf_cliente"].ToString();
            v.C.Rg = dr["rg_cliente"].ToString();
            v.C.Telefone = dr["telefone_cliente"].ToString();
            v.C.Email = dr["email_cliente"].ToString();
            v.IdImovel = v.I.Id = int.Parse(dr["id_imovel"].ToString());
            v.I.Tipo = dr["tipo_imovel"].ToString();
            v.I.Categoria = dr["categoria_imovel"].ToString();
            v.I.Valor = float.Parse(dr["valor_imovel"].ToString());
            v.I.Bairro = dr["bairro_imovel"].ToString();
            v.I.Rua = dr["rua_imovel"].ToString();
            v.I.Cidade = dr["cidade_imovel"].ToString();
            v.I.Numero = int.Parse(dr["numero_imovel"].ToString());
            v.IdFuncionario = v.F.Id = int.Parse(dr["id_funcionario"].ToString());
            v.F.Nome = dr["nome_funcionario"].ToString();
            v.F.Telefone = dr["telefone_funcionario"].ToString();
            v.F.Email = dr["email_funcionario"].ToString();
            v.F.Creci = dr["creci_funcionario"].ToString();
            v.DataVenda = dr["dataVenda"].ToString();
            v.Tipo = dr["tipo"].ToString();

            return v;
        }

        public void Salvar(Venda v)
        {
            string query = "INSERT INTO vendas(id_proprietario, nome_proprietario, cpf_proprietario, rg_proprietario, telefone_proprietario, email_proprietario, id_cliente, nome_cliente, cpf_cliente, rg_cliente, telefone_cliente, email_cliente, id_imovel, tipo_imovel, categoria_imovel, valor_imovel, bairro_imovel, rua_imovel, cidade_imovel, numero_imovel, id_funcionario, nome_funcionario, telefone_funcionario, email_funcionario, creci_funcionario, dataVenda, tipo) ";
            query += "VALUES(" + v.IdProprietario + ", '" + v.P.Nome + "', '" + v.P.Cpf + "', '" + v.P.Rg + "', '" + v.P.Telefone + "', '" + v.P.Email + "', " + v.IdCliente + ", '" + v.C.Nome + "', '" + v.C.Cpf + "', '" + v.C.Rg + "', '" + v.C.Telefone + "', '" + v.C.Email + "', " + v.IdImovel + ", '" + v.I.Tipo + "', '" + v.I.Categoria + "', " + v.I.Valor + ", '" + v.I.Bairro + "', '" + v.I.Rua + "', '" + v.I.Cidade + "', " + v.I.Numero + ", " + v.IdFuncionario + ", '" + v.F.Nome + "', '" + v.F.Telefone + "', '" + v.F.Email + "', '" + v.F.Creci + "', '" + v.DataVenda + "', '" + v.Tipo + "') ";
            GetDTO(query, v);
        }

        public List<Venda> Busca(string chave)
        {
            Database db = Database.GetInstance();
            List<Venda> lista = new List<Venda>();
            DataRow dr = null;
            int linhas;
            string query = "SELECT * FROM vendas";
            if (chave != "")
                query += " WHERE nome_funcionario LIKE '%" + @chave + "%';";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.Add("@chave", MySqlDbType.VarChar);
            cmd.Parameters["@chave"].Value = chave;

            DataSet ds = db.ExecuteQuery(cmd);
            linhas = ds.Tables[0].Rows.Count;

            for(int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                Venda venda = SetDTO(dr);
                lista.Add(venda);
            }
            return lista;
        }

        public Venda BuscaPorId(int chave)
        {
            Venda v = new Venda();
            Database db = Database.GetInstance();
            DataRow dr = null;
            string query = "SELECT * FROM vendas WHERE id = " + chave;

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            DataSet ds = db.ExecuteQuery(cmd);

            int linhas = ds.Tables[0].Rows.Count;
            for(int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                v = SetDTO(dr);
            }

            return v;
        }
    }
}
