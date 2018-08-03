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

        [Key]
        public Guid Id { get; set; }

        public Guid Login { get; set; }

        public Guid Role { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; } //updated from byte?[] to byte[]
        public virtual SecurityLoginPoco SecurityLogins { get; set; }
        public virtual SecurityRolePoco SecurityRoles { get; set; }
    }
}
