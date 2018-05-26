using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco //updated from SecurityLoginRolePoco to SecurityLoginsRolePoco and renamed the class file
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

        public Guid Role { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } //updated from byte?[] to byte[]
    }
}
