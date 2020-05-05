using EasyCall.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.modelo
{
    class Usuario
    {
        public static int idFuncionario;
        public static string login;
        public static string senha;
        public static string cpf;
        public static string email;
        public static string tipo;

        public static bool fazerLogin(string login, string senha)
        {
            bool isValid = false;
            var dao = new UsuarioDAO();
            if (dao.Logar(login,senha))
            {
                isValid = true;
            }
            return isValid;
        }

    }
}
