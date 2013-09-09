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
    public class RegisterRepository : RepositoryBase<Preregistro, PawhubBDEntities>
    {
        public RegisterRepository()
            : base()
        {
        }

        internal bool ExistUserEmail(string UserEmail)
        {
            return context.Preregistroes.Any(x => x.UserEmail == UserEmail);
        }

        internal Preregistro LoadByUserEmail(string UserEmail)
        {
            return context.Preregistroes.Where(x => x.UserEmail == UserEmail).FirstOrDefault();
        }
    }
}