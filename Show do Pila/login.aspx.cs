using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Show_do_Pila
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (banco.VerificarLogin(Login1.UserName, Login1.Password))
            {
                e.Authenticated = true;
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
            }
            else
            {
                e.Authenticated = false;
            }

        }
    }
}