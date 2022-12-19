using ContactList.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Persistence.Context
{
    public class ContactListDbContext : DbContext
    {
        public ContactListDbContext(DbContextOptions options) : base(options) { }
        DbSet<Person> Persons
        {
            get;
            set;
        }
    }
}