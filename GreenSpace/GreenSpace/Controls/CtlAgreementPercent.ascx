<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreementPercent.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreementPercent" %>
    <%@ Register src="CtlDropExplan.ascx" tagname="CtlDropExplan" tagprefix="uc1" %>
    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>
    <%@ Register src="CtlAgreePercentProtest.ascx" tagname="CtlAgreePercentProtest" tagprefix="uc3" %>
    <div >
     <asp:Label ID="LblParamAgreementPercentID"  Visible="false" runat="server" Text="0" ></asp:Label>
     <asp:Label ID="lblAgreement"  Visible="false" runat="server"  Text="0"></asp:Label> 
      <div runat="server" id="ddd" visible="false">   <asp:Label ID="ragree"   Visible="false" runat="server"  Text="0"></asp:Label>
</div>
    <input type="button" runat="server"   value="افزودن" onclick="openlight();"  SkinID="btnInsert"  />
    <asp:Button runat="server" Visible="false"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r"/> 
        <uc1:CtlDropExplan ID="DDExplainID" runat="server" />
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
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
<asp:TemplateField HeaderText="اعتراض">
            <ItemTemplate>
                        <a id="AEdit22" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="اعتراض" onserverclick="ProtestItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AgreementPercentID"  HeaderText="ش فرآیند"   SortExpression="AgreementPercentID" />
   <asp:BoundField DataField="AgreementIDName"  HeaderText="قرارداد"   SortExpression="AgreementIDName" />
   <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
   <asp:BoundField DataField="utilityPersent"  HeaderText="درصد کیفیت"   SortExpression="utilityPersent" />
   <asp:BoundField DataField="VisitDatePr"  HeaderText="تاریخ بازدید"   SortExpression="VisitDatePr" />
   <asp:BoundField DataField="SuperVisorIDName"  HeaderText="ناظر"   SortExpression="SuperVisorIDName" />
   <asp:BoundField DataField="FineMeterOrRepeat"  HeaderText="متراژ یا تعداد جریمه"   SortExpression="FineMeterOrRepeat" />
   <asp:BoundField DataField="FineFactor"  HeaderText="ضریب بالاسری"   SortExpression="FineFactor" />
             </Columns>
</asp:GridView>
         

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAgreementPercentID" ></asp:textbox></td><td></td></tr>
    <tr runat="server" visible="false"><td>قرارداد</td><td><asp:dropdownlist runat="server" ID="DDAgreementID" ></asp:dropdownlist></td><td></td></tr><tr><td colspan="2">&nbsp;</td><td></td></tr><tr><td>درصد کیفیت</td><td><asp:textbox runat="server" ID="TXTutilityPersent" ></asp:textbox></td><td>                 <asp:RequiredFieldValidator ID="RqutilityPersent" runat="server" 
                  ControlToValidate="txtutilityPersent" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_AgreementPercent" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>تاریخ بازدید</td><td> 
        <uc2:CtlDatePick ID="TXTVisitDate" runat="server" />
                      
        </td><td>                   </td></tr><tr><td>ناظر</td><td><asp:DropDownList runat="server" ID="DDSuperVisorID" ></asp:DropDownList></td><td></td></tr>
   <tr><td>ضریب بالاسری جریمه</td><td><asp:dropdownlist runat="server" ID="DDFineFactor" AutoPostBack="True" OnSelectedIndexChanged="DDFineFactor_SelectedIndexChanged" >
       <asp:ListItem Value="0">بدون اعمال جریمه</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        </asp:dropdownlist></td><td></td></tr>  
    <tr><td colspan="5">
        <table runat="server" id="tbljarime" >
<tr><td>متراژ یا تعداد جریمه</td><td><asp:textbox runat="server" ID="TXTFineMeterOrRepeat" ></asp:textbox></td><td>                 <asp:RegularExpressionValidator ID="RVFineMeterOrRepeat" runat="server" 
                  ControlToValidate="txtFineMeterOrRepeat" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_AgreementPercent" ForeColor="Red"></asp:RegularExpressionValidator>
    </td></tr>
           
<tr><td>علت اعمال جریمه</td><td><asp:TextBox runat="server" ID="txtJarimeComment" TextMode="MultiLine"></asp:TextBox></td><td>                 &nbsp;</td></tr>
           
        </table>

        </td></tr>
     
  
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                          ValidationGroup="RVTbl_AgreementPercent" />
             
             <asp:Button runat="server"   Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
    <div id="lightinsert2" class="Lightbox" >


       

        <uc3:CtlAgreePercentProtest ID="CtlAgreePercentProtest1" runat="server" />

        </div>

        </div>
 <input type="hidden"  id="LightBox" runat="server" />
 <input type="hidden"  id="LightBox2" runat="server" />  
<script type="text/javascript">
      if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }
      if (document.getElementById('<%= LightBox2.ClientID %>').value == "1") {
            setTimeout(f2, 0);
        }     
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightinsert2");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function f2() {
        scripthelper.ShowLightBox("lightinsert2", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
 // scripthelper.CloseLightBox("lightinsert2", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }

    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }

   </script>

