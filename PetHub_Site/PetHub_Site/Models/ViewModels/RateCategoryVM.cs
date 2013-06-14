using System;
namespace PetHub_Site.Models.ViewModels
{
    public class RateCategoryVM
    {
        public bool Active { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public short RateCategoryId { get; set; }
    }
}
