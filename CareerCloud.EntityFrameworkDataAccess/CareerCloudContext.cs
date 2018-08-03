using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public CareerCloudContext() : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //CompanyProfilePoco
            modelBuilder.Entity<CompanyProfilePoco>()
            .Property(e => e.CompanyWebsite)
            .IsUnicode(false);

            modelBuilder.Entity<CompanyProfilePoco>()
            .Property(e => e.ContactPhone)
            .IsUnicode(false);

            modelBuilder.Entity<CompanyProfilePoco>()
            .Property(e => e.ContactName)
            .IsUnicode(false);

            modelBuilder.Entity<CompanyProfilePoco>()
            .Property(e => e.TimeStamp)
            .IsFixedLength();

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(e => e.CompanyDescriptions)
            .WithRequired(e => e.CompanyProfiles)
            .HasForeignKey(e => e.Company)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(e => e.CompanyJobs)
            .WithRequired(e => e.CompanyProfiles)
            .HasForeignKey(e => e.Company)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(e => e.CompanyLocations)
            .WithRequired(e => e.CompanyProfiles)
            .HasForeignKey(e => e.Company)
            .WillCascadeOnDelete(false);

            //CompanyJobPoco
            modelBuilder.Entity<CompanyJobPoco>()
            .Property(e => e.TimeStamp)
            .IsFixedLength();

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(e => e.ApplicantJobApplications)
            .WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(e => e.CompanyJobEducations)
            .WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(e => e.CompanyJobSkills)
            .WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(e => e.CompanyJobDescriptions)
            .WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job)
            .WillCascadeOnDelete(false);

            //SecurityLoginPoco
            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.Login)
            .IsUnicode(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.Password)
            .IsUnicode(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.EmailAddress)
            .IsUnicode(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.PhoneNumber)
            .IsUnicode(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.PrefferredLanguage)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .Property(e => e.TimeStamp)
            .IsFixedLength();

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(e => e.ApplicantProfiles)
            .WithRequired(e => e.SecurityLogins)
            .HasForeignKey(e => e.Login)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(e => e.SecurityLoginsLogs)
            .WithRequired(e => e.SecurityLogins)
            .HasForeignKey(e => e.Login)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(e => e.SecurityLoginsRoles)
            .WithRequired(e => e.SecurityLogins)
            .HasForeignKey(e => e.Login)
            .WillCascadeOnDelete(false);

            //SecurityRolePoco
            modelBuilder.Entity<SecurityRolePoco>()
            .Property(e => e.Role)
            .IsUnicode(false);

            modelBuilder.Entity<SecurityRolePoco>()
            .HasMany(e => e.SecurityLoginsRoles)
            .WithRequired(e => e.SecurityRoles)
            .HasForeignKey(e => e.Role)
            .WillCascadeOnDelete(false);

            //SystemCountryCodePoco
            modelBuilder.Entity<SystemCountryCodePoco>()
            .Property(e => e.Code)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<SystemCountryCodePoco>()
            .HasMany(e => e.ApplicantProfiles)
            .WithOptional(e => e.SystemCountryCodes)
            .HasForeignKey(e => e.Country);

            modelBuilder.Entity<SystemCountryCodePoco>()
            .HasMany(e => e.ApplicantWorkHistories)
            .WithRequired(e => e.SystemCountryCodes)
            .HasForeignKey(e => e.CountryCode)
            .WillCascadeOnDelete(false);

            //ApplicantProfilePoco
            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.CurrentSalary)
            .HasPrecision(18, 0);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.Currency)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.Country)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.Province)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.PostalCode)
            .IsFixedLength()
            .IsUnicode(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .Property(e => e.TimeStamp)
            .IsFixedLength();

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(e => e.ApplicantEducations)
            .WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(e => e.ApplicantJobApplications)
            .WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(e => e.ApplicantResumes)
            .WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(e => e.ApplicantSkills)
            .WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(e => e.ApplicantWorkHistories)
            .WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant)
            .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
    }
}


