using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (validaCampos(tbLogin.Text, tbSenha.Text))
            {
                if (Funcionario.fazerLogin(tbLogin.Text, tbSenha.Text))
                {
                    // chama a segunda tela
                    MessageBox.Show("logado");
                }
                else
                {
                    MessageBox.Show("usuario ou senha incorretos");
                }
            }
        }

        bool validaCampos(string login, string senha)
        {
            bool isValid = true;
            if (login.Equals("") || login == null || senha.Equals("") || senha == null)
            {
                MessageBox.Show("*Campos obrigatorios não preenchidos");
                isValid = false;
            }
            return isValid;
        }
    }
}
