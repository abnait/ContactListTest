using ContactList.Models;
using ContactList.Persistence.Context;
using System;

namespace ContactList.Services
{
    public class PersonRepository : IPersonRepository
    {
        private ContactListDbContext _context;
        public PersonRepository(ContactListDbContext context)
        {
            _context = context;
        }

        public List<Person> GetAll()
        {
            List<Person> persons;
            try
            {
                persons = _context.Set<Person>().OrderBy(p => p.PersonLastName).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return persons;
        }

        public bool SavePerson(Person person)
        { 
            try
            {
                
                _context.Add<Person>(person);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
