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
        public Proprietario SetDTO(DataRow dr)
        {
            Proprietario p = new Proprietario();
            p.Id = int.Parse(dr["id"].ToString());
            p.Nome = dr["nome"].ToString();
            p.Cpf = dr["cpf"].ToString();
            p.Rg = dr["rg"].ToString();
            p.DataNasc = dr["dataNasc"].ToString();
            p.Telefone = dr["telefone"].ToString();
            p.Email = dr["email"].ToString();
            p.Rua = dr["rua"].ToString();
            p.Numero = int.Parse(dr["numero"].ToString());
            p.Bairro = dr["bairro"].ToString();
            p.Cidade = dr["cidade"].ToString();
            p.Ativo = int.Parse(dr["ativo"].ToString());

            return p;
        }
        public void GetDTO(string query, Proprietario p)
        {
            Database bd = Database.GetInstance();
            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            // Especificações, colocando tipos em cada aroba
            comando.Parameters.Add("@nome", MySqlDbType.VarChar);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar);
            comando.Parameters.Add("@rg", MySqlDbType.VarChar);
            comando.Parameters.Add("@dataNasc", MySqlDbType.VarChar);
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
            comando.Parameters["@dataNasc"].Value = p.DataNasc;
            comando.Parameters["@telefone"].Value = p.Telefone;
            comando.Parameters["@email"].Value = p.Email;
            comando.Parameters["@rua"].Value = p.Rua;
            comando.Parameters["@numero"].Value = p.Numero;
            comando.Parameters["@bairro"].Value = p.Bairro;
            comando.Parameters["@cidade"].Value = p.Cidade;

            bd.ExecuteNonQuery(comando);
        }
        public void Salvar(Proprietario p) // Salvar no banco
        {
            string query = "INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo) VALUES(@nome, @cpf, @rg, @dataNasc, @telefone, @email, @rua, @numero, @bairro, @cidade, 1)";
            //Usando GetDTO()
            GetDTO(query, p);
        }

        public List<Proprietario> Buscar(string chave) // é para ver um proprietario com um determinado cpf 
        {
            Database bd = Database.GetInstance();
            List<Proprietario> lista = new List<Proprietario>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM proprietario WHERE ativo = 1"; // é o comando sql 

            if (chave != "")
                query += " AND nome LIKE '" + @chave + "%' OR cpf LIKE '" + @chave + "%' ";

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection());
            // Especificações
            comando.Parameters.Add("@chave", MySqlDbType.VarChar);
            // Atribuição de valores
            comando.Parameters["@chave"].Value = chave;
            DataSet ds = bd.ExecuteQuery(comando);

            // Conta quantas linhas tem a tabela que o comando retornou do banco
            linhas = ds.Tables[0].Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                // Usa SetDTO 
                Proprietario p = SetDTO(dr);
                lista.Add(p);
            }
            return lista;
        }

        public Proprietario BuscarPorId(int id)
        {
            Proprietario p = new Proprietario();
            Database db = Database.GetInstance();
            DataRow dr = null; // vai receber a tabela do banco 

            string query = "SELECT * FROM proprietario WHERE id = " + id;

            MySqlCommand comando = new MySqlCommand(query, db.GetConnection());
            DataSet ds = db.ExecuteQuery(comando); // recebe a tabela do banco direto 

            int linhas = ds.Tables[0].Rows.Count; // contando quantas linhas tem na ' tabela'

            for(int i = 0;  i <linhas; i++ )
            {
                dr = ds.Tables[0].Rows[i]; // joga cada linha do dataSet para o dataRow, pois é oque vai ficar no dataGrid
                //Usa SetDTO
                p = SetDTO(dr); // passa para o proprietario
            }

            return p;
        }

        public void Atualizar (Proprietario p)
        {
            string query = "UPDATE proprietario SET id = " + p.Id + ", nome = @nome, cpf = @cpf, rg = @rg, dataNasc = @dataNasc, telefone = @telefone, email = @email, rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade, ativo = " + p.Ativo + " WHERE id = " + p.Id;
            GetDTO(query, p); // o ID não esta com aroba pois não tratamos no get ou set esse campo pois não temos 'acesso' só o banco tem
            
        }

        public void Excluir (int id)
        {
            Database bd = Database.GetInstance(); // instancia o banco para realizar a conecção

            string query = "UPDATE proprietario SET ativo = 0 WHERE id = " + id;

            MySqlCommand comando = new MySqlCommand(query, bd.GetConnection()); // banco o comando e a conecxao
            bd.ExecuteNonQuery(comando);
        }
    }
}

