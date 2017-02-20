<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlLicensingTree.ascx.cs" Inherits="GreenSpace.Controls.CtlLicensingTree" %>
<%@ Register Src="~/Controls/TreeControls/CtlTreeBonCutting.ascx" TagPrefix="uc1" TagName="CtlTreeBonCutting" %>
<%@ Register Src="~/Controls/TreeControls/CtlNazar.ascx" TagPrefix="uc1" TagName="CtlNazar" %>



<%@ Register src="~/Controls/CtlDatePicker.ascx" tagname="CtlDatePicker" tagprefix="uc2" %>
<%@ Register src="~/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc3" %>
<%@ Register Src="~/Controls/TreeControls/CtlPardakht.ascx" TagPrefix="uc1" TagName="CtlPardakht" %>
<%@ Register Src="~/Controls/TreeControls/CtlPersonal.ascx" TagPrefix="uc1" TagName="CtlPersonal" %>
<%@ Register Src="~/Controls/TreeControls/CtlHaghighi.ascx" TagPrefix="uc1" TagName="CtlHaghighi" %>






<div >
     <asp:Label ID="LblParamMojavezid"  Visible="false" runat="server" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r"/> 
     <asp:Label ID="lblPersonelID" runat="server" Visible="false" Text="0"></asp:Label>
     <asp:Label ID="lblHaghighiid" runat="server" Visible="false" Text="0"></asp:Label>
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
<%--<asp:TemplateField HeaderText="حذف"> 
               <ItemTemplate>
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >--%>
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>

        <asp:TemplateField HeaderText="ثبت درخت">
            <ItemTemplate>
                        <a id="AEdit22" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")+"-"+DataBinder.Eval(Container,"DataItem.MantagheId")%>' title="ثبت درخت" onserverclick="TreeBonCuttig" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>

            <asp:TemplateField HeaderText="ثبت نظر">
            <ItemTemplate>
                        <a id="AEdit23" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="ثبت درخت" onserverclick="Nazar" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="ثبت پرداخت">
            <ItemTemplate>
                        <a id="AEdit24" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="ثبت پرداخت" onserverclick="Pardakht" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="ثبت فرد حقیقی">
            <ItemTemplate>
                        <a id="AEdit25" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="ثبت فرد حقیقی" onserverclick="PersonalSabt" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>

                    <asp:TemplateField HeaderText="ثبت حقوقی">
            <ItemTemplate>
                        <a id="AEdit26" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.Mojavezid")%>' title="ثبت حقوقی" onserverclick="HoghoghiSabt" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>


<%--   <asp:BoundField DataField="Mojavezid"  HeaderText="Mojavezid"   SortExpression="Mojavezid" />--%>
<asp:BoundField DataField="Title"  HeaderText="عنوان"   SortExpression="Count" />
    <asp:BoundField DataField="MantagheId"  HeaderText="منطقه"   SortExpression="Count" />
   <asp:BoundField DataField="HaghighiName"  HeaderText="حقوقی"   SortExpression="HaghighiId" />
   <asp:BoundField DataField="FullName"  HeaderText="حقیقی"   SortExpression="PersonelId" />
   <asp:BoundField DataField="date1"  HeaderText="تاریخ"   SortExpression="MojavezDate" />
<%--   <asp:BoundField DataField="FinalNazar"  HeaderText="FinalNazar"   SortExpression="FinalNazar" />--%>
   <asp:BoundField DataField="CatalogName"  HeaderText="نوع مجوز"   SortExpression="LicesnceTypeid" />

             </Columns>
</asp:GridView>
  

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >
<table>
<tr runat="server" id="TrPrimery" ><td></td><td><asp:textbox Visible="false"   runat="server" ID="TXTMojavezid" ></asp:textbox></td><td></td><td>
</td><td></td></tr>
<tr  ><td>عنوان</td><td><asp:textbox   runat="server" ID="TXTTitle" ></asp:textbox></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr><tr><td>تاریخ</td><td>
        <%--<asp:textbox runat="server" ID="TXTMojavezDate" ></asp:textbox>--%>
    <uc3:CtlDatePick ID="TXTMojavezDate" runat="server" />
    </td><td></td><td>
