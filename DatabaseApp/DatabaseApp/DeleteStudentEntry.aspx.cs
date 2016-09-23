using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DatabaseApp
{
    public partial class DeleteStudentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Int32.Parse(stud_id.Text);
            }
            catch (Exception ex)
            {
                message.Text = "Please enter valid id";
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\user1\\Source\\Repos\\BAMK\\DatabaseApp\\DatabaseApp\\App_Data\\Student_Info.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT student_id from student_result WHERE student_id=@id";
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Close();
                    command.CommandText = "DELETE FROM student_result WHERE student_id=@id1";
                    command.Parameters.AddWithValue("@id1", id);
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        message.Text = "Student record deleted succesfully";
                    }
                    else
                    {
                        message.Text = "Error while deleting";
                    }
                }
                else
                {
                    message.Text = "Student id does not exist";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                message.Text = "Error while deleting";
            }
        }
    }
}