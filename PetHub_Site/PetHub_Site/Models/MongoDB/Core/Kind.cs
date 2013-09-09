using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using blastic.mongodb.interfaces;

namespace PetHub_Site.Models.MongoDB.Core.Core
{
    public class Kind:IBson
    {
        public global::MongoDB.Bson.ObjectId _id { get; set; }

        public Picture pic { get; set; }
        public List<Breed> breeds { get; set; }
        public MultilingualContent name { get; set; }
        public MultilingualContent description { get; set; }
    }
}