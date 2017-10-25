using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ImobiliariaLP2.DAO
{
    class Database
    {
        private static MySqlConnection conexao;
        private static Database instance;
        private const string URL = "SERVER=localhost;DATABASE=imobiliaria_lp2;UID=root;PASSWORD=";

        private Database()
        {
            conexao = new MySqlConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();

            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return conexao;
        }

        public void ExecuteNonQuery(string query)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void ExecuteNonQuery(MySqlCommand comando)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataSet ExecuteQuery(string query)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            conexao.Close();

            return ds;
        }

        public DataSet ExecuteQuery(MySqlCommand comando)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            conexao.Close();

            return ds;
        }
    }
}