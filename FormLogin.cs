using EasyCall.DAO;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                string senha = Utilitarios.criptografarSenha(tbSenha.Text);
                if (Usuario.fazerLogin(tbLogin.Text, senha))
                {
                    if (Usuario.tipo.Equals("admin"))
                    {
                        var telaAdmin = new FormAdmin();
                        telaAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        var tela2 = new FormCobranca();
                        tela2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("usuario ou senha incorretos");
                }
            }
        }

        bool validaCampos()
        {
            if (String.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Campo *login orbigatório");
                tbLogin.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("Campo *senha obrigatório");
                tbSenha.Focus();
                return false;
            }
            return true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbLogin;
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}