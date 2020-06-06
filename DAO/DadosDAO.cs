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
        public async Task<bool> inserir(Dados dados, string nomeEmpresa)
        {
            
            bool retorno = false;
            bool devOk = false;
            bool divOk = false;

            if (dados.devedores != null)
            {
                foreach (var dev in dados.devedores)
                {
                    SqlCommand cmd = new SqlCommand();
                    Conexao conexao = new Conexao();
                    cmd.Connection = conexao.conectar();

                    cmd.CommandText = "IF(NOT EXISTS(SELECT * FROM DEVEDOR WHERE CPF = @CPF)) BEGIN " +
                        "INSERT INTO DEVEDOR(NOME, CPF, EMAIL, TELEFONE) VALUES(@NOME, @CPF, @EMAIL, @TELEFONE) END ELSE " +
                        "BEGIN UPDATE DEVEDOR SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE CPF = @CPF END";
                    cmd.Parameters.AddWithValue("@NOME", dev.nome);
                    cmd.Parameters.AddWithValue("@CPF", dev.cpf);
                    cmd.Parameters.AddWithValue("@EMAIL", dev.email);
                    cmd.Parameters.AddWithValue("@TELEFONE", dev.telefone);
                    try
                    {
                        if (dev != null)
                        {
                            await cmd.ExecuteNonQueryAsync();
                            devOk = true;
                            cmd.Dispose();
                            conexao.desconectar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (dados.dividas != null)
            {
                foreach (var div in dados.dividas)
                {
                    SqlCommand cmd = new SqlCommand();
                    Conexao conexao = new Conexao();
                    cmd.Connection = conexao.conectar();

                    cmd.CommandText = "IF(NOT EXISTS(SELECT * FROM DIVIDA WHERE VALOR = @VALOR AND DATAVENCIMENTO = @DATAVENCIMENTO))" +
                        " BEGIN INSERT INTO DIVIDA(VALOR, DATAVENCIMENTO, IDEMPRESA, IDDEVEDOR, STATUS) VALUES(@VALOR, @DATAVENCIMENTO, (SELECT IDEMPRESA FROM EMPRESA WHERE EMPRESA.NOME = @NOMEEMPRESA), (SELECT IDDEVEDOR FROM DEVEDOR WHERE DEVEDOR.CPF = @CPF), @STATUS) END ELSE BEGIN UPDATE DIVIDA SET VALOR = @VALOR, DATAVENCIMENTO = @DATAVENCIMENTO, " +
                        "IDEMPRESA = (SELECT IDEMPRESA FROM EMPRESA WHERE EMPRESA.NOME = @NOMEEMPRESA), IDDEVEDOR = (SELECT IDDEVEDOR FROM DEVEDOR WHERE DEVEDOR.CPF = @CPF), STATUS = @STATUS END";
                    cmd.Parameters.AddWithValue("@VALOR", div.valor);
                    cmd.Parameters.AddWithValue("@DATAVENCIMENTO", div.dataVencimento);
                    cmd.Parameters.AddWithValue("@IDEMPRESA", div.idEmpresa);
                    cmd.Parameters.AddWithValue("@IDDEVEDOR", div.idDevedor);
                    cmd.Parameters.AddWithValue("@STATUS", div.status);
                    cmd.Parameters.AddWithValue("@NOMEEMPRESA", nomeEmpresa);
                    cmd.Parameters.AddWithValue("@CPF", div.cpfdevedor);

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
            }

            if (devOk && divOk || devOk && dados.dividas == null || divOk && dados.devedores == null)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
