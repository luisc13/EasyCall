using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.DAO
{
    class FuncionarioDAO
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr;
        public bool Logar(string login, string senha)
        {
            bool isValid = false;
            cmd.CommandText = "SELECT * FROM funcionario WHERE funcionario.Login_Func = @login AND funcionario.senha.func = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isValid = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isValid;
        }
    }
}
