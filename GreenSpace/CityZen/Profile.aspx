<%@ Page Title="" Language="C#" MasterPageFile="~/CityZen/DashBoard.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="GreenSpace.CityZen.Profile" %>

<%@ Register Src="~/CityZen/UploadFile.ascx" TagPrefix="uc1" TagName="UploadFile" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/jquery-ui.custom.min.css" rel="stylesheet" />
    <link href="Css/jquery.gritter.css" rel="stylesheet" />
    <link href="Css/select2.css" rel="stylesheet" />
    <link href="Css/datepicker.css" rel="stylesheet" />
    <link href="Css/bootstrap-editable.css" rel="stylesheet" />
    <link href="../App_Themes/Theme1/Css/ace.min.css" rel="stylesheet" />
    <link href="../App_Themes/Theme1/Css/ace-skins.min.css" rel="stylesheet" />
    <link href="../App_Themes/Theme1/Css/ace-rtl.min.css" rel="stylesheet" />
    <%--<link href="Css/ProfileCss.css" rel="stylesheet" />--%>
    <link href="../App_Themes/Theme1/Css/font-awesome.css" rel="stylesheet" />
    <script src="Css/ace-extra.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div id="user-profile-2" class="user-profile">
            <div class="tabbable">
                <div class="tab-content no-border padding-24">
                    <div id="home" class="tab-pane in active">
                        <div class="row">
                            <div class="col-xs-12 col-sm-3 center">
                                <span class="profile-picture">
                                    <img class="editable img-responsive" id="avatar2" runat="server" src="../Image/Profile-pic/profile-pic.jpg" />
                                </span>

                                <div class="space space-4"></div>

                                <div class="width-80 label label-info label-xlg arrowed-in arrowed-in-right">
                                    <div class="inline position-relative" style="width:150px;">
                                        <%--<i class="ace-icon fa fa-circle light-green"></i>--%>
															<%--<span class="white">Alex M. Doe</span>--%>
                                        <asp:Label ID="Semat" class="semat" runat="server" Text=""></asp:Label>

                                    </div>
                                </div>
                            </div>  
                            <!-- /.col -->

                            <div class="col-xs-12 col-sm-9">
                                <h4 class="blue">
                                    <%--<span class="middle">Alex M. Doe</span>--%>
                                    
                                </h4>

                                <div class="profile-user-info">
                                    <div class="profile-info-row">
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblUsername" class="lbls" runat="server" Text="نام کاربری"></asp:Label>
                                        </div>
                                        <div class="profile-info-value">
                                            <%-- <span>alexdoe</span>--%>
                                            <asp:Label ID="Username" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>
                                    <div class="profile-info-row">
                                        <%--<div class="profile-info-name">نام و نام خانوادگی </div>--%>
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblFullname" class="lbls" runat="server" Text="نام و نام خانوادگی"></asp:Label>
                                        </div>
                                        <div class="profile-info-value">
                                            <%-- <span>alexdoe</span>--%>
                                            <asp:Label ID="Fullname" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>

                                    <div class="profile-info-row">
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblCodemeli" runat="server" class="lbls" Text="کد ملی"></asp:Label>
                                        </div>

                                        <div class="profile-info-value">
                                            <asp:TextBox ID="codemeli" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="profile-info-row">
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblEmail" runat="server" class="lbls" Text="پست الکترونیک"></asp:Label>
                                        </div>

                                        <div class="profile-info-value">
                                            <asp:TextBox ID="Email" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="profile-info-row">
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblMobile" runat="server" class="lbls" Text="تلفن همراه"></asp:Label>
                                        </div>

                                        <div class="profile-info-value">
                                            <asp:TextBox ID="Mobile" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="profile-info-row">
                                        <div class="profile-info-name">
                                            <asp:Label ID="lblupload" runat="server" class="lbls" Text="بارگذاری عکس"></asp:Label>
                                        </div>

                                        <div class="profile-info-value">
                                            <uc1:UploadFile runat="server" id="UploadFile1" />
                                        </div>
                                    </div>


                                </div>


                                
                            </div>
                            <!-- /.col -->
                            
                        </div>
                        <!-- /.row -->
                        
                        <div class="space-20"></div>
                        <div style="text-align:center">
                             <asp:Button ID="btnUpdate" runat="server" Text="ثـبت تـغـیـیـرات" OnClick="btnUpdate_Click" CssClass="btn btn-success" style="font-family:w_yekan;color:black !important;margin-bottom:5px;"/>
                        </div>
                       
                    </div>
                    <!-- /#home -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>
