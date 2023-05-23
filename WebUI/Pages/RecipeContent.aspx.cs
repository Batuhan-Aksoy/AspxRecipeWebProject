using Business.Concrate;
using DataAccess.Concrate.EfDAL;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Pages
{
    public partial class RecipeContent : System.Web.UI.Page
    {
        RecipeManager recipeManager = new RecipeManager(new EfRecipeDAL());
        ContentManager contentManager = new ContentManager(new EfContentDAL());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                RecipeDropDownList.DataSource = recipeManager.GetAll();
                RecipeDropDownList.DataTextField = "Name";
                RecipeDropDownList.DataValueField = "Id";
                RecipeDropDownList.DataBind();
                RecipeDropDownList.Items.Insert(0, "Select...");

                if (Request.QueryString["RecipeId"] != null)
                {
                    RecipeDropDownList.Items.FindByValue(Request.QueryString["RecipeId"]).Selected = true;
                    RecipeDropDownList_SelectedIndexChanged(sender,e);
                }
            }
        }

        protected void RecipeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = RecipeDropDownList.SelectedItem.Value;
            if (selectedValue.Contains("Select").Equals(true))
            {
                RecideContentTable.InnerHtml = "";
            }
            else
            {
                var result = contentManager.GetContentsByRecipeId(Convert.ToInt32(selectedValue));
                SetRecipeContentTable(result);
            }
        }

        protected void NewContentButton_Click(object sender, EventArgs e)
        {
            var selectedValue = RecipeDropDownList.SelectedItem.Value;
            if (selectedValue.Contains("Select").Equals(false)) {
                Response.Redirect("RecipeContentEdit.aspx?RecipeId="+selectedValue);
            }
            else
            {
                Response.Write("<script>alert('İlgili Tarifi Seçip Tekrar Deneyiniz!')</script>");
            }
                
        }

        protected void SetRecipeContentTable(List<RecipeContentDTO> RecipeContentData)
        {

            RecideContentTable.InnerHtml = "";
            foreach (var content in RecipeContentData)
            {
                RecideContentTable.InnerHtml += "<tr>" +
                    "<td>" + content.ContentId + "</td>" +
                    "<td>" +

                   "<svg xmlns='http://www.w3.org/2000/svg' onclick='EditRecipeContentButton_Click(" + content.ContentId + ")' style='cursor:pointer; margin:0 5% 0 0;' width='25' height='25' viewBox='0 0 512 512'><path d='M471.6 21.7c-21.9-21.9-57.3-21.9-79.2 0L362.3 51.7l97.9 97.9 30.1-30.1c21.9-21.9 21.9-57.3 0-79.2L471.6 21.7zm-299.2 220c-6.1 6.1-10.8 13.6-13.5 21.9l-29.6 88.8c-2.9 8.6-.6 18.1 5.8 24.6s15.9 8.7 24.6 5.8l88.8-29.6c8.2-2.7 15.7-7.4 21.9-13.5L437.7 172.3 339.7 74.3 172.4 241.7zM96 64C43 64 0 107 0 160V416c0 53 43 96 96 96H352c53 0 96-43 96-96V320c0-17.7-14.3-32-32-32s-32 14.3-32 32v96c0 17.7-14.3 32-32 32H96c-17.7 0-32-14.3-32-32V160c0-17.7 14.3-32 32-32h96c17.7 0 32-14.3 32-32s-14.3-32-32-32H96z'/></svg>" +

                    "<svg xmlns='http://www.w3.org/2000/svg' onclick='DeleteRecipeContentButton_Click(" + content.ContentId + ");' style='cursor:pointer' width='25' height='25' viewBox='0 0 448 512'><path d='M135.2 17.7L128 32H32C14.3 32 0 46.3 0 64S14.3 96 32 96H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H320l-7.2-14.3C307.4 6.8 296.3 0 284.2 0H163.8c-12.1 0-23.2 6.8-28.6 17.7zM416 128H32L53.2 467c1.6 25.3 22.6 45 47.9 45H346.9c25.3 0 46.3-19.7 47.9-45L416 128z'/></svg>" +
                    "</td>" +
                    "<td>" + content.ContentName + "</td>" +
                    "</tr>";
            }
        }

        [WebMethod]
        public static bool DeleteRecipeContentButton_Click(int contentId)
        {
            ContentManager contentManagerInstance = new ContentManager(new EfContentDAL());
            var content = contentManagerInstance.GetContentById(contentId);
            contentManagerInstance.Delete(content);
            return true;
        }
    }
}