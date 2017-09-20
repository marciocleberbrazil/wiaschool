<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Form.ascx.cs" Inherits="WIASchool.Courses.Form" %>
<span class="failureNotification"></span>
<div class="accountInfo">
    <fieldset class="register">
        <legend>Course Information</legend>
        <asp:HiddenField ID="ObjectId" runat="server" Value="0" />
        <p>
            <label for="">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:CheckBox ID="ckbValid" runat="server" Text="Check if this course is valid" />
        </p>
    </fieldset>
    <p class="submitButton">
        <asp:Button ID="Button2" runat="server" Text="Cancel" onclick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
    </p>
</div>
