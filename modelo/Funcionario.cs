using EasyCall.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.modelo
{
    class Funcionario
    {
        static int idfuncionario;
        static int iddivida;
        static string login;
        static string senha;
        static string nome;
        static string CPF;
        static string email;

        public static void isLoginValido(string login, string senha)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if (dao.Logar(login,senha)
            {
                // chama a segunda tela
                MessageBox.Show("logado");
            }
            else
            {
                MessageBox.Show("usuario ou senha incorretos");
            }
            
        }

        public static void setFuncionario(string login, string senha)
        {
            // iniciar após login
            // seta dados do funcionario pegando do banco de dados
            // busca no banco
        }
    }
}
