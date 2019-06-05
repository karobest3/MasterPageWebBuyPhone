<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateInfoEmp.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.UpdateInfoEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h4 style="color: #007bff; text-align: center">Form Register</h4>
    <p style="color: #007bff; text-align: center">&nbsp;</p>
    <div class="container">
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
                <asp:RadioButton ID="RadioButton1" class="form-check-input" GroupName="Sex" runat="server" Text="Male" Checked="True" />
            </label>
        </div>
        <div class="form-check-inline">
            <label class="form-check-label" for="radio2">
                <asp:RadioButton ID="RadioButton2" class="form-check-input" GroupName="Sex" runat="server" Text="Female" />
            </label>
        </div>
        <br />
        <br />
         <asp:Button class="btn btn-primary"
            runat="server" Text="Save" 
             />
    </div>
</asp:Content>
