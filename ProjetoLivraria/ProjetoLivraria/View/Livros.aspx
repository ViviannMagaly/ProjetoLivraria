<%@ Page Title="Livros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Livros.aspx.cs" Inherits="ProjetoLivraria.View.Livros" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="divPrincipal" style="width: 100%; text-align: center; padding: 50px; border-radius: 15px; background-color: white;">
        <h1><asp:Label ID="edtTitulo" runat="server" Text="Livros:"></asp:Label></h1>
        <br />
        <br />
        <asp:GridView ID="grdLivros" runat="server" class="table table-striped table-bordered" AutoGenerateColumns="False" AllowSorting="True" AutoGenerateSelectButton="True" DataKeyNames="IdLivro" HorizontalAlign="Center" SelectedIndex="0">
            <Columns>
                <asp:BoundField DataField="IdLivro" HeaderText="Código Livro" />
                <asp:BoundField DataField="Isbn" HeaderText="Isbn" />
                <asp:BoundField DataField="Autor" HeaderText="Autor" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Preco" HeaderText="Preço" />
                <asp:BoundField DataField="DataPublicacao" HeaderText="Data Publicação" />
                <asp:BoundField DataField="ImagemCapa" HeaderText="Imagem Capa" />
            </Columns>
            <SelectedRowStyle BackColor="#99CCFF" />
        </asp:GridView>
        <br />
        <div style="width: 100%; text-align: center;">
            <asp:Button ID="btnAdicionar" runat="server" class="btn btn-outline-primary" Text="Novo Livro" OnClick="btnAdicionar_Click" />
            <asp:Button ID="btnEditar" runat="server" class="btn btn-outline-primary" Text="Editar Livro" OnClick="btnEditar_Click" />
            <asp:Button ID="btnExcluir" runat="server" class="btn btn-outline-primary" Text="Excluir Livro" OnClick="btnExcluir_Click" />
        </div>
    </div>
</asp:Content>
