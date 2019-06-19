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
    /// A concrete repository to work with addresses in the system.
    /// </summary>
    public class AddressRepository
        : Repository<Address>, IAddressRepository
    {
        #region IAddressRepository Members

        /// <inheritdoc />
        public IEnumerable<Address> FindByAddressComponent(string addressComponentValue, TypeAddressComponent addressComponentType)
        {
            IEnumerable<Address> results = null;

            switch (addressComponentType)
            {
                case TypeAddressComponent.City:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.City.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.Country:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.Country.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.County:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.County.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.Street1:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.Street1.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.Street2:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.Street2.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.Street3:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.Street3.Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.Zip4:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.Zip4.ToString().Contains(addressComponentValue));
                    break;
                case TypeAddressComponent.ZipCode:
                    results = DataContextFactory.GetDataContext().Set<Address>()
                        .Where(x => x.ZipCode.ToString().Contains(addressComponentValue));
                    break;
            }

            return results;
        }

        #endregion
    }
}
