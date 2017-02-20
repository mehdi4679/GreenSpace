<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlPark.ascx.cs" Inherits="GreenSpace.Controls.CtlPark" %>
    
    <div >
   
    <input  ID="btnInsertLight" runat="server"  type="button" value="افزودن"   SkinID="btnInsert" onclick="setlight();" />
<%--     <asp:Button runat="server"  ID="btnSerachLight"  type="button" value="جستجو"  SkinID="hbtn-search-r" OnClick="btnSerachLight_Click" />- --%>
    <input  ID="btnSerachLight" type="button" value="جستجو"  SkinID="btnInsert" onclick="setlight2();" />

    
    </div >
<asp:Label ID="LblParamParkID"  Visible="false" runat="server" Text="0"></asp:Label>
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server"
      AutoGenerateColumns="False" AllowPaging="True"
      OnPageIndexChanging="GridView1_PageIndexChanging" 
     OnSorting="GridView1_Sorting" 
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.ParkID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.ParkID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="ParkID"  HeaderText="ش پارک"   SortExpression="ParkID" />
   <asp:BoundField DataField="ParkName"  HeaderText="نام پارک"   SortExpression="ParkName" />
   <asp:BoundField DataField="ParkAdress"  HeaderText="آدرس پارک"   SortExpression="ParkAdress" />
   <asp:BoundField DataField="ParkArea"  HeaderText="مساحت پارک"   SortExpression="ParkArea" />
   <asp:BoundField DataField="ParkSum"  HeaderText="جمع اجزا پارک"   SortExpression="ParkSum" />

   <asp:BoundField DataField="ParkDistrict"  HeaderText="منطقه"   SortExpression="ParkDistrict" />
             </Columns>
</asp:GridView>
        

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>ش پارک</td><td><asp:textbox Visible="false"   runat="server" ID="TXTParkID" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>نام پارک</td><td><asp:textbox runat="server" ID="TXTParkName" ></asp:textbox></td><td></td><td>
</td><td>                 <asp:RequiredFieldValidator ID="RqParkName" runat="server" 
                  ControlToValidate="txtParkName" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Park" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr>
  <%--  <tr><td>پیمان:</td><td><asp:DropDownList runat="server" ID="ddpeyman"></asp:DropDownList></td></tr>--%>
    <tr><td>آدرس پارک</td><td><asp:textbox runat="server" ID="TXTParkAdress" TextMode="MultiLine" Width="400px" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>مساحت پارک</td><td><asp:textbox runat="server" ID="TXTParkArea" ></asp:textbox></td><td></td><td>                 <asp:RegularExpressionValidator ID="RVParkArea" runat="server" 
                  ControlToValidate="txtParkArea" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید" 
                  ValidationExpression="^(\d{1,18})(.\d{1,3})?$" SetFocusOnError="True" 
                  ValidationGroup="RVTbl_Park" ForeColor="Red"></asp:RegularExpressionValidator>
</td><td></td></tr><tr><td>منطقه</td><td><asp:dropdownlist runat="server" ID="DDParkDistrict" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
    <tr><td colspan="100"></td></tr>
</table>
              <div >
               <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
                      ValidationGroup="RVTbl_Park" OnClick="BtnInsert_Click"/> 
            <div id="dBtnSerach" runat="server" style="visibility:hidden">
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r" OnClick="BtnSerach_Click"  />   
            </div></div>
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
        $('#<%= LblParamParkID.ClientID %>').val="0";  
            f();
            
      <%--      $('#<%= dBtnInsert.ClientID %>').css('visibility', 'inherit');--%>
        $('#<%= dBtnSerach.ClientID %>').css('visibility', 'hidden');
    }
 
    function setlight2() {
        document.getElementById('<%= LightBox.ClientID %>').value = 1;
        $('#<%= LblParamParkID.ClientID %>').val="0";  
            f();
            
            $('#<%= BtnInsert.ClientID %>').css('visibility', 'hidden'); 
        $('#<%= dBtnSerach.ClientID %>').css('visibility', 'inherit');
    }
   </script>

