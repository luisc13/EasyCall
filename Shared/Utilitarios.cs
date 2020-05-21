using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCall.modelo
{
    class Utilitarios
    {
        public static string criptografarSenha(string senha)
        {
            char[] chrPass = senha.ToCharArray();
            string final = null;

            int[] asc = new int[chrPass.Length];

            for (int i = 0; i < chrPass.Length; i++)
            {
                asc[i] = Convert.ToInt32(chrPass[i]);
            }

            for (int i = 0; i < senha.Length; i++)
            {
                if (i % 2 == 0)
                {
                    final = final + asc[i].ToString();
                }
                else
                {
                    if (Char.IsNumber(Convert.ToChar(asc[i] + 1)))
                    {
                        final = final + "@";
                    }
                    final = final + Convert.ToChar(asc[i]).ToString();
                }
            }

            return final;
        }

        public static double calculoJuros(Double valorParcela, DateTime dataVencimento)
        {
            Double valorJurosTotal;
            var hoje = DateTime.Now;
            int diasAtraso = 0;
            if (hoje > dataVencimento)
            {
                diasAtraso = (hoje.Date - dataVencimento.Date).Days;
                valorJurosTotal = ((valorParcela * 1) / 100) * diasAtraso;
                valorParcela = valorParcela + valorJurosTotal;
            }
            return valorParcela;
        }
    }
}
