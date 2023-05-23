<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="CategoryEdit.aspx.cs" Inherits="WebUI.Pages.CategoryEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="CategoryCreateForm">
        <h3 class="m-2" runat="server" id="CategoryEditTitle">Kategori Ekleme</h3>
       <div class="form-group m-2">
        <label for="CategoryName">Kaategori Adı</label>
        <input runat="server" type="text" required class="form-control" id="CategoryName" name="CategoryName" placeholder="Enter Category Name">
       </div>
        <asp:Button ID="CreateCategoryButton" CssClass="btn btn-success m-2" runat="server" Text="Kaydet" OnClick="CreateCategoryButton_Click" />
    </form>
</asp:Content>
