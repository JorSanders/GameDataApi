using System;
using System.Collections.Generic;

namespace Jorkol.GameDataApi.Core
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        IEnumerable<T> All();

        T Find(Guid id);

        IEnumerable<T> CreateOrUpdate(IEnumerable<T> items);

        T CreateOrUpdate(T item, bool save = true);

        void Delete(T item, bool save = true);

        void Delete(IEnumerable<T> items);
    }
}