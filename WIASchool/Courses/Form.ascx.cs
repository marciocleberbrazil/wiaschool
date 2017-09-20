using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Data.Linq;

namespace WIASchool.Courses
{
    public partial class Form : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["id"] != null && !String.IsNullOrEmpty(Request.QueryString["id"].ToString()))
                {
                    using (var context = new DBDataContext())
                    {
                        var id = Convert.ToInt32(Request.QueryString["id"]);
                        var course = context.Courses.Where(x => x.Id == id).FirstOrDefault();
                        if (course != null)
                        {
                            ObjectId.Value = course.Id.ToString();
                            txtName.Text = course.Name;
                            ckbValid.Checked = (bool)course.Allowed;
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (Convert.ToInt32(ObjectId.Value) > 0)
                {
                    using (var context = new DBDataContext())
                    {
                        var id = Convert.ToInt32(ObjectId.Value);
                        var obj = context.Courses.Where(x => x.Id == id).FirstOrDefault();

                        obj.Name = txtName.Text;
                        obj.Allowed = ckbValid.Checked;
                        obj.Updated = DateTime.Now;


                        context.SubmitChanges();
                    }
                    Response.Redirect("~/Courses/Default.aspx", true);
                }
                else
                {
                    using (var context = new DBDataContext())
                    {
                        context.Courses.InsertOnSubmit(new Course()
                        {
                            Name = txtName.Text,
                            Allowed = ckbValid.Checked,
                            Created = DateTime.Now,
                            Updated = DateTime.Now
                        });

                        context.SubmitChanges();
                    }
                    Response.Redirect("~/Courses/Default.aspx", true);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Courses/Default.aspx", true);
        }
    }
}