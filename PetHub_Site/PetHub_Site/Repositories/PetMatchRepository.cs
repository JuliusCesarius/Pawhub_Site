using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cabinet.patterns.clases;
using PetHub_Site.Models;

namespace PetHub_Site.Repositories
{
    public class PetMatchRepository : RepositoryBase<UserRate, PawhubBDEntities> 
    {
        public PetMatchRepository()
            : base()
        {
        }
        public IEnumerable<UserRate> GetTopByUserId(Guid UserId, short RateCategoryId, short TopNumber)
        {
            return context.UserRates.Where(x => x.UserId == UserId && x.RateCategoryId == RateCategoryId).OrderByDescending(x=>x.Rating).Take(TopNumber);
        }
    }
}