using System;
namespace PetHub_Site.Models.ViewModels
{
    public class FriendshipVM
    {
        DateTime? ApprovalDate { get; set; }
        bool Approved { get; set; }
        Guid Id { get; set; }
        bool IsPet { get; set; }
        DateTime RequestDate { get; set; }
        Guid UserRequestId { get; set; }
    }
}
