using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.User
{
    public class UserAccountEntity
    {
        public int UL_ID { get; set; }
        public string UL_Account { get; set; }
        public string UL_Pwd { get; set; }
        public int UL_Type { get; set; }
    }
}
