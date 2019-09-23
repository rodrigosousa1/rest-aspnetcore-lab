using Microsoft.EntityFrameworkCore;
using RestAspNetCoreLab.Model.Base;
using RestAspNetCoreLab.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNetCoreLab.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly PgSQLContext _context;
        private DbSet<T> dbSet;

        public GenericRepository(PgSQLContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }
        public T Create(T entity)
        {
            try
            {
                dbSet.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public void Delete(int id)
        {
            var entity = dbSet.AsNoTracking().SingleOrDefault(e => e.Id == id);
            try
            {
                if (entity != null) dbSet.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindAll()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public T FindById(int id)
        {
            return dbSet.AsNoTracking().SingleOrDefault(e => e.Id == id);
        }

        public T Update(T entity)
        {
            var entityDb = dbSet.AsNoTracking().SingleOrDefault(e => e.Id == entity.Id);

            if (entityDb == null) return null;
            try
            {
                _context.Entry(entityDb).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

            return entity;
        }
    }
}
