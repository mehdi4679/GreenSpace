<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPeyman.ascx.cs" Inherits="GreenSpace.Controls.CtlPeyman" %>
    <div >
     <asp:Label ID="LblParamPeymanID"  Visible="false" runat="server" Text="0"></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClientClick="setlight();" OnClick="btnInsertLight_Click" />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" Visible="false"  SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"  /> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False"  AllowPaging="True" OnSorting="GridView1_Sorting"
               AllowSorting="True" OnPageIndexChanging="GridView1_PageIndexChanging" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.PeymanID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.PeymanID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="PeymanID"  HeaderText="ش پیمان"   SortExpression="PeymanID" />
   <asp:BoundField DataField="PeymanName"  HeaderText="نام پیمان"   SortExpression="PeymanName" />
   <asp:BoundField DataField="PeymanNumberNAme"  HeaderText="منطقه پیمان"   SortExpression="PeymanNumberNAme" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" visible="false" ><td>ش پیمان</td><td><asp:textbox Visible="false"   runat="server" ID="TXTPeymanID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نام پیمان</td><td><asp:textbox runat="server" ID="TXTPeymanName" ></asp:textbox></td><td></td><td>
</td><td>                 <asp:RequiredFieldValidator ID="RqPeymanName" runat="server" 
                  ControlToValidate="txtPeymanName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Peyman" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr><tr><td>منطقه پیمان</td><td><asp:dropdownlist runat="server" ID="DDPeymanNumber" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                      Visible="false"   ValidationGroup="RVTbl_Peyman" />
          
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r" OnClick="BtnSerach_Click"  Visible="false" />   
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
            document.getElementById('<%= LblParamPeymanID.ClientID %>').value = 0;
            f();
         
        }
   </script>

