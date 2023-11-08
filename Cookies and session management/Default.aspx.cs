using System;
using System.Web;

namespace CookiesAndSession
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] != null)
            {
                lblCookie.Text = "Cookie Value: " + Server.HtmlEncode(Request.Cookies["UserCookie"].Value);
            }

            if (Session["UserData"] != null)
            {
                lblSession.Text = "Session Value: " + Session["UserData"].ToString();
            }
        }

        protected void SetCookie_Click(object sender, EventArgs e)
        {
            string cookieValue = txtCookie.Text;
            HttpCookie cookie = new HttpCookie("UserCookie");
            cookie.Value = cookieValue;
            cookie.Expires = DateTime.Now.AddHours(1); // Cookie expiration time (1 hour)
            Response.Cookies.Add(cookie);
        }

        protected void SetSession_Click(object sender, EventArgs e)
        {
            string sessionValue = txtSession.Text;
            Session["UserData"] = sessionValue;
        }
    }
}