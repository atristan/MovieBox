#region Includes

// .NET Libraries
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Creates an instance of EmailService to facilitate email functions within the system.
    /// </summary>
    public class EmailService
        : EmailConfigService
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of EmailService in the system.
        /// </summary>
        public EmailService()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Sends an email message and returns a success/failure flag.
        /// </summary>
        /// <param name="fields">An <see cref="EmailFields"/> instance with required parameters to send an email.</param>
        /// <returns><c>true</c> if the system was able to successfully send an email, otherwise <c>false</c>.</returns>
        public bool SendMessage(EmailFields fields)
        {
            bool result = false;
            result = SendMessage(GetMailMessage(fields));
            return result;
        }

        public bool SendMessage(MailMessage message)
        {
            bool isSuccess = false;
            try
            {
                using (SmtpClient client = new SmtpClient())
                {
                    NetworkCredential credentials = new NetworkCredential(GetSetting("SendingAccount"), GetSetting("SendingPassword"));
                    client.Credentials = credentials;
                    client.Host = GetSetting("SmtpHost");
                    client.Port = Int32.Parse(GetSetting("SmtpPort"));
                    client.EnableSsl = bool.Parse(GetSetting("EnableSsl"));
                    client.Send(message);
                }
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }

            return isSuccess;
        }

        public MailMessage GetMailMessage(EmailFields fields)
        {
            MailMessage result = new MailMessage();

            result.From = new MailAddress(fields.Sender);
            result.IsBodyHtml = fields.IsHtml;
            result.Priority = fields.Priority;
            result.Subject = fields.Subject;
            result.Body = fields.Body;
            result.Sender = new MailAddress(fields.Sender);

            foreach (Attachment attachment in fields.Attachments)
                result.Attachments.Add(attachment);

            foreach (string recipient in fields.Recipients)
                if (!string.IsNullOrEmpty(recipient))
                    result.To.Add(new MailAddress(recipient));

            foreach (string ccrecipient in fields.CcRecipients)
                if (!string.IsNullOrEmpty(ccrecipient))
                    result.CC.Add(new MailAddress(ccrecipient));

            foreach (string bccrecipient in fields.BccRecipients)
                if (!string.IsNullOrEmpty(bccrecipient))
                    result.Bcc.Add(new MailAddress(bccrecipient));

            foreach (string replyto in fields.ReplyTo)
                if (!string.IsNullOrEmpty(replyto))
                    result.ReplyToList.Add(new MailAddress(replyto));

            return result;
        }

        #endregion
    }
}
