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
    public class RegisterService : PawhubServiceBase<PetHub_Site.Models.Preregistro>
    {
        private RegisterRepository _repository;

        public bool PreUser(PreregistroVM preregistroVM)
        {
            bool saved = false;
            if (!string.IsNullOrEmpty(preregistroVM.UserName))
            {
                //TODO: Validar que pasa si se proporciona mismo username y diferente email o si el email se repite
                bool exists = ((RegisterRepository)Repository).ExistUserEmail(preregistroVM.UserEmail);
                if (exists)
                {
                    var preRegistro = ((RegisterRepository)Repository).LoadByUserEmail(preregistroVM.UserEmail);
                    Mapper.Map(preregistroVM, preRegistro);
                }else{
                    ((RegisterRepository)Repository).Add(new Preregistro
                    {
                        UserName = preregistroVM.UserName,
                        LastName = preregistroVM.UserLastName,
                        UserEmail = preregistroVM.UserEmail,
                        UserCity = preregistroVM.UserCity
                    });
                }
                 
                 saved = Repository.Save();
                if (!saved)
                {
                    //Todo: Hacer lógica para manejar error
                }
            }
            return saved;
        }


        protected override blastic.patterns.interfaces.IRepository<Preregistro> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new RegisterRepository();
                }
                return _repository;
            }
        }

        internal object GetRegisteredUsers()
        {
            return ((RegisterRepository)Repository).ListAll().ToListOfDestination<PreregistroVM>();
        }

        internal object Exist(string email)
        {
            return ((RegisterRepository)Repository).ExistUserEmail(email);
        }
    }
}