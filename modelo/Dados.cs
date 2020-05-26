using EasyCall.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.modelo
{
    class Dados
    {
        public Devedor[] devedores { get; set; }
        public Divida[] dividas { get; set; }

        public async static Task<bool> carregarDados(string nomeEmpresa)
        {
            var data = JsonParser.escolherArquivos();

            var dao = new DadosDAO();

            if (data != null)
            {
                if (await dao.inserir(data, nomeEmpresa))
                {
                    MessageBox.Show("Sucesso ao carregar os dados");
                    return true;
                }
            }
            return false;
        }
    }
}
