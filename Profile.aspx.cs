using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace custome_form
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = ViewState["UserDetails"] as usermodel;
            fname1.Text = user.First_name;
            lname2.Text = user.Last_name;
            gender1.Text = user.Gender;
            number1.Text = user.Phone.ToString();
            mail1.Text = user.Email;
            pass1.Text = user.Password;
        }
    }
}