using System;
using System.Data.Objects.DataClasses;
using System.ComponentModel.DataAnnotations;
namespace PetHub_Site.Models.ViewModels
{
    public class PetProfileVM
    {
        public bool Alive { get; set; }
        public string BreedName { get; set; }
        public short? BreedId { get; set; }
        public string CoverPic { get; set; }
        public string Description { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public string FullName { get; set; }
        public int? LiveIn { get; set; }
        public string LiveInName { get; set; }
        public bool? Neatured { get; set; }
        public string Pedigree { get; set; }
        [Required]
        public Guid PetId { get; set; }
        public string Picture { get; set; }
        public bool Sex { get; set; }
        [Required]
        public short KindId { get; set; }
        public string KindName { get; set; }
        public int? WasBornIn { get; set; }
        public string WasBornInName { get; set; }
        public string Website { get; set; }
    }
}
