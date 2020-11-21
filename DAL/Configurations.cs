using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Configurations
    {
        public static string connectionString
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString; }
            set { }
        }
    }
}
