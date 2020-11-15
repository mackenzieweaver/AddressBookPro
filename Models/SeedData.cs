using AddressBookPro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookPro.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Contact.Any())
                {
                    return;
                }
                context.Contact.AddRange(
                    new Contact
                    {
                        FirstName = "Bobby",
                        LastName = "Davis",
                        Email = "bobby@davis.com",
                        Address1 = "1231 Shields Rd #5",
                        City = "Kernersville",
                        State = "North Carolina",
                        ZipCode = "27284",
                        Phone = "336-231-8632",
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        FirstName = "Antonio",
                        LastName = "Raynor",
                        Email = "antonio@raynor.com",
                        Address1 = "1400 Heartland Dr,",
                        City = "Kernersville",
                        State = "North Carolina",
                        ZipCode = "27284",
                        Phone = "336-993-7272",
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        FirstName = "Jason",
                        LastName = "Twitchell",
                        Email = "jason@twitchell.com",
                        Address1 = "915 Hwy 66 South",
                        City = "Kernersville",
                        State = "North Carolina",
                        ZipCode = "27284",
                        Phone = "336-993-5800",
                        DateAdded = DateTime.Now
                    },
                    new Contact
                    {
                        FirstName = "Drew",
                        LastName = "Russell",
                        Email = "drew@russell.com",
                        Address1 = "250 E Mountain St,",
                        City = "Kernersville",
                        State = "North Carolina",
                        ZipCode = "27284",
                        Phone = "336-992-0254",
                        DateAdded = DateTime.Now
                    }
                    //new Contact
                    //{
                    //    FirstName = "John",
                    //    LastName = "Doe",
                    //    Email = "john@doe.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Adam",
                    //    LastName = "Brooks",
                    //    Email = "adam@brooks.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Anthony",
                    //    LastName = "Duval",
                    //    Email = "anthony@duval.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Jackson",
                    //    LastName = "Holiday",
                    //    Email = "jackson@holiday.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Josh",
                    //    LastName = "Scott",
                    //    Email = "josh@scott.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Kenan",
                    //    LastName = "Bjelosevic",
                    //    Email = "kenan@bjelosevic.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //}
                    //new Contact
                    //{
                    //    FirstName = "MacColl",
                    //    LastName = "Nicolson",
                    //    Email = "maccoll@Nicolson.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Nathan",
                    //    LastName = "Frahmann",
                    //    Email = "nathan@frahmann.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Adrian",
                    //    LastName = "Edelin",
                    //    Email = "adrian@edelin.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Beau",
                    //    LastName = "Cunningham",
                    //    Email = "beau@cunningham.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Eli",
                    //    LastName = "Jones",
                    //    Email = "eli@jones.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Jessica",
                    //    LastName = "Hedenskog",
                    //    Email = "jessica@hedenskog.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Kit",
                    //    LastName = "Chau",
                    //    Email = "kit@chau.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Mackenzie",
                    //    LastName = "Weaver",
                    //    Email = "mackenzie@weaver.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Nick",
                    //    LastName = "Webb",
                    //    Email = "nick@webb.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Tony",
                    //    LastName = "Beavers",
                    //    Email = "tony@beavers.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Andres",
                    //    LastName = "Rivera",
                    //    Email = "andres@rivera.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Charles",
                    //    LastName = "Tincher",
                    //    Email = "charles@tincher.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Ethan",
                    //    LastName = "Jones",
                    //    Email = "ethan@jones.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Jonathan",
                    //    LastName = "Green",
                    //    Email = "jonathan@green.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Joseph",
                    //    LastName = "Green",
                    //    Email = "joseph@green.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Julio",
                    //    LastName = "Segarra",
                    //    Email = "julio@segarra.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Larry",
                    //    LastName = "Ashton",
                    //    Email = "larry@ashton.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Orlando",
                    //    LastName = "Olmo",
                    //    Email = "orlando@olmo.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Andrew",
                    //    LastName = "Albanese",
                    //    Email = "andrew@albanese.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Denis",
                    //    LastName = "Jojot",
                    //    Email = "denis@jojot.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Fred",
                    //    LastName = "Smith",
                    //    Email = "fred@smith.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Danny",
                    //    LastName = "Carroll",
                    //    Email = "danny@carroll.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Mark",
                    //    LastName = "Janicki",
                    //    Email = "mark@janicki.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Shyann",
                    //    LastName = "Jobe",
                    //    Email = "shyann@jobe.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //},
                    //new Contact
                    //{
                    //    FirstName = "Joshua",
                    //    LastName = "Peters",
                    //    Email = "joshua@peters.com",
                    //    Address1 = "1 First St,",
                    //    City = "Kernersville",
                    //    State = "North Carolina",
                    //    ZipCode = "27285",
                    //    Phone = "336-995-8159",
                    //    DateAdded = DateTime.Now
                    //}
                );
                context.SaveChanges();
            }
        }
    }
}
