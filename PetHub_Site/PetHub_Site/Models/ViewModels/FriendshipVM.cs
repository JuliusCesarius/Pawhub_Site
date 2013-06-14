using System;
namespace PetHub_Site.Models.ViewModels
{
    public class FriendshipVM
    {
        public DateTime? ApprovalDate { get; set; }
        public bool Approved { get; set; }
        public Guid Id { get; set; }
        public bool IsPet { get; set; }
        public DateTime RequestDate { get; set; }
        public Guid UserRequestId { get; set; }
    }
}
