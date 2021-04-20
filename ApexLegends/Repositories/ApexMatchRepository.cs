using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexMatchRepository : ApexBaseRepository, IApexMatchRepository
    {
        public ApexMatchRepository(ILogger<ApexMatchRepository> logger) : base(logger)
        {
        }

        public IEnumerable<ApexMatch> All()
        {
            return apexDbContext.ApexMatches;
        }

        public void Save(IEnumerable<ApexMatch> apexMatches)
        {
            apexDbContext.ApexMatches.AddRange(apexMatches);
            int savedItems = apexDbContext.SaveChanges();
            logger.LogInformation($"Saved {savedItems} apexMatches");
        }

        public IEnumerable<ApexMatch> CreateOrUpdate(IEnumerable<ApexMatch> apexMatches)
        {
            apexMatches.ToList().ForEach(apexMatch => CreateOrUpdate(apexMatch));

            return apexMatches;
        }

        public ApexMatch CreateOrUpdate(ApexMatch apexMatch)
        {
            ApexMatch result = apexDbContext.ApexMatches.Find(apexMatch.ApexMatchId);
            if (result == null)
            {
                result = apexDbContext.ApexMatches.Add(apexMatch).Entity;
            }
            return result;
        }
    }
}