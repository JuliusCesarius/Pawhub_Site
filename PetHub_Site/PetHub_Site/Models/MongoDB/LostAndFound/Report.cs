using System;
using System.ComponentModel;
using blastic.mongodb.interfaces;
using MongoDB.Bson;
using System.Collections.Generic;
using PetHub_Site.Models.MongoDB.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    [BsonIgnoreExtraElements]
    public class Report : IBson
    {
        public global::MongoDB.Bson.ObjectId _id { get; set; }
        public ObjectId _userId { get; set; }

        public string description { get; set; }
        public string picture { get; set; }
        public int linkedTo { get; set; }
        public string reportCode { get; set; }
        public int sharedCount { get; set; }
        public bool solved { get; set; }
        public int viewBy2 { get; set; }


        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime date { get; set; }

        public List<Comment> comments { get; set; }
        public List<ObjectId> alertTo { get; set; }
        public Location location { get; set; }

        public IReportDetail detail { get; set; }
    }
}
