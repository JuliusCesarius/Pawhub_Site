using System;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class PictureVM
    {
        DateTime CreationDate { get; set; }
        String CreationDateStr { get; set; }
        string Path { get; set; }
        Guid PictureId { get; set; }
        PicturesDetailVM PicturesDetail { get; set; }
        UserVM User { get; set; }
        Guid UserId { get; set; }
        IEnumerable<WhoIsInPictureVM> WhoIsInPictures { get; set; }
    }
}
