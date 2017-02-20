<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlCut.ascx.cs" Inherits="GreenSpace.Controls.CtlCut" %>
<%@ Register Src="~/Controls/TreeControls/CtlTreeBonCutting.ascx" TagPrefix="uc1" TagName="CtlTreeBonCutting" %>









<%@ Register src="~/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>
<%@ Register Src="~/Controls/TreeControls/CtlPardakht.ascx" TagPrefix="uc1" TagName="CtlPardakht" %>
<%@ Register Src="~/Controls/TreeControls/CtlPersonal.ascx" TagPrefix="uc1" TagName="CtlPersonal" %>
<%@ Register Src="~/Controls/TreeControls/CtlHaghighi.ascx" TagPrefix="uc1" TagName="CtlHaghighi" %>












<div >
     <asp:Label ID="LblParamid"  Visible="false" runat="server" ></asp:Label> 
    <asp:Button runat="server" ID="btnInsertLight"  text="افزودن"  SkinID="btnInsert" OnClick="btnInsertLight_Click"  />
    <asp:Button runat="server"  ID="btnSerachLight"  Text="جستجو" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click"/> 
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
                        <a id="ADel" class="ADelete"  href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="حذف"  onclick="return confirm('اطلاعات مربوط  حذف خواهد شد !!  آیا مطمئن هستید ؟')"  onserverclick="DeleteItem" runat="server"  ></a>
                </ItemTemplate>
                </asp:TemplateField >--%>
<asp:TemplateField HeaderText="ویرایش">
            <ItemTemplate>
                        <a id="AEdit" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ویرایش" onserverclick="UpItem" runat="server" ></a>
            </ItemTemplate>

             </asp:TemplateField>
    <asp:TemplateField HeaderText="ثبت درخت">
            <ItemTemplate>
                        <a id="AEdit22" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")+"-"+DataBinder.Eval(Container,"DataItem.MantagheId")%>' title="ثبت درخت" onserverclick="TreeBonCuttig" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
        <asp:TemplateField HeaderText="ثبت پرداخت">
            <ItemTemplate>
                        <a id="AEdit23" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ثبت درخت" onserverclick="Pardakht" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="ثبت فرد حقیقی">
            <ItemTemplate>
                        <a id="AEdit24" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ثبت فرد حقیقی" onserverclick="PersonalSabt" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
                <asp:TemplateField HeaderText="ثبت حقوقی">
            <ItemTemplate>
                        <a id="AEdit25" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.id")%>' title="ثبت حقوقی" onserverclick="HoghoghiSabt" runat="server" ></a>
            </ItemTemplate>
             </asp:TemplateField>
   <%--<asp:BoundField DataField="id"  HeaderText="id"   SortExpression="id" />--%>
   <%--<asp:BoundField DataField="TreeTypeId"  HeaderText="TreeTypeId"   SortExpression="TreeTypeId" />--%>
   <asp:BoundField DataField="Title"  HeaderText="عنوان"   SortExpression="Count" />

   <asp:BoundField DataField="date1"  HeaderText="تاریخ"   SortExpression="date" />
   <asp:BoundField DataField="Address"  HeaderText="آدرس"   SortExpression="Address" />
   <%--<asp:BoundField DataField="x"  HeaderText="x"   SortExpression="x" />--%>
   <%--<asp:BoundField DataField="y"  HeaderText="y"   SortExpression="y" />--%>
   <%--<asp:BoundField DataField="image"  HeaderText="image"   SortExpression="image" />--%>
   <%--<asp:BoundField DataField="StreetTypeid"  HeaderText="مکان"   SortExpression="StreetTypeid" />--%>
   <asp:BoundField DataField="FullName"  HeaderText="حقیقی"   SortExpression="PersonalId" />
   <%--<asp:BoundField DataField="Peyman"  HeaderText="Peyman"   SortExpression="Peyman" />--%>
   <asp:BoundField DataField="Peymanid"  HeaderText="پیمان"   SortExpression="Peymanid" />
   <asp:BoundField DataField="MantagheId"  HeaderText="منطقه"   SortExpression="MantagheId" />
   <%--<asp:BoundField DataField="Mojavez"  HeaderText="مج"   SortExpression="Mojavez" />--%>
   <asp:BoundField DataField="HaghighiName"  HeaderText="حقوقی"   SortExpression="HaghighiId" />
   <asp:BoundField DataField="LicensingTitle"  HeaderText="مجوز"   SortExpression="LicesnceTypeid" />
       <asp:BoundField DataField="Total"  HeaderText="خسارت کل"   SortExpression="LicesnceTypeid" />
             </Columns>
</asp:GridView>
        </div>

<div  id="lightboxdiv" class="LightBoxDiv" >
<div id="lightinsert" class="Lightbox" >



<table>
<tr runat="server" id="TrPrimery" ><td>&nbsp;</td><td><asp:textbox Visible="false"   runat="server" ID="TXTid" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>عنوان</td><td><asp:textbox   runat="server" ID="TXTTitle" ></asp:textbox></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr><tr><td>تاریخ</td><td>
<%--        <asp:textbox runat="server" ID="TXTdate" ></asp:textbox>--%>
    <uc2:CtlDatePick ID="TXTdate" runat="server" />
    </td><td></td><td>
