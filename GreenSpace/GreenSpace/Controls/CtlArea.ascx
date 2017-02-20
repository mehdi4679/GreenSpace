<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlArea.ascx.cs" Inherits="GreenSpace.Controls.CtlArea" %>
    <%@ Register src="CtlPEymanPark.ascx" tagname="CtlPEymanPark" tagprefix="uc1" %>
<%@ Register src="CtlRegionPark.ascx" tagname="CtlRegionPark" tagprefix="uc2" %>
    <div >
     <asp:Label ID="LblParamAreaID"  Visible="false" runat="server" Text="0"></asp:Label> 
     <asp:Label ID="lblAgreementID"  Visible="false" runat="server" Text="0" ></asp:Label> 

        <table>
            <tr>
                <td>موضوع&nbsp; کار:</td>
                <td>
                    <asp:DropDownList runat="server" ID="ddSubject" AutoPostBack="True" OnSelectedIndexChanged="ddSubject_SelectedIndexChanged"></asp:DropDownList>



                </td>
                </tr>
            <tr>
                <td>شرح کار</td><td><asp:dropdownlist runat="server" ID="DDSubjectExplainID" ></asp:dropdownlist></td><td></td><td>
</td><td></td>
            </tr>
            <tr>
                <td colspan="5">
                     <uc2:CtlRegionPark ID="DDParkID" runat="server" />
                   <%-- <uc2:CtlRegionPark ID="CtlRegionPark1" runat="server" />--%>
                </td>
                    </tr>
    <tr><td>مقدار واحد</td><td><asp:textbox runat="server" ID="TXTUnitNumber" ></asp:textbox></td><td></td><td>
</td><td>                 <asp:RequiredFieldValidator ID="RqUnitNumber" runat="server" 
                  ControlToValidate="txtUnitNumber" ErrorMessage="لطفا پر کنبد" 
                  ValidationGroup="RVTbl_Area" ForeColor="Red">
                 </asp:RequiredFieldValidator></td></tr>
 
            <tr>
                <td>
                    <asp:Button runat="server" Text="ثبت"  ID="BtnInsert" SkinID="btnInsert" 
                      OnClick="BtnInsert_Click"   ValidationGroup="RVTbl_Area" />

   <%-- <asp:Button runat="server"  ID="btnSerachLight" Visible="false"  Text="جستجو" SkinID="hbtn-search-r"/> 
    <input type="button" runat="server" ID="btnInsertLight"  onclick="openLight()" value="افزودن"  SkinID="btnInsert"  />--%>

                </td>
            </tr>
        </table>

    </div >
    <div >
          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
    </div >
 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="false" OnPageIndexChanging="GridView1_PageIndexChanging"  OnSorting="GridView1_Sorting"
               AllowSorting="True" >
<Columns>
            <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.AreaID")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AreaID")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <asp:BoundField DataField="AreaID"  HeaderText="ش فرآیند"   SortExpression="AreaID" />
   <asp:BoundField DataField="ParkName"  HeaderText="پارک"   SortExpression="ParkName" />
   <asp:BoundField DataField="SubjectExplainIDName"  HeaderText="شرح کار"   SortExpression="SubjectExplainIDName" />
   <asp:BoundField DataField="UnitNumber"  HeaderText="مقدار واحد"   SortExpression="UnitNumber" />
             </Columns>
</asp:GridView>
        

<div  id="lightboxdivvv" class="LightBoxDivvv" >
<div id="lightinserttt" class="Lightboxxx" >
<table>
<tr runat="server" id="TrPrimery" visible="false" ><td>ش فرآیند</td><td><asp:textbox Visible="false"   runat="server" ID="TXTAreaID" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
    <tr runat="server" visible="false"><td>پارک</td><td> 
   
    </td><td></td><td>
</td><td></td></tr>
    
              <div >
              
             
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" /> 
<script type="text/javascript">
      <%-- if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
            setTimeout(f, 0);
        }--%>
     
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv")
    }
    function openLight(){
    document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
    }
   </script>

