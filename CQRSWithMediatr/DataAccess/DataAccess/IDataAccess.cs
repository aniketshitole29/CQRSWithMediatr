using DataAccess.Model;

namespace DataAccess.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel GetPeopleById(int id);
        PersonModel InsertPerson(string firstNamr, string lastName);
        PersonModel UpdatePerson(PersonModel person);
        bool DeletePersonById(int id);
    }
}