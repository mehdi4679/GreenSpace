<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlAgreePercent22.ascx.cs" Inherits="GreenSpace.Controls.CtlAgreePercent22" %>
<%@ Register src="CtlDropExplan.ascx" tagname="CtlDropExplan" tagprefix="uc1" %>
<%@ Register src="~/Controls/CtlDatePick.ascx" tagname="CtlDatePick" tagprefix="uc2" %>
<%@ Register Src="~/Controls/CtlPercentHistory.ascx" TagPrefix="uc1" TagName="CtlPercentHistory" %>
<%@ Register src="CtlAgreePercentProtest.ascx" tagname="CtlAgreePercentProtest" tagprefix="uc3" %>
 
<div >
     <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
     <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
     <asp:Label ID="LblParamAgreementPercentID"  Visible="false" runat="server" Text="0" ></asp:Label>
     <asp:Label ID="lblAgreement"  Visible="false" runat="server"  Text="0"></asp:Label> 
  <%-- <asp:Label ID="LblParamagreementpeymankarid"  Visible="false" runat="server" Text="0" ></asp:Label>
     --%>


     <div runat="server" id="ddd" visible="false">   <asp:Label ID="ragree"   Visible="false" runat="server"  Text="0"></asp:Label>
</div>
    <div >
        <table>
            <tr><td>تاریخ:</td><td>
                <input type="text" id="txtDate" runat="server" class="form-control"   />

                 
                <td><asp:DropDownList runat="server" ID="ddsubject" OnSelectedIndexChanged="ddsubject_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList></td>
              <td>    <asp:Button runat="server"   ID="btnSerachLight"  Text="مشاهده" SkinID="hbtn-search-r" OnClick="btnSerachLight_Click" style="height: 26px"/> 
</td>
            </tr>
        </table>
    </div>
     </div >
    <div >
         

          <asp:Label runat="server" ID="LblNumber"  Font-Bold="True"  ForeColor="Green"  ></asp:Label> 
          
    </div >

 <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting"
               AllowSorting="True" PageSize="20" >
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
 
        <asp:TemplateField HeaderText="تغییرات">
        <ItemTemplate>
        <a id="AEdit66" class="AEdit" href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="تاریخچه" onserverclick="historyItem" runat="server" ></a>
        </ItemTemplate>
        </asp:TemplateField> 

      
       <asp:TemplateField HeaderText="اعتراض">
        <ItemTemplate> 
        <a id="AEdit22" class='<%# Eval("AgreementPercentID").ToString()=="0" || Eval("AgreementPercentID").ToString()=="" || Eval("AgreementPercentID")==null ? "":"AEdit"  %>' href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="اعتراض" onserverclick="ProtestItem" runat="server" >
        </a> <%# Eval("ProtestNum")   %>
        </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="مشاهده درصدهای قبلی">
        <ItemTemplate> 
        <a  class='AEdit' id="AEdit2view" AgreementID='<%# Eval("AgreementID").ToString() %>' ExplainID='<%#Eval("ExplainSubjectID").ToString() %>'   href='<%# DataBinder.Eval(Container,"DataItem.AgreementPercentID")%>' title="مشاهده درصدهای قبلی" onserverclick="ViewPercentItem" runat="server" >
        </a>
<%# Eval("percentavrg")   %>
            </ItemTemplate>
 
    </asp:TemplateField>

     <asp:TemplateField HeaderText="تعداد درصدها">
        <ItemTemplate>
            <asp:Label runat="server" ID="txExplainName22" Text='<%# Eval("percentavrg2").ToString() %>'  CssClass="txt"></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>

        <asp:TemplateField HeaderText="اعلان">
        <ItemTemplate> 
       <asp:Label runat="server" id="lblerror" data-rel="tooltip" data-placement="left" title="" placeholder="" Text="اعلان"></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
    <asp:TemplateField Visible="false"><ItemTemplate><asp:Label runat="server" ID="lblcolor" Text='<%#Eval("ProtestNum2").ToString() %>' /></ItemTemplate></asp:TemplateField>
    <asp:TemplateField Visible="false"><ItemTemplate><asp:Label runat="server" ID="lblcolor2" Text='<%#Eval("color").ToString() %>' /></ItemTemplate></asp:TemplateField>
 
        <asp:TemplateField  HeaderText="ش فرآیند">
        <ItemTemplate>
            <asp:Label runat="server" ID="txtAgreementPercentID" Text='<%# Eval("AgreementPercentID").ToString() %>' ></asp:Label>

            <asp:Label runat="server" ID="txtagreementpeymankarid" Text='<%# Eval("agreementpeymankarid").ToString() %>' Visible="false" ></asp:Label>

