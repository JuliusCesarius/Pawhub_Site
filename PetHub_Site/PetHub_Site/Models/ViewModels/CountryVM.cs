using System;
using System.Data.Objects.DataClasses;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class CountryVM
    {
        public IEnumerable<CityVM> Cities { get; set; }
        public short CountryId { get; set; }
        public string Name { get; set; }
        //TODO: Agregar propiedad del Flag
    }
}
