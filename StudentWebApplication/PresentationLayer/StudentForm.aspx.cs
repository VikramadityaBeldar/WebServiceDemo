using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentWebApplication.PresentationLayer
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Not in Use - Instead using AJAX
        //protected void btnGetStudent_Click(object sender, EventArgs e)
        //{
        //    lblMessage.Text = ""; // Clear previous messages

        //    StudentWebService studentService = new StudentWebService();

        //    try
        //    {
        //        int id = Convert.ToInt32(txtStudentId.Text);
        //        var student = studentService.GetStudentByID(id);

        //        if (student != null)
        //        {
        //            txtID.Text = student.ID.ToString();
        //            txtName.Text = student.Name;
        //            txtGender.Text = student.Gender;
        //            txtMarks.Text = student.Marks.ToString();
        //        }
        //        else
        //        {
        //            txtID.Text = "";
        //            txtName.Text = "";
        //            txtGender.Text = "";
        //            txtMarks.Text = "";
        //            lblMessage.Text = "Student not found.";
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        lblMessage.Text = "Please enter a valid numeric ID.";
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMessage.Text = "Error: " + ex.Message;
        //    }
        //}
    }
}