</td><td></td></tr><tr><td>آدرس</td><td><asp:textbox runat="server" ID="TXTAddress" TextMode="MultiLine" ></asp:textbox></td><td></td><td>
</td><td></td></tr><tr><td>منطقه</td><td><asp:dropdownlist runat="server" ID="DDMantagheId" ></asp:dropdownlist></td><td>&nbsp;</td><td>
    &nbsp;</td><td>&nbsp;</td></tr><tr><td>مجوز
    </td><td>
    <asp:CheckBox ID="chkMojavez" runat="server" AutoPostBack="True" OnCheckedChanged="chkMojavez_CheckedChanged" />
    </td><td></td><td>
    <asp:Label ID="lblHaghighiId" runat="server" Visible="False"></asp:Label>
    </td><td></td></tr><tr><td><asp:Label ID="lblMojavez" runat="server" Text="شماره مجوز" Visible="False"></asp:Label></td><td><asp:dropdownlist runat="server" ID="DDLicesnceTypeid" Visible="False" ></asp:dropdownlist></td><td></td><td>
    <asp:Label ID="lblPersonelID" runat="server" Visible="False"></asp:Label>
</td><td></td></tr>
    <tr><td>توضیحات</td><td><asp:textbox runat="server" ID="TXTDesc" TextMode="MultiLine" ></asp:textbox></td><td>&nbsp;</td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
</table>
              <div >
              <asp:Button runat="server" Text="افزودن"  ID="BtnInsert" SkinID="btnInsert" 
                      Visible="false"   ValidationGroup="RVTbl_CuttingTree" OnClick="BtnInsert_Click" />
             <asp:Button runat="server"  Text="ویرایش" ID="BtnUpdate" SkinID="btnOk" 
                      Visible="false" ValidationGroup="RVTbl_CuttingTree"  />
             <asp:Button runat="server"  Text="جستجو" ID="BtnSerach" SkinID="hbtn-search-r"  Visible="false" />   
    <asp:CheckBox ID="chkPeyman" runat="server" AutoPostBack="True" OnCheckedChanged="chkPeyman_CheckedChanged" Visible="False" />
                  <asp:dropdownlist runat="server" ID="DDPeymanid" Visible="False" ></asp:dropdownlist><asp:Label ID="lblpeyman" runat="server" Text="نوع پیمان" Visible="False"></asp:Label>
            </div>
        <div>
            <asp:Label runat="server" ID="LblMsg" ></asp:Label>
        </div>
        </div>
        <div id="lightinsert2" class="Lightbox" >

            
         <%--<asp:BoundField DataField="TreeTypeId"  HeaderText="TreeTypeId"   SortExpression="TreeTypeId" />--%>

            <uc1:CtlTreeBonCutting runat="server" id="CtlTreeBonCutting1" />
            <%--<asp:BoundField DataField="x"  HeaderText="x"   SortExpression="x" />--%>

        </div>

            <div id="lightPardakht" class="Lightbox" >

                <uc1:CtlPardakht runat="server" id="CtlPardakht1" />

         <%--<asp:BoundField DataField="TreeTypeId"  HeaderText="TreeTypeId"   SortExpression="TreeTypeId" />--%>

          
            <%--<asp:BoundField DataField="x"  HeaderText="x"   SortExpression="x" />--%>

        </div>
    <div id="lightPersonal" class="Lightbox">

        <uc1:CtlPersonal runat="server" ID="CtlPersonal1" />

    </div>
    <div id="lightHoghoghi" class="Lightbox">

        <uc1:CtlHaghighi runat="server" ID="CtlHaghighi1" />

    </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" />
 <input type="hidden"  id="LightBox2" runat="server" />   
 <input type="hidden"  id="LightBox3" runat="server" />   
 <input type="hidden"  id="LightBox4" runat="server" />  
 <input type="hidden"  id="LightBox5" runat="server" />   


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

    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightinsert2");
    }
    function g3() {
        scripthelper.CloseLightBox("lightPardakht");
    }
    function g4() {
        scripthelper.CloseLightBox("lightPersonal");
    }
    function g5() {
        scripthelper.CloseLightBox("lightHoghoghi");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function f2() {
        scripthelper.ShowLightBox("lightinsert2", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }
    function f3() {
        scripthelper.ShowLightBox("lightPardakht", '<%= LightBox3.ClientID %>', "lightboxdiv");
    }
    function f4() {
        scripthelper.ShowLightBox("lightPersonal", '<%= LightBox4.ClientID %>', "lightboxdiv");
    }

    function f5() {
        scripthelper.ShowLightBox("lightHoghoghi", '<%= LightBox5.ClientID %>', "lightboxdiv");
        }

    function back() {
        scripthelper.CloseLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightinsert2", '<%= LightBox2.ClientID %>', "lightboxdiv");

        scripthelper.CloseLightBox("lightPardakht", '<%= LightBox3.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightPersonal", '<%= LightBox4.ClientID %>', "lightboxdiv");
        scripthelper.CloseLightBox("lightHoghoghi", '<%= LightBox5.ClientID %>', "lightboxdiv");
    }

    function openlight() {
        document.getElementById('<%= LightBox.ClientID %>').value = "1";
        f();
        clearinput();
    }
   </script>
