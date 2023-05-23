<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="RecipeContent.aspx.cs" Inherits="WebUI.Pages.RecipeContent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <asp:ScriptManager runat="server"  EnablePageMethods="true"></asp:ScriptManager> 

        <asp:DropDownList ID="RecipeDropDownList" class="dropdown p-1" AutoPostBack="True" OnSelectedIndexChanged="RecipeDropDownList_SelectedIndexChanged" runat="server">  
        </asp:DropDownList>

        <asp:Button ID="NewContentButton" class="btn btn-primary" OnClick="NewContentButton_Click" runat="server" Text="İçerik Ekle" ></asp:Button>
        <table class='table'>
            <thead>
                <tr>
                    <th scope ='col'> Id </th>
                    <th scope ='col'> Actions </th>
                    <th scope ='col'> ContentName </th>
                </tr>
            </thead>
            <tbody id="RecideContentTable" runat ="server"></tbody>              
        </table>
    </form>

    <script type="text/javascript">
        function EditRecipeContentButton_Click(ContentId) {
            window.location.href = "RecipeContentEdit.aspx?ContentId=" + ContentId;
        }
        function DeleteRecipeContentButton_Click(ContentId) {
            if (window.confirm('Tarifi Silmek istediğinizden Emin misiniz ?')) {
                PageMethods.DeleteRecipeContentButton_Click(ContentId, IsSuccess, IsError); 
                function IsSuccess(result) 
                {
                    if (result == true)
                        window.location.reload(true);
                }
                function IsError(result) { 
                    alert(result);
                }
            }
           
        }
    </script>
</asp:Content>
