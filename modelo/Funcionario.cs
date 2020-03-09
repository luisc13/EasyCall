using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCall.modelo
{
    class Funcionario
    {
        static string login;
        static string senha;
        static string nome;
        static string CPF;
        static string email;

        bool isLoginValido(string login, string senha)
        {
            // verifica login no banco de dados
            return true;
        }

        void setFuncionario()
        {
            // iniciar após login
            // seta dados do funcionario pegando do banco de dados
        }
    }
}
