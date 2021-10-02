using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ObserverNotify.GmailService
{
    class Sending_Gmail
    {
        public static void SendMail(string mail,string name)
        {
            if (mail.Contains("@"))
            {
                string mailBodyhtml =
           $"<h1 style=\"color: #EB0008;\"> Your Product: {name} is already ready</h1><h1 style=\"color: #42A1D7;\"> User Name: {mail}</h1> <h2 style=\"color: #42A1D7;\">";
                var msg = new MailMessage("asoiuexam1920@gmail.com",mail,"Zor",mailBodyhtml);
                msg.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient($"smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential("asoiuexam1920@gmail.com","asoiuexam123321");
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(msg);
                }
                catch (Exception)
                {
                    MessageBox.Show($"<h1 style=\"color: #42A1D7;\">  An error occurred while sending your message. ");
                }
            }
        }
    }
}
