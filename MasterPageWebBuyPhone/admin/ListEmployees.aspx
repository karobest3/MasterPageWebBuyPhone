<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListEmployees.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.ListEmployees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">

        
             <asp:GridView ID="GridViewEmp" runat="server"
        DataKeyNames="ID_Emp" OnRowEditing="EditGridView" 
        OnRowDeleting="DeleteGridView"
        AutoGenerateColumns="false"
        HorizontalAlign="Center">
        <Columns>
            <asp:BoundField DataField="ID_Emp" HeaderText="ID" ReadOnly="true" />  
            <asp:BoundField DataField="FullName" HeaderText="Name" />  
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Email" HeaderText="Email" />  
            <asp:BoundField DataField="Phone" HeaderText="Phone" /> 
            <asp:BoundField DataField="Passport" HeaderText="Passport" />  
            <asp:BoundField DataField="Birthday" HeaderText="Birthday" /> 
            <asp:BoundField DataField="Sex" HeaderText="Sex" />
            <asp:CommandField ShowEditButton="true"  ItemStyle-HorizontalAlign="Center"/>
            <asp:CommandField ShowDeleteButton="true"  ItemStyle-HorizontalAlign="Center"/> 
        </Columns>
        <RowStyle HorizontalAlign="Center" />

    </asp:GridView>
       
  
    </div>
</asp:Content>
