using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace WCFService.models
{
    public class Email
    {
        private string fromAddress;
        private string toAddress;
        private string fromPassword;
        private string subject;
        private string body;

        public Email()
        {
            this.fromAddress = "devprojetadr@gmail.com";
            this.fromPassword = "4zerty123";
            this.subject = "";
            this.body = "";
        }

        public string FromAddress { get => fromAddress; set => fromAddress = value; }
        public string ToAddress { get => toAddress; set => toAddress = value; }
        public string FromPassword { get => fromPassword; set => fromPassword = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Body { get => body; set => body = value; }

        public static void SendEmail(string userMail, string pdfpath)
        {
            Email email = new Email();
            email.toAddress = userMail;
            var smtp = SmtpSettings(email);
            MailMessage mailInfo = MailInfo(email, pdfpath);
            smtp.Send(mailInfo);
        }

        private static MailMessage MailInfo(Email email, string pdfPath)
        {
            MailMessage msg = new MailMessage();
            MailAddress ma = new MailAddress(email.FromAddress);
            msg.To.Add(email.ToAddress);
            msg.From = ma; msg.Subject = email.Subject;
            msg.Body = email.Body;
            msg.Attachments.Add(new Attachment(pdfPath));
            return msg;
        }

        private static SmtpClient SmtpSettings(Email email)
        {
            var smtp = new SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(email.FromAddress, email.FromPassword);
                smtp.Timeout = 20000;
            }
            return smtp;
        }


    }
}