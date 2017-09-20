<%@ Page Title="" Language="C#" MasterPageFile="~/Courses/Courses.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" EnableEventValidation="false" Inherits="WIASchool.Courses.Default" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent2" runat="server">

<h1>Courses</h1>

<table>
    <thead>
        <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Created</td>
            <td>Valid</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </thead>
    <asp:Repeater ID="listOfData" runat="server"
        onitemdatabound="listOfData_ItemDataBound" 
        onitemcommand="listOfData_ItemCommand">
    <ItemTemplate>
    <tr>
        <td><%#Eval("Id") %></td>
        <td><%#Eval("Name") %></td>
        <td><%#Eval("Created") %></td>
        <td><asp:Label ID="labelValid" runat="server"></asp:Label></td>
        <td><asp:HyperLink ID="linkTo" runat="server" Text="Update"></asp:HyperLink></td>
        <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('Are you sure?')" /></td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
</table>

</asp:Content>