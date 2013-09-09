using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHub_Site.Models.ViewModels
{
    public class AllClases
    {
        public BreedVM Breed = new BreedVM();
        public PetBasicVM PetBasic = new PetBasicVM();
        public PetProfileVM PetProfile = new PetProfileVM();
        public PetRateVM PetRate = new PetRateVM();
        public PetVM Pet = new PetVM();
        public ProfileVM Profile = new ProfileVM();
        public RatingVM Rating = new RatingVM();
        public UserVM User = new UserVM();
    }
}