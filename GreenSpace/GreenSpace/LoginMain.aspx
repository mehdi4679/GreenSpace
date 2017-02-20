<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainMaster.Master" AutoEventWireup="true" CodeBehind="LoginMain.aspx.cs" Inherits="Taxi.LoginMain" Theme="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="Server">
    <title>.:: ورود به سامانه فضای سبز قم ::.</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div class="main-container">
        <div class="main-content">
            <div class="row">
                <div class="col-sm-10 col-sm-offset-1">
                    <div class="login-container">
                        <div class="center">
                            <h1>
                                <i class="ace-icon fa fa-Leaf green"></i>
                                <span class="green">سامانه فضای سبز</span>
                            </h1>
                            <h4 class="blue" id="id-company-text">استان قم</h4>
                        </div>

                        <div class="space-6"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header blue lighter bigger">
                                            <i class="ace-icon fa fa-coffee green"></i>
                                            لطفا نام کاربری و کلمه عبور خود را وارد کنید
                                        </h4>

                                        <div class="space-6"></div>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" runat="server" ID="txtUserName" class="form-control" placeholder="نام کاربری" />
                                                    <i class="ace-icon fa fa-user"></i>
                                                </span>
                                            </label>

                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="password" class="form-control"  ID="txtPass"  runat="server" placeholder="کلمه عبور" />
                                                    <i class="ace-icon fa fa-lock"></i>
                                                </span>
                                            </label>

                                            <div class="space"></div>

                                            <div class="clearfix">
                                            <asp:Button runat="server" ID="btnLogin" Text="ورود به سامانه" 
                                                    class="width-35 pull-right btn btn-sm btn-primary bigger-110 ace-icon fa fa-key" 
                                                    onclick="btnLogin_Click"  />
                                           <div class="alert alert-danger" id="DError"  runat="server" visible="false" >
															<button data-dismiss="alert" class="close" type="button">
																<i class="ace-icon fa fa-times"></i>
															</button>

															<strong>
																<i class="ace-icon fa fa-times"></i>
																خطا!
															</strong>

															نام کاربری یا کلمه عبور اشتباه است.
															</br>
														</div>
                                    

                                                <label class="inline">
                                                    <input type="checkbox" class="ace" />
                                                    <span class="lbl">مرا به خاطر بسپار</span>
                                                </label>
                                            </div>

                                            <div class="space-4"></div>
                                        </fieldset>
                                        <div class="space-6"></div>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar clearfix">
                                        <div>
                                            <a href="login.html#" data-target="#forgot-box" class="forgot-password-link">
                                                <i class="ace-icon fa fa-arrow-left"></i>
                                                کلمه عبور خود را فراموش کرده‌ام
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.login-box -->

                            <div id="forgot-box" class="forgot-box widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header red lighter bigger">
                                            <i class="ace-icon fa fa-key"></i>
                                            باز نشانی کلمه عبور
                                        </h4>

                                        <div class="space-6"></div>
                                        <p>
                                            آدرس پست الکترونیک خود را وارد کنید تا رمز برایتان ارسال شود
                                        </p>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="email" class="form-control" placeholder="آدرس پست  الکترونیک" />
                                                    <i class="ace-icon fa fa-envelope"></i>
                                                </span>
                                            </label>
<%--                              <button type="button" class="">
                                                    <i class="ace-icon fa fa-lightbulb-o"></i>
                                                    <span class="bigger-110">ر</span>
                                                </button>--%>
                                            <div class="clearfix">
                                                <asp:Button Text="بازنشانی کلمه عبور" runat="server" ID="btnSendEmail" CssClass="width-35 pull-right btn btn-sm btn-danger ace-icon fa fa-lightbulb-o" OnClick="btnSendEmail_Click"
                  />
                                            </div>
                                        </fieldset>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar center">
                                        <a href="login.html#" data-target="#login-box" class="back-to-login-link">بازگشت به صفحه ورود به سامانه
												<i class="ace-icon fa fa-arrow-right"></i>
                                        </a>
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.forgot-box -->
                        </div>
                        <!-- /.position-relative -->
                    </div>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.main-content -->
    </div>
    <!-- /.main-container -->
    <!-- basic scripts -->

    <script type="text/javascript">
        $(document).ready(function () {
            $('body').attr('class', 'login-layout light-login');
            $('#id-company-text').attr('class', 'blue');
        });

        jQuery(function ($) {
            $(document).on('click', '.toolbar a[data-target]', function (e) {
                e.preventDefault();
                var target = $(this).data('target');
                $('.widget-box.visible').removeClass('visible'); //hide others
                $(target).addClass('visible'); //show target
            });
        });
    </script>
</asp:Content>


