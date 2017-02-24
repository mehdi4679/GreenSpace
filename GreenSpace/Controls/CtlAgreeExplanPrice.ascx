<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreeExplanPrice.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreeExplanPrice" %>
    <%@ Register src="CtlDropExplan.ascx" tagname="CtlDropExplan" tagprefix="uc1" %>



    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>

    <div >
     <asp:Label ID="LblParamExplanPriceID"  Visible="false" runat="server" Text="0" ></asp:Label> 
 <div runat="server" id="dbtninsert">
    <input type="button"  ID="btnInsertLight"  value="افزودن"  SkinID="btnInsert" onclick="openlight()"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="درج تمام شرح کارهای این موضوع کار در قرارداد جاری" />
     <asp:Label runat="server" ID="Label1" ></asp:Label>
        </div>
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
<table>
    <tr runat="server" id="trrr">
        <td>
            اعمال ضریب قیمت گروهی:
        </td>
        <td><asp:TextBox runat="server" ID="txtzaribprice"></asp:TextBox></td>
        <td><asp:Button runat="server" ID="btnzarib" Text="اعمال ضریب به همه قیمت ها" OnClick="btnzarib_Click"/></td>
    </tr>
</table>

  <table>
        <tr><td>موضوع کار:</td>
            <td> 
                <asp:DropDownList ID="ddsubject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddsubject_SelectedIndexChanged">
                </asp:DropDownList>
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.ExplanPriceID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ExplanPriceID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<asp:TemplateField HeaderText="فعال">
            <ItemTemplate>
                        <a id="Af" class='<%# Eval("ActID").ToString()=="1" ? "ATrue":"AFalse" %>'    href='<%# DataBinder.Eval(Container,"DataItem.ExplanPriceID")+"$"+Eval("ActID").ToString() %>' title="فعال" onserverclick="ActItem" runat="server" >

<%--                            <%= DateConvert.m2sh( Eval("FromDateActive").ToString() ).ToString() + " , "+DateConvert.m2sh( Eval("ToDateActive").ToString() ).ToString() %> --%>

                        </a>
                                  <%--          <asp:Label runat="server" ID="lbl1" Text="<%#Eval("FromDateActivefa") %>"></asp:Label>
                            <asp:Label runat="server" ID="lbl22" Text="  "></asp:Label>
                           <asp:Label runat="server" ID="lbl2" Text="<%#Eval("ToDateActivefa") %>" ></asp:Label>--%>

            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="FromDateActivefa"  HeaderText="از تاریخ"   SortExpression="FromDateActivefa" />
   <asp:BoundField DataField="ToDateActivefa"  HeaderText="تا تاریخ"   SortExpression="ToDateActivefa" />

   <asp:BoundField DataField="ExplanPriceID"  HeaderText="ش فرآیند"   SortExpression="ExplanPriceID" />
   <asp:BoundField DataField="SubjectNamee2"  HeaderText="موضوع کار"   SortExpression="SubjectNamee2" />

   <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
<%--   <asp:BoundField DataField="PriceNightExplan"  HeaderText="قیمت در شب"  ControlStyle-CssClass="priceclass"  SortExpression="PriceNightExplan" />--%>
   <asp:BoundField DataField="PriceDayExplan"  HeaderText="قیمت  "  ControlStyle-CssClass="priceclass"  SortExpression="PriceDayExplan" />
   <asp:BoundField DataField="AgreementIDName"  HeaderText="قرارداد"   SortExpression="AgreementIDName" />
             </Columns>
</asp:GridView>
         

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTExplanPriceID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr> <td colspan="2"> 
    <uc1:CtlDropExplan ID="DDExplanID" runat="server"  />
    </td><td></td><td>
</td><td></td></tr>
    <tr runat="server" id="trpnight" visible="false" ><td>قیمت در شب</td><td><asp:textbox Text="0" runat="server" ID="TXTPriceNightExplan" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVPriceNightExplan" runat="server" 
                  ControlToValidate="txtPriceNightExplan" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_AgreeExplanPrice" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr>
    <tr><td>قیمت در روز</td><td><asp:textbox runat="server" ID="TXTPriceDayExplan" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVPriceDayExplan" runat="server" 
                  ControlToValidate="txtPriceDayExplan" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_AgreeExplanPrice" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td>                 <asp:RequiredFieldValidator ID="RqPriceDayExplan" runat="server" 
                  ControlToValidate="txtPriceDayExplan" ErrorMessage="لطفا پر کنید" 
                  ValidationGroup="RVTbl_AgreeExplanPrice" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr>
    <tr runat="server" id="ragree"><td>قرارداد</td><td><asp:dropdownlist runat="server" ID="DDAgreementID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click" 
                         ValidationGroup="RVTbl_AgreeExplanPrice" />
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
    <div id="LightFromToDate" class="Lightbox">
        <table>                    
            <tr><td>از تاریخ:</td><td> <uc2:CtlDatePick ID="txtFromDateActive" runat="server" /> </td></tr>
           <tr><td>تا تاریخ:</td><td><uc2:CtlDatePick ID="txtToDateActive" runat="server" /> </td></tr>
            <tr><td colspan="10"> <asp:Button runat="server" ID="btnSaveDates" Text="ذخیره بازه تاریخ" OnClick="btnSaveDates_Click1"/></td></tr>
        </table>
    </div>
        </div>
<asp:Label runat="server" ID="lblagreementID" Text="0" Visible="false" ></asp:Label>
 <input type="hidden"  id="LightBox" runat="server" /> 
 <input type="hidden"  id="LightBox1" runat="server" /> 

<script type="text/javascript">
        if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
            if (document.getElementById('<%= LightBox1.ClientID %>').value == "1") {
            setTimeout(f1, 0);
        }  
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function f1() {
        scripthelper.ShowLightBox("LightFromToDate", '<%= LightBox1.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv")
        scripthelper.CloseLightBox("LightFromToDate", '<%= LightBox1.ClientID %>', "lightboxdiv")

    }
    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>

