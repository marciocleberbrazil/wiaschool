<%@ Page Title="" Language="C#" MasterPageFile="~/Schools/Schools.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WIASchool.Schools.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent2" runat="server">

<table border="1" cellpadding="0" cellspacing="0">
    <thead>
        <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Address</td>
            <td>City</td>
            <td>State</td>
            <td>Open</td>
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
        <td><%#Eval("Name") %></td>
        <td><%#Eval("Address") %> - <%#Eval("Address2") %></td>
        <td><%#Eval("City") %></td>
        <td><%#Eval("State") %></td>
        <td><asp:Label ID="labelValid" runat="server"></asp:Label></td>
        <td><%#Eval("Created") %></td>
        <td><asp:HyperLink ID="linkTo" runat="server" Text="Update"></asp:HyperLink></td>
        <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('Are you sure?')" /></td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
</table>

</asp:Content>
