﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco
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

        public Guid Applicant { get; set; }

        public string Resume { get; set; }

        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }
    }
}
