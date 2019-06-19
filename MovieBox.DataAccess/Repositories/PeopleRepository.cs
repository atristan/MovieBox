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
    /// A concrete repository to work with people in the system.
    /// </summary>
    public class PeopleRepository
        : Repository<Person>, IPeopleRepository
    {
        #region IPeopleRepository Members

        /// <inheritdoc />
        public IEnumerable<Person> FindByLastName(string lastName)
        {
            return DataContextFactory.GetDataContext().Set<Person>().Where(x => x.LastName == lastName);
        }

        #endregion
    }
}
