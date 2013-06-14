using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class AlbumVM
    {
        public short AlbumId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public short Privacy { get; set; }
        public Guid UserId { get; set; }
    }
}
