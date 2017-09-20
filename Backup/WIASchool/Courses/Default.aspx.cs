using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WIASchool.Courses
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
                listOfData.DataSource = context.Courses;
                listOfData.DataBind();
            }
        }

        protected void listOfData_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HyperLink linkTo = (HyperLink)e.Item.FindControl("linkTo");
            Cours course = (Cours)e.Item.DataItem;
            linkTo.NavigateUrl = "~/Courses/Update.aspx?id=" + course.Id.ToString();

            Label labelValid = (Label)e.Item.FindControl("labelValid");
            labelValid.Text = (bool)course.Allowed ? "Yes" : "No";

            Button btnDelete = (Button)e.Item.FindControl("btnDelete");
            btnDelete.CommandName = "delete";
            btnDelete.CommandArgument = course.Id.ToString();
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
                        var course = context.Courses.Where(x => x.Id == id).FirstOrDefault();
                        if (course != null)
                        {
                            context.Courses.DeleteObject(course);
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
    }
}