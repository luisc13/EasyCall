using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCall.modelo
{
    public class Pagamento
    {
        public int idpagamento;
        public int qtdParcelas;
        public double valorParcela;
        public DateTime vencimento;
        public int iddivida;
    }
}
