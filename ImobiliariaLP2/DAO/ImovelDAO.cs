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
    public class ImovelDAO
    {
        public void  Salvar (Imovel i)
        {
            Database bd = Database.GetInstance(); 

            string query = "INSERT INTO imovel(tipo, categoria, metragem, valor, bairro, rua, numero, id_proprietario) VALUES(@tipo, @categoria, @metragem, @valor, @bairro, @rua, @numero, @id_proprietario)";
            /// essa string recebe o comando sql 

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection()); // instanciando um comand mysql e mando para ele a "solicitação" de conexao e a comando sql "query"

            // Especificações , colocando tipos em cada aroba 
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            comando.Parameters.Add("@categoria", MySqlDbType.VarChar);
            comando.Parameters.Add("@metragem", MySqlDbType.Float); 
            comando.Parameters.Add("@valor", MySqlDbType.Float);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar);
            comando.Parameters.Add("@rua", MySqlDbType.VarChar);
            comando.Parameters.Add("@numero", MySqlDbType.Int32);
            comando.Parameters.Add("@id_proprietario", MySqlDbType.Int32);

            // Atribuições de valores a cada @
            comando.Parameters["@tipo"].Value = i.Tipo;
            comando.Parameters["@categoria"].Value = i.Categoria;
            comando.Parameters["@metragem"].Value = i.Metragem;
            comando.Parameters["@valor"].Value = i.Valor;
            comando.Parameters["@bairro"].Value = i.Bairro;
            comando.Parameters["@rua"].Value = i.Rua;
            comando.Parameters["@numero"].Value = i.Numero;
            comando.Parameters["@id_proprietario"].Value = i.P.Id;

            bd.ExecuteNonQuery(comando); // é um "comando/conexao" que faz com o banco, que nao tem nenhum retorno.
        }

        public Imovel Buscar (int id) // é para localizar um imovel com um determinado id
        {
            Database bd = Database.GetInstance();

            string query = "SELECT * FROM imovel WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações do aroba , atribuindo tipo.
            comando.Parameters.Add("@id", MySqlDbType.Int32); /// JOÃO, VERIFIQUE SE REALMENTE É INT32

            // Atribuindo valor ao aroba
            comando.Parameters["@id"].Value = id;

            DataSet ds = bd.ExecuteQuery(comando);
            Imovel i = new Imovel(); /// tinha pensado em instaciar um proprietario , mais não iria dar certo

            DataRow dr = ds.Tables[0].Rows[0];
            i.Id = int.Parse(dr["id"].ToString());
            i.Tipo = dr["tipo"].ToString();
            i.Categoria = dr["categoria"].ToString();
            i.Metragem = float.Parse(dr["metragem"].ToString());
            i.Valor = float.Parse(dr["valor"].ToString());
            i.Bairro = dr["bairro"].ToString();
            i.Rua = dr["rua"].ToString();
            i.Numero = int.Parse(dr["numero"].ToString());
            i.P.Id = int.Parse(dr["id_proprietario"].ToString()); 

            return i;
        }

        public void Atualizar (Imovel i)
        {
            Database bd = Database.GetInstance();

            string query = "UPDATE imovel SET id = @id, tipo = @tipo, categoria = @categoria, metragem = @metragem, valor = @valor, bairro = @bairro, rua = @rua, numero = @numero id_proprietario = @id_proprietario WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações , colocando tipos em cada @
            comando.Parameters.Add("@id", MySqlDbType.Int32);
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            comando.Parameters.Add("@categoria", MySqlDbType.VarChar);
            comando.Parameters.Add("@metragem", MySqlDbType.Float);
            comando.Parameters.Add("@valor", MySqlDbType.Float);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar);
            comando.Parameters.Add("@rua", MySqlDbType.VarChar);
            comando.Parameters.Add("@numero", MySqlDbType.Int32);
            comando.Parameters.Add("@id_proprietario", MySqlDbType.Int32);

            // Atribuições de valores a cada aroba
            comando.Parameters["id"].Value = i.Id;
            comando.Parameters["@tipo"].Value = i.Tipo;
            comando.Parameters["@categoria"].Value = i.Categoria;
            comando.Parameters["@metragem"].Value = i.Metragem;
            comando.Parameters["@valor"].Value = i.Valor;
            comando.Parameters["@bairro"].Value = i.Bairro;
            comando.Parameters["@rua"].Value = i.Rua;
            comando.Parameters["@numero"].Value = i.Rua;
            comando.Parameters["@id_proprietario"].Value = i.P.Id;

            bd.ExecuteNonQuery(comando);
        }

        public void Excluir (int id)
        {
            Database bd = Database.GetInstance();

            string query = "DELETE FROM imovel WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificação
            comando.Parameters.Add("@id", MySqlDbType.Int32);// JOÃO, VERIFIQUE SE REALMENTE É INT32

            // Atribuição
            comando.Parameters["id"].Value = id;

            bd.ExecuteNonQuery(comando);

        }
    }
}
