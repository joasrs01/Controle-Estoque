using System.Data.SqlClient;

namespace ControleEstoque.DAO
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=JOASNOTEBOOK\SQLEXPRESS; Initial Catalog=DB_CTRL_ESTOQUE;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
