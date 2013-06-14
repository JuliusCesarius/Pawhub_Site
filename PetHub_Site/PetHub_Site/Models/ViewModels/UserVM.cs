using System;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class UserVM
    {
        string EmailId { get; set; }
        bool Online { get; set; }
        string Password { get; set; }
        IEnumerable<PetVM> Pets { get; set; }
        string Picture { get; set; }
        ProfileVM Profile { get; set; }
        Guid UserId { get; set; }
        string UserName { get; set; }
    }
}
