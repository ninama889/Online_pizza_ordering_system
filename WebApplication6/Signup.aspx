<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WebApplication6.Signup" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login Form </title>
    <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Rubik:400,700'>
    <link rel="stylesheet" href="./wwwroot/css/login.css">
    <link rel="stylesheet" href="./wwwroot/lib/twitter-bootstrap/css/bootstrap.min.css">
</head>
<body>
    <div class="signcontainer-fluid signbg">
        <div class="row justify-content-center text-white">
            <div class="col-xs-12 col-sm-6 col-md-3">
                <form class="signform-container" method="POST" runat="server">
                    <h4 classname="text-white text-center">Signup</h4>
                    <hr />
                    <div class="text-white form-group">
                        <label for="name" class="white">
                            Name <sup>*</sup>
                        </label>

                        <asp:TextBox ID="nameText" runat="server" type="text"
                            class="form-control"
                            name="name"
                            placeholder="name"
                            autoComplete="off"
                            required="true"></asp:TextBox>
                        <span classname="error_form" id="uname_error_message"></span>
                    </div>
                    <div class="form-group">
                        <label class="email">
                            email <sup>*</sup>
                        </label>
                        <asp:TextBox ID="emailText" runat="server" type="text"
                            CssClass="form-control"
                            name="email"
                            placeholder="email"
                            autoComplete="off"
                            required="true"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="password">
                            Password <sup>*</sup>
                        </label>
                        <asp:TextBox ID="passText" runat="server"
                            type="password"
                            CssClass="form-control"
                            name="password"
                            placeholder="Password"
                            required="true" />
                    </div>
                    <div class="form-group">
                        <label>Contact No</label>
                          <asp:TextBox CssClass="form-control" ID="txtMobile" runat="server" 
                              placeholder="Contact No" TextMode="Number"></asp:TextBox>                   

                    </div> 
                    <div class="form-group">
                        <label>Full Address</label>
                        <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" 
                            placeholder="Full Address" TextMode="MultiLine" name ="Address"></asp:TextBox>

                    </div>

                    <asp:Button ID="Button1" runat="server" Text="Submit" class="submitbtn" onClick="Button1_Click"/>
                    <p class="para" id="signup-link">
                        Already have an account?
             <a href="Login.aspx">Login</a>
                        here
                    </p>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