<%--           , <asp:Label  runat="server" ID="txtAgreementID" Text='<%# Eval("AgreementID").ToString() %>' ></asp:Label>
         --%>
   <asp:Label Visible="false"  runat="server" ID="lblExplainSubjectID" Text='<%# Eval("ExplainSubjectID").ToString() %>' ></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="موضوع کار">
        <ItemTemplate>
            <asp:Label runat="server" ID="txExplainName" Text='<%# Eval("SubjectNamee2").ToString() %>'  CssClass="txt"></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="شرح کار">
        <ItemTemplate>
            <asp:Label runat="server" ID="txExplainName2" Text='<%# Eval("ExplainNameonly").ToString() %>'  CssClass="txt"></asp:Label>
        </ItemTemplate>
    </asp:TemplateField>


       <asp:TemplateField HeaderText="روتین؟"><ItemTemplate>
                   
        <asp:Label  runat="server" ID="txtRotinOrNot"  Text='<%# Eval("RotinOrNot").ToString() %>' ></asp:Label>
 
        </ItemTemplate></asp:TemplateField>


         <asp:TemplateField HeaderText="نوع واحد"><ItemTemplate>
                   
        <asp:Label  runat="server" ID="txtUnitNameIDName"  Text='<%# Eval("UnitNameIDName").ToString() %>' ></asp:Label>
 
        </ItemTemplate></asp:TemplateField>

    <asp:TemplateField HeaderText="عملکرد-پیمانکار" >
        <ItemTemplate><asp:TextBox runat="server" ID="txtUnitNumberPeymankar" Text='<%# Eval("UnitNumberPeymankar").ToString() %>' Width="100"   CssClass="txt" ReadOnly="true" Enabled="false"></asp:TextBox></ItemTemplate>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="عملکرد-نظارت" >
        <ItemTemplate><asp:TextBox runat="server" ID="txtunitNumberNazer" Text='<%# Eval("unitNumberNazer2").ToString() %>'  Width="100"  CssClass="txt"></asp:TextBox></ItemTemplate>
    </asp:TemplateField>


     <asp:TemplateField HeaderText="درصد کیفیت">
        <ItemTemplate>
             <asp:TextBox runat="server" ID="txtutilityPersent" Text='<%# Eval("utilityPersent").ToString() %>'  CssClass="txt" Width="40" ></asp:TextBox>
        </ItemTemplate>
    </asp:TemplateField>

     

     <asp:TemplateField  HeaderText="متراژ یا تعداد جریمه" >
        <ItemTemplate>
        <asp:TextBox runat="server" id="txtFineMeterOrRepeat" Text='<%# Eval("FineMeterOrRepeat").ToString()   %>'     CssClass="txt" SortExpression="FineFactor" />
        </ItemTemplate>
    </asp:TemplateField>

    <asp:TemplateField  HeaderText="ضریب بالاسری">
        <ItemTemplate>
        <asp:TextBox runat="server" id="txtFineFactor" Text='<%# Eval("FineFactor").ToString()   %>'  CssClass="txt"    SortExpression="FineFactor" />
        </ItemTemplate>
    </asp:TemplateField>
         <asp:TemplateField HeaderText="توضیحات" >
        <ItemTemplate><asp:TextBox runat="server" ID="txtcommentdarsad" Text='<%# Eval("commentdarsad").ToString() %>'   CssClass="txt"></asp:TextBox></ItemTemplate>
    </asp:TemplateField>

