using System;
using System.Collections.Generic;
using System.Text;
using Work.Core.Application;

namespace Work.Infrastructure.Data.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext context;
        public Repository(DataContext context)
        {
            this.context = context;
        }


        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            context.Set<T>().Remove(context.Set<T>().Find(id));
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> Get()
        {
            return context.Set<T>();
        }

        public void Update(int id, T entity)
        {
            context.Update(entity);
        }
    }
}
