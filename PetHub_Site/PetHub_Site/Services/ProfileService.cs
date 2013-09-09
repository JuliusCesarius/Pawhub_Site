using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetHub_Site.Repositories;
using AutoMapper;
using PetHub_Site.Models.ViewModels;
using PetHub_Site.Models;

namespace PetHub_Site.Services
{
    public class ProfileService : PawhubServiceBase<PetHub_Site.Models.User>
    {
        private ProfileRepository _repository;

        protected override blastic.patterns.interfaces.IRepository<Models.User> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new ProfileRepository();
                }
                return _repository;
            }
        }

        internal IEnumerable<KindVM> GetKinds()
        {
            return ((ProfileRepository)Repository).GetKinds().ToListOfDestination<KindVM>();
        }

        internal IEnumerable<BreedVM> GetBreedsByKindId(short KindId)
        {
            return ((ProfileRepository)Repository).GetBreedsByKindId(KindId).ToListOfDestination<BreedVM>();
        }

        internal PetProfileVM GetPetProfile(Guid PetId)
        {
            var petProfileVM = new PetProfileVM();
            var petProfile = ((ProfileRepository)Repository).GetPetProfile(PetId);
            petProfileVM = Mapper.Map(petProfile, petProfileVM);
            return petProfileVM;
        }

        internal ProfileVM GetUserProfile(Guid UserId)
        {
            var profileVM = new ProfileVM();
            var profile = ((ProfileRepository)Repository).GetUserProfile(UserId);
            Mapper.CreateMap<PetHub_Site.Models.Profile, ProfileVM>();
            profileVM = Mapper.Map(profile, profileVM);
            return profileVM;
        }

        internal bool RegisterUserProfile(ProfileVM profile)
        {
            User user = ((ProfileRepository)Repository).GetUser(profile.UserId);
            if (user == null)
            {
                return false;
            }

            var userProfile = new PetHub_Site.Models.Profile();
            //TODO: Validate el profile
            var currenProfile = user.Profile;
            userProfile = Mapper.Map(profile, userProfile);
            if (currenProfile != null)
            {
                userProfile.CreationDate = currenProfile.CreationDate;
            }
            else
            {
                userProfile.CreationDate = DateTime.UtcNow;
            }
            user.Profile = userProfile;
            Succeed = ((ProfileRepository)Repository).Save();
            return Succeed;
        }

        internal bool RegisterPetProfile(PetProfileVM PetProfile)
        {
            Pet pet = ((ProfileRepository)Repository).GetPet(PetProfile.PetId);
            if (pet == null)
            {
                return false;
            }

            var petProfile = new PetProfile();
            //TODO: Validate el profile
            var currenProfile = pet.PetProfile;
            petProfile = Mapper.Map(PetProfile, petProfile);
            pet.PetProfile = petProfile;
            if (PetProfile.KindId <= 0 && currenProfile != null)
            {
                pet.PetProfile.KindId = currenProfile.KindId;
            }
            Succeed = ((ProfileRepository)Repository).Save();
            return Succeed;
        }
    }

}