</Columns>
</asp:GridView>
         
<asp:Button runat="server" ID="btnSave" Text="ذخیره" OnClick="btnSave_Click"   />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ثبت واحد پیمانکار" Visible="false" />
<fieldset>
    <legend>
        توضیحات 
    </legend>
    1-در هر صفحه پس از وارد کردن درصد ها باید دکمه ذخیره را بفشارید
    <br />
    2-در صورت ثبت شدن سطر سبز رنگ خواهد شد
    <br />

    3-در صورت خطا سطر قرمز رنگ خواهد شد که برای مشاهده پیغام خطا باید موس را روی کلمه اعلان قرار دهید

    <br />
</fieldset>
<div  id="lightboxdiv" class="LightBoxDiv" >
 
    <div id="lightinsert2" class="Lightbox" >
        <uc3:CtlAgreePercentProtest ID="CtlAgreePercentProtest1" runat="server" />
          </div>
    <div id="lightinsert3" class="Lightbox" >
        
        <asp:Label runat="server" ID="lblsemat" Text="0" Visible="false"></asp:Label>
       
          <uc1:CtlPercentHistory ID="CtlPercentHistory1" runat="server" />

         </div>
    <div id="lightinsert4" class="Lightbox" >
        <asp:GridView runat="server" ID="GridAllPercent" AutoGenerateColumns="false" >
            <Columns>
           
             <asp:TemplateField HeaderText="ردیف">
            <ItemTemplate >
            <asp:Label runat="server"  ID="RowNum"   Text='<%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1) %> '></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>

    <asp:TemplateField Visible="false"><ItemTemplate><asp:Label runat="server" ID="lblcolor" Text='<%#Eval("ProtestNum2").ToString() %>' /></ItemTemplate></asp:TemplateField>
    <asp:TemplateField Visible="false"><ItemTemplate><asp:Label runat="server" ID="lblcolor2" Text='<%#Eval("color").ToString() %>' /></ItemTemplate></asp:TemplateField>

        <asp:BoundField DataField="AgreementPercentID"  HeaderText="ش فرآیند"   SortExpression="AgreementPercentID" />
        <asp:BoundField DataField="AgreementIDName"  HeaderText="قرارداد"   SortExpression="AgreementIDName" />
        <asp:BoundField DataField="ExplainName"  HeaderText="شرح کار"   SortExpression="ExplainName" />
        <asp:TemplateField HeaderText="تعداد واحد"   SortExpression="unitNumberNazer"><ItemTemplate>
        <asp:Label  runat="server" ID="txtunitNumberNazer"  Text='<%# Eval("unitNumberNazer").ToString() %>' ></asp:Label>
 
        </ItemTemplate></asp:TemplateField>
        <asp:BoundField DataField="commentdarsad"   HeaderText="توضیحات"   SortExpression="commentdarsad" />

        <asp:BoundField DataField="utilityPersent"   HeaderText="درصد کیفیت"   SortExpression="utilityPersent" />
        <asp:BoundField DataField="VisitDatePr"  HeaderText="تاریخ بازدید"   SortExpression="VisitDatePr" />
        <asp:BoundField DataField="SuperVisorIDName"  HeaderText="ناظر"   SortExpression="SuperVisorIDName" />
        <asp:BoundField DataField="FineMeterOrRepeat"      HeaderText="متراژ یا تعداد جریمه"   SortExpression="FineMeterOrRepeat" />
        <asp:BoundField DataField="FineFactor"  HeaderText="ضریب بالاسری"   SortExpression="FineFactor" />

            </Columns>
        </asp:GridView>
    </div>
        </div>
 <input type="hidden"  id="LightBox" runat="server" />
 <input type="hidden"  id="LightBox2" runat="server" />  
 <input type="hidden"  id="LightBox3" runat="server" />  
 <input type="hidden"  id="LightBox4" runat="server" />  
