<%@ Page Title="" Language="C#" MasterPageFile="~/Schools/Schools.master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="WIASchool.Schools.Create" %>
<%@ Register src="Form.ascx" tagname="Form" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
<h2>
    Create a New School
</h2>
<uc1:Form ID="Form1" runat="server" />
</asp:Content>