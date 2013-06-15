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
    public class PetMatchService : PawhubServiceBase<PetHub_Site.Models.UserRate>
    {
        private PetMatchRepository _repository;

        public IEnumerable<UserRateVM> GetTopCategoryByUserId(Guid UserId, short RateCategoryId, short TopNumber)
        {
            var topCategory = ((PetMatchRepository)Repository).GetTopByUserId(UserId, RateCategoryId, TopNumber);
            return topCategory.ToListOfDestination<UserRateVM>();
        }

        public IEnumerable<TopRateCategoryVM> GetTopCategories()
        {
            var topCategory = ((PetMatchRepository)Repository).GetTopCategories();
            return topCategory.ToListOfDestination<TopRateCategoryVM>();
        }

        public IEnumerable<TopRateCategoryVM> RateMyPet(Guid PetId)
        {
            var topCategory = ((PetMatchRepository)Repository).GetTopCategories();
            return topCategory.ToListOfDestination<TopRateCategoryVM>();
        }

        public PetBasicVM RateAPet(Guid UserId, Guid PetId, List<RatingVM> Ratings)
        {
            Succeed = UserId != null;
            if (Ratings != null)
            {
                foreach (var rating in Ratings)
                {
                    ((PetMatchRepository)Repository).Add(new UserRate
                    {
                        PetId = PetId,
                        Stars = rating.Stars,
                        RateDate = DateTime.UtcNow,
                        UserId = UserId,
                        RateCategoryId = rating.RateCategoryId
                    });
                    var petRate = ((PetMatchRepository)Repository).GetPetRatesByCategory(PetId, rating.RateCategoryId);
                    if (petRate == null)
                    {
                        petRate = new PetRate();
                    }
                    petRate.LastRateDate = DateTime.UtcNow;
                    petRate.PetId = PetId;
                    petRate.RateCategoryId = rating.RateCategoryId;
                    short totalRates = ((PetMatchRepository)Repository).GetUserRatesCount(rating.RateCategoryId);
                    petRate.Rating = (petRate.Rate1Star + petRate.Rate2Stars + petRate.Rate3Stars + petRate.Rate4Stars + petRate.Rate5Stars) / totalRates;
                    switch (rating.Stars)
                    {
                        case 1:
                            petRate.Rate1Star++;
                            break;
                        case 2:
                            petRate.Rate2Stars++;
                            break;
                        case 3:
                            petRate.Rate3Stars++;
                            break;
                        case 4:
                            petRate.Rate4Stars++;
                            break;
                        case 5:
                            petRate.Rate5Stars++;
                            break;
                    }
                    if (petRate.PetRateId == 0)
                    {
                        ((PetMatchRepository)Repository).AddPetRate(petRate);
                    }
                    Succeed = ((PetMatchRepository)Repository).Save();                    
                }
            }
            if (Succeed)
            {
                //Obtengo el nuevo Pet para evaluar
                //TODO:Analizar las preferencias del usuario
                Pet pet = ((PetMatchRepository)Repository).GetNewPetForRate(UserId);
                PetBasicVM petBasicVM = null;
                if (pet != null)
                {
                    petBasicVM = new PetBasicVM()
                    {
                        Name = pet.Name,
                        PetId = pet.PetId,
                        UserId = pet.UserId,
                        Picture = pet.PetProfile.Picture
                    };
                }
                return petBasicVM;
            }
            else
            {
            //TODO:Validar y no devolver null
                return null;
            }
        }

        protected override cabinet.patterns.interfaces.IRepository<Models.UserRate> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new PetMatchRepository();
                }
                return _repository;
            }
        }        
    }
}