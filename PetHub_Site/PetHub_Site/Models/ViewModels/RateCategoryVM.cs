using System;
namespace PetHub_Site.Models.ViewModels
{
    public class RateCategoryVM
    {
        bool Active { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        short RateCategoryId { get; set; }
    }
}
