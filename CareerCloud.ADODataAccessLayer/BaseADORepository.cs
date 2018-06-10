using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADORepository
    {
        protected readonly string _connString;
        public BaseADORepository()
        {
            _connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        }
    }
}