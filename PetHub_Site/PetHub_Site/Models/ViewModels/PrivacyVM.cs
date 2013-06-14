using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PrivacyVM
    {
        public short Address { get; set; }
        public short Feed { get; set; }
        public short Pics { get; set; }
        public short Profile { get; set; }
        public UserVM User { get; set; }
        public Guid UserId { get; set; }
    }
}
