using System;
using System.Collections.Generic;
using PetHub_Site.Models.ViewModels;
namespace PetHub_Site.Models.ViewModels
{
    public class UserVM
    {
        public string EmailId { get; set; }
        public bool Online { get; set; }
        public string Password { get; set; }
        public IEnumerable<PetVM> Pets { get; set; }
        public string Picture { get; set; }
        public ProfileVM Profile { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
    }
}
