using Business.Concrate;
using DataAccess.Concrate.EfDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Pages
{
    public partial class RecipeDetail : System.Web.UI.Page
    {
        RecipeManager recipeManager = new RecipeManager(new EfRecipeDAL());
        ContentManager contentManager = new ContentManager(new EfContentDAL());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
            {
                var recipe = recipeManager.GetRecipeById(Convert.ToInt32(Request.QueryString["Id"]));
                RecipeNameTitle.InnerText = recipe.Name;
                RecipeCreatedBy.InnerText = recipe.CreatedBy;
                RecipeCreatedDate.InnerText = recipe.CreatedDate.ToString();
                var recipeContents = contentManager.GetContentsByRecipeId(Convert.ToInt32(Request.QueryString["Id"]));
                foreach (var recipeContent in recipeContents)
                {
                    RecipeContent.InnerHtml += "<li>" +
                        recipeContent.ContentName +
                        "</li>";
                }
            }
                
        }
    }
}