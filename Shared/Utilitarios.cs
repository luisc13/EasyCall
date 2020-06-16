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

        public class Validacoes

        {

            public static bool ValidaCPF(string vrCPF)

            {

                string valor = vrCPF.Replace(".", "");

                valor = valor.Replace("-", "");



                if (valor.Length != 11)

                    return false;



                bool igual = true;

                for (int i = 1; i < 11 && igual; i++)

                    if (valor[i] != valor[0])

                        igual = false;



                if (igual || valor == "12345678909")

                    return false;



                int[] numeros = new int[11];



                for (int i = 0; i < 11; i++)

                    numeros[i] = int.Parse(

                      valor[i].ToString());



                int soma = 0;

                for (int i = 0; i < 9; i++)

                    soma += (10 - i) * numeros[i];



                int resultado = soma % 11;



                if (resultado == 1 || resultado == 0)

                {

                    if (numeros[9] != 0)

                        return false;

                }

                else if (numeros[9] != 11 - resultado)

                    return false;



                soma = 0;

                for (int i = 0; i < 10; i++)

                    soma += (11 - i) * numeros[i];



                resultado = soma % 11;



                if (resultado == 1 || resultado == 0)

                {

                    if (numeros[10] != 0)

                        return false;

                }

                else

                    if (numeros[10] != 11 - resultado)

                    return false;



                return true;

            }

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