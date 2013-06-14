using System;
namespace PetHub_Site.Models.ViewModels
{
    public class UserRateVM
    {
        Guid PetId { get; set; }
        short Rate1Star { get; set; }
        short Rate2Stars { get; set; }
        short Rate3Stars { get; set; }
        short Rate4Stars { get; set; }
        short Rate5Stars { get; set; }
        short RateCategoryId { get; set; }
        DateTime RateDate { get; set; }
        double Rating { get; set; }
        Guid UserId { get; set; }
    }
}
