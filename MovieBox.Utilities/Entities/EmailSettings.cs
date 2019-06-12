#region Includes

// .NET Libraries
using System.Net;
using System.Net.Mail;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Represents email settings in the system.
    /// </summary>
    public class EmailSettings
    {
        #region Properties

        /// <summary>
        /// Gets or sets flag to enable/disable ssl.
        /// </summary>
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets the port number of the SMTP host.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the sending email account address.
        /// </summary>
        public string SendingAccount { get; set; }

        /// <summary>
        /// Gets or sets the sending email account password.
        /// </summary>
        public string SendingPassword { get; set; }

        /// <summary>
        /// Gets or sets the SMTP host.
        /// </summary>
        public string SmtpHost { get; set; }

        #endregion
    }
}
