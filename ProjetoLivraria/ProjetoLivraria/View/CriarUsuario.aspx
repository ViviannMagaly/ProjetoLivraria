<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarUsuario.aspx.cs" Inherits="ProjetoLivraria.CriarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Novo Usuario</h1>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Nome Completo:"></asp:Label>
    <br />
    <asp:TextBox ID="edtNome" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
    <br />
    <asp:TextBox ID="edtEmail" runat="server" OnTextChanged="edtEmail_TextChanged" CausesValidation="True" TextMode="Email"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Senha:"></asp:Label>
    <br />
    <asp:TextBox ID="edtSenha" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Confirmar Senha:"></asp:Label>
    <br />
    <asp:TextBox ID="edtConfirmarSenha" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnConfirmar" runat="server" class="btn btn-outline-primary" Text="Confirmar" OnClick="btnConfirmar_Click" />
</asp:Content>

