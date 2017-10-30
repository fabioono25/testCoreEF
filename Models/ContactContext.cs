using System;
using Microsoft.EntityFrameworkCore;

namespace TestCoreEF.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            :base(options)
        {
        }

        public DbSet<Contact> Contacts {get; set;}
        public DbSet<Address> Addresses {get; set;}
    }
}