using System;
namespace PetHub_Site.Models.ViewModels
{
    public class NicknameVM
    {
        string Name { get; set; }
        short Privacy { get; set; }
        Guid UserId { get; set; }
    }
}
