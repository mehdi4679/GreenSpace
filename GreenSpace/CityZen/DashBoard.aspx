<%@ Page Title="" Language="C#" MasterPageFile="~/CityZen/DashBoard.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="GreenSpace.CityZen.DashBoard1" %>

<%@ Register Src="~/Controls/CtlAttach.ascx" TagPrefix="uc1" TagName="CtlAttach" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="lightbox/LightBox.css" rel="stylesheet" />
    <script src="../App_Themes/Theme3/jquery-1.11.3.min.js"></script>
    <script src="lightbox/lightbox.js"></script>
    <script src="../App_Themes/Theme3/bootstrap-rtl.js"></script>
    <script type="text/javascript">
        function setID(id) {
            $(".txtid").val(id);
        }
    </script>
    <style>
        .item .bg_img {
    background:url('/App_Themes/Theme1/images/ttrree.jpg') fixed center center;
    background-size: cover;
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    z-index: -1;
}

        .wizard-steps li:first-child:before {
            max-width: 100% !important;
            left: -39% !important;
        }

        .sender {
            position: absolute;
            top: -1em;
            width: 125px;
            text-align: right;
            margin-right:-1em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="item">
  <div class="bg_img"></div>
    <div>
        <div class="page-header" style="margin: 20px 0 20px;">
            <h1>صندوق دریافت</h1>
        </div>
        

        <asp:GridView ID="gvTree" runat="server" AutoGenerateColumns="false" EmptyDataText="هیچ رکوردی یافت نشد">
            <Columns>        
                <asp:BoundField DataField="cuttingID" HeaderText="شماره" />
                        
                <asp:BoundField DataField="FullName" HeaderText="ثبت کننده" />
                <%--<asp:BoundField DataField="LicensingTitle" HeaderText="نوع مجوز" />--%>
                <asp:BoundField DataField="Count" HeaderText="تعداد" />
                <asp:BoundField DataField="Bon" HeaderText="بن" />
                <%--<asp:BoundField DataField="date1" HeaderText="تاریخ" />--%>
                <asp:BoundField DataField="Descr" HeaderText="توضیحات" />
                <asp:BoundField DataField="treetypeName" HeaderText="نوع درخت" />
                <asp:BoundField DataField="statusFa" HeaderText="وضعیت درخواست" />

                <asp:TemplateField HeaderText="تایید مدیر">

                    <ItemTemplate>
                        <%--(Session["roleid"].ToString() == "1")&--%>
                        <%--<% if (  (Request.QueryString["Mode"].ToString() == "3"))
                            { %>--%>
                        <itemtemplate>
                            <% if (  (Request.QueryString["Mode"].ToString() != "4")) { %> 
                    <a style="margin-left:5px; " id="A_ok" runat="server"
                         onclick="javascript:return confirm('آیا از تأیید اطلاعات اطمینان دارید؟')" 
                         onserverclick="GV_ok"  kartableid='<%# Eval("kartableid") %>' cuttingID='<%# Eval("cuttingID") %>'   href="#" >تایید</a>/                    
                </itemtemplate>
                        <itemtemplate>
                    <a id="A_cancel" runat="server" kartableid='<%# Eval("kartableid") %>' cuttingID='<%# Eval("cuttingID") %>' onclick="javascript:return confirm('آیا از رد اطلاعات اطمینان دارید؟')"  onserverclick="GV_cancel"  href="#" gridid='<%# Eval("kartableid") %>' >رد</a>/
                             <%} %>
                                               <a style="cursor:pointer;"  data-toggle="modal" data-target="#ErjaModal"  onclick="setID('<%# Eval("cuttingid") %>')">ارجاع</a>

                </itemtemplate>

                       <%-- <%} %>--%>

                       <%-- <itemtemplate>
                             <% if (Request.QueryString["Mode"].ToString() != "4")
                                 {%>
                   <a style="cursor:pointer;"  data-toggle="modal" data-target="#ErjaModal"  onclick="setID('<%# Eval("cuttingid") %>')">ارجاع</a>
                 <%} %>
                        </itemtemplate>--%>

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="مشاهده روند پرونده">
                    <ItemTemplate>
                        <itemtemplate>
                        <%--<asp:LinkButton runat="server" OnClick="History_ServerClick" OnClientClick="setID('<%# Eval("cuttingid") %>')">مشاهده</asp:LinkButton> data-toggle="modal"  data-target="#HistoryModal" --%>
                        <a id="b" href="#" style="cursor:pointer" runat="server"  GridID='<%# Eval("cuttingid") %>'  onserverclick="History_ServerClick" class="Lishow">مشاهده</a>
                        <%--<asp:Button runat="server" Text="Button"  data-toggle="modal"  data-target="#HistoryModal" OnClick="History_ServerClick"   />--%>
                              </itemtemplate>
                    </ItemTemplate>

                </asp:TemplateField>


                       <asp:TemplateField HeaderText="نمایش  ">
                    <ItemTemplate>
                        <itemtemplate>
                   <a runat="server" href="#" id="lknlnn" style="cursor:pointer;"  GridID='<%# Eval("cuttingid") %>'    onserverclick="viewpic" class="Lishow">مشاهده عکس</a>
                           &nbsp;&nbsp;
                         <a id="bdscs" href="#" style="cursor:pointer" runat="server"  GridID='<%# Eval("cuttingid") %>'  onserverclick="viewMap" class="Lishow">مشاهده نقشه</a>
                               </itemtemplate>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

        <!-- Modal -->
        <div id="ErjaModal" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">ارجاع درخواست</h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-6">
                            <div>ارجاع به</div>
                            <asp:DropDownList ID="ddlErja" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <div>توضیحات</div>
                            <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="row">
                            <asp:Button ID="btnErja" runat="server" Text="ارسال" CssClass="btn btn-primary" OnClick="btnErja_Click" />
                        </div>
                    </div>

                </div>

            </div>
        </div>
         
        <div id="lightboxdiv" class="LightBoxDiv">
 <div id="lightinsert" class="Lightbox">        
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">عکس ها</h4>
                    </div>
                    <div class="modal-body">
                        <uc1:CtlAttach runat="server" ID="CtlAttach" />
                    </div>

                </div> 
        </div>

        <asp:TextBox ID="LiBo" runat="server" Style='display: none' class="LiBo"></asp:TextBox>
        <div class='overlay' id='b1' style='display: none;'></div>
        <div class='box' id='b2'>
            <a class='boxclose'></a>
            <h1>
                <asp:Label ID='lbl_Lightbox1' runat='server' Text=''>روند پرونده</asp:Label></h1>
            <div data-target="#step-container " id="fuelux-wizard" style="margin-top: 50px;">
                <ul class="wizard-steps">
                    <asp:Repeater ID="gvHistory1" runat="server">
                        <ItemTemplate>
                            <li runat="server" id="step1" data-target="#step1" class="step1 active">
                                <span class="sender"><%# Eval("girande") %></span>
                                <span class="step">
<%--                                    <%# Convert.ToString(Convert.ToInt32(DataBinder.Eval(Container, "DataItemIndex"))+1)  %>--%>
                                    *
                                </span>
                                <span class="title"><%# Eval("Descr") %></span>

                            </li>

                        </ItemTemplate>

                    </asp:Repeater>
                </ul>

            </div>
        </div>

        </div>
        <div style="display: none">
            <asp:TextBox ID="txtid" runat="server" Text="" CssClass="txtid"></asp:TextBox>
        </div>

        </div>
 <input id="LightBox" type="hidden" value="0" runat="server"/>
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

 
</asp:Content>
