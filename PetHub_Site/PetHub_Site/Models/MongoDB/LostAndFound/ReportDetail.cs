using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    [BsonKnownTypes(typeof(Abuse), typeof(Found), typeof(Lost), typeof(Resque))]
    public class ReportDetail : PetHub_Site.Models.MongoDB.LostAndFound.IReportDetail
    {
        public string dateEvent { get; set; }
        public string adress { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string characteristics { get; set; }
        public List<Picture> pics { get; set; }
    }
}
