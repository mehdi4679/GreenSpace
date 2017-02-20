<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreeExplanRepeat1.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreeExplanRepeat1" %>
  <%@ Register src="CtlDropExplan.ascx" tagname="CtlDropExplan" tagprefix="uc1" %>
    <div >
     <asp:Label ID="LblParamExplanRepeatID"  Visible="false" runat="server" Text="0" ></asp:Label> 
        <asp:Label ID="LblAgreementID"  Visible="false" runat="server" Text="0" ></asp:Label>
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click" />
    <asp:Button runat="server"  ID="btnSerachLight" Visible="false" Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
<table>
    <tr><td>موضوع کار</td>
        <td>
<asp:DropDownList runat="server" ID="ddSubjectFilter" AutoPostBack="True" OnSelectedIndexChanged="ddSubjectFilter_SelectedIndexChanged"></asp:DropDownList>

        </td>
    </tr>
</table>
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnSorting="GridView1_Sorting" OnPageIndexChanging="GridView1_PageIndexChanging"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.ExplanRepeatID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ExplanRepeatID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="ExplanRepeatID"  HeaderText="ش فرآیند"   SortExpression="ExplanRepeatID" />
   <asp:BoundField DataField="YearLyOrMonthlyName"  HeaderText="ماهانه یا سالانه"   SortExpression="YearLyOrMonthlyName" />
   <asp:BoundField DataField="ExplanIDName"  HeaderText="شرح کار"   SortExpression="ExplanIDName" />
   <asp:BoundField DataField="RpeatMonth1"  HeaderText="فروردین"   SortExpression="RpeatMonth1" />
   <asp:BoundField DataField="RpeatMonth2"  HeaderText="اردیبهشت"   SortExpression="RpeatMonth2" />
   <asp:BoundField DataField="RpeatMonth3"  HeaderText="خرداد"   SortExpression="RpeatMonth3" />
   <asp:BoundField DataField="RpeatMonth4"  HeaderText="تیر"   SortExpression="RpeatMonth4" />
   <asp:BoundField DataField="RpeatMonth5"  HeaderText="مرداد"   SortExpression="RpeatMonth5" />
   <asp:BoundField DataField="RpeatMonth6"  HeaderText="شهریور"   SortExpression="RpeatMonth6" />
   <asp:BoundField DataField="RpeatMonth7"  HeaderText="مهر"   SortExpression="RpeatMonth7" />
   <asp:BoundField DataField="RpeatMonth8"  HeaderText="آبان"   SortExpression="RpeatMonth8" />
   <asp:BoundField DataField="RpeatMonth9"  HeaderText="آذر"   SortExpression="RpeatMonth9" />
   <asp:BoundField DataField="RpeatMonth10"  HeaderText="دی"   SortExpression="RpeatMonth10" />
   <asp:BoundField DataField="RpeatMonth11"  HeaderText="بهمن"   SortExpression="RpeatMonth11" />
   <asp:BoundField DataField="RpeatMonth12"  HeaderText="اسفند"   SortExpression="RpeatMonth12" />
   <asp:BoundField DataField="AgreementName"  HeaderText="قرارداد"   SortExpression="AgreementName" />
   <asp:BoundField DataField="YearSUM"  HeaderText="تکرار سالانه"   SortExpression="YearSUM" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTExplanRepeatID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>ماهانه یا سالانه</td><td><asp:dropdownlist runat="server" ID="DDYearLyOrMonthly" AutoPostBack="True" OnSelectedIndexChanged="DDYearLyOrMonthly_SelectedIndexChanged" >
    <asp:ListItem Value="1">سالانه</asp:ListItem>
    <asp:ListItem Value="2">ماهانه</asp:ListItem>
    </asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td colspan="5"> 
