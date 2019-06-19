#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with email addresses in the system.
    /// </summary>
    public class EmailRepository
        : Repository<Email>, IEmailRepository
    {
        #region IEmailRepository Members

        /// <inheritdoc />
        public IEnumerable<Email> FindAllBy(string emailContains)
        {
            return DataContextFactory.GetDataContext().Set<Email>().Where(x => x.Address.Contains(emailContains));
        }

        #endregion
    }
}
