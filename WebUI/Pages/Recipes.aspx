<%@ Page Title="Tarifler" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="Recipes.aspx.cs" Inherits="WebUI.Pages.Recides" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Tarifler</h3>
    <form runat="server">

        <asp:ScriptManager runat="server"  EnablePageMethods="true"></asp:ScriptManager> 
        <%--bu js içinde server side fonkları yani c# fonklarını kullanabilmemiz için ama fonka [WebMethod] attribute eklemek
            ve static olarak tanımlamak gerekiyor.--%>
    <asp:DropDownList ID="CategoryDropDownList" class="dropdown p-1" AutoPostBack="True" OnSelectedIndexChanged="CategoryDropDownList_SelectedIndexChanged" runat="server">  
    </asp:DropDownList>

    <asp:Button ID="NewRecideButton" class="btn btn-primary" OnClick="NewRecideButton_Click" runat="server" Text="Traif Ekle" ></asp:Button>
       

    <table class='table'>
        <thead>
            
            <tr>
                <th scope ='col'> Id </th>
                <th scope ='col'> Actions </th>
                <th scope ='col'> Name </th>
                <th scope ='col'> CategoryName </th>
                <th scope ='col'> CreatedBy </th>
                <th scope ='col'> CreatedDate </th>
            </tr>
        </thead>
        <tbody id="RecideTable" runat ="server"></tbody>              
    </table>
     </form>
    

    <script type="text/javascript">
        function ViewRecipeButton_Click(RecipeId) {
            window.location.href = "RecipeDetail.aspx?Id=" + RecipeId;
        }
        function EditRecipeButton_Click(RecipeId) {
            window.location.href = "RecipeEdit.aspx?Id=" + RecipeId;
        }
        function DeleteRecipeButton_Click(RecipeId) {
            if (window.confirm('Tarifi Silmek istediğinizden Emin misiniz ?')) {
                PageMethods.DeleteRecipeButton_Click(RecipeId, IsSuccess, IsError); //c# methodunu çağırmak için
                function IsSuccess(result) // c# methodu bittiğinde retrun ü karşılayan fonksiyon
                {
                    if (result == true)
                        window.location.reload(true);
                }
                function IsError(result) { //c# methodu hataya düştüğünde çalışan fonk
                    alert(result);
                }
            }
           
        }
    </script>
</asp:Content>
