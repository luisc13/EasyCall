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
        public Devedor getDevedor(int id)
        {
            var retorno = new Devedor();
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM DEVEDOR WHERE DEVEDOR.IDDEVEDOR = @ID";
            cmd.Parameters.AddWithValue("@ID", id);
            
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
    }
}
