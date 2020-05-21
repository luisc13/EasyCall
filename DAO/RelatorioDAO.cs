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
    class RelatorioDAO
    {
        public static void inserirRegistro (int iddivida, int iddevedor, string descricao)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "INSERT INTO RELATORIO (IDDIVIDA, IDDEVEDOR, DESCRICAO, DATA, HORA)" +
                "VALUES(@IDDIVIDA, @IDDEVEDOR, @DESCRICAO, @DATA, @HORA)";
            cmd.Parameters.AddWithValue("@IDDIVIDA", iddivida);
            cmd.Parameters.AddWithValue("@IDDEVEDOR", iddevedor);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@DATA", (DateTime.Now).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@HORA", DateTime.Now.ToString("HH:mm"));
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

        public static List<Registro> gerarRelatorio (string buscarPor, int id)
        {
            buscarPor = buscarPor.ToUpper();

            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;
            var ocrDAO = new OcorrenciaDAO();

            switch (buscarPor)
            {
                case "DIVIDA":
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE RELATORIO.IDDIVIDA = @IDDIVIDA";
                    cmd.Parameters.AddWithValue("@IDDIVIDA", id);
                    break;
                case "DEVEDOR":
                    cmd.CommandText = "SELECT * FROM RELATORIO WHERE RELATORIO.IDDEVEDOR = @IDDEVEDOR";
                    cmd.Parameters.AddWithValue("@IDDEVEDOR", id);
                    break;
            }

            List<Registro> retorno = new List<Registro>();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Registro reg = new Registro();
                        reg.idrelatorio = Convert.ToInt32(dr["IDRELATORIO"]);
                        reg.iddivida = Convert.ToInt32(dr["IDDIVIDA"]);
                        reg.iddevedor = Convert.ToInt32(dr["IDDEVEDOR"]);
                        reg.data = DateTime.Parse(Convert.ToString(dr["DATA"]));
                        reg.hora = DateTime.Parse(Convert.ToString(dr["HORA"]));
                        reg.descricao = Convert.ToString(dr["DESCRICAO"]);
                        retorno.Add(reg);
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
