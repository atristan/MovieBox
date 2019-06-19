#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.Linq;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with companies in the system.
    /// </summary>
    public class CompanyRepository
        : Repository<Company>, ICompanyRepository
    {
        #region ICompanyRepository

        /// <inheritdoc />
        public IEnumerable<Company> FindByName(string name)
        {
            return DataContextFactory.GetDataContext().Set<Company>().Where(x => x.Name.Contains(name));
        }

        #endregion
    }
}
