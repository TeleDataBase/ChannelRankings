using System.Collections.Generic;
using ChannelRankins.Contracts.Data;
using System.Data.Entity;

namespace ChannelRankings.Data
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public GenericRepository(IDbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        protected IDbContext Context { get; set; }

        protected IDbSet<T> DbSet { get; set; }

        public IEnumerable<T> GetAll()
        {
            return this.DbSet;
        }

        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
        }

        public void Delete(T entity)
        {
            //this.DbSet.Remove(entity);
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }
    }
}
