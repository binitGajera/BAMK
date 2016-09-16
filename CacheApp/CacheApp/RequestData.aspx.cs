using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace CacheApp
{
    public partial class RequestData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String selectsql="select * from Student ";
            String connectionStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\user1\\Source\\Repos\\BAMK\\CacheApp\\CacheApp\\App_Data\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionStr);
           SqlCommand cmd = new SqlCommand(selectsql, con);
            DataSet ds=new DataSet();
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            
            con.Open();
            adapter.Fill(ds,"Student" );
            Cache.Insert("tablename",ds,null,DateTime.Now.AddMinutes(60),TimeSpan.Zero);
          con.Close();
            }
        protected void Button_click(object sender,EventArgs e)
        {
            if(Cache["tablename"]==null)
            {
                lb1.Text="Data can't be retrieved from Cache";
            }
            else
            {
                DataSet temp=(DataSet)Cache["tablename"];

                lb1.Text = "success";
            }

        }
    }
}