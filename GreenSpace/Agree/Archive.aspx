<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="Archive.aspx.cs" Inherits="GreenSpace.Agree.Archive" %>
<%@ Register src="/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
    <asp:Label runat="server" ID="lblAgrement" Text="0" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblArchiveAgreeTitle" Text="0" Visible="false"></asp:Label>
    <table>
        <tr><td>عنوان</td><td colspan="10"><asp:TextBox runat="server" ID="txtTitle"></asp:TextBox></td></tr>
        <tr><td>صورتجلسه پرداخت</td><td colspan="10"><asp:TextBox Text="0"  runat="server" ID="txtSoratJalase"></asp:TextBox></td></tr>
        <tr><td>صورتجلسه کسر</td><td colspan="10"><asp:TextBox  Text="0"  runat="server" ID="txtSoratJalase_Manfi"></asp:TextBox></td></tr>

        <tr>
            <td>از تاریخ:</td>
            <td>
                <uc1:CtlDatePick ID="CtlFromDate" runat="server" />
            </td>
        
            <td>تا تاریخ:</td>
            <td>
                <uc1:CtlDatePick ID="CtlToDate" runat="server" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="اضافه کردن به آرشیو" OnClick="Button1_Click" /></td>
        </tr>
    </table>
                        <asp:DropDownList Visible="false" runat="server" ID="ddArchivID" AutoPostBack="True" OnSelectedIndexChanged="ddArchivID_SelectedIndexChanged" ></asp:DropDownList>
    
   <asp:GridView ID="GridView1"  runat="server"
        AutoGenerateColumns="False" AllowPaging="false" 
     
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
 <asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.tbl_ArchiveAgreeTitle")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
  <asp:TemplateField HeaderText="دریافت گزارش"> 
               <ItemTemplate>
                        <a id="ADeleee" class="fa fa-print"  href='<%# DataBinder.Eval(Container,"DataItem.tbl_ArchiveAgreeTitle")%>' title="print"   onserverclick="PrintItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
  <asp:TemplateField HeaderText="اصلاح مقادیر"> 
               <ItemTemplate>
                        <a id="ADeleeeff" class="fa fa-edit" aid='<%# DataBinder.Eval(Container,"DataItem.AgreeID") %>' href='<%# DataBinder.Eval(Container,"DataItem.tbl_ArchiveAgreeTitle")%>' title="print"   onserverclick="PrintItem2" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >

   <asp:BoundField DataField="tbl_ArchiveAgreeTitle"  HeaderText="شماره"   SortExpression="tbl_ArchiveAgreeTitle" />
       <asp:BoundField DataField="Title"  HeaderText="عنوان"   SortExpression="Title" />
       <asp:BoundField DataField="AgreeID"  HeaderText="قرارداد"   SortExpression="AgreeID" />
<%--    <asp:TemplateField HeaderText="ازتاریخ"   SortExpression="FromDate"><ItemTemplate> <asp:Label runat="server" ID="l1" Text='<%=  DateConvert.m2sh( Eval("FromDate").ToString()).ToString() %>' ></asp:Label> </ItemTemplate></asp:TemplateField>--%>
      <asp:BoundField DataField="FromDatefa"  HeaderText="ازتاریخ"   SortExpression="FromDate" />
<%--        <asp:TemplateField HeaderText="تا تاریخ"   SortExpression="ToDate"><ItemTemplate><asp:Label runat="server" ID="l2" Text='<%= DateConvert.m2sh( Eval("ToDate").ToString()).ToString() %>'></asp:Label></ItemTemplate></asp:TemplateField>--%>

   <asp:BoundField DataField="ToDatefa"  HeaderText="تا تاریخ"   SortExpression="ToDate" />
    <asp:BoundField DataField="SoratJalase"  HeaderText="صورتجلسه"   SortExpression="SoratJalase" />
   <asp:BoundField DataField="SoratJalase_Manfi"  HeaderText="صورتجلسه منفی"   SortExpression="SoratJalase_Manfi" />


             </Columns>
</asp:GridView>
</asp:Content>

