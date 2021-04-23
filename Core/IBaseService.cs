using System;
using System.Collections.Generic;

namespace Jorkol.GameDataApi.Core
{
    public interface IBaseService<T> where T : EntityBase
    {
        IEnumerable<T> All();

        T Find(Guid id);

        T Save(T item);

        IEnumerable<T> Save(IEnumerable<T> items);

        void Delete(T item);

        void Delete(IEnumerable<T> items);
    }
}