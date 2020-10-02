<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ProfileMemberPage.aspx.cs" Inherits="Assignment.View.Member.ProfileUserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <br />
    <br />
    <asp:GridView runat="server" ID="_user" style="background-color:red" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID"/>
            <asp:BoundField DataField="Gender" HeaderText="Gender"/>
            <asp:BoundField DataField="Email" HeaderText="Email"/>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button runat="server" ID="updateprofile" Text="Update Profile" OnClick="updateprofile_Click"/>
    <asp:Button runat="server" ID="changepassword" Text="Change Password" OnClick="changepassword_Click"/>
</asp:Content>
