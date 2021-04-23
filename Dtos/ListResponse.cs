using System.Collections.Generic;
using System.Linq;
using Jorkol.GameDataApi.ApexLegends.Models;

namespace Jorkol.GameDataApi.Dtos
{
    public class ListResponse<T>
    {
        public ListResponse(IEnumerable<T> items)
        {
            this.Items = items;
        }

        public int Total
        {
            get
            {
                if (Items == null)
                {
                    return 0;
                }
                return Items.ToList().Count();
            }
        }
        public IEnumerable<T> Items { get; set; }
    }
}