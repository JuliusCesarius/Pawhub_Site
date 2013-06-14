using System;
using System.Data.Objects.DataClasses;
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
        public string FullName { get; set; }
        public int? LiveIn { get; set; }
        public string LiveInCity { get; set; }
        public bool? Neatured { get; set; }
        public string Pedigree { get; set; }
        public Guid PetId { get; set; }
        public string Picture { get; set; }
        public bool Sex { get; set; }
        public short Type { get; set; }
        public string TypeString { get; set; }
        public int? WasBornIn { get; set; }
        public string WasBornInCity { get; set; }
        public string Website { get; set; }
    }
}
