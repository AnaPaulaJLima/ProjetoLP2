using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImobiliariaLP2.Modelo;
using System.Data;
using MySql.Data.MySqlClient;

namespace ImobiliariaLP2.DAO
{
    class FuncionarioDAO
    {
        public Funcionario SetDTO(DataRow dr)
        {
            Funcionario f = new Funcionario();
            f.Id = int.Parse(dr["id"].ToString());
            f.Nome = dr["nome"].ToString();
            f.Telefone = dr["telefone"].ToString();
            f.Email = dr["email"].ToString();
            f.Funcao = dr["funcao"].ToString();
            f.Creci = dr["creci"].ToString();
            f.Login = dr["login"].ToString();
            f.Senha = dr["senha"].ToString();
            f.Ativo = int.Parse(dr["ativo"].ToString());
            f.Acesso = int.Parse(dr["acesso"].ToString());
            return f;
        }

        public void GetDTO(string query, Funcionario f)
        {
            Database db = Database.GetInstance();
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar);
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar);
            cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            cmd.Parameters.Add("@funcao", MySqlDbType.VarChar);
            cmd.Parameters.Add("@creci", MySqlDbType.VarChar);
            cmd.Parameters.Add("@login", MySqlDbType.VarChar);
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar);
            cmd.Parameters.Add("@acesso", MySqlDbType.Int32);

            cmd.Parameters["@nome"].Value = f.Nome;
            cmd.Parameters["@telefone"].Value = f.Telefone;
            cmd.Parameters["@email"].Value = f.Email;
            cmd.Parameters["@funcao"].Value = f.Funcao;
            cmd.Parameters["@creci"].Value = f.Creci;
            cmd.Parameters["@login"].Value = f.Login;
            cmd.Parameters["@senha"].Value = f.Senha;
            cmd.Parameters["@acesso"].Value = f.Acesso;

            db.ExecuteNonQuery(cmd);
        }

        public void Salvar(Funcionario f)
        {
            string query = "INSERT INTO funcionario(nome, telefone, email, funcao, creci, login, senha, ativo, acesso) VALUES(@nome, @telefone, @email, @funcao, @creci, @login, @senha, 1, @acesso)";
            GetDTO(query, f);
        }

        public List<Funcionario> Buscar(string chave)
        {
            Database db = Database.GetInstance();
            List<Funcionario> lista = new List<Funcionario>();
            DataRow dr = null;
            int linhas;

            string query = "SELECT * FROM funcionario WHERE ativo = 1";

            if (chave != "")
                query += " AND nome LIKE '" + @chave + "%' ";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.Add("@chave", MySqlDbType.VarChar);
            cmd.Parameters["@chave"].Value = chave;

            DataSet ds = db.ExecuteQuery(query);
            linhas = ds.Tables[0].Rows.Count;

            for(int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                Funcionario f = SetDTO(dr);
                lista.Add(f);
            }
            return lista;
        }

        public Funcionario BuscarPorId(int id) // É USADO PARA COLOCAR NA TELA DE VISUALIZAR FUNCIOANRIO O FUNCIONARIO SELECIONADO NO DATAGRID
        {
            Funcionario f = new Funcionario();
            Database db = Database.GetInstance();
            DataRow dr = null;

            string query = "SELECT * FROM funcionario WHERE id = " + id;

            MySqlCommand comando = new MySqlCommand(query, db.GetConnection());
            DataSet ds = db.ExecuteQuery(comando);

            int linhas = ds.Tables[0].Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dr = ds.Tables[0].Rows[i];
                // Usa SetDTO 
                f = SetDTO(dr);
            }
            return f;
        }

        public void Atualizar(Funcionario f)
        {
            Database db = Database.GetInstance();
            string query = "UPDATE funcionario SET id = " + f.Id + ", nome = @nome, telefone = @telefone, email = @email, funcao = @funcao, creci = @creci, login = @login, senha = @senha WHERE id = " + f.Id;
            GetDTO(query, f);
        }

        public void Excluir(int id)
        {
            Database db = Database.GetInstance();
            string query = "UPDATE funcionario SET ativo = 0 WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.ExecuteNonQuery(cmd);
        }
    }
}
