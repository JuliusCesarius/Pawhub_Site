using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetRateBasicVM
    {
        public Guid PetId { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string OwnerName { get; set; }
        public string RateName { get; set; }
        public short RateCategoryId { get; set; }
        public double Rating { get; set; }
        public short Votes { get; set; }
    }
}
