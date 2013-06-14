using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetRateVM
    {
        DateTime LastRateDate { get; set; }
        PetVM Pet { get; set; }
        Guid PetId { get; set; }
        int PetRateId { get; set; }
        short Rate1Star { get; set; }
        short Rate2Stars { get; set; }
        short Rate3Stars { get; set; }
        short Rate4Stars { get; set; }
        short Rate5Stars { get; set; }
        RateCategory RateCategory { get; set; }
        short RateCategoryId { get; set; }
        double Rating { get; set; }
    }
}
