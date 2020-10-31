using BmesRestApi.Database;
using BmesRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories.Implementations
{
    public class PersonRepository :IPersonRepository
    {
        private BmesDbContext _context;
        public PersonRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Person FindPersonById(long Id)
        {
            var person = _context.Persons.Find(Id);
            return person;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            var persons = _context.Persons;
            return persons;
        }

        public void SavePerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }
        public void UpdatePerson(Person person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
        }
        public void DeletePerson(Person person)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
    }
}
