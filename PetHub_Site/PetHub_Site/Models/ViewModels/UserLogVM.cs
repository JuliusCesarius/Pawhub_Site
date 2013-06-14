using System;
namespace PetHub_Site.Models.ViewModels
{
    public class UserLogVM
    {
        string LastActivity { get; set; }
        DateTime LastActivityDate { get; set; }
        Guid UserId { get; set; }
        int UserLogId { get; set; }
    }
}
