<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="DeleteProductTypePage.aspx.cs" Inherits="Assignment.View.Admin.DeleteProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <asp:GridView runat="server" ID="_allproduct" Height="211px" Width="452px" AutoGenerateColumns="false" style="text-align: center">
        <Columns>
            <asp:BoundField HeaderText="Product Type ID" DataField="producttypeid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Product Type Name" DataField="producttypename"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Description" DataField="descript"/>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">ID product type you want to delete</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="id"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="deleteproducttype" Text="Delete" OnClick="deleteproducttype_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
