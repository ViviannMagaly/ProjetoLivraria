<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarUsuario.aspx.cs" Inherits="ProjetoLivraria.CriarUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divPrincipal" style="width: 100%; text-align: center; padding:50px; border-radius: 15px; background-color: white;">
        <h1>Novo Usuario</h1>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nome Completo:"></asp:Label>
        <br />
        <asp:TextBox ID="edtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="edtEmail" runat="server" CausesValidation="True" TextMode="Email"></asp:TextBox>
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
        <div id="mensagem"></div>
        <br />
        <asp:Button ID="btnConfirmar" runat="server" class="btn btn-outline-primary" Text="Confirmar" OnClick="btnConfirmar_Click" />
    </div>
</asp:Content>