</td><td></td></tr><tr><td>نوع</td><td><asp:dropdownlist runat="server" ID="DDLicesnceTypeid" ></asp:dropdownlist></td><td></td><td>
</td><td></td></tr>
    <tr><td>منطقه</td><td><asp:dropdownlist runat="server" ID="DDMantagheId" ></asp:dropdownlist></td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
    <tr><td>توضیحات</td><td><asp:textbox runat="server" ID="TXTDesc" TextMode="MultiLine" ></asp:textbox></td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td>
        
    </tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_LicensingTree" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_LicensingTree" OnClick="BtnUpdate_Click1"  />
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
     <div id="lightTreeBonCutting" class="Lightbox" >

            
         <%--   <asp:BoundField DataField="Count"  HeaderText="Count"   SortExpression="Count" />--%>

            <uc1:CtlTreeBonCutting runat="server" id="CtlTreeBonCutting1" />
         <%--   <asp:BoundField DataField="FinalNazar"  HeaderText="FinalNazar"   SortExpression="FinalNazar" />--%>

        </div>
        <div id="lightNazar" class="Lightbox" >

        
     <uc1:CtlNazar runat="server" id="CtlNazar" />



        </div>

    <div  id="lightPardakht" class="Lightbox" >

        <uc1:CtlPardakht runat="server" ID="CtlPardakht1" />
    </div>
        <div  id="lightPersonal" class="Lightbox" >

            <uc1:CtlPersonal runat="server" ID="CtlPersonal1" />
    </div>
    <div  id="lighHoghoghi" class="Lightbox" >
        <uc1:CtlHaghighi runat="server" ID="CtlHaghighi1" />
    </div>
         
        </div>
 <input type="hidden"  id="LightBox" runat="server" />
 <input type="hidden"  id="LightBox2" runat="server" />  
 <input type="hidden"  id="LightBox3" runat="server" />    
 <input type="hidden"  id="LightBox4" runat="server" />  
 <input type="hidden"  id="LightBox5" runat="server" /> 
 <input type="hidden"  id="LightBox6" runat="server" /> 
  
<script type="text/javascript">

    if (document.getElementById('<%= LightBox.ClientID %>').value == "1") {
        setTimeout(f, 0);
    }
    if (document.getElementById('<%= LightBox2.ClientID %>').value == "1") {
        setTimeout(f2, 0);
    }
    if (document.getElementById('<%= LightBox3.ClientID %>').value == "1") {
        setTimeout(f3, 0);
    }
    if (document.getElementById('<%= LightBox4.ClientID %>').value == "1") {
        setTimeout(f4, 0);
    }
    if (document.getElementById('<%= LightBox5.ClientID %>').value == "1") {
        setTimeout(f5, 0);
    }
    if (document.getElementById('<%= LightBox6.ClientID %>').value == "1") {
        setTimeout(f6, 0);
    }
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightTreeBonCutting");
    }
    function g3() {
        scripthelper.CloseLightBox("lightNazar");
    }
    function g4() {
        scripthelper.CloseLightBox("lightPardakht");
    }
    function g5() {
        scripthelper.CloseLightBox("lightPersonal");
    }
    function g6() {
        scripthelper.CloseLightBox("lighHoghoghi");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function f2() {
        scripthelper.ShowLightBox("lightTreeBonCutting", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }
    function f3() {
        scripthelper.ShowLightBox("lightNazar", '<%= LightBox3.ClientID %>', "lightboxdiv");
    }
    function f4() {
        scripthelper.ShowLightBox("lightPardakht", '<%= LightBox4.ClientID %>', "lightboxdiv");
        }
    function f5() {
        scripthelper.ShowLightBox("lightPersonal", '<%= LightBox5.ClientID %>', "lightboxdiv");
    }

    function f6() {
        scripthelper.ShowLightBox("lighHoghoghi", '<%= LightBox6.ClientID %>', "lightboxdiv");
        }

    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
        
        scripthelper.CloseLightBox("lightTreeBonCutting", '<%= LightBox2.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightNazar", '<%= LightBox3.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightPardakht", '<%= LightBox4.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightPersonal", '<%= LightBox5.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lighHoghoghi", '<%= LightBox6.ClientID %>', "lightboxdiv")
    }



    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
        clearinput();
    }
   </script>