<script src="/App_Themes/Theme1/js/jquery-1.4.1.min.js"></script>
<script src="/App_Themes/Theme1/js/AlmostafaScript.js"></script>
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
    function g() {
        scripthelper.CloseLightBox("lightinsert");
    }
    function g2() {
        scripthelper.CloseLightBox("lightinsert2");
    } function g3() {
        scripthelper.CloseLightBox("lightinsert3");
    }
    function f() {
        scripthelper.ShowLightBox("lightinsert", '<%= LightBox.ClientID %>', "lightboxdiv");
    }
    function f2() {
        scripthelper.ShowLightBox("lightinsert2", '<%= LightBox2.ClientID %>', "lightboxdiv");
    }
    function f3() {
        scripthelper.ShowLightBox("lightinsert3", '<%= LightBox3.ClientID %>', "lightboxdiv");
    }
    function f4() {
        scripthelper.ShowLightBox("lightinsert4", '<%= LightBox4.ClientID %>', "lightboxdiv");
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
 
 <link href="/Scripts/footable.min.css" rel="stylesheet" />
<%--<script src="/Scripts/jquery.min.js"></script>--%>
<link href="/Scripts/footable.min.css" rel="stylesheet" />

 
<script type="text/javascript">
    $(function () {
        $('[id*=GridView1]').footable();
    });
</script>
    
<script language="javascript" type="text/javascript">
        $(document).ready(function () {
            //For navigating using left and right arrow of the keyboard
            $("input[type='text'], select").keydown(
function (event) {
    if ((event.keyCode == 37) || (event.keyCode == 9 && event.shiftKey == false)) {
        var inputs = $(this).parents("form").eq(0).find("input[type='text'], select");
        var idx = inputs.index(this);
        if (idx == inputs.length - 1) {
            inputs[0].select()
        } else {
            $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
            });
            inputs[idx + 1].parentNode.parentNode.style.backgroundColor = "Aqua";
            inputs[idx + 1].focus();
        }
        return false;
    }

    if ((event.keyCode == 39) || (event.keyCode == 9 && event.shiftKey == true)) {
        var inputs = $(this).parents("form").eq(0).find("input[type='text'], select");
        var idx = inputs.index(this);
        if (idx > 0) {
            $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
            });
            inputs[idx - 1].parentNode.parentNode.style.backgroundColor = "Aqua";

            inputs[idx - 1].focus();
        }
        return false;
    }
});

            //For navigating using up and down arrow of the keyboard
            $("input[type='text'], select").keydown(
function (event) {
    if ((event.keyCode == 40)) {
        if ($(this).parents("tr").next() != null) {
            var nextTr = $(this).parents("tr").next();
            var inputs = $(this).parents("tr").eq(0).find("input[type='text'], select");
            var idx = inputs.index(this);
            nextTrinputs = nextTr.find("input[type='text'], select");
            if (nextTrinputs[idx] != null) {
                $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                    $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
                });
                nextTrinputs[idx].parentNode.parentNode.style.backgroundColor = "Aqua";
                nextTrinputs[idx].focus();
            }
        }
        else {
            $(this).focus();
        }
    }

    if ((event.keyCode == 38)) {
        if ($(this).parents("tr").next() != null) {
            var nextTr = $(this).parents("tr").prev();
            var inputs = $(this).parents("tr").eq(0).find("input[type='text'], select");
            var idx = inputs.index(this);
            nextTrinputs = nextTr.find("input[type='text'], select");
            if (nextTrinputs[idx] != null) {
                $(this).parents("table").eq(0).find("tr").not(':first').each(function () {

                    $(this).attr("style", "BACKGROUND-COLOR: white; COLOR: #003399");
                });
                nextTrinputs[idx].parentNode.parentNode.style.backgroundColor = "Aqua";
                nextTrinputs[idx].focus();
            }
            return false;
        }
        else {
            $(this).focus();
        }
    }
});
        });
    </script>

 
    <script src="/App_Themes/Theme1/js/persianDatepicker.js"></script>
 
<script type="text/javascript" >

    $("#<%= txtDate.ClientID %>").persianDatepicker({
        theme: 'dark'
    });

</script>
