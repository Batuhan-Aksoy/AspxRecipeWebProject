<%@ Page Title="Kategoriler" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="WebUI.Pages.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Kategoriler</h3>
    <form runat="server">
    <asp:ScriptManager runat="server"  EnablePageMethods="true"></asp:ScriptManager>
        <asp:Button ID="NewCategoryButton" class="btn btn-primary" OnClick="NewCategoryButton_Click" runat="server" Text="Kategori Ekle" ></asp:Button>
    </form>
    
     <table class='table'>
        <thead>
            <tr>
                <th scope ='col'> Id </th>
                <th scope ='col'> Actions </th>
                <th scope ='col'> Name </th>
            </tr>
        </thead>
        <tbody id="CategoryTable" runat ="server"></tbody>              
    </table>
    <script type="text/javascript">
        function EditCategoryContentButton_Click(CategoryId) {
            window.location.href = "CategoryEdit.aspx?Id=" + CategoryId;
        }
        function DeleteCategoryContentButton_Click(CategoryId) {
            if (window.confirm('Tarifi Silmek istediğinizden Emin misiniz ?')) {
                PageMethods.DeleteRecipeContentButton_Click(CategoryId, IsSuccess, IsError);
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
