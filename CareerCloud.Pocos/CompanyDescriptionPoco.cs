using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
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
                id = value; //updated from value = id to id = value
            }
        }

        public Guid Company { get; set; }

        [Column("LanguageID")]
        public string LanguageId { get; set; } //updated from LanguageID to LanguageId and added column attribute

        [Column("Company_Name")]
        public string CompanyName { get; set; }

        [Column("Company_Description")]
        public string CompanyDescription { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
