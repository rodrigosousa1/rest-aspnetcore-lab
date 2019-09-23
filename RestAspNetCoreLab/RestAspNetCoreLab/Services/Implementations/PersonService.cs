using RestAspNetCoreLab.Model;
using RestAspNetCoreLab.Repository;
using RestAspNetCoreLab.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Services.Implementations
{
    public class PersonService : IPersonService
    {

        private readonly IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
