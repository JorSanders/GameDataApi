using System.Collections.Generic;
using System.Linq;

using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Models;
using Microsoft.Extensions.Logging;

namespace Jorkol.GameDataApi.ApexLegends.Repositories
{
    public class ApexMatchRepository : ApexBaseRepository, IApexMatchRepository
    {
        public ApexMatchRepository(ILogger<ApexMatchRepository> logger, ApexDbContext apexDbContext) : base(logger, apexDbContext)
        {
        }

        public IEnumerable<ApexMatch> All()
        {
            return apexDbContext.ApexMatches;
        }

        public IEnumerable<ApexMatch> CreateOrUpdate(IEnumerable<ApexMatch> apexMatches)
        {
            apexMatches.ToList().ForEach(apexMatch => CreateOrUpdate(apexMatch, false));
            int savedItems = apexDbContext.SaveChanges();
            logger.LogInformation($"Saved {savedItems} apexMatches");
            return apexMatches;
        }

        public ApexMatch CreateOrUpdate(ApexMatch apexMatch, bool save = true)
        {
            ApexMatch result = apexDbContext.ApexMatches.Find(apexMatch.ApexMatchId);
            if (result == null)
            {
                result = apexDbContext.ApexMatches.Add(apexMatch).Entity;
            }
            else
            {
                apexDbContext.ApexMatches.Update(result);
            }

            if (save)
            {
                int savedItems = apexDbContext.SaveChanges();
                logger.LogInformation($"Saved apexMatch");
            }
            return result;
        }
    }
}