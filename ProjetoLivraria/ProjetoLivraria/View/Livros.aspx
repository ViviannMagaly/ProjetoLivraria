<%@ Page Title="Livros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Livros.aspx.cs" Inherits="ProjetoLivraria.View.Livros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
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
    <table>
        <tr>
            <td>
                <asp:Button ID="btnAdicionar" runat="server" class="btn btn-outline-primary" Text="Novo Livro" OnClick="btnAdicionar_Click" />
            </td>            
            <td>
                <asp:Button ID="btnEditar" runat="server" class="btn btn-outline-primary" Text="Editar Livro" OnClick="btnEditar_Click" />
            </td>
            <td>
                <asp:Button ID="btnExcluir" runat="server" class="btn btn-outline-primary" Text="Excluir Livro" OnClick="btnExcluir_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
