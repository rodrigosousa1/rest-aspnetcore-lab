using RestAspNetCoreLab.Model;
using RestAspNetCoreLab.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNetCoreLab.Repository.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PgSQLContext _context;

        public PersonRepository(PgSQLContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public void Delete(int id)
        {
            var person = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (person != null) _context.Persons.Remove(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            var personDb = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (personDb == null) return new Person();
            try
            {
                _context.Entry(personDb).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

            return person;

        }
    }
}

