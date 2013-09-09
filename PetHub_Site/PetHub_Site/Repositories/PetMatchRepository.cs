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
    public class PetMatchRepository : RepositoryBase<UserRate, PawhubBDEntities>
    {
        public PetMatchRepository()
            : base()
        {
        }
        internal IEnumerable<UserRate> GetTopByUserId(Guid UserId, short RateCategoryId, short TopNumber)
        {
            return context.UserRates.Where(x => x.UserId == UserId && x.RateCategoryId == RateCategoryId).OrderByDescending(x => x.Stars).Take(TopNumber);
        }

        internal IEnumerable<TopRateCategory> GetTopCategories()
        {
            var topRateCategories = context.LoadTopRateCategory();
            return topRateCategories;
        }

        //TODO: Borrar este método
        internal User GetRandomUser()
        {
            //TODO:Checar si en concurrencia se tiene que implementar un Seed diferente
            int rand = new Random().Next(0, 1000);
            return context.Users.OrderBy(x => x.UserId).Skip(rand).FirstOrDefault();
        }

        internal PetRate GetPetRatesByCategory(Guid PetId, short RateCategoryId)
        {
            var petRate = context.PetRates.Where(x => x.PetId == PetId && x.RateCategoryId == RateCategoryId).FirstOrDefault();
            return petRate;
        }

        internal short GetUserRatesCount(short RateCategoryId)
        {
            var userRatesCount = context.UserRates.Count(x => x.RateCategoryId == RateCategoryId);
            return (short)userRatesCount;
        }

        internal void AddPetRate(PetRate PetRate)
        {
            context.PetRates.AddObject(PetRate);
        }

        internal Pet GetNewPetForRate(Guid UserId)
        {
            var newPets = from p in context.Pets
                          join ur in context.UserRates on p.PetId equals ur.PetId into pUr
                          from ur in pUr.DefaultIfEmpty()
                          where ur != null
                          select p;
            //TODO:Checar si en concurrencia se tiene que implementar un Seed diferente
            int petNumber = new Random().Next(0, newPets.Count() - 1);
            return newPets.OrderBy(x => x.PetId).Skip(petNumber).FirstOrDefault();
        }

        internal IEnumerable<RateCategory> GetRateCategories()
        {
            return context.RateCategories;
        }

        internal PetRate GetPetRateByCategory(short RateCategoryId, Guid PetId)
        {
            return context.PetRates.Where(x => x.RateCategoryId == RateCategoryId && x.PetId == PetId).FirstOrDefault();
        }

        internal PetRate GetPetRate(Guid PetId, short CategoryId)
        {
            return context.PetRates.Where(x => x.PetId == PetId && x.RateCategoryId == CategoryId).FirstOrDefault();
        }
    }
}