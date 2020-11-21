using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDAL;
using Model.User;
using System.Data;
using System.Data.SqlClient;

namespace DAL.User
{
    public class UserAccountDal : IDAL.User.IUserAccountDal
    {
        public bool SignIn(UserAccountEntity _u)
        {
            string sqlstr = @"select * from User_Login where UL_Account=@userName and UL_pwd=@userPassword";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@userName", _u.UL_Account),
                new SqlParameter("@userPassword", _u.UL_Pwd)
            };
            int result = (int)DAL.SQLHelper.ExecuteScalar(sqlstr, CommandType.Text, paras);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
