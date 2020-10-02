<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewProductTypePage.aspx.cs" Inherits="Assignment.View.Admin.ViewProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <asp:GridView runat="server" ID="_allProduct" Height="211px" Width="452px" AutoGenerateColumns="false" style="text-align: center">
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
    <br /><br />
    <asp:Button runat="server" ID="insertproducttype" Text="Insert Product Type" OnClick="insertproducttype_Click"/>
    <asp:Button runat="server" ID="deleteproducttype" Text="Delete Product Type" OnClick="deleteproducttype_Click" />
    <asp:Button runat="server" ID="updateproducttype" Text="Update Product Type" OnClick="updateproducttype_Click" />
</asp:Content>
