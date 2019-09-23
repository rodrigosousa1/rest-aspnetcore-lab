using RestAspNetCoreLab.Model;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(int id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(int id);
    }
}
