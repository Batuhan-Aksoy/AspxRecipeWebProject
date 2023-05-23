using Business.Concrate;
using DataAccess.Concrate.EfDAL;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Pages
{
    public partial class CategoryEdit : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    var category = categoryManager.GetCategoryById(Convert.ToInt32(Request.QueryString["Id"]));
                    CategoryName.Value = category.Name;
                    CreateCategoryButton.Text = "Güncelle";
                    CategoryEditTitle.InnerText = "Kategori Güncelle";
                }
            }
        }

        protected void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)//update
            { 
                var category= categoryManager.GetCategoryById(Convert.ToInt32(Request.QueryString["Id"]));
                category.Name = CategoryName.Value;
                categoryManager.Update(category);
            }
            else
            {
                Category category = new Category()
                {
                    Name = CategoryName.Value
                };
                categoryManager.Add(category);
            }

            Response.Write("<script>" +
                    "if (window.confirm('İşlem Başarılı')) {" +
                    "window.location.href ='Categories.aspx'" +
                    "}else {" +
                    "window.location.href ='Categories.aspx'" +
                    "}" +
                    "</script>");
        }
    }
}