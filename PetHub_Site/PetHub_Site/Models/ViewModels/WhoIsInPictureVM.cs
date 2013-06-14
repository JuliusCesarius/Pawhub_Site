using System;
namespace PetHub_Site.Models.ViewModels
{
    public class WhoIsInPictureVM
    {
        public bool IsPet { get; set; }
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public Guid PictureId { get; set; }
        public string WhoIsInPictureId { get; set; }
    }
}
