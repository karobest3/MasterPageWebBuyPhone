<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterHomePage.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="MasterPageWebBuyPhone.HomePage.ProductsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <div class="container">
        <div class="card-deck">
            <asp:Repeater ID="RepterDetails" runat="server">

                <ItemTemplate>
                    <div class="col-md-3">
                        <div class="card mb-3">

                            <div class="view overlay">
                                <a href="#!">
                                    <img style="height: 200px" class="card-img-top" src="<%#Eval("Img_Product")%>" alt="Card image cap">
                                </a>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </div>


                            <div class="card-body">


                                <h4 class="card-title" style="height: 100px"><%#Eval("Name_Product")%></h4>

                                <p class="card-text"><b>Price</b>:<%#Eval("Price_Product")%>$</p>

                                <button type="button" class="btn btn-primary btn-md" style="float: right">Buy Now !</button>

                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>




</asp:Content>
