using BmesRestApi.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories
{
    public interface IPersonRepository
    {
        Person FindPersonById(long Id);
        IEnumerable<Person> GetAllPersons();
        void SavePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);

    }
}
