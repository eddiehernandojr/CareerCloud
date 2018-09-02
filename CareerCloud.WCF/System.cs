﻿using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//namespace CareerCloud.WCF
namespace SystemService
{
    class System : ISystem
    {
        //Add
        public void AddSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Add(pocos);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Add(pocos);
        }

        //GetAll
        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            return logic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            return logic.GetAll();
        }

        //GetSingle
        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id) //changed
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            return logic.Get(Id); //changed
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            return logic.Get(Id);
        }

        //Remove
        public void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Delete(pocos);
        }

        //Update
        public void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Update(pocos);
        }
    }
}
