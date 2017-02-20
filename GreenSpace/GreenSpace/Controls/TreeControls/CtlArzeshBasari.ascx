<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlArzeshBasari.ascx.cs" Inherits="GreenSpace.Controls.CtlArzeshBasari" %>
    <div >
     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r"/> 
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="id"  HeaderText="id"   SortExpression="id" />
   <asp:BoundField DataField="StreetType"  HeaderText="نوع مکان"   SortExpression="StreetType" />
   <asp:BoundField DataField="BasariRotbeh"  HeaderText="رتبه ارزش بصری"   SortExpression="BasariRotbeh" />
   <asp:BoundField DataField="ArzeshBasari"  HeaderText="ضریب ارزش بصری"   SortExpression="ArzeshBasari" />
   <asp:BoundField DataField="yearcatalog"  HeaderText="سال"   SortExpression="yearcatalog" />
             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>&nbsp;</td><td><asp:textbox Visible="false"   runat="server" ID="TXTid" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نوع مکان</td><td><asp:dropdownlist runat="server" ID="DDStreetTypeId" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>رتبه ارزش بصری</td><td><asp:dropdownlist runat="server" ID="DDBasariRotbehId" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>ضریب ارزش بصری</td><td><asp:textbox runat="server" ID="TXTArzeshBasari" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVArzeshBasari" runat="server" 
                  ControlToValidate="txtArzeshBasari" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^[+]?\d*$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_ArzeshBasari" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>سال</td><td><asp:dropdownlist runat="server" ID="DDyear" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_ArzeshBasari" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_ArzeshBasari" OnClick="BtnUpdate_Click1"  />
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

