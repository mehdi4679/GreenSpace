<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainMaster.Master" AutoEventWireup="true" CodeBehind="LoginCityZen.aspx.cs" Inherits="Taxi.LoginMain" Theme="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="Server">
    <title>سامانه قطع درخت</title>
    <style>
        /*.msg {
    background-color: #cdcdcd;
    border-style: solid;
    height: 50px;
    left: 45%;
    position: absolute;
    top: 350px;
    width: 250px;
    z-index: 99999;
        }*/
    </style>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div class="main-container">
        <div class="main-content">
            <div class="row">
                <%--<div id="dTrafficArm"class="selected  left responsive" ><img src="App_Themes/Theme1/Images/terrafic.png" style="position: fixed; height: 35%;   width: 20%;" /></div>--%>
                <div id="dshahrdariArm" class="  responsive right">
                    <img src="App_Themes/Theme1/Images/arm2.png" style="position: fixed; top: 5px; right: 5px; width: 15%; height: 35%" /></div>

                <div class="col-sm-10 col-sm-offset-1">
                    <div class="login-container">
                        <div class="center">
                            <h1>
                                <i class="ace-icon fa  fa-leaf green"></i>
                                <span class="green">سامانه ثبت درخواست مزاحمت یا قطع درختان فضای سبز  </span>
                            </h1>
                            <h4 class="blue" id="id-company-text"></h4>
                        </div>

                        <div class="space-6"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header blue lighter bigger">
                                            <i class="ace-icon fa fa-coffee green"></i>
                                            لطفا کد ملی و کلمه عبور خود را وارد کنید
                                        </h4>
                                        <div>

                                            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUserName"
                                                Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                                                SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RFV" ForeColor="Red"
                                                Width="128px"></asp:CustomValidator>
                                        </div>
                                        <div class="space-6"></div>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" runat="server" id="txtUserName" class="form-control" placeholder="کد ملی" />
                                                    <i class="ace-icon fa fa-user"></i>
                                                    <input type="password" class="form-control" id="txtPass" runat="server" placeholder="کلمه عبور" />
                                                    <i class="ace-icon fa fa-lock"></i>
                                                </span>
                                            </label>

                                            <div class="space"></div>

                                            <div class="clearfix">
                                                <asp:Button runat="server" ID="btnLogin" Text="ورود به سامانه"
                                                    class="width-35 pull-right btn btn-sm btn-primary bigger-110 ace-icon fa fa-key"
                                                    OnClick="btnLogin_Click" />

                                                <asp:Label runat="server" ID="lblmsg" ForeColor="Red"></asp:Label>
                                                <br />

                                                <input type="checkbox" class="ace" />

                                            </div>

                                            <div class="space-4"></div>
                                        </fieldset>
                                        <div class="space-6"></div>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar clearfix">
                                        <div style="width: auto">
                                            <a href="login.html#" data-target="#forgot-box" class="forgot-password-link">
                                                <i class="ace-icon fa fa-arrow-left"></i>
                                                کلمه عبور خود را فراموش کرده‌ام
                                            </a>
                                        </div>
                                    </div>
                                    <div id="reg">
                                        <a href="#" data-toggle="modal" data-target="#RegModal">
                                            <div id="signindiv" style="border: solid; margin-top: 5px; background: none repeat scroll 0 0 #f7f7f7" class="center">
                                                <h1><span class="lbl">ثبت نام اولیه</span>

                                                </h1>
                                                </h1>
                                                <span style="color: black">خودروهای دارای پلاک قرمز,پلاکهای "ت" پلاک های "ع" پلاک های جانبازی ,  پلاکهای الف و خودروهای امدادی دولتی نیازمند ثبت نام در سیستم نیستند و برای عبور از محدوده طرح ترافیک دارای معافیت هستند</span>


                                            </div>

                                        </a>

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
                                            شماره تلفن همراه خود را وارد کنید تا رمز برایتان ارسال شود
                                        </p>
                                        <fieldset>
                                            <label class="block clearfix">
                                                <span class="block input-icon input-icon-right">
                                                    <input type="text" runat="server" id="txtmobile" cssclass="form-control " placeholder="شماره تلفن همراه" />
                                                    <i class="ace-icon fa fa-mobile large"></i>
                                                </span>
                                            </label>

                                            <div class="clearfix">
                                                <asp:Button Text="ارسال کلمه عبور" runat="server" ID="btnSendEmail" CssClass="width-35 pull-right btn btn-sm btn-danger ace-icon fa fa-lightbulb-o" OnClick="btnSendEmail_Click" />
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
     <!-- REgister Modal -->
          <div class="regForm col-lg-9" style="float:left">

            <div class="row">
                <div>توجه :کد ملی شما به منزله نام کاربری جهت ورود به سایت میباشد.</div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>* کد ملی</div>
                    <asp:TextBox runat="server" ID="TXTNationalCode" data-rel="tooltip" data-placement="left" title="فقط عدد و بدون خط تیره" placeholder="فقط عدد و بدون خط تیره"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVNationalCode" runat="server"
                        ControlToValidate="txtNationalCode" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TXTNationalCode"
                        Display="Dynamic" ErrorMessage="کد ملی نامعتبر است" ClientValidationFunction="checkMelliCode"
                        SetFocusOnError="True" ValidateEmptyText="false" ValidationGroup="RFV" ForeColor="Red"
                        Width="128px"></asp:CustomValidator>
                    <asp:RequiredFieldValidator ID="RqNationalCode" runat="server" ControlToValidate="txtNationalCode" ErrorMessage="لطفا پر کنید" ValidationGroup="RVTbl_Personal" ForeColor="Red">  </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>* نام</div>
                    <asp:TextBox runat="server" data-rel="tooltip" title="فقط حروف فارسی وارد کنید" ID="TXTFirstName"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVFirstName" runat="server"
                        ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>

                    <asp:RequiredFieldValidator ID="RqFirstName" runat="server"
                        ControlToValidate="txtFirstName" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>نام خانوادگی</div>
                    <asp:TextBox runat="server" ID="TXTLastName" data-rel="tooltip" title="فقط حروف فارسی وارد کنید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVLastName" runat="server"
                        ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="فقط حروف فارسی وارد کنید"
                        ValidationExpression="^([ اآبپتثجچحیخدذرزژسشطظعغفقکكگلمنوهيئضصي]\s?)*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>

                    <asp:RequiredFieldValidator ID="RqLastName" runat="server"
                        ControlToValidate="txtLastName" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>ایمیل</div>
                    <asp:TextBox runat="server" ID="TXTEmail" data-rel="tooltip" title="فقط حروف انگلیسی وارد کنید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateEmail" ValidationGroup="RVTbl_Personal"
                        runat="server" ErrorMessage="ایمیل اشتباه است."
                        ControlToValidate="TXTEmail"
                        ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>* کلمه عبور</div>
                    <asp:TextBox runat="server" ID="txtpass1" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RqLastName02" runat="server"
                        ControlToValidate="txtpass1" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationGroup="RVTbl_Personal"
                        ErrorMessage="کلمه عبور بایستی بین 4 تا 10 کاراکتر و اعداد و حروف انگلیسی باشد"
                        ControlToValidate="txtpass1"
                        ValidationExpression="^[a-zA-Z0-9'@&#.\s]{4,10}$" />
                </div>
                <div class="col-md-6">
                    <div>تکرار کلمه عبور</div>
                    <asp:TextBox runat="server" ID="txtrepass" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="Red" ControlToValidate="txtrepass" ControlToCompare="txtpass1" Operator="Equal" ErrorMessage="تکرار کلمه عبور یکسان نمیباشد" ValidationGroup="RVTbl_Personal"></asp:CompareValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>تلفن همراه</div>
                    <asp:TextBox runat="server" ID="TXTPersonalMobile" MaxLength="11" data-rel="tooltip" title="شماره موبایل را 11 رقمی و صحیح وارد نمایید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ValidationGroup="RVTbl_Personal"
                        ControlToValidate="TXTPersonalMobile" Display="Dynamic"
                        ErrorMessage="شماره موبایل را 11 رقمی و صحیح وارد نمایید" ValidationExpression="^\d{11}$">    
                    </asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server"
                        ControlToValidate="TXTPersonalMobile" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="col-md-6">
                    <div>آدرس</div>
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="TXTPersonalAdress" data-rel="tooltip" title="آدرس محل سکونت"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>کدپستی</div>
                    <asp:TextBox runat="server" ID="TXTPostiCode" data-rel="tooltip" title="وارد کردن کدپستی برای متقاضیان تخفیف اجباری است"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <div>تلفن ثابت</div>
                    <asp:TextBox runat="server" ID="TXTPersonalTel" data-rel="tooltip" title="فقط عدد وارد نمایید"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RVJobName0" runat="server"
                        ControlToValidate="TXTPersonalTel" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RVTbl_Personal" ForeColor="Red"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div>شغل</div>
                    <asp:TextBox runat="server" ID="TXTJobName"></asp:TextBox>
                </div>
                
            </div>
            <div>
                  <asp:Button runat="server" Text="ثبت" ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                ValidationGroup="RVTbl_Personal" />
                </div>
            <asp:Label ID="lblPersonalID" runat="server" Text="0" Visible="false"></asp:Label>
            
            <div>
            </div>
        </div>
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

    <script type="text/javascript">
        function checkMelliCode(val, args) {
            var meli_code;
            meli_code = args.Value;
            if (meli_code.length == 10) {
                if ((meli_code == '0000000000') || (meli_code == '1111111111') || (meli_code == '2222222222') || (meli_code == '3333333333') || (meli_code == '4444444444') || (meli_code == '5555555555') || (meli_code == '6666666666') || (meli_code == '7777777777') || (meli_code == '8888888888') || meli_code == ('9999999999')) {
                    alert("کد ملي صحيح نمي باشد");
                    args.IsValid = false;
                    return false;
                }
                c = parseInt(meli_code.charAt(9));
                n = (parseInt(meli_code.charAt(0)) * 10) + (parseInt(meli_code.charAt(1)) * 9) + (parseInt(meli_code.charAt(2)) * 8) + (parseInt(meli_code.charAt(3)) * 7) + (parseInt(meli_code.charAt(4)) * 6) + (parseInt(meli_code.charAt(5)) * 5) + (parseInt(meli_code.charAt(6)) * 4) + (parseInt(meli_code.charAt(7)) * 3) + (parseInt(meli_code.charAt(8)) * 2);
                r = n - parseInt(n / 11) * 11;
                if ((r == 0 && r == c) || (r == 1 && c == 1) || (r > 1 && c == 11 - r)) {
                    args.IsValid = true;
                }
                else {
                    alert("کد ملي صحيح نمي باشد");
                    args.IsValid = false;
                }
            }
            else {
                alert("کد ملي صحيح نمي باشد");
                args.IsValid = false;
                return false;
            }
        }


    </script>
</asp:Content>


