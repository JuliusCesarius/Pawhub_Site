using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using blastic.mongodb.interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PetHub_Site.Models.MongoDB.Core
{
    public class User : IBson
    {
        public global::MongoDB.Bson.ObjectId _id { get; set; }

        public string username { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public bool online { get; set; }
        public short petcoins { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime date { get; set; }

        public Picture pic { get; set; }
        public List<ObjectId> friends { get; set; }
        public List<ObjectId> requests { get; set; }
    }
}