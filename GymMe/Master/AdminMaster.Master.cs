using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Layout
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Hoem_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Manage_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_0rderQueue_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/AdminProfilePage.aspx");
        }

        protected void Btn_Report_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_logout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-2);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}