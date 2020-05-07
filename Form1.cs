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
                if (Usuario.fazerLogin(tbLogin.Text, tbSenha.Text))
                {
                    var tela2 = new Form2();
                    tela2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("usuario ou senha incorretos");
                }
            }
        }

        bool validaCampos(string login, string senha)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var backdoor = new Form2();
            backdoor.Show();
        }
    }
}