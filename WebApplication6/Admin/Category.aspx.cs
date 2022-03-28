using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6.Admin
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Session["breadCrum"] = "Category";
            }
            lblMsg.Visible = false;
            GetCategories();
        }
        //Add and update Category
        protected void BtnAddOrUpdate_click(object sender, EventArgs e)
        {
            ServiceReferenceAdmin.AdminControlClient ct = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
            ServiceReferenceAdmin.Category c = new ServiceReferenceAdmin.Category();
            int categoryId = Convert.ToInt32(hdnId.Value);
            c.CategoryId = categoryId;
            c.Name = txtName.Text.Trim();
            c.IsActive = cbIsActive.Checked;
            c.CreatedDate = DateTime.Now;
            string fileExtension = Path.GetExtension(fuCategoryImage.FileName);

            bool isValidToExecute;
            if (fuCategoryImage.HasFile)
            {
                if (Utils.IsValidExtention(fileExtension))
                {
                    Guid obj = Guid.NewGuid();
                    string imagePath = "Images/Category/" + obj.ToString() + fileExtension;
                    fuCategoryImage.PostedFile.SaveAs(Server.MapPath("~/Images/Category/") + obj.ToString() + fileExtension);
                    c.ImageUrl = imagePath;
                    isValidToExecute = true;
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = fileExtension+ "Please select .jpg , .jpeg or .png image";
                    lblMsg.CssClass = "alert alert-danger";
                    isValidToExecute = false;
                }
            }
            else
            {
                isValidToExecute = true;
            }
            if (isValidToExecute)
            {
                if (categoryId == 0)
                {
                    if (ct.AddCategory(c))
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Category is Added!!!";
                        lblMsg.CssClass = "alert alert-success";
                        GetCategories();
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Category is Updated!!!";
                        lblMsg.CssClass = "alert alert-success";
                    }
                }
                else
                {
                    if (ct.UpdateCategory(c))
                    {
                        NotiCategory.Text = "Category is Updated!!!";
                    }
                    else
                    {
                        NotiCategory.Text = "Something went wrong please try again later!!!";
                    }
                }
            }
            Clear();
        }

        private void GetCategories()
        {
            ServiceReferenceAdmin.AdminControlClient ct = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
            DataSet ds = ct.SelectCategories();
            rCategory.DataSource = ds;
            rCategory.DataBind();
        }

        private void Clear()
        {
            txtName.Text = string.Empty;
            cbIsActive.Checked = false;
            hdnId.Value = "0";
            btnAddOrUpdate.Text = "Add";
        }

        protected void BtnClear_click(object sender, EventArgs e) => Clear();

        protected void rCategory_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            lblMsg.Visible = false;
            if (e.CommandName == "edit")
            {
                ServiceReferenceAdmin.AdminControlClient ct = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
                NotiCategory.Visible = true;
                int id = Convert.ToInt32(e.CommandArgument);
                NotiCategory.Text = id.ToString();
                DataSet ds = ct.SelectCategoryById(id);
                txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                cbIsActive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsActive"]);
                imgCategory.ImageUrl = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["ImageUrl"].ToString()) ? "../Images/No_image.png" : "../" + ds.Tables[0].Rows[0]["ImageUrl"].ToString();
                imgCategory.Height = 200;
                imgCategory.Width = 200;
                hdnId.Value = ds.Tables[0].Rows[0]["CategoryId"].ToString();
                btnAddOrUpdate.Text = "Update";
                LinkButton btn = e.Item.FindControl("lnkEdit") as LinkButton;
                btn.CssClass = "badge badge-warning";
            }
            else if(e.CommandName == "delete")
            {
                ServiceReferenceAdmin.AdminControlClient ct = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
                if (ct.DeleteCategory(Convert.ToInt32(e.CommandArgument)))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Category is Deleted!!!";
                    lblMsg.CssClass = "alert alert-success";
                    GetCategories();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Error while delete category please try again later!!!";
                    lblMsg.CssClass = "alert alert-danger";

                }
            }
        }

        protected void rCategory_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }
    }
}