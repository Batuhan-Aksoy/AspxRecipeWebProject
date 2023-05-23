<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="RecipeEdit.aspx.cs" Inherits="WebUI.Pages.RecipeEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form runat="server" id="RecipeCreateForm">
        <h3 class="m-2" runat="server" id="RecipeEditTitle">Tarif Ekleme</h3>
       <div class="form-group m-2">
        <label for="RecipeName">Tarif Adı</label>
        <input runat="server" type="text" required class="form-control" id="RecipeName" name="RecipeName" placeholder="Enter Recipe">
      </div>
        <div class="form-group m-2">
            <label for="RecipeName">Kategori</label><br />
            <asp:DropDownList ID="RecipeEditCategoryDropdown" class="dropdown border-1 p-1" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
      <div class="form-group m-2">
        <label for="RecipeCreatedBy">Oluşturan</label>
        <input required runat="server" type="text" class="form-control" id="RecipeCreatedBy" placeholder="Enter CreatedBy">
      </div>
        <asp:Button ID="CreateRecipeButton" CssClass="btn btn-success m-2" runat="server" Text="Kaydet" OnClick="CreateRecipeButton_Click" />
    </form>
    
</asp:Content>
