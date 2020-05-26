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
    class DevedorDAO
    {
        public Devedor getDevedor()
        {
            var retorno = new Devedor();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT TOP 1 * FROM DEVEDOR INNER JOIN DIVIDA ON DIVIDA.IDDEVEDOR = DEVEDOR.IDDEVEDOR" +
                " WHERE DIVIDA.STATUS = 'PENDENTE' ORDER BY NEWID()";            
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retorno.iddevedor = Convert.ToInt32(dr["IDDEVEDOR"]);
                        retorno.nome = Convert.ToString(dr["NOME"]);
                        retorno.cpf = Convert.ToString(dr["CPF"]);
                        retorno.email = Convert.ToString(dr["EMAIL"]);
                        retorno.telefone = Convert.ToString(dr["TELEFONE"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public List<Devedor> listDevedor()
        {
            var retorno = new List<Devedor>();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT TOP 1 * FROM DEVEDOR, DIVIDA " +
                "WHERE DEVEDOR.IDDEVEDOR = DIVIDA.IDDEVEDOR ORDER BY DIVIDA.UL ASC";
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new Devedor();
                        item.iddevedor = Convert.ToInt32(dr["IDDEVEDOR"]);
                        item.nome = Convert.ToString(dr["NOME"]);
                        item.cpf = Convert.ToString(dr["CPF"]);
                        item.email = Convert.ToString(dr["EMAIL"]);
                        item.telefone = Convert.ToString(dr["TELEFONE"]);
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
