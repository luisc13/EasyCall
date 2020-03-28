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

        private void button1_Click(object sender, EventArgs e)
        {
            String ocr = TxbOcorrencia.Text;
            MessageBox.Show("Enviado com Sucesso");
            // registra ocorrencia
            this.Close();

        }
    }
}
