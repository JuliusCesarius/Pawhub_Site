using System;
namespace PetHub_Site.Models.ViewModels
{
    public class WhoIsInPictureVM
    {
        bool IsPet { get; set; }
        Guid MemberId { get; set; }
        string Name { get; set; }
        Guid PictureId { get; set; }
        string WhoIsInPictureId { get; set; }
    }
}
