#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Mail;

// MovieBox Libraries
using Entities;
using MovieBox.DataAccess;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A custom implementation of MovieBoxContext that creates a new person with address details.
    /// </summary>
    public class CreateDbIfModelChanges
        : DropCreateDatabaseIfModelChanges<MovieBoxContext>
    {
        /// <summary>
        /// Creates a new customer in the system.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MovieBoxContext context)
        {
            Customer person = new Customer()
            {
                DateCreated = DateTime.Now,
                MemberStartDate = DateTime.Now,
                CustomerId = "test1234",
                FirstName = "Ima",
                MiddleName = "Test",
                LastName = "User",
                MailingAddresses = CreateAddresses(),
                Numbers = CreateNumbers(),
                EmailAddresses = CreateEmails,
                RentalHistory = CreateRentals
            };

            
            base.Seed(context);
        }

        /// <summary>
        /// Creates a mock address to seed 
        /// </summary>
        /// <returns></returns>
        private static Addresses CreateAddresses()
        {
            Addresses items = new Addresses();

            items.Add(new Address()
            {
                ZipCode = 78260,
                Street1 = "123 Broadway",
                City = "San Antonio",
                County = "Bexar",
                Country = "USA",
                StateOrProvince = "TX"
            });

            return items;
        }
    }
}
