﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListRoles.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.ListRoles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <br />
    <br />
    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Select Roles:"></asp:Label>
        <br />
        <asp:DropDownList ID="ListRole" runat="server" AutoPostBack="True" OnSelectedIndexChanged="LoadGridView">
        </asp:DropDownList><br /><br />
    <asp:GridView ID="GridViewRoles" runat="server"
        DataKeyNames="Username" OnRowEditing="EditGridView" 
        OnRowCancelingEdit="CancelGridView" 
        AutoGenerateColumns="false"
        OnRowUpdating ="UpdateGridView">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="true"/>  
            <asp:CheckBoxField DataField="C_Register" HeaderText="C_Register" />  
            <asp:CheckBoxField DataField="R_Register" HeaderText="R_Register" />
            <asp:CheckBoxField DataField="U_Register" HeaderText="U_Register" />  
            <asp:CheckBoxField DataField="D_Register" HeaderText="D_Register" /> 
            <asp:CheckBoxField DataField="C_Product" HeaderText="C_Product" />  
            <asp:CheckBoxField DataField="R_Product" HeaderText="R_Product" />
            <asp:CheckBoxField DataField="U_Product" HeaderText="U_Product" />  
            <asp:CheckBoxField DataField="D_Product" HeaderText="D_Product" /> 
            <asp:CheckBoxField DataField="C_Roles" HeaderText="Decentralization" /> 
            <asp:CommandField ShowEditButton="true" />
        </Columns>
        <RowStyle HorizontalAlign="Center" />
    </asp:GridView>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</asp:Content>