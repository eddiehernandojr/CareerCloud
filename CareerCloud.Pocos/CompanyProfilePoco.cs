using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
   public class CompanyProfilePoco : IPoco
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

        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }

        [Column("Company_Website")]
        public string CompanyWebsite { get; set; }

        [Column("Contact_Phone")]
        public string ContactPhone { get; set; }

        [Column("Contact_Name")]
        public string ContactName { get; set; }

        [Column("Company_Logo")]
        public byte[] CompanyLogo { get; set; } //updated from byte?[] to byte[]

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } //updated from byte?[] to byte[]
    }
}
