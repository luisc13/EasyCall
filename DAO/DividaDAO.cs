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
                        retorno.ocorrencia = Convert.ToString(dr["OCORRENCIA"]);
                        retorno.dataVencimento = Convert.ToDateTime(dr["DATAVENCIMENTO"]);
                        retorno.idFuncionario = Convert.ToInt32(dr["IDFUNCIONARIO"]);
                        retorno.idBbanco = Convert.ToInt32(dr["IDBANCO"]);
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
      
        public void setOcorrencia(String ocorrencia, int id) {

            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "UPDATE DIVIDA SET OCORRENCIA = @ocorrencia WHERE IDDIVIDA = @ID";
            cmd.Parameters.AddWithValue("@ocorrencia", ocorrencia);
            cmd.Parameters.AddWithValue("@id", id);
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
