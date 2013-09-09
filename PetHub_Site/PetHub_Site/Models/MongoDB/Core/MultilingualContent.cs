using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHub_Site.Models.MongoDB.Core
{
    public class MultilingualContent
    {
        public List<Content> contents { get; set; }
    }
    public class Content
    {
        public string culture { get; set; }
        public string content { get; set; }
    }
}