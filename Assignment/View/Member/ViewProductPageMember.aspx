<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewProductPageMember.aspx.cs" Inherits="Assignment.View.Member.ViewProductPageMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <asp:GridView runat="server" ID="_allproduct" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="ProductID" DataField="productid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="ProductTypeID" DataField="producttypeid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="ProductName" DataField="productname"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Price" DataField="price"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Stock" DataField="stock"/>
        </Columns>
    </asp:GridView>
</asp:Content>
