<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreementFine.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreementFine" %>
    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
    <%@ Register src="CtlPrice.ascx" tagname="CtlPrice" tagprefix="uc2" %>
    <div >
  <asp:Label ID="ragree"  Visible="false" runat="server"  Text="0"></asp:Label>   
     <asp:Label ID="LblParamAgreementFineID"  Visible="false" runat="server"   Text="0" ></asp:Label>
     <asp:Label ID="lblAgreement"  Visible="false" runat="server"  Text="0"></asp:Label> 
     
    <input runat="server" ID="btnInsertLight"  value="افزودن" type="button"  onclick="openlight();" />
    <asp:Button runat="server"  ID="btnSerachLight" Visible="false"  Text="جستجو" SkinID="hbtn-search-r"/> 
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AgreementFineID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreementFineID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AgreementFineID"  HeaderText="ش فرآیند"   SortExpression="AgreementFineID" />
   <asp:BoundField DataField="AgreementIDName"  HeaderText="ش فرآیند"   SortExpression="AgreementIDName" />

   <asp:BoundField DataField="FineIDName"  HeaderText="نوع تخلف"   SortExpression="FineIDName" />
   <asp:BoundField DataField="PRFineDate"  HeaderText="تاریخ تخلف"   SortExpression="PRFineDate" />
   <asp:BoundField DataField="FinePrice"  HeaderText="مبلغ تخلف"   SortExpression="FinePrice"  ControlStyle-CssClass="priceclass"/>
   <asp:BoundField DataField="FineComment"  HeaderText="توضیحات"   SortExpression="FineComment" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAgreementFineID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نوع تخلف</td><td><asp:dropdownlist runat="server" ID="DDFineID" AutoPostBack="true"  OnSelectedIndexChanged="DDFineID_SelectedIndexChanged" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>تاریخ تخلف</td><td> 
    <uc1:CtlDatePick ID="TXTFineDate" runat="server" />
    </td><td></td><td>
</td><td></td></tr><tr><td>مبلغ تخلف</td><td> 
    <uc2:CtlPrice ID="TXTFinePrice"  runat="server"  />
    </td><td></td><td>                 
</td><td>                 
                  </td></tr><tr><td>توضیحات</td><td><asp:textbox TextMode="MultiLine" runat="server" ID="TXTFineComment" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                       ValidationGroup="RVTbl_AgreementFine" />
             
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
    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>

