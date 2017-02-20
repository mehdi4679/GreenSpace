<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="GreenSpace.DashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .fontmitra
{
    font-family:'mitrabold',Tahoma,arial,sans-serif;
    font-size:28pt;
    
    }
            .desktopIcon
        {
            float: right;
            padding: 15px;
            text-align:center;
            width:350px;
            height:250px;
        }
        .IconPic
        {
            width:128px;height:128px;
            margin-top:10px;
            }
         .classsug
         {
             width:80%;
             }   
         .fa{
             padding-left:5px;
         }
         .nav li a {
             font-size:17px !important;
         }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topMenuProfile" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subMaster" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="dsug" style="margin-top:-30px;" align="center" >
      <%--  <asp:TextBox runat="server" ID="txtsuggession" Width="400px"/>--%>

    </div>
<div id="taxi" class="desktopIcon">
<table>
<tr><td class="fontmitra">نمایش نقشه</td></tr>
<%--<tr><td><a href="/ESRI3TestPage.aspx"><img src="/App_Themes/Theme1/Images2/Map.png" class="IconPic"/></a></td></tr>--%>
<tr><td><a href="/CityZen/MapRegTree.aspx"><img src="/App_Themes/Theme1/Images2/Map.png" class="IconPic"/></a></td></tr>

<tr><td> </td></tr>
</table>
</div>
 
<div id="Users" class="desktopIcon">
<table>
<tr><td class="fontmitra">کاربران،افراد</td></tr>
<tr><td><a href="/User/User.aspx"> <img class="IconPic" src="/App_Themes/Theme1/Images2/Users.png" /></a></td></tr>
<tr><td></td></tr>
</table>
</div>
<div id="catalog" class="desktopIcon">
<table>
<tr><td class="fontmitra">قراردادها</td></tr>
<tr><td><a href="/Manage/Agreement.aspx">
    <img src="/App_Themes/Theme1/Images2/Agree.png"  class="IconPic" /></a></td></tr>
<tr><td></td></tr>
</table>
</div>
 <div id="Div1" class="desktopIcon">
<table>
<tr><td class="fontmitra">پارک ها</td></tr>
<tr><td><a href="/Manage/Park.aspx">
    <img src="/App_Themes/Theme1/Images2/park.png"  class="IconPic" />  </a></td></tr>
<tr><td></td></tr>
</table>
</div>
 <div id="Divtree" class="desktopIcon">
<table>
<tr><td class="fontmitra">قطع اشجار</td></tr>
<tr><td><a href="/Manage/Tree/CuttingTree.aspx">
    <img src="/App_Themes/Theme1/Images2/tree.png"  class="IconPic" />  </a></td></tr>
<tr><td></td></tr>
</table>
</div>
<div id="Div1" class="desktopIcon">
<table>
<tr><td class="fontmitra">گزارشات</td></tr>
<tr><td><a href="/Report/Rep_Dashbord.aspx">
    <img src="/App_Themes/Theme1/Images2/report.png"  class="IconPic" />  </a></td></tr>
<tr><td></td></tr>
</table>
</div>
<%--<div id="Person" class="desktopIcon"><a href=""><img src="Images/driver_taxi_taxi_driver.png" class="IconPic"/></a></div>
<div id="User" class="desktopIcon"><a href="/User.aspx"><img src="Images/USer.jpg" class="IconPic"/></a></div>
<div id="Catalog" class="desktopIcon"><a href=""><img src="Images/catalog.png" class="IconPic"/></a></div>
--%>

</asp:Content>
