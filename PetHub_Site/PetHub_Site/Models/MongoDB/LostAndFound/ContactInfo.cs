using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetHub_Site.Models.MongoDB.LostAndFound
{
    public class ContactInfo
    {
        public string name { get; set; }
        public string adress { get; set; }
        public List<string> email { get; set; }
        public List<string> phones { get; set; }
    }
}
