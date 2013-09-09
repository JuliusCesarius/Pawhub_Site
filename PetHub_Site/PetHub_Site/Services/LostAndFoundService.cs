using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetHub_Site.Repositories;
using AutoMapper;
using PetHub_Site.Models.ViewModels;
using PetHub_Site.Models;
using PetHub_Site.Models.MongoDB.LostAndFound;
using System.Collections;
using System.Data.Entity.Infrastructure;

namespace PetHub_Site.Services
{
    public class LostAndFoundService : PawhubServiceBase<Report>, IDisposable
    {
        LostAndFoundRepository _repository;

        internal IEnumerable<Report> GetReports()
        {
            return Repository.ListAll();
        }

        protected override blastic.patterns.interfaces.IRepository<Report> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new LostAndFoundRepository();
                }
                return _repository;
            }
        }

        public void Dispose()
        {
            
        }

        internal void Add(Report report)
        {
            Repository.Insert(report);
            Succeed = true;
            return;
        }
    }
}