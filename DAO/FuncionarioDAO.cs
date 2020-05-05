using EasyCall.modelo;
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
            cmd.CommandText = "SELECT * FROM funcionario WHERE funcionario.LOGIN = @login AND funcionario.SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isValid = true;
                    while(dr.Read()) // seta o funcionario
                    {
                        Funcionario.idFuncionario = Convert.ToInt32(dr["idfuncionario"]);
                        Funcionario.login = Convert.ToString(dr["login"]);
                        Funcionario.senha = Convert.ToString(dr["senha"]);
                        Funcionario.cpf = Convert.ToString(dr["cpf"]);
                        Funcionario.email = Convert.ToString(dr["email"]);
                        Funcionario.tipo = Convert.ToString(dr["tipo"]);
                    }
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