<uc1:CtlDropExplan ID="DDExplanID" runat="server"  />

                       </td></tr>
         <tr runat="server" id="ragree" ><td>قرارداد</td>
             <td colspan="10"><asp:dropdownlist runat="server" ID="DDAgreementID" ></asp:dropdownlist>

                              </td> 
          </tr>
    <%--<tr>
        <td  > <input type="radio" id="rmonth"  onclick="fnm('1')"  >ماهانه </input> 
        <td colspan="4"> <input type="radio" id="ryear"   onclick="fnm('2')"  > سالانه </input> 
        </td></tr>--%>
    </table>
        <table id="tbmonth" runat="server" >

        <tr><td>فروردین</td><td><asp:textbox runat="server" ID="TXTRpeatMonth1" Text="0" ></asp:textbox></td><td></td><td>  
                           <asp:RegularExpressionValidator ID="RVRpeatMonth1" runat="server" 
        ControlToValidate="txtRpeatMonth1" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>اردیبهشت</td><td><asp:textbox runat="server" ID="TXTRpeatMonth2"  Text="0"></asp:textbox></td><td></td><td> 
                            <asp:RegularExpressionValidator ID="RVRpeatMonth2" runat="server" 
        ControlToValidate="txtRpeatMonth2" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>خرداد</td><td><asp:textbox runat="server" ID="TXTRpeatMonth3" Text="0" ></asp:textbox></td><td></td><td>
                             <asp:RegularExpressionValidator ID="RVRpeatMonth3" runat="server" 
        ControlToValidate="txtRpeatMonth3" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>تیر</td><td><asp:textbox runat="server" ID="TXTRpeatMonth4"  Text="0"></asp:textbox></td><td></td><td> 
                            <asp:RegularExpressionValidator ID="RVRpeatMonth4" runat="server" 
        ControlToValidate="txtRpeatMonth4" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>مرداد</td><td><asp:textbox runat="server" ID="TXTRpeatMonth5"  Text="0"></asp:textbox></td><td></td><td>  
                           <asp:RegularExpressionValidator ID="RVRpeatMonth5" runat="server" 
        ControlToValidate="txtRpeatMonth5" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>شهریور</td><td><asp:textbox runat="server" ID="TXTRpeatMonth6"  Text="0"></asp:textbox></td><td></td><td>
                             <asp:RegularExpressionValidator ID="RVRpeatMonth6" runat="server" 
        ControlToValidate="txtRpeatMonth6" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>مهر</td><td><asp:textbox runat="server" ID="TXTRpeatMonth7" Text="0" ></asp:textbox></td><td></td><td>    
                         <asp:RegularExpressionValidator ID="RVRpeatMonth7" runat="server" 
        ControlToValidate="txtRpeatMonth7" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>آبان</td><td><asp:textbox runat="server" ID="TXTRpeatMonth8" Text="0" ></asp:textbox></td><td></td><td>   
                          <asp:RegularExpressionValidator ID="RVRpeatMonth8" runat="server" 
        ControlToValidate="txtRpeatMonth8" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>آذر</td><td><asp:textbox runat="server" ID="TXTRpeatMonth9"  Text="0"></asp:textbox></td><td></td><td>    
                         <asp:RegularExpressionValidator ID="RVRpeatMonth9" runat="server" 
        ControlToValidate="txtRpeatMonth9" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>دی</td><td><asp:textbox runat="server" ID="TXTRpeatMonth10"  Text="0"></asp:textbox></td><td></td><td>    
                         <asp:RegularExpressionValidator ID="RVRpeatMonth10" runat="server" 
        ControlToValidate="txtRpeatMonth10" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>بهمن</td><td><asp:textbox runat="server" ID="TXTRpeatMonth11"  Text="0"></asp:textbox></td><td></td><td> 
                            <asp:RegularExpressionValidator ID="RVRpeatMonth11" runat="server" 
        ControlToValidate="txtRpeatMonth11" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        <tr><td>اسفند</td><td><asp:textbox runat="server" ID="TXTRpeatMonth12"  Text="0"></asp:textbox></td><td></td><td> 
                            <asp:RegularExpressionValidator ID="RVRpeatMonth12" runat="server" 
        ControlToValidate="txtRpeatMonth12" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        </table>
        <table id="tbrepeat" runat="server" >
        <tr><td>تکرار سالانه</td><td><asp:textbox runat="server" ID="TXTRepeateYear"  Text="0"></asp:textbox></td><td></td><td>  
                           <asp:RegularExpressionValidator ID="RVRepeateYear" runat="server" 
        ControlToValidate="txtRepeateYear" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
        ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
        ValidationGroup="RVTbl_AgreeExplanRepeat" ForeColor="Red"></asp:RegularExpressionValidator>
        </td><td></td></tr>
        </table>
        
        <div >
        <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
            ValidationGroup="RVTbl_AgreeExplanRepeat" OnClick="BtnInsert_Click"/>
         <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" OnClick="BtnSerach_Click" />   
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
    function fnm(i){
        if (i == "1") {
            $('#tbmonth').fadein(1000);
            $('#tbrepeat').fadeout();
        }
        else {
            $('#tbmonth').fadeout();
            $('#tbrepeat').fadein(1000);

        }
    }
   </script>

