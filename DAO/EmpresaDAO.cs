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
    class EmpresaDAO
    {
        public List<Empresa> listEmpresas()
        {
            var retorno = new List<Empresa>();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM EMPRESA";
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new Empresa();
                        item.idempresa = Convert.ToInt32(dr["IDEMPRESA"]);
                        item.nome = Convert.ToString(dr["NOME"]);
                        item.cnpj = Convert.ToString(dr["CNPJ"]);
                        retorno.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

    }
}
