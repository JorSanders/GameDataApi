using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public abstract class ApexBaseRepository<T> : IApexBaseRepository<T> where T : ApexBaseModel
    {
        protected readonly ApexDbContext apexDbContext;

        protected object Model;

        public ApexBaseRepository(ApexDbContext apexDbContext)
        {
            this.apexDbContext = apexDbContext;
        }

        protected DbSet<T> DbSet()
        {
            return apexDbContext.Set<T>();
        }

        public virtual IEnumerable<T> All()
        {
            return DbSet();
        }

        public virtual T CreateOrUpdate(T item, bool save = true)
        {
            T result = Find(item);
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
                int savedItems = apexDbContext.SaveChanges();
            }
            return result;
        }

        public virtual T Find(T item)
        {
            return DbSet().Find(item.Id);
        }

        public virtual IEnumerable<T> CreateOrUpdate(IEnumerable<T> items)
        {
            items.ToList().ForEach(item => CreateOrUpdate(item, false));
            int savedItems = apexDbContext.SaveChanges();
            return items;
        }
    }
}