<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="GuessViewProductPage.aspx.cs" Inherits="Assignment.View.Guess.GuessViewProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" OnClick="back_Click" Text="Back"/>
    <asp:GridView runat="server" ID="_allproduct" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="ProductID" DataField="ProductID"/>
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
