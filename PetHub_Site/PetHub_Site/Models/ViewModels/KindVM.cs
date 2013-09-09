using System;
using System.Data.Objects.DataClasses;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class KindVM
    {
        public short KindId { get; set; }
        public string Name { get; set; }
        IEnumerable<BreedVM> Breeds { get; set; }
    }
}
