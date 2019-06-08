<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateInfoEmp.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.UpdateInfoEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h4 style="color: #007bff; text-align: center">Form Update</h4>
    <p style="color: #007bff; text-align: center">&nbsp;</p>
    <div class="container">
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
        <div class="form-group">
            <label>Address</label>
            <asp:TextBox ID="Address" placeholder="Address" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator10" runat="server" ControlToValidate="Address" Display="Dynamic" ErrorMessage="Address must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label for="inputAddress">Passport</label>
            <asp:TextBox ID="Passport" placeholder="Passport" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator11" runat="server" ControlToValidate="Passport" Display="Dynamic" ErrorMessage="Passport must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label>Birthday</label>
            <asp:TextBox ID="Birthday" placeholder="Birthday" TextMode="Date" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator12" runat="server" ControlToValidate="Birthday" Display="Dynamic" ErrorMessage="Birthday must not Empty" ForeColor="Red"></asp:RequiredFieldValidator>
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
         <asp:Button class="btn btn-primary"
            runat="server" Text="Save" OnClick="btnUpdate_Click" 
             />
    </div>
</asp:Content>
