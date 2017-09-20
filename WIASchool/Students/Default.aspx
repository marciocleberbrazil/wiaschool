<%@ Page Title="" Language="C#" MasterPageFile="~/Students/Students.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WIASchool.Students.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent2" runat="server">

<table border="1" cellpadding="0" cellspacing="0">
    <thead>
        <tr>
            <td>ID</td>
            <td>First Name</td>
            <td>Last Name</td>
            <td>School</td>
            <td>Created</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </thead>
    <asp:Repeater ID="listOfData" runat="server" 
        onitemcommand="listOfData_ItemCommand" 
        onitemdatabound="listOfData_ItemDataBound">
    <ItemTemplate>
    <tr>
        <td><%#Eval("Id") %></td>
        <td><%#Eval("FirstName") %></td>
        <td><%#Eval("LastName") %></td>
        <td><asp:Label ID="labelSchool" runat="server"></asp:Label></td>
        <td><%#Eval("Created") %></td>
        <td><asp:HyperLink ID="linkTo" runat="server" Text="Update"></asp:HyperLink></td>
        <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('Are you sure?')" /></td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
</table>

</asp:Content>
