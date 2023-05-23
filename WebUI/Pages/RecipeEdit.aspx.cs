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
    public partial class RecipeEdit : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        RecipeManager recipeManager = new RecipeManager(new EfRecipeDAL());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //postdan kaynaklı load ise içeri girme sadece normal sayfa loadlarında içeri gir
            {
                RecipeEditCategoryDropdown.DataSource = categoryManager.GetCategories();
                RecipeEditCategoryDropdown.DataTextField = "Name";
                RecipeEditCategoryDropdown.DataValueField = "Id";
                RecipeEditCategoryDropdown.DataBind();
                RecipeEditCategoryDropdown.Items.Insert(0, "Select...");
                if (Request.QueryString["Id"] != null)
                {
                    var recipeId = Request.QueryString["Id"];
                    var recipe = recipeManager.GetRecipeById(Convert.ToInt32(recipeId));
                    RecipeName.Value = recipe.Name;
                    RecipeEditCategoryDropdown.Items.FindByValue(recipe.CategoryId.ToString()).Selected = true;
                    RecipeCreatedBy.Value = recipe.CreatedBy;
                    CreateRecipeButton.Text = "Güncelle";
                    if(RecipeEditTitle != null) 
                        RecipeEditTitle.InnerText = "Tarif Güncelle";
                }
            }
            
        }

        protected void CreateRecipeButton_Click(object sender, EventArgs e)
        {
            var recipeCategory = RecipeEditCategoryDropdown.SelectedItem.Value;
            if (recipeCategory.Contains("Select").Equals(true))
            {
                Response.Write("<script>alert('Kategori Boş Geçilemez')</script>");
            }
            else
            {
                var recipeName = RecipeName.Value;
                var recipeCreatedBy = RecipeCreatedBy.Value;
                if (Request.QueryString["Id"] != null)
                {
                    var recipe = recipeManager.GetRecipeById(Convert.ToInt32(Request.QueryString["Id"]));
                    recipe.Name = recipeName;
                    recipe.CreatedBy = recipeCreatedBy;
                    recipe.CategoryId = Convert.ToInt32(recipeCategory);
                    recipeManager.Update(recipe);
                }
                else
                {
                    Recipe recipe = new Recipe()
                    {
                        Name = recipeName,
                        CategoryId = Convert.ToInt32(recipeCategory),
                        CreatedBy = recipeCreatedBy,
                        CreatedDate = DateTime.Now
                    };
                    recipeManager.Add(recipe);
                }
                    
                Response.Write("<script>" +
                    "if (window.confirm('İşlem Başarılı')) {" +
                    "window.location.href ='Recipes.aspx'" +
                    "}else {" +
                    "window.location.href ='Recipes.aspx'" +
                    "}" +
                    "</script>");
                
            }

        }
    }
}