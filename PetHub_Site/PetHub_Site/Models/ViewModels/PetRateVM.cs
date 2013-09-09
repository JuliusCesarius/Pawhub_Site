using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PetRateVM
    {
        public DateTime LastRateDate { get; set; }
        public Guid PetId { get; set; }
        public int PetRateId { get; set; }
        public short Rate1Star { get; set; }
        public short Rate2Stars { get; set; }
        public short Rate3Stars { get; set; }
        public short Rate4Stars { get; set; }
        public short Rate5Stars { get; set; }
        public string RateName { get; set; }
        public short RateCategoryId { get; set; }
        double Rating { get; set; }
    }
}
