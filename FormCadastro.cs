using EasyCall.DAO;
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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
              var login = txbLogin.Text;
            if (String.IsNullOrEmpty(login) ) {
            MessageBox.Show("Preencher campo obrigatório 'LOGIN'");
            }
         
            //---------------------------
            var senha = txbSenha.Text;
            if (String.IsNullOrEmpty(senha) ) {
            MessageBox.Show("Preencher campo obrigatório 'SENHA'");
            }
          
            //---------------------------
            var cpf = txbCpf.Text;
            if (String.IsNullOrEmpty(cpf) ) {
            MessageBox.Show("Preencher campo obrigatório 'CPF'");
            }
         
            //---------------------------
            var tipo = txbTipo.Text;
            if (String.IsNullOrEmpty(tipo) ) {
            MessageBox.Show("Preencher campo obrigatório 'TIPO'");
            }
            
            //---------------------------
            var email = txbEmail.Text;
            if (String.IsNullOrEmpty(email) ) {
            MessageBox.Show("Preencher campo obrigatório 'EMAIL'");
            }
            else{
             var dao = new UsuarioDAO();
             dao.insertUsuario(login, senha, email, cpf, tipo);
            }
            //--------------------------
            MessageBox.Show("Cadastrado com Sucesso");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
