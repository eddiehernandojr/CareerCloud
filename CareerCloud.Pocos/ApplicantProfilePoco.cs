using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        private Guid _id; //updated from id to _id to follow naming convention

        [Key]
        public Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value; //updated from value = id to id = value
            }
        }
        
        public Guid Login { get; set; }

        [Column("Current_Salary")]
        public decimal? CurrentSalary { get; set; }

        [Column("Current_Rate")]
        public decimal? CurrentRate { get; set; }

        public string Currency { get; set; }

        [Column("Country_Code")]
        public string Country { get; set; } //updated from CountryCode to Country

        [Column("State_Province_Code")]
        public string Province { get; set; } //updated from StateProvinceCode to Province

        [Column("Street_Address")]
        public string Street { get; set; } //updated from StreetAddress to Street

        [Column("City_Town")]
        public string City { get; set; } //updated from CityTown to City

        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; } //updated from ZipPostalCode to PostalCode

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
        
    }
}
