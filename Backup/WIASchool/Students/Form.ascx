<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Form.ascx.cs" Inherits="WIASchool.Students.Form" %>
<span class="failureNotification"></span>
<div class="accountInfo">
    <fieldset class="register">
        <legend>Students Information</legend>
        <asp:HiddenField ID="ObjectId" runat="server" Value="0" />
        <p>
            <label for="">First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtFirstName" runat="server" ErrorMessage="First Name is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label for="">Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtLastName" runat="server" ErrorMessage="Last Name is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label>School</label>
            <asp:DropDownList ID="ddlSchools" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="ddlSchools" runat="server" ErrorMessage="Select a School"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:CheckBox ID="ckbValid" runat="server" Text="Check if this school is open" />
        </p>
    </fieldset>
    <p class="submitButton">
        <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
    </p>
</div>