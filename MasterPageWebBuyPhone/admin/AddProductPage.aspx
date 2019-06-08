<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProductPage.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.AddProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
        <div class="container" id="formAdd" runat="server">

            <h4 style="color: #007bff; text-align: center">Form Register</h4>
            <p style="color: #007bff; text-align: center">
            </p>
            <br />
             <asp:Label ID="Label1" runat="server" Text="Select Manufacturer"></asp:Label><br />
            <asp:DropDownList ID="ListManufacturer" runat="server" Width="223px">
            </asp:DropDownList>
             <asp:CustomValidator SetFocusOnError="true"
                ID="CustomValidator3" runat="server"
                ControlToValidate="ListManufacturer"
                Display="Dynamic" ErrorMessage="Please Choose Manufacturer" 
                 ForeColor="Red" OnServerValidate="CheckChooseManufacturer"></asp:CustomValidator>
            <div class="row">
                <div class="col-md-6">
                    <label>Name</label>
                    <asp:TextBox ID="Name" placeholder="Name" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator1"
                        ControlToValidate="Name" runat="server" ErrorMessage="Name must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <div class="col-md-6">
                    <label for="inputAddress2">Price</label>
                    <asp:TextBox ID="Price" placeholder="Price" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator2" ControlToValidate="Price" runat="server" ErrorMessage="Price must not Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RangeValidator runat="server" Type="Double"  ForeColor="Red" Display="Dynamic"
                    SetFocusOnError="true"
                    MinimumValue="0" MaximumValue="10000000" ControlToValidate="Price" 
                    ErrorMessage="Value must be a whole number between 0 and 10.000.000$" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-3">
                    <label for="inputAddress2">Screen</label>
                    <asp:TextBox ID="Screen" placeholder="Screen" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator4"
                        ControlToValidate="Screen" runat="server" ErrorMessage="Screen must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">Operating system</label>
                    <asp:TextBox ID="Operating" placeholder="Operating" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator5"
                        ControlToValidate="Operating" runat="server" ErrorMessage="Operating must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">Front camera</label>
                    <asp:TextBox ID="FrontCamera" placeholder="FrontCamera" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator6"
                        ControlToValidate="FrontCamera" runat="server" ErrorMessage="FrontCamera must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">Rear camera</label>
                    <asp:TextBox ID="RearCamera" placeholder="RearCamera" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator7"
                        ControlToValidate="RearCamera" runat="server" ErrorMessage="RearCamera must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-3">
                    <label for="inputAddress2">CPU</label>
                    <asp:TextBox ID="CPU" placeholder="CPU" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator8"
                        ControlToValidate="CPU" runat="server" ErrorMessage="CPU must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">RAM</label>
                    <asp:TextBox ID="RAM" placeholder="RAM" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator9"
                        ControlToValidate="RAM" runat="server" ErrorMessage="RAM must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">Internal memory</label>
                    <asp:TextBox ID="InternalMemory" placeholder="InternalMemory" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator10"
                        ControlToValidate="InternalMemory" runat="server" ErrorMessage="InternalMemory must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-3">
                    <label for="inputPassword4">Memory Stick</label>
                    <asp:TextBox ID="MemoryStick" placeholder="MemoryStick" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator11"
                        ControlToValidate="MemoryStick" runat="server" ErrorMessage="MemoryStick must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-6">
                    <label for="inputAddress2">SIM</label>
                    <asp:TextBox ID="SIM" placeholder="SIM" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator12"
                        ControlToValidate="SIM" runat="server" ErrorMessage="SIM must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <label for="inputPassword4">Battery capacity</label>
                    <asp:TextBox ID="BatteryCapacity" placeholder="BatteryCapacity" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator13"
                        ControlToValidate="BatteryCapacity" runat="server" ErrorMessage="BatteryCapacity must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-12">
                    <label for="inputAddress2">New feature</label>
                    <asp:TextBox ID="Newfeature" placeholder="Newfeature" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator14"
                        ControlToValidate="Newfeature" runat="server" ErrorMessage="Newfeature must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-12">
                    <label for="inputAddress2">Details</label>
                    <asp:TextBox ID="DetailsProduct" placeholder="DetailsProduct" runat="server" class="form-control">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator15"
                        ControlToValidate="DetailsProduct" runat="server" ErrorMessage="DetailsProduct must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-12">
                    <label for="inputAddress2">Image Link</label>
                    <asp:FileUpload ID="FileUpload" runat="server" />
                    <asp:RequiredFieldValidator SetFocusOnError="true" ID="RequiredFieldValidator16"
                        ControlToValidate="FileUpload" runat="server" ErrorMessage="File Upload must not Empty"
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>

            <br />

            <br />
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="SaveProduct" class="btn btn-primary" runat="server" Text="Save" />
                </div>
            </div>
        </div>
       
        <br />

        <br />
</asp:Content>
