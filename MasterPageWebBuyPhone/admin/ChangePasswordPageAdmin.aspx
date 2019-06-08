<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePasswordPageAdmin.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.ChangePasswordPageAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <br />
    <div class="container">
        <h4 style="color: #007bff; text-align: center">Form Register</h4>
        <p style="color: #007bff; text-align: center">&nbsp;</p>
        <div class="form-group">
            <label>Old Password</label>
            <asp:TextBox ID="OldPassword" placeholder="Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator1" ControlToValidate="OldPassword" runat="server" ErrorMessage="Old Password must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
          <asp:CustomValidator SetFocusOnError="true"
                ID="CustomValidator3" runat="server"
                ControlToValidate="OldPassword"
                Display="Dynamic" ErrorMessage="Old Password is incorrect" ForeColor="Red" OnServerValidate="CheckOldPassword"></asp:CustomValidator>
        </div>
        <div class="form-group">
            <label>New Password</label>
            <asp:TextBox ID="NewPassword" placeholder="New Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator9" ControlToValidate="NewPassword" runat="server" ErrorMessage="New Password must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>New Password Confirm</label>
            <asp:TextBox ID="NewPasswordConfirm" placeholder="New Password Confirm" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:CustomValidator SetFocusOnError="true" ID="CustomValidator2" runat="server" ControlToValidate="NewPasswordConfirm" Display="Dynamic" ErrorMessage="Password And Confirm Password is Incorrect" ForeColor="Red" OnServerValidate="CustomPassValided" ValidateEmptyText="True"></asp:CustomValidator>
        </div>
        <asp:Button class="btn btn-primary" ID="btnSaveChangePass"
            runat="server" Text="Save"/>
    </div>
</asp:Content>
