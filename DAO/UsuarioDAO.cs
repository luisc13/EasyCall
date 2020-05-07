﻿using EasyCall.modelo;
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
    }
}