using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using blastic.mongodb.interfaces;
using MongoDB.Bson;

namespace PetHub_Site.Models.MongoDB.Core
{
    public class Location
    {
        public string latitud { get; set; }
        public string longitud { get; set; }
    }
}
