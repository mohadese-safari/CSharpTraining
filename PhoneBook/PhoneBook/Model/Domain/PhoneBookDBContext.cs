using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PhoneBookApp.Model.Domain
{
    class PhoneBookDBContext : DbContext
    {
        public PhoneBookDBContext() : base("phonebook")
        {
            //Database.SetInitializer<StoreDbContext>(new <StoreDbContext>());
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhoneNumber> phoneNumbers { get; set; }

    }
}
