<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/DashBordMaster.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Taxi.Catalog" %>
<%@ Register src="~/Controls/CtlCatalog.ascx" tagname="CtlCatalog" tagprefix="uc1" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="/Script/jquery-1.4.1.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style type="text/css" >
.MainForm{width:500px;text-align:right;direction:rtl; line-height:30px;margin:10px auto;}
.item{width:500px;clear:both;direction:rtl}
.text{width:120px;float:right}
.input{width:320px;float:right}
     
</style>
<input type="button" id="btnadd" onclick="openlight(0)" value="ثبت" style="visibility:hidden"/>
 
<table>
<tr><td>نوع موجودیت:</td><td><asp:DropDownList runat="server"  type="" onchange="run(this);"  
        id="txtCatalogType" CssClass="txtCatalogType" name="txtName" 
        
          /></td></tr>
<tr><td>عنوان :</td><td><input   type="text"  id="txttitle" name="txtName"  /></td></tr>
<tr><td colspan="2"> <input type="button" id="btnSave" value="ذخیره" onclick="SendData()" /><span id="Loading"><span id="SpanMessage"></span></td></tr>
</table>
<input type="hidden" id="txtcaid" />



      



     <div id="gv" col="4" colname="عنوان:CatalogName,مقدار:CatalogValue,موجودیت:EntityName,''"></div>
<br />
<div style="text-align:center;width:100%" class="Pager"></div>
<script type="text/javascript" src="/AjaxJS/Catalog.js"></script>
</asp:Content>


