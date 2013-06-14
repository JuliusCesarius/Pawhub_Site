using System;
using System.Data.Objects.DataClasses;
namespace PetHub_Site.Models.ViewModels
{
    public class PetProfileVM
    {
        bool Alive { get; set; }
        string BreedName { get; set; }
        short? BreedId { get; set; }
        string CoverPic { get; set; }
        string Description { get; set; }
        DateTime DOB { get; set; }
        string FullName { get; set; }
        int? LiveIn { get; set; }
        string LiveInCity { get; set; }
        bool? Neatured { get; set; }
        string Pedigree { get; set; }
        Guid PetId { get; set; }
        string Picture { get; set; }
        bool Sex { get; set; }
        short Type { get; set; }
        string TypeString { get; set; }
        int? WasBornIn { get; set; }
        string WasBornInCity { get; set; }
        string Website { get; set; }
    }
}
