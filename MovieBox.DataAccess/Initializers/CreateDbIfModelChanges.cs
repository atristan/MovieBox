#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Mail;

// MovieBox Libraries
using Entities;
using Infrastructure;
using Infrastructure.Enums;
using MovieBox.DataAccess;
using Utilities;

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
                EmailAddresses = CreateEmails(),
                RentalHistory = CreateRentals()
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

        /// <summary>
        /// Creates a mock PhoneNumbers to seed.
        /// </summary>
        /// <returns></returns>
        private static PhoneNumbers CreateNumbers()
        {
            PhoneNumbers items = new PhoneNumbers();

            items.Add(new PhoneNumber()
            {
                AreaCode = 210,
                Prefix = 422,
                LineNumber = 1234,
                PhoneType = TypePhone.Home,
                CountryCodeType = TypeCountryCode.USA,
                Ordinality = TypeOrdinality.Primary
            });

            return items;
        }

        /// <summary>
        /// Creates a mock emails to seed.
        /// </summary>
        /// <returns></returns>
        private static Emails CreateEmails()
        {
            Emails items = new Emails();

            items.Add(new Email()
            {
                Address = "test123@test.com",
                OrdinalType = TypeOrdinality.Primary,
                UsageType = TypeUsage.Personal
            });

            return items;
        }

        /// <summary>
        /// Creates a mock rentals to seed.
        /// </summary>
        /// <returns></returns>
        private static Rentals CreateRentals()
        {
            Rentals items = new Rentals();

            items.Add(new Rental()
            {
                IsDamaged = false,
                DateRented = DateTime.Now,
                RatePerDay = 0.99,
                TrackingId = "1SD456C800-001",
                CheckedOut = CreateMovies()
            });

            return items;
        }

        /// <summary>
        /// Creates a mock movies to seed.
        /// </summary>
        /// <returns></returns>
        private static Movies CreateMovies()
        {
            Movies items = new Movies();

            items.Add(new Movie()
            {
                ReleaseDate = new DateTime(2014, 01, 18),
                Name = "I Origins",
                GenreType = TypeGenre.Drama,
                Actors = new People(),
                Directors = new People(),
                Producers = new People()
            });

            return items;
        }
    }
}
