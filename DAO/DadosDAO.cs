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
    class DadosDAO
    {
        public async Task<bool> inserir(Dados dados)
        {
            
            bool retorno = false;
            bool devOk = false;
            bool divOk = false;

            foreach (var dev in dados.devedores)
            {
                SqlCommand cmd = new SqlCommand();
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.conectar();

                cmd.CommandText = "INSERT INTO DEVEDOR(NOME, CPF, EMAIL, TELEFONE)" +
                "VALUES(@NOME, @CPF, @EMAIL, @TELEFONE)";
                cmd.Parameters.AddWithValue("@NOME", dev.nome);
                cmd.Parameters.AddWithValue("@CPF", dev.cpf);
                cmd.Parameters.AddWithValue("@EMAIL", dev.email);
                cmd.Parameters.AddWithValue("@TELEFONE", dev.telefone);
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    devOk = true;
                    cmd.Dispose();
                    conexao.desconectar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            foreach (var div in dados.dividas)
            {
                SqlCommand cmd = new SqlCommand();
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.conectar();

                cmd.CommandText = "INSERT INTO DIVIDA(VALOR, DATAVENCIMENTO, IDEMPRESA, IDDEVEDOR, STATUS)"
                + "VALUES(@VALOR, @DATAVENCIMENTO, @IDEMPRESA, @IDDEVEDOR, @STATUS)";
                cmd.Parameters.AddWithValue("@VALOR", div.valor);
                cmd.Parameters.AddWithValue("@DATAVENCIMENTO", div.dataVencimento);
                cmd.Parameters.AddWithValue("@IDEMPRESA", div.idEmpresa);
                cmd.Parameters.AddWithValue("@IDDEVEDOR", div.idDevedor);
                cmd.Parameters.AddWithValue("@STATUS", div.status);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    divOk = true;
                    cmd.Dispose();
                    conexao.desconectar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (devOk == true && divOk == true)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
