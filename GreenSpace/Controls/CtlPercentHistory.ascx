<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPercentHistory.ascx.cs" Inherits="GreenSpace.Controls.CtlPercentHistory" %>
    <div >
     <asp:Label ID="LblParamHistoryPercentID"  Visible="false" runat="server" Text="0" ></asp:Label> 
        <asp:Label ID="lblAgreementPercentID"  Visible="false" runat="server"  Text="0"></asp:Label>
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<%--<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.HistoryPercentID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.HistoryPercentID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="HistoryPercentID"  HeaderText="ش فرآیند"   SortExpression="HistoryPercentID" />
   <asp:BoundField DataField="PercentNumber"  HeaderText="درصد"   SortExpression="PercentNumber" />
   <asp:BoundField DataField="IP"  HeaderText="IP"   SortExpression="IP" />
   <asp:BoundField DataField="OS"  HeaderText="OS"   SortExpression="OS" />
<%--    <asp:TemplateField HeaderText="تاریخ ثبت"   SortExpression="DateReg"><ItemTemplate><asp:Label runat="server" ID="lblDate" Text='<%# Eval(DateConvert.m2sh("DateReg").ToString()) %>'  ></asp:Label></ItemTemplate></asp:TemplateField>--%>
   <asp:BoundField DataField="DateRegpr"  HeaderText="تاریخ و ساعت ثبت"   SortExpression="DateRegpr" />
   <asp:BoundField DataField="UserIDName"  HeaderText="کاربر"   SortExpression="UserIDName" />
   <asp:BoundField DataField="UnitNumber"  HeaderText="مقدار"   SortExpression="UnitNumber" />
   <asp:BoundField DataField="DescChange"  HeaderText="توضیحات"   SortExpression="DescChange" />
             </Columns>
</asp:GridView>
       

 
