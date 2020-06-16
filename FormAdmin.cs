using EasyCall.CarregarDados;
using EasyCall.modelo;
using EasyCall.Relatorio;
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            var telaCadastro = new FormCadastro();
            telaCadastro.Show();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            new FormEscolherEmpresa().Show();
        }

        private void btnGerarR_Click(object sender, EventArgs e)
        {
            new FormOptions().Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lbBemVindo.Text += " " + Usuario.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaLogin = new FormLogin();
            telaLogin.Show();
            this.Dispose();
            
        }
    }
}
