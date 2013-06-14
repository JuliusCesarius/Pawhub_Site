using System;
namespace PetHub_Site.Models.ViewModels
{
    public class ProfileVM
    {
        public string AboutMe { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DOB { get; set; }
        public string LastName { get; set; }
        public int LivesIn { get; set; }
        public CityVM LivesInCity { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public short Privacy { get; set; }
        public int ProfileId { get; set; }
        public UserVM User { get; set; }
        public Guid UserId { get; set; }
        public int WasBornIn { get; set; }
        public CityVM WasBornInCity { get; set; }
    }
}
