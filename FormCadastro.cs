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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                var login = txbLogin.Text;
                if (String.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Preencher campo obrigatório 'LOGIN'");
                }

                //---------------------------
                var senha = Utilitarios.criptografarSenha(txbSenha.Text);
                if (String.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Preencher campo obrigatório 'SENHA'");
                }

                //---------------------------

                string cpf = txbCpf.Text;
                if (String.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Preencher campo obrigatório 'CPF'");
                }

                if (!Utilitarios.Validacoes.ValidaCPF(cpf))
                {
                    MessageBox.Show("cpf invalido");
                    return;
                }

                //---------------------------
                var tipo = txbTipo.Text;
                if (String.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Preencher campo obrigatório 'TIPO'");
                }

                //---------------------------
                var email = txbEmail.Text;
                if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Preencher campo obrigatório 'EMAIL'");
                }
                else
                {
                    var dao = new UsuarioDAO();
                    dao.insertUsuario(login, senha, email, cpf, tipo);
                }
                //--------------------------
                MessageBox.Show("Cadastrado com Sucesso");

            }
        }

        bool validarCampos()
        {
            if (String.IsNullOrEmpty(txbLogin.Text))
            {
                MessageBox.Show("Campo *login orbigatório");
                txbLogin.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Campo *senha obrigatório");
                txbSenha.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbCpf.Text))
            {
                MessageBox.Show("Campo *Cpf obrigatório");
                txbCpf.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txbEmail.Text))
            {
                MessageBox.Show("Campo *email obrigatório");
                txbEmail.Focus();
                return false;
            }


            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

    }
}