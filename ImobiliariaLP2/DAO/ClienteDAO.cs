using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ImobiliariaLP2.Modelo;
using System.Data;

namespace ImobiliariaLP2.DAO
{
    public class ClienteDAO
    { 
        public Cliente SetDTO(DataRow dr)
        {
            Cliente c = new Cliente();

            c.Id = int.Parse(dr["id"].ToString());
            c.Nome = dr["nome"].ToString();
            c.Cpf = dr["cpf"].ToString();
            c.Rg = dr["rg"].ToString();
            c.Telefone = dr["telefone"].ToString();
            c.Email = dr["email"].ToString();

            return c;
        }

        public void Salvar(Cliente c) // Salvar no banco
        {
            Database bd = Database.GetInstance();

            string query = "INSERT INTO cliente(nome, cpf, rg, telefone, email) VALUES(@nome, @cpf, @rg, @telefone, @email)";
            // essa string recebe o comando sql.

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações, colocando tipos em cada aroba
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);
            comando.Parameters.Add("@rg", MySqlDbType.VarChar);
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar);
            comando.Parameters.Add("@email", MySqlDbType.VarChar);

            // Atribuição de valores
            comando.Parameters["@nome"].Value = c.Nome;
            comando.Parameters["@cpf"].Value = c.Cpf;
            comando.Parameters["@rg"].Value = c.Rg;
            comando.Parameters["@telefone"].Value = c.Telefone;
            comando.Parameters["@email"].Value = c.Email;

            bd.ExecuteNonQuery(comando);
        }
        /*
        public List<Cliente> BuscarTodos() // busca todos do banco
        {
            Database bd = Database.GetInstance();
            List<Cliente> lista = new List<Cliente>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM cliente"; // é o comando sql 

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            DataSet ds = bd.ExecuteQuery(comando);

            // Conta quantas linhas tem a tabela que o comando retornou do banco
            linhas = ds.Tables[0].Rows.Count;

            for(int i=0; i < linhas; i++)
            {
                Cliente c = new Cliente();

                dr = ds.Tables[0].Rows[i];
                c.Id = int.Parse(dr["id"].ToString());
                c.Nome = dr["nome"].ToString();
                c.Cpf = dr["cpf"].ToString();
                c.Rg = dr["rg"].ToString();
                c.Telefone = dr["telefone"].ToString();
                c.Email = dr["email"].ToString();

                lista.Add(c);
            }

            return lista;
        }*/

        public List<Cliente> Buscar(string chave) // busca todos do banco
        {
            Database bd = Database.GetInstance();
            List<Cliente> lista = new List<Cliente>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM cliente"; // é o comando sql 

            if (chave != "")
                //query += " WHERE nome LIKE '%@nome%' OR cpf LIKE '@nome%'";
                query += " WHERE nome LIKE '%" +chave+ "%' OR cpf LIKE '"+chave+"%'";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            DataSet ds = bd.ExecuteQuery(comando);

            // Conta quantas linhas tem a tabela que o comando retornou do banco
            linhas = ds.Tables[0].Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];

                Cliente c = SetDTO(dr);

                lista.Add(c);
            }

            return lista;
        }


        public DataTable BuscarPorNome(string nome) // é para ver um cliente com um determinado no
        {
            Database bd = Database.GetInstance();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            string query = "SELECT id, nome FROM cliente WHERE nome LIKE '%' + @nome + '%'"; // é o comando sql 

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);

            // Atribuição de valores
            comando.Parameters["@nome"].Value = nome;

            da.SelectCommand = comando;
            da.Fill(dt);

            return dt;
        }

        /*public Cliente Buscar(string cpf) // é para ver um cliente com um determinado cpf 
        {
            Database bd = Database.GetInstance();

            string query = "SELECT * FROM cliente WHERE cpf = @cpf"; // é o comando sql 

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);

            // Atribuição de valores
            comando.Parameters["@cpf"].Value = cpf;

            DataSet ds = bd.ExecuteQuery(comando);
            Cliente c = new Cliente();

            DataRow dr = ds.Tables[0].Rows[0];
            c.Id = int.Parse(dr["id"].ToString());
            c.Nome = dr["nome"].ToString();
            c.Cpf = dr["cpf"].ToString();
            c.Rg = dr["rg"].ToString();
            c.Telefone = dr["telefone"].ToString();
            c.Email = dr["email"].ToString();

            return c;
        }*/

        public void Atualizar(Cliente c)
        {
            Database bd = Database.GetInstance();

            string query = "UPDATE cliente SET id = @id, nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone, email = @email WHERE id = @id;";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificando que tipo de dado é cada @
            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);
            comando.Parameters.Add("@rg", MySqlDbType.VarChar);
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar);
            comando.Parameters.Add("@email", MySqlDbType.VarChar);

            /// Atribuindo os valores aos @
            comando.Parameters["@id"].Value = c.Id;
            comando.Parameters["@nome"].Value = c.Nome;
            comando.Parameters["@cpf"].Value = c.Cpf;
            comando.Parameters["@rg"].Value = c.Rg;
            comando.Parameters["@telefone"].Value = c.Telefone;
            comando.Parameters["@email"].Value = c.Email;

            bd.ExecuteNonQuery(comando);
        }

        public void Excluir(string cpf)
        {
            Database bd = Database.GetInstance();

            string query = "DELETE FROM cliente WHERE cpf = @cpf;";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            //Especificação
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);

            //Atribuição
            comando.Parameters["@cpf"].Value = cpf;

            bd.ExecuteNonQuery(comando);
        }   
    }
}
