using System;
namespace PetHub_Site.Models.ViewModels
{
    public class PicturesDetailVM
    {
        AlbumVM Album { get; set; }
        short AlbumId { get; set; }
        DateTime CreationDate { get; set; }
        string Description { get; set; }
        decimal? Latitud { get; set; }
        decimal? Longitud { get; set; }
        string Name { get; set; }
        Guid PictureId { get; set; }
    }
}
