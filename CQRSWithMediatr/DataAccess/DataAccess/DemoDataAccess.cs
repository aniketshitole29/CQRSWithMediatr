using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Aniket", LastName = "Shitole" });
            people.Add(new PersonModel { Id = 2, FirstName = "Kamlesh", LastName = "Jadhav" });
            people.Add(new PersonModel { Id = 3, FirstName = "Sahil", LastName = "Shinde" });
        }

        public bool DeletePersonById(int id)
        {
            people.Remove(GetPeopleById(id));
            return true;
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }
        public PersonModel GetPeopleById(int id)
        {
            var result = people.FirstOrDefault(x => x.Id == id);
            var res = result == null ? new PersonModel() : result;
            return res;
        }
        public PersonModel InsertPerson(string firstNamr, string lastName)
        {
            var id = people.Max(i => i.Id) + 1;
            var person = new PersonModel { Id = id, FirstName = firstNamr, LastName = lastName };
            people.Add(person);
            return person;
        }

        public PersonModel UpdatePerson(PersonModel person)
        {
            var item = people.FirstOrDefault(p => p.Id == person.Id);
            if (item != null)
            {
                item.LastName = person.LastName;
                item.FirstName = person.FirstName;
                return item;
            }
            return new PersonModel();
        }
    }
}
