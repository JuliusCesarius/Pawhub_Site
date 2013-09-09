using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    public class Resque:ReportDetail
    {
        public ContactInfo contactInfo { get; set; }
    }
}
