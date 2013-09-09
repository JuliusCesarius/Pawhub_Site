using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    public class UserAlert
    {
        public ObjectId _userId { get; set; }
        public string reportCode { get; set; }
    }
}