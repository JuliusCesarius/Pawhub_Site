using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetVM
    {
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public PetCounterVM PetCounter { get; set; }
        public Guid PetId { get; set; }
        public PetProfileVM PetProfile { get; set; }
        public UserVM User { get; set; }
        public Guid UserId { get; set; }
    }
}
