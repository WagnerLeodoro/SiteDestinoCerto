using System.Collections.Generic;
using MySqlConnector;

namespace destinoCerto.Models
{
    public class UsuarioRepository : Repository
    {
        public void Insert(Usuario u)
        {
            conn.Open();

            string sql = "INSERT INTO Usuario(nome, login, senha, dataNascimento) VALUES (@Nome, @Login, @Senha, @DataNascimento);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@senha", u.Senha);
            cmd.Parameters.AddWithValue("@dataNascimento", u.DataNascimento);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Usuario BuscarPorId(int id)
        {
            conn.Open();

            string sql = "SELECT * FROM Usuario WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            Usuario usr = new Usuario();

            while (reader.Read())
            {
                usr.Id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    usr.Nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("login")))
                    usr.Login = reader.GetString("login");

                if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                    usr.Senha = reader.GetString("senha");

                if (!reader.IsDBNull(reader.GetOrdinal("dataNascimento")))
                    usr.DataNascimento = reader.GetDateTime("dataNascimento");
            }

            conn.Close();
            return usr;
        }

        public List<Usuario> Listar()
        {
            conn.Open();

            string sql = "SELECT * FROM Usuario";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();

            while (reader.Read())
            {
                Usuario usr = new Usuario();
                usr.Id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    usr.Nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("login")))
                    usr.Login = reader.GetString("login");

                if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                    usr.Senha = reader.GetString("senha");

                if (!reader.IsDBNull(reader.GetOrdinal("dataNascimento")))
                    usr.DataNascimento = reader.GetDateTime("dataNascimento");

                lista.Add(usr);
            }

            conn.Close();
            return lista;
        }

        public void Atualizar(Usuario u)
        {
            conn.Open();

            string sql = "UPDATE Usuario SET nome=@Nome, login=@Login, senha=@Senha, dataNascimento=@DataNascimento WHERE id=@Id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@senha", u.Senha);
            cmd.Parameters.AddWithValue("@dataNascimento", u.DataNascimento);
            cmd.Parameters.AddWithValue("@id", u.Id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Remover(int id)
        {
            conn.Open();

            string sql = "DELETE FROM Usuario WHERE id=@Id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Usuario QueryLogin(Usuario u)
        {
            conn.Open();

            string sql = "SELECT * FROM Usuario WHERE login = @login AND senha = @senha";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@senha", u.Senha);
            cmd.Parameters.AddWithValue("@id", u.Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            Usuario usr = null;
            if (reader.Read())
            {
                usr = new Usuario();
                usr.Id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    usr.Nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("login")))
                    usr.Login = reader.GetString("login");

                if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                    usr.Senha = reader.GetString("senha");
            }

            conn.Close();
            return usr;

        }
    }
}