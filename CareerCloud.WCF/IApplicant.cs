﻿using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//namespace CareerCloud.WCF
namespace ApplicantService
{
    [ServiceContract]
    interface IApplicant
    {
        //ApplicantEducation
        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco[] pocos);

        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();

        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(Guid Id); //

        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] pocos);

        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] pocos);

        //ApplicantJobApplication
        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos);

        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();

        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(Guid Id);

        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos);

        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos);

        //ApplicantProfile
        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] pocos);

        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();

        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(Guid Id);

        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] pocos);

        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] pocos);

        //ApplicantResume
        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] pocos);

        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();

        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(Guid Id);

        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] pocos);

        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] pocos);

        //ApplicantSkill
        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] pocos);

        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();

        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(Guid Id);

        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] pocos);

        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] pocos);

        //ApplicantWorkHistory
        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos);

        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();

        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(Guid Id);

        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos);

        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos);
    }
}
