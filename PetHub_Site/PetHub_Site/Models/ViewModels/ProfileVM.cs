using System;
namespace PetHub_Site.Models.ViewModels
{
    public class ProfileVM
    {
        string AboutMe { get; set; }
        DateTime CreationDate { get; set; }
        DateTime DOB { get; set; }
        string LastName { get; set; }
        int LivesIn { get; set; }
        CityVM LivesInCity { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string Picture { get; set; }
        short Privacy { get; set; }
        int ProfileId { get; set; }
        UserVM User { get; set; }
        Guid UserId { get; set; }
        int WasBornIn { get; set; }
        CityVM WasBornInCity { get; set; }
    }
}
