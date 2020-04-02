using System;
using System.Collections.Generic;
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

        public async Task<bool> enviarEmail(string para)
        {
            bool ok = false;

            string items = null;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    items = dialog.FileName;
                }
            }

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("easycall.project@gmail.com");
            mail.To.Add(new MailAddress(para));
            mail.Body = "pague oque deve...";
            mail.Subject = "Negociação de credito - EasyCall";
            mail.Attachments.Add(new Attachment(items));

            try
            {
                await client.SendMailAsync(mail);
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ok;
        }
    }
}
