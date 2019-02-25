<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoLivraria._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divPrincipal" style="width: 100%; text-align: center; padding:50px; border-radius: 15px; background-color: white;">
        <br />
        <asp:Button ID="btnLogin" runat="server" class="btn btn-outline-primary" Text="Login" Width="120px" OnClick="btnLogin_Click"/>
        <br />
        <br />
        <asp:Button ID="btnCriarConta" runat="server" class="btn btn-outline-primary" Text="Novo Usuario" Width="120px" OnClick="btnCriarConta_Click" />
        <br />
        <div id="mensagem"></div>        
    </div>
</asp:Content>
