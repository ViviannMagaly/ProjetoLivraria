<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoLivraria._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 100%; text-align: center;">
        <br />
        <asp:Button ID="btnLogin" runat="server" class="btn btn-outline-primary" Text="Login" Width="120px" OnClick="btnLogin_Click" />
        <br />
        <br />
        <asp:Button ID="btnCriarConta" runat="server" class="btn btn-outline-primary" Text="Novo Usuario" Width="120px" OnClick="btnCriarConta_Click" />
    </div>
</asp:Content>
