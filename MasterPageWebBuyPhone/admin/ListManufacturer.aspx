<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListManufacturer.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.pagelist.ListManufacturer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <br />
    <div class="container">
   
        <br />
       <h2 style="color: #007bff; text-align: center">LIST MANUFACTURER</h2>
        <br />
        <br />
    
    <asp:GridView ID="GridViewManufacturer" runat="server"
        DataKeyNames="Id_Manufacturer" OnRowEditing="EditGridView" 
        OnRowCancelingEdit="CancelGridView"
        OnRowDeleting="DeleteGridView"
        AutoGenerateColumns="false"
        OnRowUpdating ="UpdateGridView" Width="699px"  HorizontalAlign="Center">
        <Columns>
            <asp:BoundField DataField="Id_Manufacturer" HeaderStyle-HorizontalAlign="Center" HeaderText="ID" ReadOnly="true"  ItemStyle-HorizontalAlign="Center"/>  
            <asp:BoundField DataField="Name_Manufacturer" HeaderText="Name" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"/>  
            <asp:CommandField ShowEditButton="true"  ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"/>
            <asp:CommandField ShowDeleteButton="true"  ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"/> 
        </Columns>
        <RowStyle HorizontalAlign="Center" />

    </asp:GridView>
           
        </div>
</asp:Content>
