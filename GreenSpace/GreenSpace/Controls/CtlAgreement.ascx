<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreement.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreement" %>
    <%@ Register src="CtlCatalog.ascx" tagname="CtlCatalog" tagprefix="uc1" %>
     <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>
 
     <div >
     <asp:Label ID="LblParamAgreementID"  Visible="false" runat="server" Text="0" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" SkinID="grid1"
               AllowSorting="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AgreementID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreementID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<asp:TemplateField HeaderText="پرونده قرارداد">
            <ItemTemplate>
                        <a id="AEdit2" class="" href='<%# "/agree/agreepark.aspx?pname=پارک های قرارداد&District="+ Eval("District").ToString() +"&Aid="+ DataBinder.Eval(Container,"DataItem.AgreementID").ToString()%>' title="ورود پرونده"   runat="server" ><span class="fa fa-arrow-left"></span></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AgreementID"  HeaderText="ش فرآیند"   SortExpression="AgreementID" />
   <asp:BoundField DataField="PeymanIDName"  HeaderText="پیمان"   SortExpression="PeymanIDName" />
   <asp:BoundField DataField="PeymanKarIDName"  HeaderText="پیمانکار"   SortExpression="PeymanKarIDName" />
   <asp:BoundField DataField="supervisorStaticIDName"  HeaderText="ناظر مقیم"   SortExpression="supervisorStaticIDName" />
   <asp:BoundField DataField="MasterGreenSpaceIDName"  HeaderText="مسول منطقه سبز"   SortExpression="MasterGreenSpaceIDName" />
   <asp:BoundField DataField="supervisor2IDName"  HeaderText="ناظر عالی"   SortExpression="supervisor2IDName" />
   <asp:BoundField DataField="supervisor3IDName"  HeaderText="ناظر 3"   SortExpression="supervisor3IDName" />
    <asp:TemplateField  HeaderText="تاریخ شروع قرارداد"   SortExpression="StatrtDateAgreement"><ItemTemplate><%#  Eval("StatrtDateAgreementName").ToString()  %></ItemTemplate></asp:TemplateField>
  
    <asp:TemplateField HeaderText="تاریخ اتمام قرارداد"   SortExpression="EndDateAgreement"><ItemTemplate><%#   Eval("EndDateAgreementName").ToString()  %></ItemTemplate></asp:TemplateField>
    <asp:TemplateField HeaderText="مبلغ پایه"   SortExpression="PriceAgreementYear"><ItemTemplate><span class="priceclass"><%#   Eval("PriceAgreementYear").ToString()  %></span></ItemTemplate></asp:TemplateField>
 
<%--   <asp:BoundField DataField="PriceAgreementYear"  HeaderText="برآورد قیمت سالانه" ControlStyle-CssClass="priceclass"   SortExpression="PriceAgreementYear" />--%>
<%--   <asp:BoundField DataField="MonitorinOfficeIDName"  HeaderText="تایید اداره نظارت"   SortExpression="MonitorinOfficeIDName" />--%>
   <asp:BoundField DataField="Puls"  HeaderText="ضریب پلوس"   SortExpression="Puls" />

             </Columns>
</asp:GridView>
      

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAgreementID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>پیمان</td><td><asp:dropdownlist runat="server" ID="DDPeymanID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>پیمانکار</td><td><asp:dropdownlist runat="server" ID="DDPeymanKarID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>ناظر مقیم</td><td><asp:dropdownlist runat="server" ID="DDsupervisorStaticID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>مسول منطقه سبز</td><td><asp:dropdownlist runat="server" ID="DDMasterGreenSpaceID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>ناظر عالی</td><td><asp:dropdownlist runat="server" ID="DDsupervisor2ID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>ناظر 3</td><td><asp:dropdownlist runat="server" ID="DDsupervisor3ID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>تاریخ شروع قرارداد</td><td> 
  
    <uc2:CtlDatePick ID="TXTStatrtDateAgreement" runat="server" />
  
    </td><td></td><td>
    
   
    
</td><td>                 &nbsp;</td></tr><tr><td>تاریخ اتمام قرارداد</td><td> <uc2:CtlDatePick ID="TXTEndDateAgreement" runat="server" /></td><td></td><td>
  
    
  
</td><td></td></tr><tr><td>مبلغ پایه</td><td><asp:textbox runat="server" ID="TXTPriceAgreementYear" CssClass="priceclass" ></asp:textbox></td><td></td><td>          
         <%--  <asp:RegularExpressionValidator ID="RVPriceAgreementYear" runat="server" 
                  ControlToValidate="txtPriceAgreementYear" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Agreement" ForeColor="Red"></asp:RegularExpressionValidator>--%>
</td><td></td></tr>
    
    <tr><td>ضریب پلوس</td><td><asp:TextBox runat="server" ID="txtPulse"></asp:TextBox></td><td>&nbsp;</td><td>                 &nbsp;</td><td>&nbsp;</td></tr>
    
    <tr runat="server" visible="false"><td>تایید اداره نظارت</td><td><asp:dropdownlist runat="server" ID="DDMonitorinOfficeID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                         ValidationGroup="RVTbl_Agreement" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_Agreement"  />
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" /> 
<script type="text/javascript">

    if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
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
   </script>

