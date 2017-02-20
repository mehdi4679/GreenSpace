<%@ Page Title="" Language="C#" MasterPageFile="~/Report/RepMaster.master" AutoEventWireup="true" CodeBehind="Rep_Dashbord.aspx.cs" Inherits="GreenSpace.Report.Rep_Dashbord" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="chead" runat="server">
    <style>
        .background { border:0px solid red;
                        height:300px;
                       /* padding:20px;
                         
                      //background:url('park.JPG') 0 0 no-repeat; }*/
.cover { background-size:cover; }
         
     
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
  
    <div align="center">
    <div align="center">
     <h1>سیستم گزارش گیری فضای سبز</h1>

    </div>
<div class="background cover"  style="width:80%; border-radius:40px;box-shadow: 10px 10px 5px #888888;" align="center" >
      <img src="park.JPG" style="position:relative;width:100%;height:100%;border:0px solid red;border-radius:40px;" />
</div>
</div>
</asp:Content>
