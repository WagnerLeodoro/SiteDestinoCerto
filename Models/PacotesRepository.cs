using System.Collections.Generic;
using MySqlConnector;

namespace destinoCerto.Models
{
    public class PacotesRepository : Repository
    {
        public void Insert(PacotesTuristicos p, int id)
        {
            conn.Open();

            string sql = "INSERT INTO PacotesTuristicos (nome, origem, destino, atrativos, saida, retorno, usuario) VALUES (@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@origem", p.Origem);
            cmd.Parameters.AddWithValue("@destino", p.Destino);
            cmd.Parameters.AddWithValue("@atrativos", p.Atrativos);
            cmd.Parameters.AddWithValue("@saida", p.Saida);
            cmd.Parameters.AddWithValue("@retorno", p.Retorno);
            cmd.Parameters.AddWithValue("@usuario", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public PacotesTuristicos BuscarPorId(int id)
        {
            conn.Open();

            string sql = "SELECT * FROM PacotesTuristicos WHERE id = @Id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            PacotesTuristicos pct = new PacotesTuristicos();

            while (reader.Read())
            {
                pct.Id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    pct.Nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("origem")))
                    pct.Origem = reader.GetString("origem");

                if (!reader.IsDBNull(reader.GetOrdinal("destino")))
                    pct.Destino = reader.GetString("destino");

                if (!reader.IsDBNull(reader.GetOrdinal("atrativos")))
                    pct.Atrativos = reader.GetString("atrativos");

                if (!reader.IsDBNull(reader.GetOrdinal("saida")))
                    pct.Saida = reader.GetDateTime("saida");

                if (!reader.IsDBNull(reader.GetOrdinal("retorno")))
                    pct.Retorno = reader.GetDateTime("retorno");

                if (!reader.IsDBNull(reader.GetOrdinal("usuario")))
                    pct.Usuario = reader.GetInt32("usuario");
            }

            conn.Close();
            return pct;
        }

        public List<PacotesTuristicos> Listar(int id)
        {
            conn.Open();

            string sql = "SELECT * FROM PacotesTuristicos" + (id > 0 ? "WHERE id = @id" : "") + " ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (id > 0)
            {
                cmd.Parameters.AddWithValue("@id", id);
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            List<PacotesTuristicos> lista = new List<PacotesTuristicos>();

            while (reader.Read())
            {
                PacotesTuristicos pct = new PacotesTuristicos();
                pct.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                    pct.Nome = reader.GetString("nome");

                if (!reader.IsDBNull(reader.GetOrdinal("origem")))
                    pct.Origem = reader.GetString("origem");

                if (!reader.IsDBNull(reader.GetOrdinal("destino")))
                    pct.Destino = reader.GetString("destino");

                if (!reader.IsDBNull(reader.GetOrdinal("atrativos")))
                    pct.Atrativos = reader.GetString("atrativos");

                if (!reader.IsDBNull(reader.GetOrdinal("saida")))
                    pct.Saida = reader.GetDateTime("saida");

                if (!reader.IsDBNull(reader.GetOrdinal("retorno")))
                    pct.Retorno = reader.GetDateTime("retorno");

                if (!reader.IsDBNull(reader.GetOrdinal("usuario")))
                    pct.Usuario = reader.GetInt32("usuario");

                lista.Add(pct);
            }

            conn.Close();
            return lista;
        }

        public List<PacotesTuristicos> Listar()
        {
            return Listar(0);
        }

        public void Atualizar(PacotesTuristicos p)
        {
            conn.Open();

            string sql = "UPDATE PacotesTuristicos SET nome=@Nome, origem=@Origem, destino=@Destino, atrativos=@Atrativos, saida=@Saida, retorno=@Retorno, usuario=@Usuario WHERE id=@Id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@origem", p.Origem);
            cmd.Parameters.AddWithValue("@destino", p.Destino);
            cmd.Parameters.AddWithValue("@atrativos", p.Atrativos);
            cmd.Parameters.AddWithValue("@saida", p.Saida);
            cmd.Parameters.AddWithValue("@retorno", p.Retorno);
            cmd.Parameters.AddWithValue("@usuario", p.Usuario);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Remover(int id)
        {
            conn.Open();

            string sql = "DELETE FROM PacotesTuristicos WHERE id=@Id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}