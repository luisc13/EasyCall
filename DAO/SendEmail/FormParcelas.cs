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
        Email mail = new Email();
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

            for (int i = 0; i <= lbParcelas.SelectedIndex; i++)
            {
                //envia email d acordo com as parcelas selecionadas
                mail.enviarEmail(devedor.email, divida);
                await Task.Delay(1000);

                //registra na tabela de pagamentos
                var pmt = new Pagamento();
                pmt.valorParcela = divida.valor;
                pmt.vencimento = divida.dataVencimento;
                pmt.iddivida = divida.idDevedor;
                PagamentoDAO.SetPagamento(pmt);

                //mes de vencimento ++ para poder registrar e mandar emails com vencimentos diferentes
                divida.dataVencimento = divida.dataVencimento.AddMonths(1);
            }

            //atualiza status da divida para sair da lista de cobrança
            divida.status = "boleto emitido";
            DividaDAO.UpdateStatus(divida);

            //faz registro para gerar relatorio depois
            var registro = "Email enviado com o valor de " + divida.valor.ToString("c") + 
                "por parcela a ser pago, divido em " 
                + (lbParcelas.SelectedIndex + 1).ToString() + " vezes";
            RelatorioDAO.inserirRegistro(divida.idDivida, devedor.iddevedor, registro);
        }

        private void lbParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dividaplh = new Divida();
            dividaplh.dataVencimento = divida.dataVencimento;

            lblDataVencimento.Text = "";
            lblValor.Text = (divida.valor / (lbParcelas.SelectedIndex + 1)).ToString("c");

            for (int i = 0; i <= lbParcelas.SelectedIndex; i++)
            {
                lblDataVencimento.Text += dividaplh.dataVencimento.ToString("dd/MM/yyyy") + " ";
                dividaplh.dataVencimento = dividaplh.dataVencimento.AddMonths(1);
            }
        }

        private void tDesabilitaBtn_Tick(object sender, EventArgs e)
        {
            btnEnviar.Enabled = true;
            tDesabilitaBtn.Stop();
        }
    }
}
