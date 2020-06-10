using EasyCall.modelo;
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
        private SmtpClient client;
        private static int PORTA = 587;

        public Email ()
        {
            
        }

        public void enviarEmail(string para, Divida divida)
        {
            this.client = new SmtpClient();
            this.client.Host = "smtp.gmail.com";
            this.client.Port = PORTA;
            this.client.EnableSsl = true;
            this.client.UseDefaultCredentials = false;
            this.client.Credentials = new NetworkCredential("easycall.project@gmail.com", "Toledo123");

            string anexo = verificaArquivo(divida);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("easycall.project@gmail.com");
            mail.To.Add(new MailAddress(para));
            mail.Body = "Mensagem automatica, não é necessario responder. Segue em anexo seu(s) boleto(s).";
            mail.Subject = "Negociacao de credito - EasyCall";
            mail.Attachments.Add(new Attachment(anexo));

            try
            {
                client.Send(mail);
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                //MessageBox.Show("email enviado com sucesso!");
                mail.Dispose();
                client.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // caso de erro
                MessageBox.Show("erro, tente novamente..");
                return;
            }
            else if (e.Cancelled)
            {
                // caso seja cancelado
                return;
            } 
            else
            {
                
            }
        }

        private string verificaArquivo(Divida divida)
        {
            string caminho = "Boleto-EasyCall.txt";

            if (File.Exists(caminho))
            {
                File.Delete(caminho);
            }
            
            StreamWriter sw = File.CreateText(caminho);
            sw.WriteLine("EasyCall negociações");
            sw.WriteLine();
            sw.WriteLine("Você esta recebendo esse email pois solicitou o envio do boleto");
            sw.WriteLine("Você precisa pagar: " + Utilitarios.calculoJuros(divida.valor, divida.dataVencimento).ToString("c"));
            sw.WriteLine("Data de vencimento: " + divida.dataVencimento.ToString("dd/MM/yyyy"));
            sw.Close();
            sw.Dispose();
            return caminho;
        }
    }
}
