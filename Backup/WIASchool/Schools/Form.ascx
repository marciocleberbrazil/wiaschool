<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Form.ascx.cs" Inherits="WIASchool.Schools.Form" %>
<span class="failureNotification"></span>
<div class="accountInfo">
    <fieldset class="register">
        <legend>School Information</legend>
        <asp:HiddenField ID="ObjectId" runat="server" Value="0" />
        <p>
            <label for="">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label for="">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtAddress" runat="server" ErrorMessage="Address is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label for="">Address 2:</label>
            <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtAddress2" runat="server" ErrorMessage="txtAddress 2 is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label for="">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtCity" runat="server" ErrorMessage="City is required"></asp:RequiredFieldValidator>
        </p>
        <p>
            <label for="">State:</label>
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtState" runat="server" ErrorMessage="State is required"></asp:RequiredFieldValidator>
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