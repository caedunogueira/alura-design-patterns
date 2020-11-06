using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var conexao = new SqlConnection
            {
                ConnectionString = "User Id=root;Pasword=;Server=localhost;Database=meuBanco"
            };
            conexao.Open();

            return conexao;
        }
    }
}
