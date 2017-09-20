<%@ Page Title="" Language="C#" MasterPageFile="~/Students/Students.master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="WIASchool.Students.Create" %>
<%@ Register src="Form.ascx" tagname="Form" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
<h2>
    Create a New Students
</h2>

    <uc1:Form ID="Form1" runat="server" />

</asp:Content>