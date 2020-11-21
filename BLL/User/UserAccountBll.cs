using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.User;
using DAL.User;

namespace BLL.User
{
    public class UserAccountBll
    {
        public bool SignIn(UserAccountEntity _u)
        {
            return (new UserAccountDal()).SignIn(_u);
        }
    }
}
