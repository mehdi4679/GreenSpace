<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Bazras.master" AutoEventWireup="true" CodeBehind="AllPeyman.aspx.cs" Inherits="GreenSpace.Bazras.AllPeyman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="padding :15px">
        <legend style="width:100px;">توجه:</legend>
        کاربر گرامی یکی از پیمان های زیر را انتخاب نمایید
    </fieldset>
    <asp:GridView runat="server" AutoGenerateColumns="false"
         ID="GridView1" AllowPaging="true" AllowSorting="true" 
        OnSorting="GridView1_Sorting" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
<asp:TemplateField HeaderText="انتخاب پیمان">
            <ItemTemplate>
                        <a id="AEdit" aname='<%#Eval("AgreeName").ToString() %>' class="" href='<%# DataBinder.Eval(Container,"DataItem.AgreementID")%>' title="انتخاب" onserverclick="UpItem" runat="server" >
                            <%# Eval("AgreeName").ToString() %>
                        </a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AgreeSerial"  HeaderText="ش قرادداد پیمان"   SortExpression="AgreeSerial" />
<%--   <asp:BoundField DataField="AgreeName"  HeaderText="نام پیمان"   SortExpression="AgreeName" />--%>
        </Columns>
    </asp:GridView>
</asp:Content>
