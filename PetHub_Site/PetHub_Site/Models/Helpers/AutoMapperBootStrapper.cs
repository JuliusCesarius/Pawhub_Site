using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PetHub_Site.Models;
using PetHub_Site.Models.ViewModels;

namespace PetHub_Site.Models.Helpers
{
    public static class AutoMapperBootStrapperHelper
    {
        public static void Bootstrap()
        {
            //******************Entity to ViewModel********************//
            Mapper.CreateMap<Album, AlbumVM>();
            Mapper.CreateMap<Breed, BreedVM>();
                    //.ForMember(vm => vm.MaximoAFinanciar, opt => opt.MapFrom(m => Math.Round(Convert.ToDecimal(m.Parametros.MaximoAFinanciar), 2)))
                    //.ForMember(vm => vm.ThumbnailIFE, opt => opt.MapFrom(m => m.IFE.Replace("UploadImages", "UploadImages/Thumbnails")))
                    //.ForMember(vm => vm.ThumbnailComprobante, opt => opt.MapFrom(m => m.Comprobante.Replace("UploadImages", "UploadImages/Thumbnails")));
            Mapper.CreateMap<City, CityVM>();
            Mapper.CreateMap<Country, CountryVM>();
            Mapper.CreateMap<Friendship, FriendshipVM>();
            Mapper.CreateMap<Nickname, NicknameVM>();
            Mapper.CreateMap<PetCounter, PetCounterVM>();
            Mapper.CreateMap<PetOwnerHistory, PetOwnerHistoryVM>();
            Mapper.CreateMap<PetProfile, PetProfileVM>();
            Mapper.CreateMap<PetRate, PetProfileVM>();
            Mapper.CreateMap<Pet, PetVM>();
            Mapper.CreateMap<PicturesDetail, PicturesDetailVM>();
            Mapper.CreateMap<Picture, PictureVM>();
            Mapper.CreateMap<Privacy, PrivacyVM>();
            Mapper.CreateMap<Profile, ProfileVM>();
            Mapper.CreateMap<RateCategory, RateCategoryVM>();
            Mapper.CreateMap<UserLog, UserLogVM>();
            Mapper.CreateMap<UserRate, UserRateVM>();
            Mapper.CreateMap<User, UserVM>();
            Mapper.CreateMap<WhoIsInPicture, WhoIsInPictureVM>();

            //ComplexEntities
            Mapper.CreateMap<TopRateCategory, TopRateCategoryVM>();

            //******************ViewModel to Entity********************//
                //.ForMember(m => m.CuentasBancariasVM, opt => opt.Ignore());
            Mapper.CreateMap<AlbumVM, Album>();
            Mapper.CreateMap<BreedVM, Breed>();
            Mapper.CreateMap<CityVM, City>();
            Mapper.CreateMap<CountryVM, Country>();
            Mapper.CreateMap<FriendshipVM, Friendship>();
            Mapper.CreateMap<NicknameVM, Nickname>();
            Mapper.CreateMap<PetCounterVM, PetCounter>();
            Mapper.CreateMap<PetOwnerHistoryVM, PetOwnerHistory>();
            Mapper.CreateMap<PetProfileVM, PetProfile>();
            Mapper.CreateMap<PetRateVM, PetProfile>();
            Mapper.CreateMap<PetVM, Pet>();
            Mapper.CreateMap<PicturesDetailVM, PicturesDetail>();
            Mapper.CreateMap<PictureVM, Picture>();
            Mapper.CreateMap<PrivacyVM, Privacy>();
            Mapper.CreateMap<ProfileVM, Profile>();
            Mapper.CreateMap<RateCategoryVM, RateCategory>();
            Mapper.CreateMap<UserLogVM, UserLog>();
            Mapper.CreateMap<UserRateVM, UserRate>();
            Mapper.CreateMap<UserVM, User>();
            Mapper.CreateMap<WhoIsInPictureVM, WhoIsInPicture>();

            //ComplexEntities
            Mapper.CreateMap<TopRateCategoryVM, TopRateCategory>();
        }
    }
}