<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddManufacturerPage.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.AddManufacturerPage1" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h4 style="color: #007bff; text-align: center">Add New Manufacturer</h4>
        <p style="color: #007bff; text-align: center">&nbsp;</p>
        <div class="form-group">
            <label>Name Manufacturer</label>
            <asp:TextBox ID="NameMNF" placeholder="Name Manufacturer" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator1" ControlToValidate="NameMNF" runat="server" ErrorMessage="Username must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
        <asp:Button class="btn btn-primary" ID="btnAddMNF" runat="server" Text="Save" OnClick="btnAddManufacturer" />
    </div>
</asp:Content>
