<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdicaoLivro.aspx.cs" Inherits="ProjetoLivraria.View.NovoLivro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <asp:Label ID="edtTitulo" runat="server" Text="Novo Livro"></asp:Label></h1>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="ISBN:"></asp:Label>
    <br />
    <asp:TextBox ID="edtISBN" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Autor:"></asp:Label>
    <br />
    <asp:TextBox ID="edtAutor" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
    <br />
    <asp:TextBox ID="edtNome" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Preço:"></asp:Label>
    <br />
    <asp:TextBox ID="edtPreco" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Data Publicação:"></asp:Label>
    <br />
    <asp:TextBox ID="edtDataPublicacao" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <div id="mensagem"></div>
    <br />
    <asp:Button ID="btnConfirmar" runat="server" class="btn btn-outline-primary" Text="Confirmar" OnClick="btnConfirmar_Click" />
    <asp:Button ID="btnCancelar" runat="server" class="btn btn-outline-primary" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
