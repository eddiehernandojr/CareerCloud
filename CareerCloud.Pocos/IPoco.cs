using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    public interface IPoco //added public access modifier to interface
    {
        Guid Id { get; set; }
    }
}
