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
    public class ProprietarioDao
    {
        public void Salvar(Proprietario p) // Salvar no banco
        {
            Database bd = Database.GetInstance();

            string query = "INSERT INTO proprietario(nome, cpf, rg, telefone, email, rua, numero, bairro, cidade) VALUES(@nome, @cpf, @rg, @telefone, @email, @rua, @numero, @bairro, @cidade)";
            // essa string recebe o comando sql.

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações, colocando tipos em cada aroba
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);
            comando.Parameters.Add("@rg", MySqlDbType.VarChar);
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar);
            comando.Parameters.Add("@email", MySqlDbType.VarChar);
            comando.Parameters.Add("@rua", MySqlDbType.VarChar);
            comando.Parameters.Add("@numero", MySqlDbType.Int32);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar);
            comando.Parameters.Add("@cidade", MySqlDbType.VarChar);

            // Atribuição de valores
            comando.Parameters["@nome"].Value = p.Nome;
            comando.Parameters["@cpf"].Value = p.Cpf;
            comando.Parameters["@rg"].Value = p.Rg;
            comando.Parameters["@telefone"].Value = p.Telefone;
            comando.Parameters["@email"].Value = p.Email;
            comando.Parameters["@rua"].Value = p.Rua;
            comando.Parameters["@numero"].Value = p.Numero;
            comando.Parameters["@bairro"].Value = p.Bairro;
            comando.Parameters["@cidade"].Value = p.Cidade;

            bd.ExecuteNonQuery(comando);
        }

        public Proprietario Buscar (string cpf) // é para ver um proprietario com um determinado cpf 
        {
            Database bd = Database.GetInstance();

            string query = "SELECT * FROM proprietario WHERE cpf = @cpf"; // é o comando sql 

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);

            // Atribuição de valores
            comando.Parameters["@cpf"].Value = cpf;

            DataSet ds = bd.ExecuteQuery(comando);
            Proprietario p = new Proprietario();

            DataRow dr = ds.Tables[0].Rows[0];
            p.Id = int.Parse(dr["id"].ToString());
            p.Nome = dr["nome"].ToString();
            p.Cpf = dr["cpf"].ToString();
            p.Rg = dr["rg"].ToString();
            p.Telefone = dr["telefone"].ToString();
            p.Email = dr["email"].ToString();
            p.Rua = dr["rua"].ToString();
            p.Numero = int.Parse(dr["numero"].ToString());
            p.Bairro = dr["bairro"].ToString();
            p.Cidade = dr["cidade"].ToString();

            return p;
        }

        public void Atualizar (Proprietario p)
        {
            Database bd = Database.GetInstance();

            string query = "UPDATE proprietario SET id = @id, nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone, email = @email, rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade WHERE id = @id;";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificando que tipo de dado é cada @
            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);
            comando.Parameters.Add("@rg", MySqlDbType.VarChar);
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar);
            comando.Parameters.Add("@email", MySqlDbType.VarChar);
            comando.Parameters.Add("@rua", MySqlDbType.VarChar);
            comando.Parameters.Add("@numero", MySqlDbType.Int32);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar);
            comando.Parameters.Add("@cidade", MySqlDbType.VarChar);

            /// Atribuindo os valores aos @
            comando.Parameters["@id"].Value = p.Id;
            comando.Parameters["@nome"].Value = p.Nome;
            comando.Parameters["@cpf"].Value = p.Cpf;
            comando.Parameters["@rg"].Value = p.Rg;
            comando.Parameters["@telefone"].Value = p.Telefone;
            comando.Parameters["@email"].Value = p.Email;
            comando.Parameters["@rua"].Value = p.Rua;
            comando.Parameters["@numero"].Value = p.Numero;
            comando.Parameters["@bairro"].Value = p.Bairro;
            comando.Parameters["@cidade"].Value = p.Cidade;

            bd.ExecuteNonQuery(comando);
        }

        public void Excluir (string cpf )
        {
            Database bd = Database.GetInstance();

            string query = "DELETE FROM proprietario WHERE cpf = @cpf;";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            //Especificação
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);

            //Atribuição
            comando.Parameters["@cpf"].Value = cpf;

            bd.ExecuteNonQuery(comando);
        }
    }
}

