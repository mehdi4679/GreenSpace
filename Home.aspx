<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GreenSpace.Home" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>سامانه جامع فضای سبز</title>
    <link href="App_Themes/Theme3/bootstrap-rtl.css" rel="stylesheet" />
    <link href="App_Themes/Theme3/jquery-ui.css" rel="stylesheet" />
    <link href="CityZen/HomeCSS.css" rel="stylesheet" />
<%--    <link href="App_Themes/Theme1/Css/font-awesome.min.css" rel="stylesheet" />--%>
    <script src="App_Themes/Theme3/jquery-1.11.3.min.js"></script>
    <script src="App_Themes/Theme3/jquery-ui.js"></script>
    <script src="App_Themes/Theme3/bootstrap-rtl.js"></script>
</head>
<body>
    <form id="form1" runat="server">       
        <div>
            <!-- Start Logo Section -->
            <section id="logo-section" class="text-center">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <img src="App_Themes/Theme1/images/arm2.png" style="float: left; width: 70px;" />                            
                                <div class="logo text-center">
                                    <h1>شــهـرداری قــم</h1>
                                    <span>سامانه جامع فضای سبز استان قم</span>
                                </div>                           
                        </div>
                    </div>
                </div>
            </section>
            <!-- End Logo Section -->

            <!-- Start Main Body Section -->
            <div class="mainbody-section text-center">
                <div class="container">
                    <div class="row">

                        <div class="col-md-3">

                            <div class="menu-item blue">
                                <a href="/LoginMain.aspx" data-toggle="modal">
                                    <i class="fa fa-magic"></i>
                                    <p>مدیریت پیمان ها</p>
                                </a>
                            </div>

                            <div class="menu-item green ">
                                <a href="/LoginMain.aspx" data-toggle="modal">
                                    <i class="fa fa-file-photo-o"></i>
                                    <p>ناظران</p>
                                </a>
                            </div>
                           <div class="menu-item red">
                                <a href="/LoginMain.aspx" data-toggle="modal">
                                    <i class="fa fa-file-photo-o"></i>
                                    <p>پیمانکاران</p>
                                </a>
                            </div>

                        </div>

                        <div class="col-md-6">

                            <!-- Start Carousel Section -->
                            <div class="row center" style="margin: 0">
                                
                                    <div id="myCarousel1" class="carousel slide">
                                        <ol class="carousel-indicators">
                                            <li data-target="#myCarousel1" data-slide-to="0" class="active"></li>
                                            <li data-target="#myCarousel1" data-slide-to="1"></li>
                                            <li data-target="#myCarousel1" data-slide-to="2"></li>
                                        </ol>
                                        <!-- Carousel items -->
                                        <div class="carousel-inner">
                                            <div class="active item">
                                                <img src="Image/1.jpg" class="imgwidth"/>
                                            </div>
                                            <div class="item">
                                                <img src="Image/2.jpg" class="imgwidth"/>
                                            </div>
                                            <div class="item">
                                                <img src="Image/3.jpg" class="imgwidth"/>
                                            </div>
                                        </div>
                                        <!-- Carousel nav -->
                                        <a class="carousel-control right" href="#myCarousel1" data-slide="next">&lsaquo;</a>
                                        <a class="carousel-control left" href="#myCarousel1" data-slide="prev">&rsaquo;</a>
                                    </div>
                                
                            </div>
                            <!-- Start Carousel Section -->
                        </div>


                        <div class="col-md-3">
                           <%-- <div class="menu-item color">
                                <a href="#service-modal" data-toggle="modal">
                                    <i class="fa fa-server" style="height: 60px;"></i>
                                    <p>کارتابل کمیسیون ماده 7</p>
                                </a>
                            </div>--%>

                            <div class="menu-item red">
                                <a href="/LoginMain.aspx" data-toggle="modal">
                                    <i class="fa fa-users"></i>
                                    <p>مزاحمت درختان</p>
                                </a>
                            </div>

                           <div class="menu-item light-orange">
                                <a href="/LoginMain.aspx" data-toggle="modal">
                                    <i class="fa fa-user"></i>
                                    <p>کارتابل</p>
                                </a>
                            </div>
                            <div class="menu-item blue">
                                <a href="/CityZen/Login.aspx" data-toggle="modal">
                                    <i class="fa fa-user"></i>
                                    <p>شهروند</p>
                                </a>
                            </div>
                        </div>

                        <%--<div class="col-md-4">

                            <div class="menu-item light-red">
                                <a href="#contact-modal" data-toggle="modal">
                                    <i class="fa fa-envelope-o"></i>
                                    <p>Contact</p>
                                </a>
                            </div>

                            <div class="menu-item color">
                                <a href="#clients-modal" data-toggle="modal">
                                    <i class="fa fa-comment-o"></i>
                                    <p>Clients</p>
                                </a>
                            </div>

                            <div class="menu-item blue">
                                <a href="#news-modal" data-toggle="modal">
                                    <i class="fa fa-edit"></i>
                                    <p>Blog</p>
                                </a>
                            </div>

                        </div>--%>
                    </div>
                </div>
            </div>
            <!-- End Main Body Section -->

            <!-- Start Copyright Section -->
            <div class="copyright text-center">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div style="font-family:'B Mitra';font-size:x-large">طراحی    & برنامه نویسی <a href="http://www.tarsimRayan.ir" target="_blank">شرکت ترسیم رایان</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>


<script type="text/javascript">
  $(document).ready(function() {
      $('#myCarousel1').carousel({
      interval: 2500
    })
  });
</script>