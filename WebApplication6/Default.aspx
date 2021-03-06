<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Start WOWSlider.com HEAD section -->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>complete responsive food website design tutorial </title>

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">

    <!-- custom css file link  -->
    <link rel="stylesheet" href="WWWroot/css/StyleSheet1.css">

    <!-- End WOWSlider.com HEAD section -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- header section ends -->

    <!-- home section starts  -->

    <section class="home" id="home">

        <div class="content">
            <h3>FoodVilla</h3>
            <p>Food Made with love. with best taste and quality services.</p>
            <a href="#order" class="btn">order now</a>
        </div>

        <div class="image">
            <img src="images/123.png" alt="">
        </div>

    </section>

    <!-- home section ends -->

    <!-- speciality section starts  -->

    <section class="speciality" id="speciality">

        <h1 class="heading">our <span>speciality</span> </h1>

        <div class="box-container">

            <div class="box">
                <img class="image" src="images/s-img-1.jpg" alt="">
                <div class="content">
                    <img src="images/s-1.png" alt="">
                    <h3>tasty burger</h3>
                    <p>Tasty, delicious, and has me craving more on the first bite.” to “Juicy, mouthwatering, tasty, and everything you’d ever want to savor. choice of yours</p>
                </div>
            </div>
            <div class="box">
                <img class="image" src="images/s-img-2.jpg" alt="">
                <div class="content">
                    <img src="images/s-2.png" alt="">
                    <h3>tasty pizza</h3>
                    <p>tastes like bread tomato and cheese, chewy, moist, slightly acidic, and sharp. Then once you apply toppings, that changes it. Ham and pineapple, adds salty, sweet and juicy. Pepperoni adds a meatiness and spice.</p>
                </div>
            </div>
            <div class="box">
                <img class="image" src="images/s-img-3.jpg" alt="">
                <div class="content">
                    <img src="images/s-3.png" alt="">
                    <h3>cold ice-cream</h3>
                    <p>rich, sweet, creamy frozen food made from variously flavored cream and milk products churned or stirred to a smooth consistency during the freezing process and often containing gelatin, eggs, fruits, nuts, etc.</p>
                </div>
            </div>
            <div class="box">
                <img class="image" src="images/s-img-4.jpg" alt="">
                <div class="content">
                    <img src="images/s-4.png" alt="">
                    <h3>cold drinks</h3>
                    <p>From punches to  to , served everywhere from Maui to Mexico, these 10 beverages are excellent ways to kick off that (much-needed) getaway. and special kind of cocktails available at your menu.</p>
                </div>
            </div>


        </div>

    </section>

    <!-- speciality section ends -->

    <!-- popular section starts  -->

    <section class="popular" id="popular">

        <h1 class="heading">most <span>popular</span> foods </h1>
        <div class="box-container">
            <asp:Repeater ID="R_Products" runat="server" DataSourceID="SqlCategory">
                <ItemTemplate>
                    <div class="box">
                        <%--<span class="price"></span>--%>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageUrl") %>' />
                        <h3><%# Eval("Name") %></h3>
                        <div class="stars">
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="far fa-star"></i>
                        </div>
                        <a href="#order" class="btn">order now</a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlProduct" runat="server" ConnectionString="<%$ ConnectionStrings:FoodieDBConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [Products] WHERE ([IsActive] = @IsActive)">
                <SelectParameters>
                    <asp:FormParameter DefaultValue="true" FormField="Products" Name="IsActive" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlCategory" runat="server" ConnectionString="<%$ ConnectionStrings:FoodieDBConnectionString %>" SelectCommand="SELECT * FROM [Categories] WHERE ([IsActive] = @IsActive)">
                <SelectParameters>
                    <asp:FormParameter DefaultValue="true" FormField="Category" Name="IsActive" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

    </section>

    <!-- popular section ends -->

    <!-- steps section starts  -->

    <div class="step-container">

        <h1 class="heading">how it <span>works</span></h1>

        <section class="steps">

            <div class="box">
                <img src="images/step-1.jpg" alt="">
                <h3>choose your favorite food</h3>
            </div>
            <div class="box">
                <img src="images/step-2.jpg" alt="">
                <h3>free and fast delivery</h3>
            </div>
            <div class="box">
                <img src="images/step-3.jpg" alt="">
                <h3>easy payments methods</h3>
            </div>
            <div class="box">
                <img src="images/step-4.jpg" alt="">
                <h3>and finally, enjoy your food</h3>
            </div>

        </section>

    </div>

    <!-- steps section ends -->

    <!-- gallery section starts  -->

    <section class="gallery" id="gallery">

        <h1 class="heading">our food <span>gallery </span></h1>

        <div class="box-container">
            <asp:Repeater ID="R_Gallery" runat="server" DataSourceID="SqlProduct">
                <ItemTemplate>
                    <div class="box">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageUrl") %>' />
                        <div class="content">
                            <asp:Label ID="lbl_Gallery" runat="server" Text='<%# Eval("Name") %>'
                                Font-Bold="True" Font-Size="X-Large"></asp:Label>
                            <p class="font-weight-bold p-1">
                                Price: RS. <%#Eval("Price") %>
                                <a href="#order" class="btn">ordern now</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SQL_Gallery" runat="server" ConnectionString="<%$ ConnectionStrings:FoodieDBConnectionString %>"
                SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>

    </section>

    <!-- gallery section ends -->

    <!-- review section starts  -->

    <section class="review" id="review">

        <h1 class="heading">About <span>US</span> </h1>

        <div class="box-container">

            <div class="box">
                <img src="images/pic1.png" alt="">
                <h3>Hemangini ninama</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <p>Roll no : CE093</p>
            </div>
            <div class="box">
                <img src="images/pic1.png" alt="">
                <h3>Ruchita oza</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <p>Roll no : CE094</p>
            </div>
        </div>

    </section>

    <!-- review section ends -->

    <!-- order section starts  -->
    
        <section class="order" id="order">

            <h1 class="heading"><span>order</span> now </h1>

            <div class="row">
                <div class="col-sm-6 col-md-4">
                    <div class="image">
                        <img src="images/order-img.jpg" alt="">
                    </div>
                </div>
                <div class="col-sm-6 col-md-8">
                    <div class="inputBox">
                        <asp:TextBox ID="txtName" placeholder="name" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtEmail" placeholder="Email" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputBox">
                        <asp:TextBox CssClass="form-control" ID="txtMobile" runat="server"
                            placeholder="Contact No" TextMode="Number"></asp:TextBox>
                        <asp:TextBox ID="txtFoodname" placeholder="Food name" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server"
                        placeholder="Full Address" TextMode="MultiLine" name="Address"></asp:TextBox>
                    <asp:Button ID="BtnSubmit" runat="server" CssClass="btn" Text="Order now" onClick="BtnSubmit_Click"/>
                </div>
            </div>
        </section>
    <!-- order section ends -->



    <!-- scroll top button  -->
    <a href="#home" class="fas fa-angle-up" id="scroll-top"></a>

    <!-- loader  -->
    <div class="loader-container">
        <img src="images/loader.gif" alt="">
    </div>

    <!-- custom js file link  -->
    <script src="WWWroot/js/JavaScript.js"></script>

</asp:Content>
