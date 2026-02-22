using RentACarProject.DataAccessLayer.Abstract;
using RentACarProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccessLayer.Repostiries
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        RentContext context =new RentContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            context = new RentContext(); 
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity =context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
           var addedEntity =context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
           var updatedEntity =context.Entry(entity);
           updatedEntity.State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}
