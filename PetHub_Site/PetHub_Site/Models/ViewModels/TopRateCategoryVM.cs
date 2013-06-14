using System;
namespace PetHub_Site.Models.ViewModels
{
    public class TopRateCategoryVM
    {
        public short RateCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Petid { get; set; }
        public short Rates { get; set; }
        public string Picture { get; set; }
        public string PetName { get; set; }
    }
}
