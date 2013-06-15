using System;
namespace PetHub_Site.Models.ViewModels
{
    public class RateAPetVM
    {
        public Guid PetId { get; set; }
        public short Rate1Star { get; set; }
        public short Rate2Stars { get; set; }
        public short Rate3Stars { get; set; }
        public short Rate4Stars { get; set; }
        public short Rate5Stars { get; set; }
        public short RateCategoryId { get; set; }
        public DateTime RateDate { get; set; }
        public double Rating { get; set; }
        public Guid UserId { get; set; }
    }
}
