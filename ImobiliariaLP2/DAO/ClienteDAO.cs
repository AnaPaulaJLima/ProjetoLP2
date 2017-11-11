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
        // Usa para passar do banco para um objeto
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

        // Usa para passar um objeto para o banco
        public void GetDTO(string query, Cliente c)
        {
            Database bd = Database.GetInstance();
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

        public void Salvar(Cliente c) // Salvar no banco
        {
            string query = "INSERT INTO cliente(nome, cpf, rg, telefone, email) VALUES(@nome, @cpf, @rg, @telefone, @email)";
            // Usando GetDTO
            GetDTO(query, c);
        }

        public List<Cliente> Buscar(string chave) // busca todos do banco
        {
            Database bd = Database.GetInstance();
            List<Cliente> lista = new List<Cliente>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM cliente"; // é o comando sql 

            if (chave != "")
                query += " WHERE nome LIKE '%" + @chave + "%' OR cpf LIKE '" + @chave + "%'";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            comando.Parameters.Add("@chave", MySqlDbType.VarChar);
            comando.Parameters["@chave"].Value = chave;

            DataSet ds = bd.ExecuteQuery(comando);

            // Conta quantas linhas tem a tabela que o comando retornou do banco
            linhas = ds.Tables[0].Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                // Usa SetDTO 
                Cliente c = SetDTO(dr);

                lista.Add(c);
            }

            return lista;
        }

        public Cliente BuscarPorId(int id)
        {
            Cliente c = new Cliente();
            Database db = Database.GetInstance();
            DataRow dr = null;

            string query = "SELECT * FROM cliente WHERE id = " + id;

            MySqlCommand comando = new MySqlCommand(query, db.GetConnection());
            DataSet ds = db.ExecuteQuery(comando);

            int linhas = ds.Tables[0].Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                // Usa SetDTO 
                c = SetDTO(dr);
            }

            return c;
        }

        public void Atualizar(Cliente c)
        {
            string query = "UPDATE cliente SET id = " + c.Id + ", nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone, email = @email WHERE id = "+ c.Id;
            GetDTO(query, c);
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
