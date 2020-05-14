﻿using EasyCall.DAO;
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
            var senha = criptografarSenha(txbSenha.Text);
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
            new FormAdmin().Show();
            this.Close();
        }

        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

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
    }
}
