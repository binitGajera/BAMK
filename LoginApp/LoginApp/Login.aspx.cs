using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String conString = WebConfigurationManager.ConnectionStrings["bin"].ConnectionString; 
            SqlConnection con = new SqlConnection(conString);
            String selectQuery = "select * from login";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            String uname = TextBox1.Text;
            String pwd = TextBox2.Text;
            while(rdr.Read())
            {
                if(rdr["username"].ToString()==uname && rdr["password"].ToString()==pwd )
                {
                    Session["usersession"] = TextBox1.Text;
                    Response.Redirect("~/home.aspx");
                }
                else
                {
                    Label1.Text = "Incorrect Username/Password !";
                    Label1.Visible = true;
                }   
            }
            con.Close();
        }
    }
}