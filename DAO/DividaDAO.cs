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
    class DividaDAO
    {
        public Divida getDivida(int iddevedor)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM DIVIDA WHERE DIVIDA.IDDEVEDOR = @ID";
            cmd.Parameters.AddWithValue("@ID", iddevedor);
            Divida retorno = new Divida();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retorno.idDivida = Convert.ToInt32(dr["IDDIVIDA"]);
                        retorno.valor = Convert.ToDouble(dr["VALOR"]);
                        retorno.dataVencimento = Convert.ToDateTime(dr["DATAVENCIMENTO"]);
                        retorno.idEmpresa = Convert.ToInt32(dr["IDEMPRESA"]);
                        retorno.idDevedor = Convert.ToInt32(dr["IDDEVEDOR"]);
                        retorno.status = Convert.ToString(dr["STATUS"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public List<Divida> listDivida()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM DIVIDA";
            var retorno = new List<Divida>();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new Divida();
                        item.idDivida = Convert.ToInt32(dr["IDDIVIDA"]);
                        item.valor = Convert.ToDouble(dr["VALOR"]);
                        item.dataVencimento = Convert.ToDateTime(dr["DATAVENCIMENTO"]);
                        item.idEmpresa = Convert.ToInt32(dr["IDEMPRESA"]);
                        item.idDevedor = Convert.ToInt32(dr["IDDEVEDOR"]);
                        item.status = Convert.ToString(dr["STATUS"]);
                        //item.ul = Convert.ToDateTime(dr["UL"]);
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
        public void setUl(int idDivida, DateTime UL)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "UPDATE DIVIDA SET UL = @UL WHERE DIVIDA.IDDIVIDA = @IDDIVIDA";
            cmd.Parameters.AddWithValue("@IDDIVIDA", idDivida);
            cmd.Parameters.AddWithValue("@UL", UL);
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
