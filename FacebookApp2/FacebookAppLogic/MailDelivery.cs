using System.Collections.Generic;
using System.Net.Mail;

namespace FacebookAppLogic
{
    public class MailDelivery
    {
        private const string k_senderMail = "facebookapp.designpatterns@gmail.com";
        private const string k_password = "power4us";
        private const string k_subject = "Your resume";
        private const string k_depaultbody = "mail with attachment";
        private const string k_smtpClient = "smtp.gmail.com";
        private const int k_Port = 587;

        public MailMessage Message { get; set; }

        public SmtpClient SmtpClient { get; set; }

        public Dictionary<string, Attachment> Attachments;

        public MailDelivery(string i_To)
        {
            Message = new MailMessage(k_senderMail, i_To, k_subject, k_depaultbody);
            Attachments = new Dictionary<string, Attachment>();
        }

        public MailDelivery(string i_To, string i_subject, string i_message)
        {
            Message = new MailMessage(k_senderMail, i_To, i_subject, i_message);
            Attachments = new Dictionary<string, Attachment>();
        }

        public void Send()
        {
            ////final operations before send the mail!
            ////Add all the attachments!
            foreach(KeyValuePair<string, Attachment> Attachment in Attachments)
            {
                Message.Attachments.Add(Attachment.Value);
            }

            SmtpClient = new SmtpClient(k_smtpClient, k_Port);
            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.Credentials = new System.Net.NetworkCredential(k_senderMail, k_password);
            SmtpClient.EnableSsl = true;

            ////Finally - SEND
            SmtpClient.Send(this.Message);
        }

        /* Add To The Message Body another message  */
        public void AddMessage(string i_Body)
        {
            this.Message.Body += i_Body;
        }

        /* Change The Message Body  */
        public void ChangeMessage(string i_Body)
        {
            this.Message.Body = i_Body;
        }

        /* Change The Message Subject */
        public void ChangeSubject(string i_Subject)
        {
            this.Message.Subject = i_Subject;
        }

        /* Add an attachment */
        public void AddAttachment(string i_FilePath)
        {
            Attachments.Add(i_FilePath, new Attachment(i_FilePath));
        }

        /* Remove an attachment */
        public void RemoveAttachment(string i_FilePath)
        {
            Attachments.Remove(i_FilePath);
        }
    }
}
