using System;
using System.Data.SqlClient;

namespace LoginAndRegisterUsingASP_ADO
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nithi\\source\\repos\\LoginAndRegisterUsingASP_ADO\\LoginAndRegisterUsingASP_ADO\\App_Data\\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            username.Focus();
            connection.Open();
        }
        
        protected void RegisterButton_click(object sender, EventArgs e)
        {
            string query = "insert into [dbo].[Users] values ('"
                + username.Text + "', '" + password.Text + "', '" + email.Text
                + "', '" + mobile.Text + "')";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandText = query;

            int res = cmd.ExecuteNonQuery();

            if (res == 0)
            {
                Response.Write("Something went wrong");
            } else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}