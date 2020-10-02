<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewUserPage.aspx.cs" Inherits="Assignment.View.Admin.ViewUserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <div>
        <br />
        <br />
&nbsp;<asp:GridView runat="server" ID="_allUser" Height="211px" Width="452px" AutoGenerateColumns="false" OnRowCommand="_allUser_RowCommand" style="text-align: center">
        <Columns>
            <asp:BoundField HeaderText="User ID" DataField="userid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Role ID" DataField="roleid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Username" DataField="username"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Email" DataField="email"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Gender" DataField="gender"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Status" DataField="status"/>
        </Columns>
        <Columns>
            <asp:ButtonField HeaderText="Change Status" ButtonType="Button" Text="Change" CommandName="changestatus">
            <ControlStyle BackColor="#CC3300" />
            </asp:ButtonField>
        </Columns>
        </asp:GridView>
        <br /><br />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server">Input ID to change the role</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="id"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button runat="server" ID="update" Text="Update" OnClick="update_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
