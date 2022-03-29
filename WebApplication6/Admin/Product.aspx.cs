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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["breadCrum"] = "Product";
            }
            lblMsg.Visible = false;
            GetProducts();

        }

        protected void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            ServiceReferenceAdmin.AdminControlClient pd = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
            ServiceReferenceAdmin.Product p = new ServiceReferenceAdmin.Product();
            int productId = Convert.ToInt32(hdnId.Value);
            p.ProductId = productId;
            p.Name = txtName.Text.Trim();
            p.Description = txtDescription.Text.Trim();
            p.Price = Convert.ToDecimal(txtPrice.Text.Trim());
            p.Quantity =Convert.ToInt32( txtQuantity.Text.Trim());
            p.CategoryId =Convert.ToInt32( ddlCategories.SelectedValue);
            p.IsActive = cbIsActive.Checked;
            p.CreatedDate = DateTime.Now;
            string fileExtension = Path.GetExtension(fuProductImage.FileName);

            bool isValidToExecute;
            if (fuProductImage.HasFile)
            {
                if (Utils.IsValidExtention(fileExtension))
                {
                    Guid obj = Guid.NewGuid();
                    string imagePath = "Images/Product/" + obj.ToString() + fileExtension;
                    fuProductImage.PostedFile.SaveAs(Server.MapPath("~/Images/Product/") + obj.ToString() + fileExtension);
                    p.ImageUrl = imagePath;
                    isValidToExecute = true;
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = fileExtension + "Please select .jpg , .jpeg or .png image";
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
                if (productId == 0)
                {
                    if (pd.AddProduct(p))
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Product is Added!!!";
                        lblMsg.CssClass = "alert alert-success";
                        GetProducts();
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Something went wrong please try again later!!!";
                        lblMsg.CssClass = "alert alert-success";
                    }
                }
                else
                {
                    if (pd.UpdateProduct(p))
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Product is Updated!!!";
                        lblMsg.CssClass = "alert alert-success";
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Something went wrong please try again later!!!";
                        lblMsg.CssClass = "alert alert-success";
                    }
                }
            }
            Clear();

        }

        private void Clear()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            ddlCategories.ClearSelection();
            cbIsActive.Checked = false;
            hdnId.Value = "0";
            btnAddOrUpdate.Text = "Add";
            imgProduct.ImageUrl = string.Empty;

        }
        private void GetProducts()
        {
            ServiceReferenceAdmin.AdminControlClient pd = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
            DataSet ds = pd.SelectProducts();
            rProduct.DataSource = ds;
            rProduct.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e) => Clear();
        

        protected void rProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                ServiceReferenceAdmin.AdminControlClient pd = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
                int id = Convert.ToInt32(e.CommandArgument);
                lblMsg.Text = id.ToString();
                DataSet ds = pd.SelectProductById(id);
                txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtDescription.Text= ds.Tables[0].Rows[0]["Description"].ToString(); ;
                txtPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                txtQuantity.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                cbIsActive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["IsActive"]);
                ddlCategories.SelectedValue= ds.Tables[0].Rows[0]["CategoryId"].ToString();
                imgProduct.ImageUrl = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["ImageUrl"].ToString()) ? "../Images/No_image.png" : "../" + ds.Tables[0].Rows[0]["ImageUrl"].ToString();
                imgProduct.Height = 200;
                imgProduct.Width = 200;
                hdnId.Value = ds.Tables[0].Rows[0]["ProductId"].ToString();
                btnAddOrUpdate.Text = "Update";
                LinkButton btn = e.Item.FindControl("lnkEdit") as LinkButton;
                btn.CssClass = "badge badge-warning";
            }
            else if (e.CommandName == "delete")
            {
                ServiceReferenceAdmin.AdminControlClient pd = new ServiceReferenceAdmin.AdminControlClient("WSHttpBinding_IAdminControl");
                if (pd.DeleteProduct(Convert.ToInt32(e.CommandArgument)))
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Product is Deleted!!!";
                    lblMsg.CssClass = "alert alert-success";
                    GetProducts();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Error while delete Product please try again later!!!";
                    lblMsg.CssClass = "alert alert-danger";

                }
            }

        }

        protected void rProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Label lblIsActive = e.Item.FindControl("lblIsActive") as Label;
                Label lblQuantity = e.Item.FindControl("lblQuantity") as Label;
                if (lblIsActive.Text == "True")
                {
                    lblIsActive.Text = "Active";
                    lblIsActive.CssClass = "badge badge-success";
                }
                else
                {
                    lblIsActive.Text = "In-Active";
                    lblIsActive.CssClass = "badge badge-danger";
                }
                if(Convert.ToInt32(lblQuantity.Text) <= 5)
                {
                    lblQuantity.CssClass = "badge badge-danger";
                    lblQuantity.ToolTip = "Item about to be 'Out of stock' !";
                }
            }
        }
    }
}