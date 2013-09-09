using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PetHub_Site.Models.MongoDB.Core
{
    public class Comment
    {
        public string content { get; set; }
        public ObjectId _userId { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime date { get; set; }
    }
}
