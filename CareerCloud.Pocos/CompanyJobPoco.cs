using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco
    {
        private Guid id;

        [Key]
        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                value = id;
            }
        }

        public Guid Company { get; set; }

        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }

        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }

        [Column("Is_Company_Hidden")]
        public bool IsCompanyHidden { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } //updated from byte?[] to byte[]
    }
}
