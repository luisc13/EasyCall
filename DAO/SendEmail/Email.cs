using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall.DAO
{
    class Email
    {
        private SmtpClient client = new SmtpClient();
        private static int PORTA = 587;

        public Email ()
        {
            this.client.Host = "smtp.gmail.com";
            this.client.Port = PORTA;
            this.client.EnableSsl = true;
            this.client.UseDefaultCredentials = false;
            this.client.Credentials = new NetworkCredential("easycall.project@gmail.com", "Toledo123");
        }

        public async Task<bool> enviarEmail(string para, double valorParcela)
        {
            bool ok = false;

            string anexo = verificaArquivo(valorParcela);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("easycall.project@gmail.com");
            mail.To.Add(new MailAddress(para));
            mail.Body = "Mensagem automatica - segue aqui o boleto...";
            mail.Subject = "Negociacao de credito - EasyCall";
            mail.Attachments.Add(new Attachment(anexo));

            try
            {
                await client.SendMailAsync(mail);
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ok;
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // caso de erro
            }
            else if (e.Cancelled)
            {
                // caso seja cancelado
            }
        }

        private string verificaArquivo(double valorParcela)
        {
            string caminho = "Anexo.txt";
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
            }
            StreamWriter sw = File.CreateText(caminho);
            sw.WriteLine("EasyCall negociações");
            sw.WriteLine();
            sw.WriteLine("Você esta recebendo esse email pois solicitou o envio do boleto");
            sw.WriteLine("Você precisa pagar: R$" + valorParcela);
            sw.Close();
            return caminho;
        }
    }
}
