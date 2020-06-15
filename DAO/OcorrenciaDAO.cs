using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyCall.modelo;

namespace EasyCall.DAO
{
    class OcorrenciaDAO
    {
        public void setOcorrencia(String ocorrencia, int idDivida)
        {

            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "INSERT INTO OCORRENCIA (CONTEUDO, IDDIVIDA, DATAOCORRENCIA, HORAOCORRENCIA) VALUES(@CONTEUDO, @ID, @DATAOCORRENCIA, @HORAOCORRENCIA)";
            cmd.Parameters.AddWithValue("@CONTEUDO", ocorrencia);
            cmd.Parameters.AddWithValue("@ID", idDivida);
            cmd.Parameters.AddWithValue("@DATAOCORRENCIA", (DateTime.Now).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORAOCORRENCIA", DateTime.Now.ToString("HH:mm"));
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

        public OcorrenciaModelo getOcorrencia(int id)
        {
            var retorno = new OcorrenciaModelo();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM OCORRENCIA WHERE OCORRENCIA.IDDIVIDA = @IDDIVIDA";
            cmd.Parameters.AddWithValue("@IDDIVIDA", id);
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retorno.idocorrencia = Convert.ToInt32(dr["IDOCORRENCIA"]);
                        retorno.conteudo = Convert.ToString(dr["CONTEUDO"]);
                        retorno.iddivida = Convert.ToInt32(dr["IDDIVIDA"]);
                        retorno.dataocorrencia = DateTime.Parse(Convert.ToString(dr["DATAOCORRENCIA"]));
                        retorno.horaOcorrencia = DateTime.Parse(Convert.ToString(dr["HORAOCORRENCIA"]));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        public List<OcorrenciaModelo> listLastOcorrencias (int iddivida)
        {
            var retorno = new List<OcorrenciaModelo>();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM OCORRENCIA WHERE OCORRENCIA.IDDIVIDA = @IDDIVIDA";
            cmd.Parameters.AddWithValue("@IDDIVIDA", iddivida);
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var item = new OcorrenciaModelo();
                        item.idocorrencia = Convert.ToInt32(dr["IDOCORRENCIA"]);
                        item.conteudo = Convert.ToString(dr["CONTEUDO"]);
                        item.iddivida = Convert.ToInt32(dr["IDDIVIDA"]);
                        item.dataocorrencia = DateTime.Parse(Convert.ToString(dr["DATAOCORRENCIA"]));
                        item.horaOcorrencia = DateTime.Parse(Convert.ToString(dr["HORAOCORRENCIA"]));
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
