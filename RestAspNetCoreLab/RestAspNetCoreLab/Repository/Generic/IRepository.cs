using RestAspNetCoreLab.Model.Base;
using System.Collections.Generic;

namespace RestAspNetCoreLab.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T FindById(int id);
        T Update(T entity);
        List<T> FindAll();
        void Delete(int id);
    }
}
