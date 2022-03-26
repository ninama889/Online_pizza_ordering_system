<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.WebForm1" %>
<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title> Login Form </title>
  <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Rubik:400,700'>
    <link rel="stylesheet" href="./wwwroot/css/login.css">
    <link rel="stylesheet" href="./wwwroot/lib/twitter-bootstrap/css/bootstrap.min.css">
</head>
<body>
 <div class="signcontainer-fluid signbg">
      <div class="row justify-content-center text-white">
        <div class="col-xs-12 col-sm-6 col-md-3">
          <form class="signform-container" method="POST" runat="server">
            <h4 class="text-center"> Login</h4>
            <hr />
            <div class="form-group">
              <label class="email">
                email <sup>*</sup>
              </label>
              <asp:TextBox ID="emailText" runat="server" type="text"
                class="form-control"
                name="email"
                placeholder="email"
                autoComplete="off"
                required="true" OnTextChanged="emailText_TextChanged"></asp:TextBox>
              
            </div>
            <div class="form-group">
              <label for="password">
                Password <sup>*</sup>
              </label>
              <asp:TextBox ID="passText" runat="server"
                type="password"
                class="form-control"
                name="password"
                placeholder="Password"
                required="true"
              />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Submit"  CssClass="submitbtn" OnClick="Button1_Click"/>
              <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <p class="para" id="signup-link">
              Don't have an account?
             <a href="Signup.aspx">Signup</a>
              here
            </p>
          </form>
        </div>
      </div>
    </div>
    </body>
    </html>