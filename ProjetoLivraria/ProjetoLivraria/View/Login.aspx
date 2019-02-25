<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetoLivraria.View.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divPrincipal" style="width: 100%; text-align: center; padding:50px; border-radius: 15px; background-color: white;">
        <h1>Login</h1>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="E-mail:"></asp:Label>
        <br />
        <asp:TextBox ID="edtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Senha:"></asp:Label>
        <br />
        <asp:TextBox ID="edtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <div id="mensagem"></div>
        <br />
        <asp:Button ID="btnLogin" runat="server" class="btn btn-outline-primary" Text="Login" OnClick="btnLogin_Click" />
    </div>
</asp:Content>
