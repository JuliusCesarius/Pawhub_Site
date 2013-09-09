using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    public class Found : ReportDetail
    {
        public List<Breed> breeds { get; set; }
        public string size { get; set; }
    }
}
