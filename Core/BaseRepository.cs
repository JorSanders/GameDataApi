using System;
using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.Core
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        protected readonly DbContext dbContext;

        protected object Model;

        public BaseRepository(DbContext apexDbContext)
        {
            this.dbContext = apexDbContext;
        }

        protected DbSet<T> DbSet()
        {
            return dbContext.Set<T>();
        }

        public virtual IEnumerable<T> All()
        {
            return DbSet().ToList();
        }

        public virtual T Find(Guid id)
        {
            return DbSet().Find(id);
        }

        public virtual T CreateOrUpdate(T item, bool save = true)
        {
            T result = Find(item.Id);
            if (result == null)
            {
                result = DbSet().Add(item).Entity;
            }
            else
            {
                result = DbSet().Update(result).Entity;
            }

            if (save)
            {
                int savedItems = dbContext.SaveChanges();
            }
            return result;
        }

        public virtual IEnumerable<T> CreateOrUpdate(IEnumerable<T> items)
        {
            items.ToList().ForEach(item => CreateOrUpdate(item, false));
            int savedItems = dbContext.SaveChanges();
            return items;
        }

        public virtual void Delete(T item, bool save = true)
        {
            DbSet().Remove(item);
            dbContext.SaveChanges();
        }

        public virtual void Delete(IEnumerable<T> items)
        {
            items.ToList().ForEach(item => this.Delete(item, false));
            dbContext.SaveChanges();
        }

    }
}