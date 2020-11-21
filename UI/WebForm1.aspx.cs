using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            Model.User.UserAccountEntity _u = new Model.User.UserAccountEntity();
            _u.UL_Account = username.Text;
            _u.UL_Pwd = pwd.Text;
            if((new BLL.User.UserAccountBll()).SignIn(_u) == true)
            {
                Response.Write("1111");
            }
        }
    }
}