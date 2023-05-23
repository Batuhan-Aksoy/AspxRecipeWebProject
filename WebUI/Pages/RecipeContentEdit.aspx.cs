using Business.Concrate;
using DataAccess.Concrate.EfDAL;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace WebUI.Pages
{
    public partial class RecipeContentEdit : System.Web.UI.Page
    {
        ContentManager contentManager = new ContentManager(new EfContentDAL());
        public static int RecipeId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["ContentId"] != null)
                {
                    var contentId = Request.QueryString["ContentId"];
                    var content = contentManager.GetContentById(Convert.ToInt32(contentId));
                    ContentTextArea.Value = content.Name;
                    CreateContentButton.Text = "Güncelle";
                    RecipeContentEditTitle.InnerText = "İçerik Güncelle";
                }
                else
                {
                    RecipeId = Convert.ToInt32(Request.QueryString["RecipeId"]);
                }
            }
        }

        protected void CreateContentButton_Click(object sender, EventArgs e)
        {
            var contentValue = ContentTextArea.Value;
            var processRecipeId = 0;
            if (Request.QueryString["ContentId"] != null) //update
            {
                var content = contentManager.GetContentById(Convert.ToInt32(Request.QueryString["ContentId"]));
                content.Name = contentValue;
                contentManager.Update(content);
                processRecipeId = content.RecipeId;
            }
            else //add
            {
                Content newcontent = new Content()
                {
                    Name = contentValue,
                    RecipeId = RecipeId
                };
                contentManager.Add(newcontent);
                processRecipeId = RecipeId;
            }

            Response.Write("<script>" +
                    "if (window.confirm('İşlem Başarılı')) {" +
                    "window.location.href ='RecipeContent.aspx?RecipeId="+ processRecipeId + "'" +
                    "}else {" +
                    "window.location.href ='RecipeContent.aspx?RecipeId="+processRecipeId+"'" +
                    "}" +
                    "</script>");
        }
    }
}