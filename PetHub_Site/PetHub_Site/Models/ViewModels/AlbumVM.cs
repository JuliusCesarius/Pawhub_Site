using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class AlbumVM
    {
        short AlbumId { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        short Privacy { get; set; }
        Guid UserId { get; set; }
    }
}
