<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="MasterPageWebBuyPhone.admin.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <link href="css/FormLogin.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <div class="container">
        <div class="card card-container">
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <form class="form-signin" id="form1" runat="server">
                &nbsp;
           <p id="profile-name" class="profile-name-card">
               <asp:TextBox ID="Username" placeholder="Username" runat="server" class="form-control" Height="30px"></asp:TextBox>
               <asp:RequiredFieldValidator class="form-control" CssClass="float-left" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username must not Empty" ControlToValidate="Username" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
               <asp:TextBox ID="Password" TextMode="Password" placeholder="Password" runat="server" class="form-control" Height="30px"></asp:TextBox>
               <asp:RequiredFieldValidator class="form-control" CssClass="float-left" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password must not Empty" ControlToValidate="Password" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
           </p>
                <br />
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-lg btn-primary btn-block btn-signin" OnClick="btnLogin_Click" />
            </form>
        </div>
    </div>
</body>
</html>
