<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Start WOWSlider.com HEAD section -->
    <link rel="stylesheet" type="text/css" href="wwwroot/engine1/style.css" />
    <script type="text/javascript" src="wwwroot/engine1/jquery.js"></script>
<!-- End WOWSlider.com HEAD section -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content_wrapper">
    
    	<div id="slider">
    	          
           
            <!-- Start WOWSlider.com BODY section -->
        <div id="wowslider-container1">
        <div class="ws_images"><ul>
          <li><img src="./wwwroot/images/FoodBanner1.jpg" alt="css slider" title="banner2" id="wows1_1"/></li>
		        <li><img src="./wwwroot/images/FoodBanner2.jpg" alt="banner3" title="banner3" id="wows1_2"/></li>
	        </ul></div>
        <div class="ws_script" style="position:absolute;left:-99%"><a href="http://wowslider.com">bootstrap carousel example</a> by WOWSlider.com v7.6</div>
        <div class="ws_shadow"></div>
        </div>	
        <script type="text/javascript" src="engine1/wowslider.js"></script>
        <script type="text/javascript" src="engine1/script.js"></script>
        <!-- End WOWSlider.com BODY section -->
                
           
              </div><!-- End contentslider -->
          </div>          
          
</asp:Content>
