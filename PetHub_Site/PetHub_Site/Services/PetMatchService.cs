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