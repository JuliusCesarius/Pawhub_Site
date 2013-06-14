using System;
namespace PetHub_Site.Models.ViewModels
{
    public class NicknameVM
    {
        public string Name { get; set; }
        public short Privacy { get; set; }
        public Guid UserId { get; set; }
    }
}
