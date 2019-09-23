using RestAspNetCoreLab.Model;
using RestAspNetCoreLab.Repository;
using RestAspNetCoreLab.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Services.Implementations
{
    public class BookService : IBookService
    {

        private readonly IRepository<Book> _repository;

        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
