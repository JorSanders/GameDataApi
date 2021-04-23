using System;
using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.EntityFrameworkCore;

namespace Jorkol.GameDataApi.Core
{
    public abstract class BaseService<TRepository, TEntity> where TRepository : IBaseRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly TRepository repository;

        protected object Model;

        public BaseService(TRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> All()
        {
            return repository.All();
        }

        public TEntity Find(Guid id)
        {
            return repository.Find(id);
        }

        public TEntity Save(TEntity item)
        {
            return repository.CreateOrUpdate(item);
        }

        public IEnumerable<TEntity> Save(IEnumerable<TEntity> items)
        {
            return repository.CreateOrUpdate(items);
        }

        public void Delete(TEntity item)
        {
            repository.Delete(item);
        }

        public void Delete(IEnumerable<TEntity> items)
        {
            repository.Delete(items);
        }
    }
}