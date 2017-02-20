<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AgreeMaster.master" AutoEventWireup="true" CodeBehind="ReportMonth.aspx.cs" Inherits="GreenSpace.Agree.ReportMonth" %>
<%@ Register src="../Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PesonContentPlaceHolder" runat="server">
    <asp:Label runat="server" ID="lblAgrement" Text="0" Visible="false"></asp:Label>

    <table>
        <tr>
            <td>از تاریخ:</td>
            <td>
                <uc1:CtlDatePick ID="CtlFromDate" runat="server" />
            </td>
        
            <td>تا تاریخ:</td>
            <td>
                <uc1:CtlDatePick ID="CtlToDate" runat="server" />
            </td>
        </tr>
    </table>
                        <asp:DropDownList runat="server" ID="ddSubject" AutoPostBack="True" OnSelectedIndexChanged="ddSubject_SelectedIndexChanged"></asp:DropDownList>
  <table>
      <tr>
          <td>خسارت:</td>
          <td>
            <asp:Label runat="server" ID="LBLkHESARAT" Text="0" ></asp:Label>
          </td>
      </tr>
  </table> 
   <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="false" OnPageIndexChanging="GridView1_PageIndexChanging"  OnSorting="GridView1_Sorting"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<%--<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AreaID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AreaID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
   <%--<asp:BoundField DataField="UnitNameIDname"  HeaderText="واحد"   SortExpression="UnitNameIDname" />--%>
    <asp:TemplateField    HeaderText="واحد"   SortExpression="UnitNameIDname"><ItemTemplate><%# Eval("UnitNameIDname").ToString()+Eval("daynamee").ToString() %></ItemTemplate></asp:TemplateField>

   <asp:BoundField DataField="pprriiccee"  HeaderText="بهای واحد"   SortExpression="pprriiccee"/>
   <asp:BoundField DataField="repeattt"  HeaderText="تکرار"   SortExpression="repeattt" />
   <asp:BoundField DataField="darsadreal"  HeaderText="درصد مطلوبیت"   SortExpression="darsadreal" />
   <asp:BoundField DataField="Darsadfinal"  HeaderText="درصد اعمالی"   SortExpression="Darsadfinal" />

    <asp:BoundField DataField="metraj"  HeaderText="متراژ"   SortExpression="metraj" />
   <asp:BoundField DataField="plus"  HeaderText="درصد پلوس"   SortExpression="plus" />
   <asp:BoundField DataField="amalkerd"  HeaderText="جمع عملکرد"   SortExpression="amalkerd" />
   <asp:BoundField DataField="pardakhti"  HeaderText="پرداختی"   SortExpression="pardakhti" />
<%--    <asp:BoundField DataField="finekhesarat"  HeaderText="خسارت"   SortExpression="finekhesarat" />--%>
       <asp:BoundField DataField="FineZarib"  HeaderText="جریمه:ضریب"   SortExpression="FineZarib" />
 

             </Columns>
</asp:GridView>
</asp:Content>
