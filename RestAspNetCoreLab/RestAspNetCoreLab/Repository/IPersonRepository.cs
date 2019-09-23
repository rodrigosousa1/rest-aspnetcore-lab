using RestAspNetCoreLab.Model;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(int id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(int id);
    }
}
