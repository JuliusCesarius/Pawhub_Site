using System;
using System.ComponentModel.DataAnnotations;
namespace PetHub_Site.Models.ViewModels
{
    public class ProfileVM
    {
        public string AboutMe { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DOB { get; set; }
        public string LastName { get; set; }
        public int? LivesIn { get; set; }
        public string LivesInName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public short Privacy { get; set; }
        public int ProfileId { get; set; }
        public Guid UserId { get; set; }
        public int? WasBornIn { get; set; }
        public string WasBornInName { get; set; }
        public string EmailUser { get; set; }
    }
}
