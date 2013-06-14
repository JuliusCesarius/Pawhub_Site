using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PicturesDetailVM
    {
        public AlbumVM Album { get; set; }
        public short AlbumId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string Name { get; set; }
        public Guid PictureId { get; set; }
    }
}
