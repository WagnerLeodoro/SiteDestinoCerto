using MySqlConnector;

namespace destinoCerto.Models
{
    public abstract class Repository
    {
        protected const string _strConexao = "Database=destinoCerto; Data Source=localhost;User Id=root;";
        protected MySqlConnection conn = new MySqlConnection(_strConexao);
    }
}
