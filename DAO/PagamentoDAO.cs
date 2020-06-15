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
    class PagamentoDAO
    {
        public static void SetPagamento(Pagamento pmt)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            cmd.CommandText = "INSERT INTO PAGAMENTO(VALORPARCELA, VENCIMENTO, IDDIVIDA) " +
                "VALUES (@valorparcela, @vencimento, @iddivida)";
            cmd.Parameters.AddWithValue("@valorparcela", pmt.valorParcela);
            cmd.Parameters.AddWithValue("@vencimento", (pmt.vencimento).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@iddivida", pmt.iddivida);
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
