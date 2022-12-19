using ContactList.Models;
using System.Collections.Generic;

namespace ContactList.Services
{
    public interface IPersonRepository
    {

        List<Person> GetAll();


        bool SavePerson(Person person);


    }
}