using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class PetOwnerHistoryVM
    {
        DateTime AssignDate { get; set; }
        DateTime? DeassociateDate { get; set; }
        Guid PetId { get; set; }
        int PetOwnerHistoryId { get; set; }
        Guid UserId { get; set; }
    }
}
