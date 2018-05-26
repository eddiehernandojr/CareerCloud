using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
   public class CompanyJobDescriptionPoco : IPoco
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

        public Guid Job { get; set; }

        [Column("Job_Name")]
        public string JobName { get; set; }

        [Column("Job_Descriptions")]
        public string JobDescriptions { get; set; } //updated from JobDescription to JobDescriptions

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } //updated from byte?[] to byte[]
    }
}
