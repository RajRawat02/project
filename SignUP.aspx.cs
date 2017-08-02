using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace custome_form
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (txtpass.Text.Equals(confpass.Text))
            {
                var user_model = new usermodel();

                user_model.First_name = Fname.Text;
                user_model.Last_name = Lname.Text;
                user_model.Gender = gender.Text;
                user_model.Phone = Convert.ToInt32(number.Text);
                user_model.Email = mail.Text;
                user_model.Password = txtpass.Text;
                ViewState["UserDetails"] = user_model;
                Response.Redirect("profile.aspx");
            }

            else
                Lblerror.Text = "Password does not Match";
        }
    }
}
