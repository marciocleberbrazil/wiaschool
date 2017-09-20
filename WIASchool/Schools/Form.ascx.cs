using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WIASchool.Schools
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
                        var school = context.Schools.Where(x => x.Id == id).FirstOrDefault();
                        if (school != null)
                        {
                            ObjectId.Value = school.Id.ToString();
                            txtName.Text = school.Name;
                            txtAddress.Text = school.Address;
                            txtAddress2.Text = school.Address2;
                            txtCity.Text = school.City;
                            txtState.Text = school.State;
                            ckbValid.Checked = (bool)school.Allowed;
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

                        var obj = context.Schools.Where(x => x.Id == id).FirstOrDefault();

                        obj.Name = txtName.Text;
                        obj.Address = txtAddress.Text;
                        obj.Address2 = txtAddress2.Text;
                        obj.City = txtCity.Text;
                        obj.State = txtState.Text;
                        obj.Allowed = ckbValid.Checked;
                        obj.Updated = DateTime.Now;

                        context.SubmitChanges();
                    }
                    Response.Redirect("~/schools/Default.aspx", true);
                }
                else
                {
                    using (var context = new DBDataContext())
                    {
                        context.Schools.InsertOnSubmit(new School()
                        {
                            Name = txtName.Text,
                            Address = txtAddress.Text,
                            Address2 = txtAddress2.Text,
                            City = txtCity.Text,
                            Allowed = ckbValid.Checked,
                            Created = DateTime.Now,
                            Updated = DateTime.Now
                        });

                        context.SubmitChanges();
                    }
                    Response.Redirect("~/Schools/Default.aspx", true);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Schools/Default.aspx", true);
        }
    }
}