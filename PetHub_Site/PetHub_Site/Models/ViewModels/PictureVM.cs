using System;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class PictureVM
    {
        public DateTime CreationDate { get; set; }
        public string CreationDateStr { get; set; }
        public string Path { get; set; }
        public Guid PictureId { get; set; }
        public PicturesDetailVM PicturesDetail { get; set; }
        public UserVM User { get; set; }
        public Guid UserId { get; set; }
        public IEnumerable<WhoIsInPictureVM> WhoIsInPictures { get; set; }
    }
}
