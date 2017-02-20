<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreeStatus.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreeStatus" %>
    <%@ Register src="CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc1" %>
    <div >
     <asp:Label ID="LblParamAgreeStatus"  Visible="false" runat="server"  Text="0"></asp:Label> 
     <asp:Label ID="lblAgreement"  Visible="false" runat="server"  Text="0"></asp:Label> 

    <input   ID="btnInsertLight"  value="افزودن" type="button"    OnClick="openlight();"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" Visible="false" SkinID="hbtn-search-r"/> 
    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AgreeStatus")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<%--<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreeStatus")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>--%>
   <asp:BoundField DataField="AgreeStatus"  HeaderText="ش فرآیند"   SortExpression="AgreeStatus" />
   <asp:BoundField DataField="StatusIDname"  HeaderText="وضعیت"   SortExpression="StatusIDname" />
   <asp:BoundField DataField="StatusDatepr"  HeaderText="تاریخ"   SortExpression="StatusDatepr" />
   <asp:BoundField DataField="AgreeStatusComment"  HeaderText="توضیحات"   SortExpression="AgreeStatusComment" />
             </Columns>
</asp:GridView>
       

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAgreeStatus" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>وضعیت</td><td><asp:dropdownlist runat="server" ID="DDStatusID" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr><tr><td>تاریخ</td><td><uc1:CtlDatePick ID="TXTStatusDate" runat="server" /> </td><td>
    
    </td><td>
</td><td></td></tr><tr><td>توضیحات</td><td><asp:textbox runat="server" ID="TXTAgreeStatusComment" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" OnClick="BtnInsert_Click"
                          ValidationGroup="RVTbl_AgreeStatus" />
             
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

