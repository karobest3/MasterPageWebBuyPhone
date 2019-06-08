<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
        <br />
    <br />
    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Select Manufacturer:"></asp:Label>
        <br />
        <asp:DropDownList ID="ListManufacturer" runat="server" AutoPostBack="True" OnSelectedIndexChanged="LoadGridView" Width="169px">
        </asp:DropDownList><br /><br />
    <asp:GridView ID="GridViewProduct" runat="server"
        DataKeyNames="ID_Product" OnRowEditing="EditGridView" 
        AutoGenerateColumns="false"
       >
        <Columns>
            <asp:BoundField DataField="ID_Product" HeaderText="ID" ReadOnly="true"/>  
            <asp:BoundField DataField="Name_Product" HeaderText="Name" />  
            <asp:BoundField DataField="ID_Manufacturer" HeaderText="Manufacturer" />
            <asp:BoundField DataField="Price_Product" HeaderText="Price"/>  
            <asp:BoundField DataField="Screen" HeaderText="Screen" />  
            <asp:BoundField DataField="Operating" HeaderText="Operating" />
            <asp:BoundField DataField="CPU" HeaderText="CPU"/>  
            <asp:BoundField DataField="RAM" HeaderText="RAM" />  
            <asp:BoundField DataField="FrontCamera" HeaderText="Front Camera" />
            <asp:BoundField DataField="RearCamera" HeaderText="Rear Camera"/>  
            <asp:BoundField DataField="SIM" HeaderText="Sim" />
            <asp:BoundField DataField="Battery" HeaderText="Battery"/>  
            <asp:CommandField ShowEditButton="true" />
        </Columns>
        <RowStyle HorizontalAlign="Center" />
    </asp:GridView>
        </div>
</asp:Content>
