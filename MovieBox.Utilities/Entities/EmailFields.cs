#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Represents email fields needed for sending an email in the system.
    /// </summary>
    public class EmailFields
    {
        #region Properties

        /// <summary>
        /// Gets or sets whether or not the email is HTML formatted.
        /// </summary>
        public bool IsHtml { get; set; }

        /// <summary>
        /// Gets or sets the internal identifier of the item.
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the sender of the email.
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Gets or sets the subject of an email message.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body of the message.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the body template root.
        /// </summary>
        public string BodyTemplateRoot { get; set; }

        /// <summary>
        /// Gets or sets the templates for the body of the email.
        /// </summary>
        public List<string> BodyTemplateFiles { get; set; }

        /// <summary>
        /// Gets or sets the reply to address.
        /// </summary>
        public List<string> ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the email priority.
        /// </summary>
        public MailPriority Priority { get; set; }

        /// <summary>
        /// Gets or sets the list of attachments to be added to an email.
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or sets a list of recipients.
        /// </summary>
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Gets or sets a list of CC recipients.
        /// </summary>
        public List<string> CcRecipients { get; set; }

        /// <summary>
        /// Gets or sets a list of BCC recipients.
        /// </summary>
        public List<string> BccRecipients { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of EmailFields in the system.
        /// </summary>
        public EmailFields()
        {
            Priority = MailPriority.Normal;
            Recipients = new List<string>();
            CcRecipients = new List<string>();
            BccRecipients = new List<string>();
            Attachments = new List<Attachment>();
            BodyTemplateFiles = new List<string>();
            ReplyTo = new List<string>();
        }

        #endregion
    }
}
