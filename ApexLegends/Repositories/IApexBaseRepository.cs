using System.Collections.Generic;
using System.Threading.Tasks;
using Jorkol.GameDataApi.ApexLegends.Models;
using Jorkol.GameDataApi.TrackerNetworkClient.Models;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public interface IApexBaseRepository<T>
    {
        IEnumerable<T> All();
        T CreateOrUpdate(T item, bool save = true);
        IEnumerable<T> CreateOrUpdate(IEnumerable<T> items);
    }
}