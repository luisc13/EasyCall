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

namespace EasyCall.DAO.SendEmail
{
    public partial class FormParcelas : Form
    {
        Devedor devedor;
        Divida divida;
        public FormParcelas(Divida divida, Devedor devedor)
        {
            InitializeComponent();
            this.devedor = devedor;
            this.divida = divida;
        }

        private void FormParcelas_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++)
            {
                lbParcelas.Items.Add("Parcelar em " + i + "x");
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            tDesabilitaBtn.Tick += tDesabilitaBtn_Tick;
            tDesabilitaBtn.Start();
            btnEnviar.Enabled = false;

            divida.valor = (divida.valor / (lbParcelas.SelectedIndex + 1));
            Email mail = new Email();
            await mail.enviarEmail(devedor.email, divida);

            var registro = "Email enviado com o valor a ser pago";
            RelatorioDAO.inserirRegistro(divida.idDivida, devedor.iddevedor, registro);
        }

        private void lbParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = (divida.valor / (lbParcelas.SelectedIndex + 1)).ToString("c");

        }

        private void tDesabilitaBtn_Tick(object sender, EventArgs e)
        {
            btnEnviar.Enabled = true;
            tDesabilitaBtn.Stop();
        }
    }
}
