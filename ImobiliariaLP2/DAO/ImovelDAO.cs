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
        public Imovel SetDTO(DataRow dr)
        {
            Imovel i = new Imovel();

            i.Id = int.Parse(dr["id"].ToString());
            i.Tipo = dr["tipo"].ToString();
            i.Categoria = dr["categoria"].ToString();
            i.Metragem = float.Parse(dr["metragem"].ToString());
            i.Frente = float.Parse(dr["frente"].ToString());
            i.Fundo = float.Parse(dr["fundo"].ToString());
            i.Valor = float.Parse(dr["valor"].ToString());
            i.Bairro = dr["bairro"].ToString();
            i.Rua = dr["rua"].ToString();
            i.Numero = int.Parse(dr["numero"].ToString());
            i.IdProprietario = int.Parse(dr["id_proprietario"].ToString());

            return i;
        }

        public void GetDTO(string query, Imovel i)
        {
            Database db = Database.GetInstance();
            MySqlCommand comando = new MySqlCommand(query, db.GetConnection());

            // Especificações , colocando tipos em cada @
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            comando.Parameters.Add("@categoria", MySqlDbType.VarChar);
            comando.Parameters.Add("@metragem", MySqlDbType.Float);
            comando.Parameters.Add("@frente", MySqlDbType.Float);
            comando.Parameters.Add("@fundo", MySqlDbType.Float);
            comando.Parameters.Add("@valor", MySqlDbType.Float);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar);
            comando.Parameters.Add("@rua", MySqlDbType.VarChar);
            comando.Parameters.Add("@numero", MySqlDbType.Int32);
            comando.Parameters.Add("@id_proprietario", MySqlDbType.Int32);

            // Atribuições de valores a cada aroba
            comando.Parameters["@tipo"].Value = i.Tipo;
            comando.Parameters["@categoria"].Value = i.Categoria;
            comando.Parameters["@metragem"].Value = i.Metragem;
            comando.Parameters["@frente"].Value = i.Frente;
            comando.Parameters["@fundo"].Value = i.Fundo;
            comando.Parameters["@valor"].Value = i.Valor;
            comando.Parameters["@bairro"].Value = i.Bairro;
            comando.Parameters["@rua"].Value = i.Rua;
            comando.Parameters["@numero"].Value = i.Rua;
            comando.Parameters["@id_proprietario"].Value = i.IdProprietario;

            db.ExecuteNonQuery(comando);
        }

        public void  Salvar (Imovel i)
        {
            string query = "INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, numero, id_proprietario, vendido, alugado) VALUES(@tipo, @categoria, @metragem, @frente, @fundo, @valor, @bairro, @rua, @numero, " + i.IdProprietario + ", 0, 0)";
            GetDTO(query, i);
        }

        /*
         Busca um imovel pelo CPF ou NOME do proprietario
        */
        public List<Imovel> Buscar (string chave)
        {
            Database bd = Database.GetInstance();
            List<Imovel> lista = new List<Imovel>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM imovel";
            if (chave != "")
                query += " i JOIN proprietario p ON i.id_proprietario = p.id AND p.nome LIKE '%" + @chave + "%' ";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());

            // Especificações do aroba , atribuindo tipo.
            comando.Parameters.Add("@chave", MySqlDbType.VarChar);

            // Atribuindo valor ao aroba
            comando.Parameters["@chave"].Value = chave;

            DataSet ds = bd.ExecuteQuery(comando);
            linhas = ds.Tables[0].Rows.Count;
            for(int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                Imovel imovel = SetDTO(dr);
                lista.Add(imovel);
            }
            return lista;
        }

        public Imovel BuscaPorId(int id)
        {
            Database db = Database.GetInstance();
            Imovel imovel = new Imovel();
            DataRow dr = null;

            string query = "SELECT * FROM imovel WHERE id = " + id;
            MySqlCommand comando = new MySqlCommand(query, db.GetConnection());
            DataSet ds = db.ExecuteQuery(comando);

            dr = ds.Tables[0].Rows[0];
            imovel = SetDTO(dr);
            return imovel;
        }

        public void Atualizar (Imovel i)
        {
            string query = "UPDATE imovel SET id = " + i.Id + ", tipo = @tipo, categoria = @categoria, metragem = @metragem, frente = @frente, fundo = @fundo, valor = @valor, bairro = @bairro, rua = @rua, numero = @numero id_proprietario = @id_proprietario WHERE id = " + i.Id;
            GetDTO(query, i);
        }

        public void Excluir (int id)
        {
            Database bd = Database.GetInstance();

            string query = "DELETE FROM imovel WHERE id = " + id;

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            bd.ExecuteNonQuery(comando);
        }
    }
}
