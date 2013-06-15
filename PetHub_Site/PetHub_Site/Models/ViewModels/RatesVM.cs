using System;
namespace PetHub_Site.Models.ViewModels
{
    public class RatesVM
    {
        public bool Active { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public short RateCategoryId { get; set; }
    }
}
