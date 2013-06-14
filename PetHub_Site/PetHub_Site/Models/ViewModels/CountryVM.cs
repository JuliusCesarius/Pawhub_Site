using System;
using System.Data.Objects.DataClasses;
using System.Collections.Generic;
namespace PetHub_Site.Models.ViewModels
{
    public class CountryVM
    {
        IEnumerable<CityVM> Cities { get; set; }
        short CountryId { get; set; }
        string Name { get; set; }
        //TODO: Agregar propiedad del Flag
    }
}
