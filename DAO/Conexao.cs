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
            //Gustavo - con.ConnectionString = @"Data Source=LAPTOP-OGHHCABF\SQLEXPRESS;Initial Catalog=EasyCall;Persist Security Info=True;User ID=sa;Password=toledo";
            //Luis - con.ConnectionString = @"Data Source=LAPTOP-3H8K5NM5;Initial Catalog=EasyCall;Persist Security Info=True;User ID=sa;Password=toledo";
            con.ConnectionString = @"Data Source=LAPTOP-3H8K5NM5;Initial Catalog=EasyCall;Persist Security Info=True;User ID=sa;Password=toledo";
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

        public void desconectar ()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
