using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetHub_Site.Models.MongoDB.LostAndFound;
using blastic.mongodb.clases;

namespace PetHub_Site.Repositories
{
    public class LostAndFoundRepository : ObjectRepositoryBase<Report>
    {
        public LostAndFoundRepository()
            : base()
        {
        }
    }
}