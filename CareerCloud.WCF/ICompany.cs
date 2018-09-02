﻿using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//namespace CareerCloud.WCF
namespace CompanyService
{
    [ServiceContract]
    interface ICompany
    {
        //CompanyDescription
        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] pocos);

        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();

        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(Guid Id);

        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos);

        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos);

        //CompanyJobDescription
        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos);

        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();

        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(Guid Id);

        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos);

        //CompanyJobEducation
        [OperationContract]
        void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos);

        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();

        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(Guid Id);

        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos);

        //CompanyJob
        [OperationContract]
        void AddCompanyJob(CompanyJobPoco[] pocos);

        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();

        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(Guid Id);

        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] pocos);

        //CompanyJobSkill
        [OperationContract]
        void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos);

        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();

        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(Guid Id);

        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos);

        //CompanyLocation
        [OperationContract]
        void AddCompanyLocation(CompanyLocationPoco[] pocos);

        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();

        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(Guid Id);

        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] pocos);

        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] pocos);

        //CompanyProfile
        [OperationContract]
        void AddCompanyProfile(CompanyProfilePoco[] pocos);

        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();

        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(Guid Id);

        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] pocos);

        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] pocos);
    }
}
