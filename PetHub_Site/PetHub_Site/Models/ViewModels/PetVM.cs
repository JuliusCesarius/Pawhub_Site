using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetVM
    {
        bool Active { get; set; }
        DateTime CreationDate { get; set; }
        string Name { get; set; }
        PetCounterVM PetCounter { get; set; }
        Guid PetId { get; set; }
        PetProfileVM PetProfile { get; set; }
        UserVM User { get; set; }
        Guid UserId { get; set; }
    }
}
