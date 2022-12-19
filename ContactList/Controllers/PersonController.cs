using ContactList.Models;
using ContactList.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {   
            List<Person> persons = _personRepository.GetAll();
            foreach(Person person in persons)
            {
                var age = DateTime.Now - person.PersonBirthday;
                person.Age = System.Convert.ToInt32(age.TotalDays / 365);
            }
            return Ok(persons);
            
        }

        [HttpPost(Name = "SavePerson")]
        public IActionResult SavePerson(Person person)
        {
            var age = DateTime.Now - person.PersonBirthday;
            if (age.TotalDays / 365 > 150)
            {
                return Ok("You are old");
            }
            _personRepository.SavePerson(person);
            return Ok("Inserted");
        }
    }
}