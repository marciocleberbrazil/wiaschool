using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WIASchool.Students
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected void LoadData()
        {
            using (var context = new WIADBEntities())
            {
                listOfData.DataSource = context.Students;
                listOfData.DataBind();
            }
        }

        protected void listOfData_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "delete")
                {
                    using (var context = new WIADBEntities())
                    {
                        var id = Convert.ToInt32(e.CommandArgument);
                        var course = context.Students.Where(x => x.Id == id).FirstOrDefault();
                        if (course != null)
                        {
                            context.Students.DeleteObject(course);
                            context.SaveChanges();
                        }
                    }
                    LoadData();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        protected void listOfData_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HyperLink linkTo = (HyperLink)e.Item.FindControl("linkTo");
            Student course = (Student)e.Item.DataItem;
            linkTo.NavigateUrl = "~/Students/Update.aspx?id=" + course.Id.ToString();


            Button btnDelete = (Button)e.Item.FindControl("btnDelete");
            btnDelete.CommandName = "delete";
            btnDelete.CommandArgument = course.Id.ToString();

            Label labelSchool = (Label)e.Item.FindControl("labelSchool");

            using (var context = new WIADBEntities())
            {
                var school = context.Schools.Where(x => x.Id == course.SchoolId).FirstOrDefault();

                labelSchool.Text = school != null ? school.Name : String.Empty;
            }
        }
    }
}