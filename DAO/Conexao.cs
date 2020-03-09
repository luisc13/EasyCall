using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.DAO
{
    class Conexao
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            builder.DataSource = ""; // caminho
            builder.InitialCatalog = ""; // nome do banco
            builder.UserID = ""; // usuario
            builder.Password = ""; // senha
            con.ConnectionString = builder.ConnectionString; // caminho do banco
        }

        public SqlConnection conectar ()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
            return con;
        }

        public SqlConnection desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
