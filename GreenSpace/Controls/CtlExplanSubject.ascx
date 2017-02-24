<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlExplanSubject.ascx.cs" Inherits="GreenSpace.Controls.CtlExplanSubject" %>

    <%@ Register src="CtlPrice.ascx" tagname="CtlPrice" tagprefix="uc1" %>
<style>
    .notvisible{visibility:hidden;}
    .isvisible{visibility:inherit;}
</style>
    <div >
     <asp:Label ID="LblParamExplainSubjectID" Visible="false"  runat="server" Text="0" ></asp:Label> 
    <input type="button" runat="server" ID="btnInsertLight"  value="افزودن"  SkinID="btnInsert" onclick="setlight()"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
          
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnSorting="GridView1_Sorting" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="30"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<%--<asp:TemplateField HeaderText="ارث بری از کل">
            <ItemTemplate>
                        <a id="AEdit" class='<%# Eval("ErthAzKol").ToString()=="0" ? "AFalse":"ATrue"  %>' ErthAzKol='<%#Eval("ErthAzKol").ToString() %>'  href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")%>' title="ارث بری از کل" onserverclick="ErthItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="ExplainSubjectID"  HeaderText="ش فرآیند"   SortExpression="ExplainSubjectID" />
   <asp:BoundField DataField="SubjectName"  HeaderText="موضوع کار"   SortExpression="SubjectName" />
<%--       <asp:BoundField DataField="RotinOrNot"  HeaderText="RotinOrNotر"   SortExpression="RotinOrNot" />--%>
  
              <asp:TemplateField HeaderText="پلوس" SortExpression="ErthAzKol" >
            <ItemTemplate>
            <a id="AfasdaHavePlus" class='<%# Eval("HavePlus").ToString()=="1" ? "ATrue":"AFalse" %>' VisibleItem='<%#Eval("HavePlus").ToString() %> '   href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")  %>' title="پلوس" onserverclick="HavePlusItem" runat="server" ></a>
            </ItemTemplate>
            </asp:TemplateField>     

            <asp:TemplateField HeaderText="نمایش" SortExpression="ErthAzKol" >
            <ItemTemplate>
            <a id="Afasda" class='<%# Eval("Visible").ToString()=="1" ? "ATrue":"AFalse" %>' VisibleItem='<%#Eval("Visible").ToString() %> '   href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")  %>' title="نمایش" onserverclick="VisibleItem" runat="server" ></a>
            </ItemTemplate>
            </asp:TemplateField>    
    
      <asp:TemplateField HeaderText="تشکیل دهنده کل" SortExpression="ErthAzKol" >
            <ItemTemplate>
                         <a id="Af" class='<%# Eval("ErthAzKol").ToString()=="1" ? "ATrue":"AFalse" %>' ErthAzKol='<%#Eval("ErthAzKol").ToString() %> '   href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")  %>' title="فعال" onserverclick="ErthItem" runat="server" ></a>
             </ItemTemplate>
             </asp:TemplateField>
    <asp:TemplateField HeaderText="متراژ کل" SortExpression="ErthAzKol" >
            <ItemTemplate>
           <%--  <div class='<%# Eval("RotinOrNot").ToString()=="2" ? "isvisible":"notvisible" %>'>  --%>
                        <a id="ggg" class='<%# Eval("UseFromKol").ToString()=="1" ? "ATrue":"AFalse" %>' UseFromKol='<%#Eval("UseFromKol").ToString() %> '   href='<%# DataBinder.Eval(Container,"DataItem.ExplainSubjectID")  %>' title="" onserverclick="UseFromKolItem" runat="server" ></a>
              <%--  </div>--%>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
    <%--<asp:TemplateField HeaderText="قیمت واحد پیش فرض  "  SortExpression="DayPriceDefualt" ><ItemTemplate><span class="priceclass"><%#Eval("DayPriceDefualt").ToString() %></span></ItemTemplate></asp:TemplateField>--%>
  <%--  <asp:TemplateField HeaderText="قیمت واحد پیش فرض در شب"  SortExpression="DayPriceDefualt" ><ItemTemplate><span class="priceclass"><%#Eval("NightPriceDefualt").ToString() %></span></ItemTemplate></asp:TemplateField>--%>
  <asp:BoundField DataField="DayPriceDefualt"  HeaderText="قیمت واحد پیش فرض  " ControlStyle-CssClass="priceclass"  SortExpression="DayPriceDefualt" />
 <%--  <asp:BoundField DataField="NightPriceDefualt"  CssClass="priceclass"  SortExpression="NightPriceDefualt" /> --%>
   <asp:BoundField DataField="UnitNameIDName"  HeaderText="نام واحد شمارش"   SortExpression="UnitNameIDName" />
   <asp:BoundField DataField="RotinOrNotName"  HeaderText="روتین؟"   SortExpression="RotinOrNotName" />
             </Columns>
</asp:GridView>
         

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false"><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTExplainSubjectID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>موضوع کار</td><td><asp:dropdownlist runat="server" ID="DDSubjectID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>شرح کار</td><td><asp:textbox runat="server" ID="TXTExplainName" ></asp:textbox></td><td></td><td>
</td><td>                 <asp:RequiredFieldValidator ID="RqExplainName" runat="server" 
                  ControlToValidate="txtExplainName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_ExplanSubject" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>قیمت واحد پیش فرض  </td><td>
                  <%--   <asp:textbox runat="server" ID="" CssClass="priceclass"></asp:textbox>--%>
                     <uc1:CtlPrice ID="TXTDayPriceDefualt" runat="server" />

                                                                                             </td><td></td><td>             
                        <%-- <asp:RegularExpressionValidator ID="RVDayPriceDefualt" runat="server" 
                  ControlToValidate="txtDayPriceDefualt" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_ExplanSubject" ForeColor="Red"></asp:RegularExpressionValidator>--%>
</td><td></td></tr>
    <tr runat="server" visible="false" ><td>قیمت واحد پیش فرض در شب</td><td>
<%--    <asp:textbox runat="server" ID="" CssClass="priceclass" ></asp:textbox>--%>

 <uc1:CtlPrice Text="0" ID="TXTNightPriceDefualt" runat="server"  />
                                                       </td><td></td><td>            
<%--         <asp:RegularExpressionValidator ID="RVNightPriceDefualt" runat="server" 
                  ControlToValidate="txtNightPriceDefualt" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_ExplanSubject" ForeColor="Red"></asp:RegularExpressionValidator>--%>
</td><td></td></tr><tr><td>نام واحد شمارش</td><td><asp:dropdownlist runat="server" ID="DDUnitNameID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>روتین؟</td><td><asp:dropdownlist runat="server" ID="DDRotinOrNot" >
    <asp:ListItem Value="1">روتین</asp:ListItem>
    <asp:ListItem Value="2">غیر روتین</asp:ListItem>
    </asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert"  OnClick="BtnInsert_Click"
                          ValidationGroup="RVTbl_ExplanSubject" />
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
    function setlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = 1;
        //document.getElementById('<%= LblParamExplainSubjectID.ClientID %>').value = "0";
            f();

         }
   </script>

