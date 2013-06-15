using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetBasicVM
    {
        public string Name { get; set; }
        public PetCounterVM PetCounter { get; set; }
        public Guid PetId { get; set; }
        public string Picture { get; set; }
        public Guid UserId { get; set; }
    }
}
