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
            MessageBox.Show(email.enviarEmail("gunais1234@gmail.com").ToString());

            this.Close();

        }
    }
}
