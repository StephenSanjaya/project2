<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Assignment.View.Admin.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat = "server" ID="back" OnClick="back_Click" Text="Back"/>
    <asp:GridView runat="server" ID="_prodtable"></asp:GridView>
    <asp:Table runat="server" ID="_producttable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">ID you want to update</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="id"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" ID="selectid" Text="Select ID" OnClick="selectid_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
