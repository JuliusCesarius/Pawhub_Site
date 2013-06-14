using System;
namespace PetHub_Site.Models.ViewModels
{
    public class UserLogVM
    {
        public string LastActivity { get; set; }
        public DateTime LastActivityDate { get; set; }
        public Guid UserId { get; set; }
        public int UserLogId { get; set; }
    }
}
