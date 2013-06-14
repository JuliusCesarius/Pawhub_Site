using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PrivacyVM
    {
        short Address { get; set; }
        short Feed { get; set; }
        short Pics { get; set; }
        short Profile { get; set; }
        UserVM User { get; set; }
        Guid UserId { get; set; }
    }
}
