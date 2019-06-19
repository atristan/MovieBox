#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.Linq;

// MovieBox Libraries
using Entities;
using Infrastructure;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with phone numbers in the system.
    /// </summary>
    public class PhoneNumberRepository
        : Repository<PhoneNumber>, IPhoneNumberRepository
    {
        #region IPhoneNumberRepository Members

        /// <inheritdoc />
        public IEnumerable<PhoneNumber> FindAllBy(int numberComponentValue, TypePhoneNumberComponent numberComponentType)
        {
            IEnumerable<PhoneNumber> results = null;

            switch (numberComponentType)
            {
                case TypePhoneNumberComponent.AreaCode:
                    results = DataContextFactory.GetDataContext().Set<PhoneNumber>()
                        .Where(x => x.AreaCode == numberComponentValue);
                    break;
                case TypePhoneNumberComponent.CountryCode:
                    results = DataContextFactory.GetDataContext().Set<PhoneNumber>()
                        .Where(x => (int)x.CountryCodeType == numberComponentValue);
                    break;
                case TypePhoneNumberComponent.Extension:
                    results = DataContextFactory.GetDataContext().Set<PhoneNumber>()
                        .Where(x => x.Extension == numberComponentValue);
                    break;
                case TypePhoneNumberComponent.LineNumber:
                    results = DataContextFactory.GetDataContext().Set<PhoneNumber>()
                        .Where(x => x.LineNumber == numberComponentValue);
                    break;
                case TypePhoneNumberComponent.Prefix:
                    results = DataContextFactory.GetDataContext().Set<PhoneNumber>()
                        .Where(x => x.Prefix == numberComponentValue);
                    break;
            }

            return results;
        }

        #endregion
    }
}
