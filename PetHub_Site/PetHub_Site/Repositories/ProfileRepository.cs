using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using blastic.patterns.clases;
using PetHub_Site.Models;
using AutoMapper;
using PetHub_Site.Models.ViewModels;

namespace PetHub_Site.Repositories
{
    public class ProfileRepository : RepositoryBase<User, PawhubBDEntities>
    {
        public ProfileRepository()
            : base()
        {
        }
        internal IEnumerable<Kind> GetKinds()
        {
            return context.Kinds;
        }

        internal IEnumerable<Breed> GetBreedsByKindId(short KindId)
        {
            if (KindId ==0)
            {

                return context.Breeds;
            }
            else
            {

                return context.Breeds.Where(x => x.KindId == KindId);
            }
        }

        internal PetProfile GetPetProfile(Guid PetId)
        {
            return context.PetProfiles.Where(x => x.PetId == PetId).FirstOrDefault();
        }

        internal PetHub_Site.Models.Profile GetUserProfile(Guid UserId)
        {
            return context.Profiles.Where(x => x.UserId == UserId).FirstOrDefault();
        }

        internal User GetUser(Guid UserId)
        {
            return context.Users.Where(x => x.UserId == UserId).FirstOrDefault();
        }

        internal Pet GetPet(Guid PetId)
        {
            return context.Pets.Where(x => x.PetId == PetId).FirstOrDefault();
        }

    }
}