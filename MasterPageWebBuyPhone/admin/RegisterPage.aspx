<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h4 style="color: #007bff; text-align: center">Form Register</h4>
        <p style="color: #007bff; text-align: center">&nbsp;</p>
        <div class="form-group">
            <label>Username</label>
            <asp:TextBox ID="Username" placeholder="Username" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator1" ControlToValidate="Username" runat="server" ErrorMessage="Username must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label>Password</label>
            <asp:TextBox ID="Password" placeholder="Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator2" ControlToValidate="Password" runat="server" ErrorMessage="Password must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Confirm Password</label>
            <asp:TextBox ID="ConfirmPassword" placeholder="Confirm Password" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:CustomValidator SetFocusOnError="true" ID="CustomValidator1" runat="server" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="Password And Confirm Password is Incorrect" ForeColor="Red" OnServerValidate="CustomPassValided" ValidateEmptyText="True"></asp:CustomValidator>
        </div>

        <div class="form-group">
            <label>Select Secret Question:</label>
            <asp:DropDownList ID="ListQuestion" runat="server" class="form-control">
            </asp:DropDownList>   
        </div>
        <div class="form-group">
            <label>Answer</label>
            <asp:TextBox ID="Answer" placeholder="Answer" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="Validator7" runat="server" ControlToValidate="Answer" Display="Dynamic" ErrorMessage="Answer must not Empty" ForeColor="Red" ValidateEmptyText="True"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Confirm Answer</label>
            <asp:TextBox ID="ConfirmAnswer" placeholder="Confirm Answer" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
            <asp:CustomValidator SetFocusOnError="true" ID="CustomValidator3" runat="server" ControlToValidate="ConfirmAnswer" Display="Dynamic" ErrorMessage="Answer And Confirm Answer is Incorrect" ForeColor="Red" OnServerValidate="CheckConfirmAnwser" ValidateEmptyText="True"></asp:CustomValidator>
        </div>
        <div class="form-group">
            <label>Full Name</label>
            <asp:TextBox ID="FullName" placeholder="Full Name" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator3" runat="server" ControlToValidate="FullName" Display="Dynamic" ErrorMessage="Full Name must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Address</label>
            <asp:TextBox ID="Address" placeholder="Address" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator4" runat="server" ControlToValidate="Address" Display="Dynamic" ErrorMessage="Address must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Email</label>
            <asp:TextBox ID="Email" TextMode="Email" placeholder="Email" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator5" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Email must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>Phone</label>
            <asp:TextBox ID="Phone" placeholder="Phone" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator6" runat="server" ControlToValidate="Phone" Display="Dynamic" ErrorMessage="Phone must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label for="inputAddress">Passport</label>
            <asp:TextBox ID="Passport" placeholder="Passport" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator7" runat="server" ControlToValidate="Passport" Display="Dynamic" ErrorMessage="Passport must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label>Birthday</label>
            <asp:TextBox ID="Birthday" placeholder="Birthday" TextMode="Date" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator8" runat="server" ControlToValidate="Birthday" Display="Dynamic" ErrorMessage="Birthday must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <label>
            Sex
        </label>
        <br />
        <div class="form-check-inline">
            <label class="form-check-label" for="radio1">
                <asp:RadioButton ID="Male" class="form-check-input" GroupName="Sex" runat="server" Text="Male" Checked="True" />
            </label>
        </div>
        <div class="form-check-inline">
            <label class="form-check-label" for="radio2">
                <asp:RadioButton ID="Female" class="form-check-input" GroupName="Sex" runat="server" Text="Female" />
            </label>
        </div>
        <br />
        <br />
        <asp:Button class="btn btn-primary" ID="btnRegister" runat="server" Text="Register" />
    </div>
</asp:Content>
