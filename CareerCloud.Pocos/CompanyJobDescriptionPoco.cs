﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Description")]
   public class CompanyJobDescriptionPoco : IPoco
    {
        private Guid id;

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

        [Key]
        public Guid Id { get; set; }

        public Guid Job { get; set; }

        [Column("Job_Name")]
        public string JobName { get; set; }

        [Column("Job_Descriptions")]
        public string JobDescription { get; set; }

        [Column("Time_Stamp")]
        public byte?[] TimeStamp { get; set; }
    }
}
