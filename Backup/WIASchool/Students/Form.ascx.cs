using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WIASchool.Students
{
    public partial class Form : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSchools();

                if (Request.QueryString["id"] != null && !String.IsNullOrEmpty(Request.QueryString["id"].ToString()))
                {
                    using (var context = new WIADBEntities())
                    {
                        var id = Convert.ToInt32(Request.QueryString["id"]);
                        var student = context.Students.Where(x => x.Id == id).FirstOrDefault();
                        if (student != null)
                        {
                            ObjectId.Value = student.Id.ToString();
                            txtFirstName.Text = student.FirstName;
                            txtLastName.Text = student.LastName;
                            ckbValid.Checked = (bool)student.Allowed;
                            ddlSchools.SelectedValue = student.SchoolId.ToString();
                        }
                    }
                }
            }
        }

        protected void LoadSchools()
        {
            using (var context = new WIADBEntities())
            {
                ddlSchools.DataSource = context.Schools;
                ddlSchools.DataTextField = "Name";
                ddlSchools.DataValueField = "Id";
                ddlSchools.DataBind();
                ddlSchools.Items.Insert(0, new ListItem("Select a School", ""));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ObjectId.Value) > 0)
                {
                    using (var context = new WIADBEntities())
                    {
                        var id = Convert.ToInt32(ObjectId.Value);
                        var obj = context.Students.Where(x => x.Id == id).FirstOrDefault();

                        obj.FirstName = txtFirstName.Text;
                        obj.LastName = txtLastName.Text;
                        obj.Allowed = ckbValid.Checked;
                        obj.SchoolId = Convert.ToInt32(ddlSchools.SelectedValue);
                        obj.Updated = DateTime.Now;


                        context.SaveChanges();
                    }
                    Response.Redirect("~/students/Default.aspx", true);
                }
                else
                {
                    using (var context = new WIADBEntities())
                    {
                        var obj = new Student();
                        obj.FirstName = txtFirstName.Text;
                        obj.LastName = txtLastName.Text;
                        obj.Allowed = ckbValid.Checked;
                        obj.SchoolId = Convert.ToInt32(ddlSchools.SelectedValue);
                        obj.Created = DateTime.Now;
                        obj.Updated = DateTime.Now;

                        context.AddToStudents(obj);
                        context.SaveChanges();
                    }
                    Response.Redirect("~/students/Default.aspx", true);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/students/Default.aspx", true);
        }
    }
}