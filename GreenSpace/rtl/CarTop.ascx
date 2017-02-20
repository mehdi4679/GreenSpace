<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CarTop.ascx.cs" Inherits="Taxi.rtl.CarTop" %>
<div style="float: left; padding-left:110px;font-family:'mitrabold',Tahoma,arial,sans-serif;" class="navbar-header">
            <style>
            .tbmaster td
            {
                padding-right:15px;
                }
            </style>
       
<ul class="nav">
                <li class="light-blue open"><a class="dropdown-toggle" href="inbox.html#" data-toggle="dropdown" style="left:-100px">
                    <img alt='maarefi' id="imgmaster" src="~/Images/taxi.png" class="nav-user-photo" runat="server" style="border-radius:40px;">
                    <span class="user-info"><small></small> <asp:Label runat="server" ID="lblNameMasetr"></asp:Label> </span><i class="ace-icon fa fa-caret-down">
                    </i></a>
                    <ul class="user-menu dropdown-menu-right dropdown-menu dropdown-yellow dropdown-caret dropdown-close" style="width:190px;">
                        <li>کد خودرو<asp:Label runat="server" ID="lblcode"></asp:Label></li>
                        <li>پلاک <asp:Label id="lblPelek" runat="server" ></asp:Label> </li>
                        <li>شماره شاسی<asp:Label runat="server" ID="lblshasi"></asp:Label> </li>
                        <li>شماره موتور<asp:Label runat="server" ID="lblmotor"></asp:Label> </li>
                        

                       
                         <li><a href="/index.aspx"  ><i class="fa fa-fw fa-dashboard"></i>میز کار </a></li> 
                    </ul>
                </li>
            </ul>
 </div>