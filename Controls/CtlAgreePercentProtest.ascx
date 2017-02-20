<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreePercentProtest.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreePercentProtest" %>
    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
    <div >
     <asp:Label ID="LblParamAgreePercentProtestID"  Visible="false" runat="server" Text="0" ></asp:Label> 
     <asp:Label ID="LblAgreementPercentID"  Visible="false" runat="server" Text="0" ></asp:Label> 
     <asp:Label ID="LblUserResponseID"  Visible="false" runat="server" Text="0" ></asp:Label>
        <asp:Label ID="lblsematid"  Visible="false" runat="server" Text="0" ></asp:Label> 

   <%-- <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" Visible="false" SkinID="hbtn-search-r"/> --%>
    </div >
<div  id="lightboxdivvvvvs" class="LightBoxDiv11" >
<div id="lightinserttrfgd" class="Lightbox11" runat="server" >
<table >
<tr runat="server" id="TrPrimery" visible="false" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAgreePercentProtestID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>وضعیت اعتراض</td><td runat="server">
  

    <asp:DropDownList ID="DDProtestStatusID" runat="server"></asp:DropDownList>

                                            </td><td></td><td>
</td><td></td></tr><tr><td>تاریخ</td><td> 
    <uc1:CtlDatePick ID="TXTProtestDate" runat="server" />
    </td><td></td><td>
</td><td></td></tr><tr runat="server" id="trmmm"><td>مسول پاسخگویی</td><td><asp:dropdownlist runat="server" ID="DDUserResponseID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>توضیحات  </td><td><asp:textbox runat="server" TextMode="MultiLine" ID="TXTProtestComment" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
                        OnClick="BtnInsert_Click"  ValidationGroup="RVTbl_AgreePercentProtest" />
             
             <asp:Button  runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
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
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AgreePercentProtestID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="مشاهده و پاسخ"> 
               <ItemTemplate>
                        <a id="ADelpasokh" class="AEdit"  href='<%# DataBinder.Eval(Container,"DataItem.AgreePercentProtestID")%>' title="مشاهده و پاسخر"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
 
   <asp:BoundField DataField="AgreementIDName"  HeaderText="پیمان"   SortExpression="AgreementIDName" />
   <asp:BoundField DataField="utilityPersent"  HeaderText="درصد"   SortExpression="utilityPersent" />
   <asp:BoundField DataField="FullNameNazer"  HeaderText="ناظر"   SortExpression="FullNameNazer" />
   <asp:BoundField DataField="regdarsad"  HeaderText="تاریخ درصد"   SortExpression="regdarsad" />



   <asp:BoundField DataField="AgreePercentProtestID"  HeaderText="ش فرآیند"   SortExpression="AgreePercentProtestID" />
   <asp:BoundField DataField="ProtestStatusIDName"  HeaderText="وضعیت اعتراض"   SortExpression="ProtestStatusIDName" />
   <asp:BoundField DataField="ProtestDatePR"  HeaderText="تاریخ"   SortExpression="ProtestDatePR" />
   <asp:BoundField DataField="fullName"  HeaderText="مسول پاسخگویی"   SortExpression="fullName" />
   <asp:BoundField DataField="ProtestComment"  HeaderText="توضیحات  "   SortExpression="ProtestComment" />
             </Columns>
</asp:GridView>
        


<%-- <input type="hidden"  id="LightBox" runat="server" /> --%>
<%--<script type="text/javascript">
    var requestinupdatePrm = Sys.WebForms.PageRequestManager.getInstance();
    requestinupdatePrm.add_pageLoaded(requestinupdatePageLoaded);
    function requestinupdatePageLoaded(sender, args) {
        if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
    }
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv")
    }
   </script>--%>

