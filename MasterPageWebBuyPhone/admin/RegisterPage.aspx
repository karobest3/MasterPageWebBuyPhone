<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <h4 style="color: #007bff; text-align: center">Form Register</h4>
        <p style="color: #007bff; text-align: center">&nbsp;</p>
        <div class="form-group">
            <label>Username</label>
            <asp:TextBox ID="Username" placeholder="Username" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredUserName"
                ControlToValidate="Username" runat="server" ErrorMessage="Username must not Empty" ForeColor="Red" Display="Dynamic" EnableTheming="True"></asp:RequiredFieldValidator>
            <asp:CustomValidator SetFocusOnError="true"
                ID="CustomValidator3" runat="server"
                ControlToValidate="Username"
                Display="Dynamic" ErrorMessage="Username is already exists" ForeColor="Red" OnServerValidate="CheckUsername" ValidateEmptyText="True"></asp:CustomValidator>
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator2" runat="server" 
                ErrorMessage="Username must 4-12 character, NOT begin number and character special !!!" 
                ValidationExpression="^(?=.{4,90}$)[a-zA-Z][a-zA-Z0-9_-]+$"
                ClientIDMode="Static" ControlToValidate="Username" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RegularExpressionValidator>
            </div>


        <div class="form-group">
            <label>Full Name</label>
            <asp:TextBox ID="FullName" placeholder="Full Name" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator3" runat="server" ControlToValidate="FullName" Display="Dynamic" ErrorMessage="Full Name must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label>Email</label>
            <asp:TextBox ID="Email" TextMode="Email" placeholder="Email" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator5" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Email must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email Invalid" 
                ValidationExpression="^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$" ClientIDMode="Static" 
                ControlToValidate="Email" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <label>Phone</label>
            <asp:TextBox ID="Phone" placeholder="Phone" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator6" runat="server" ControlToValidate="Phone" ErrorMessage="Phone must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator3" runat="server" 
                ErrorMessage="Phone is incorrect !!!" 
                ValidationExpression="^([0-9][0-9]{1,19}$)|\+84[0-9]{1,17}$"
                ClientIDMode="Static" ControlToValidate="Phone" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RegularExpressionValidator>
        </div>
    
        <br />
        <br />
        <asp:Button class="btn btn-primary" ID="btnRegister"
            runat="server" Text="Register"
            OnClientClick="if(Page_ClientValidate()) { this.disabled = true;this.value='Please wait...'; } else {return false;}"
            UseSubmitBehavior="false" />
    </div>
</asp:Content>
