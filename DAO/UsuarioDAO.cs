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
    class UsuarioDAO
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr;
        public bool Logar(string login, string senha)
        {
            bool isValid = false;
            cmd.CommandText = "SELECT * FROM USUARIO WHERE USUARIO.LOGIN = @login AND USUARIO.SENHA = @senha";
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
                        Usuario.idFuncionario = Convert.ToInt32(dr["idusuario"]);
                        Usuario.login = Convert.ToString(dr["login"]);
                        Usuario.senha = Convert.ToString(dr["senha"]);
                        Usuario.cpf = Convert.ToString(dr["cpf"]);
                        Usuario.email = Convert.ToString(dr["email"]);
                        Usuario.tipo = Convert.ToString(dr["tipo"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isValid;
        }
        public void insertUsuario(String login, String senha, String email, String cpf, String tipo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "INSERT INTO USUARIO (LOGIN, SENHA, CPF, EMAIL, TIPO) VALUES(@LOGIN, @SENHA, @CPF, @EMAIL, @TIPO)";
            cmd.Parameters.AddWithValue("@LOGIN", login);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@EMAIL",email);
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
