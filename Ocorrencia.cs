using EasyCall.DAO;
using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall
{
    public partial class Ocorrencia : Form
    {
        public Ocorrencia()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            String ocr = TxbOcorrencia.Text;
            // registra ocorrencia

            var email = new Email();
            await email.enviarEmail(ocr);

            
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();
            SqlDataReader dr;

            cmd.CommandText = "INSERT INTO DIVIDA(Ocorrencia) VALUES (@ocorrencia)";
            cmd.Parameters.AddWithValue("@ocorrencia", ocr);
            this.Close();
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
