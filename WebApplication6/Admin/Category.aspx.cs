using System;
using System.Collections.Generic;
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

            bool isValidToExecute;
            if (fuCategoryImage.HasFile)
            {
                if (Utils.IsValidExtention(fuCategoryImage.FileName))
                {
                    Guid obj = Guid.NewGuid();
                    string fileExtension = Path.GetExtension(fuCategoryImage.FileName);
                    string imagePath = "Images/Category" + obj.ToString() + fileExtension;
                    fuCategoryImage.PostedFile.SaveAs(Server.MapPath("~/Images/Category") + obj.ToString() + fileExtension);
                    c.ImageUrl = imagePath;
                    isValidToExecute = true;
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Please select .jpg , .jpeg or .png image";
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
                        NotiCategory.Text = "Category is Added!!!";
                    }
                    else
                    {
                        NotiCategory.Text = "Something went wrong please try again later!!!";
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
            clear();
        }
        private void clear()
        {
            txtName.Text = string.Empty;
            cbIsActive.Checked = false;
            hdnId.Value = "0";
            btnAddOrUpdate.Text = "Add";
        }

    }
}