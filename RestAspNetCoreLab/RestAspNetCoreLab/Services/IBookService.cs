using RestAspNetCoreLab.Model;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Services
{
    public interface IBookService
    {
        Book Create(Book book);
        Book FindById(int id);
        Book Update(Book book);
        List<Book> FindAll();
        void Delete(int id);
    }
}
