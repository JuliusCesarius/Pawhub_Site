using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class PetOwnerHistoryVM
    {
        public DateTime AssignDate { get; set; }
        public DateTime? DeassociateDate { get; set; }
        public Guid PetId { get; set; }
        public int PetOwnerHistoryId { get; set; }
        public Guid UserId { get; set; }
    }
}
