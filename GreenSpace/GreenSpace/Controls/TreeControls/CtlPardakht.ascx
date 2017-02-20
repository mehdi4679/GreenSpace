<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPardakht.ascx.cs" Inherits="GreenSpace.Controls.CtlPardakht" %>

 <%@ Register src="~/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
<%--  <script type='text/javascript'>
      function digitGroup(dInput) {
          var output = "";
          try {
              dInput = dInput.replace(/[^0-9]/g, ""); // remove all chars including spaces, except digits.
              var totalSize = dInput.length;
              for (var i = totalSize - 1; i > -1; i--) {
                  output = dInput.charAt(i) + output;
                  var cnt = totalSize - i;
                  if (cnt % 3 === 0 && i !== 0) {
                      output = "," + output; // seperator is " "
                  }
              }
          } catch (err) {
              output = dInput; // it won't happen, but it's sweet to catch exceptions.
          }
          return output;
      }
        </script>--%>


  <asp:Label ID="LblCuttingTreeID" runat="server" Text="0" Visible="False"></asp:Label>
     <asp:Label ID="LblLicensingId" runat="server" Text="0" Visible="False"></asp:Label>     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 


<div  id="lightboxdivvvvvs13" class="LightBoxDiv11" >
<div id="lightinserttrfgd23" class="Lightbox11" >
<table>
<tr runat="server" id="TrPrimery" ><td> </td><td><asp:textbox Visible="false"   runat="server" ID="TXTPardakhtId" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>وضعیت پرداخت</td><td><asp:dropdownlist runat="server" ID="DDPardakhtStatusid" ></asp:dropdownlist></td><td></td><td>                 
</td><td>                 &nbsp;</td></tr><tr><td>مبلغ</td><td><asp:textbox runat="server" ID="TXTMablaghFinal"   ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>شماره فیش</td><td><asp:textbox runat="server" ID="TXTFishNum" ></asp:textbox></td><td></td><td>                 &nbsp;</td><td>                 &nbsp;</td></tr><tr><td>تاریخ فیش</td><td>
    <uc1:CtlDatePick ID="TXTPardakhtDate" runat="server" />
    </td><td>&nbsp;</td><td>                 &nbsp;</td><td>                 &nbsp;</td></tr><tr><td>توضیحات</td><td><asp:textbox runat="server" ID="TXTDesc" ></asp:textbox></td><td>&nbsp;</td><td>                 &nbsp;</td><td>                 &nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="true"   ValidationGroup="RVTbl_Abbaha" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Abbaha" OnClick="BtnUpdate_Click1"  />
             <asp:Button runat="server"  Text="انصراف" ID="btnCancel" SkinID="btnOk" 
                     ValidationGroup="RVTbl_Abbaha" OnClick="btnCancel_Click"  />
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PardakhtId")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.PardakhtId")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="PardakhtStatus"  HeaderText="وضعیت پرداخت"   SortExpression="PardakhtStatusid" />
   <asp:BoundField DataField="Total"  HeaderText="مبلغ نهایی"   SortExpression="Total"  />
   <asp:BoundField DataField="FishNum"  HeaderText="شماره فیش"   SortExpression="FishNum" />
<asp:BoundField DataField="date1"  HeaderText="تاریخ"   SortExpression="date1" />

             </Columns>
</asp:GridView>


<%--   <asp:BoundField DataField="mony"  HeaderText="mony"   SortExpression="mony" />
   <asp:BoundField DataField="year"  HeaderText="year"   SortExpression="year" />--%>

