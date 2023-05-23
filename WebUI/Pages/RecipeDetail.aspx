<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Index.Master" AutoEventWireup="true" CodeBehind="RecipeDetail.aspx.cs" Inherits="WebUI.Pages.RecipeDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-between p-0 mt-4">
        <h3><b runat="server" id="RecipeNameTitle"></b></h3>
        <h3><b runat="server" id="RecipeCreatedBy"></b></h3>
        <h3><b runat="server" id="RecipeCreatedDate"></b></h3>
    </div>
    <hr class="m-0"/>
    <ul runat="server" id="RecipeContent" class="m-2">

    </ul>
</asp:Content>
