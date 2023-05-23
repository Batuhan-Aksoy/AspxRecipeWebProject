<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="RecipeContentEdit.aspx.cs" Inherits="WebUI.Pages.RecipeContentEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" id="RecipeContentCreateForm">
        <h3 class="m-2" runat="server" id="RecipeContentEditTitle">İçerik Ekle</h3>
      <div class="form-group m-2">
        <label for="ContentTextArea">İçerik</label>
        <textarea required runat="server" class="form-control" id="ContentTextArea" name="ContentTextArea" placeholder="Enter Content"></textarea>
      </div>
        <asp:Button ID="CreateContentButton" CssClass="btn btn-success m-2" runat="server" Text="Kaydet" OnClick="CreateContentButton_Click" />
    </form>

</asp:Content>
