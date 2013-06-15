using System;
namespace PetHub_Site.Models.ViewModels
{
    public class UserRateVM
    {
        public Guid PetId { get; set; }
        public short RateCategoryId { get; set; }
        public DateTime RateDate { get; set; }
        public double Stars { get; set; }
        public Guid UserId { get; set; }
    }
}
