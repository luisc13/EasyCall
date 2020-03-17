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
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-OGHHCABF\SQLEXPRESS;Initial Catalog=db_callcenter;User ID=sa;Password=toledo";
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
