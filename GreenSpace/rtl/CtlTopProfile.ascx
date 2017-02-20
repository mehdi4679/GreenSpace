<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlTopProfile.ascx.cs" Inherits="Taxi.rtl.CtlTopProfile" %>

        <div style="float: left; padding-left:19px;font-family:'mitrabold',Tahoma,arial,sans-serif;" class="navbar-header">
            <style>
            .tbmaster td
            {
                padding-right:15px;
                }
            </style>
       
<ul class="nav">
                <li class="light-blue "><a class="dropdown-toggle" href="inbox.html#" data-toggle="dropdown">
                    <img alt='پارس رایانه' id="imgmaster" src="~/Images/taxi.png" class="nav-user-photo" runat="server" style="border-radius:40px;width:50px;height:50px">
                    <span class="user-info"><small></small> <asp:Label runat="server" ID="lblNameMasetr"></asp:Label> </span><i class="ace-icon fa fa-caret-down">
                    </i></a>
                    <ul class="user-menu dropdown-menu-right dropdown-menu dropdown-yellow dropdown-caret dropdown-close">
                        <li><a href="/index.aspx"><i class="ace-icon fa fa-cog"></i>میز کار </a></li>
                        <li><a href='<%=Page.ResolveUrl("~/Personal/Person.aspx?pname=پروفایل&Pid=")+ Request.QueryString["pID"] %>'>     <i class="ace-icon fa fa-user"></i>پروفایل </a></li>
                        <li class="divider"></li>
                        <%--<li><a href="/index.aspx"  ><i class="fa fa-fw fa-dashboard"></i>میز کار </a></li>--%>
                    </ul>
                </li>
            </ul>
 </div>

<div runat="server"   id="dPerson" style="float: right;font-family:'mitrabold',Tahoma,arial,sans-serif;padding-right:10px " class="navbar-header">
<ul class="nav">
<li>
<table class="tbmaster">
    <tr>
  <td colspan="2"><asp:Label runat="server" ID="lblFulname"></asp:Label></td>
<td>کد ملی:</td><td><asp:Label runat="server" ID="lblcodemelli"></asp:Label></td>
<td>شماره گواهینامه:</td><td><asp:Label runat="server" ID="lblgovahiname"></asp:Label></td>
<td>وضعیت:</td><td><asp:Label runat="server" ID="lblactive"></asp:Label></td>
</tr>
    <tr>
  <td>شماره پروانه:</td><td><asp:Label runat="server" ID="lblParvanehnumber"></asp:Label></td>
<td>اعتبار تا تاریخ:</td><td><asp:Label runat="server" ID="parvanehMaxDatePR"></asp:Label></td>
<td>شماره همراه:</td><td><asp:Label runat="server" ID="lblmobile"></asp:Label></td>
     <td>تاریخ انقضا گواهینامه</td><td><asp:Label runat="server" ID="lblGavahinameEnghezaDate"></asp:Label></td>
    </tr>
<%--<tr>
<td>خودروها:</td><td><asp:Label runat="server" ID="lblAllCars"></asp:Label></td>
</tr>--%>
</table>
</li>
</div>
