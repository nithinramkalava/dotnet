using System;
using System.Data.SqlClient;


namespace LoginAndRegisterUsingASP_ADO
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nithi\\source\\repos\\LoginAndRegisterUsingASP_ADO\\LoginAndRegisterUsingASP_ADO\\App_Data\\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            username.Focus();
            connection.Open();
        }

        protected void LoginButton_click(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[Users] where username='"
                + username.Text + "' and password='" + password.Text + "'";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                Response.Redirect("Home.html");
            } else
            {
                Response.Write("Invalid Creadentaials");
            }
        }
    }
}