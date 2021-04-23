using System.Collections.Generic;

namespace Jorkol.GameDataApi.Core
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> All();
        T CreateOrUpdate(T item, bool save = true);
        IEnumerable<T> CreateOrUpdate(IEnumerable<T> items);
        T Find(T item);
    }
}