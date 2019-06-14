﻿#region Includes

// MovieBox Libraries
using Infrastructure;
using Utilities;

#endregion

namespace Entities
{
    public class UsAddress
        : AddressBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the country code type.
        /// </summary>
        public TypeCountryCode CountryCodeType => TypeCountryCode.USA;

        /// <summary>
        /// Gets or sets the US state type.
        /// </summary>
        public TypeUsState UsStateType { get; set; }

        #endregion
    }
}
