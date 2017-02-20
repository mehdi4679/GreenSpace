<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/WizardDashboard.Master" AutoEventWireup="true" CodeBehind="MapRegTree.aspx.cs" Inherits="GreenSpace.CityZen.MapRegTree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
         <link href="/CSS/ol.css" rel="stylesheet" />
 <!-- Our app styles -->
    <link href="/App_Themes/jquery-ui.css" rel="stylesheet" />
    <link href="/App_Themes/bootstrap.css" rel="stylesheet" />

 <style>
     .map {
 width: 100%;
 height: 100%;
}
    
      .ol-popup {
        position: absolute;
        background-color: white;
        -webkit-filter: drop-shadow(0 1px 4px rgba(0,0,0,0.2));
        filter: drop-shadow(0 1px 4px rgba(0,0,0,0.2));
        padding: 15px;
        border-radius: 10px;
        border: 1px solid #cccccc;
        bottom: 12px;
        left: -50px;
        min-width: 280px;
      }
      .ol-popup:after, .ol-popup:before {
        top: 100%;
        border: solid transparent;
        content: " ";
        height: 0;
        width: 0;
        position: absolute;
        pointer-events: none;
      }
      .ol-popup:after {
        border-top-color: white;
        border-width: 10px;
        left: 48px;
        margin-left: -10px;
      }
      .ol-popup:before {
        border-top-color: #cccccc;
        border-width: 11px;
        left: 48px;
        margin-left: -11px;
      }
      .ol-popup-closer {
        text-decoration: none;
        position: absolute;
        top: 2px;
        right: 8px;
      }
      .ol-popup-closer:after {
        content: "✖";
      }
    
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <body>
 <!-- Our app HTML tags here -->
     
    <div id="map" class="map">
        <div id="popup2"  >
      <div id="popup" class="ol-popup"  >
      <a href="#" id="popup-closer" class="ol-popup-closer"></a>
 
                          <div id="tabs">
  <ul>
    <li><a href="#tabs-1">ثبت درخت</a></li>
    <li><a href="#tabs-2">پیوست مدارک</a></li>
   </ul>
  <div id="tabs-1">
 <div class="tab-content">
			  <div class="tab-pane active" id="home"  style="height:200px;overflow:auto;width:400px"> 
                <div class="regTree col-md-8" style="height:200px;overflow:auto;width:400px">
        <div class="row">
            <div class="col-md-6">
                <div>نوع درخت<span style="color:red">*</span> </div>
                <asp:DropDownList ID="ddlTreeType"  runat="server" CssClass="ddlTreeType">
                    <asp:ListItem>1</asp:ListItem>

                </asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>
                    نوع مکان</div>
                <asp:DropDownList ID="ddlStreetType" runat="server" CssClass="ddlStreetType">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>نوع مجوز</div>
                <asp:DropDownList ID="ddlLicesnceType" runat="server" CssClass="ddlLicesnceType">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-6">
                <div>
                    <span style="color:red">*</span>
                    تعداد</div>
                <asp:TextBox ID="txtCount" runat="server" CssClass="txtCount"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RVtxtCount" runat="server"
                        ControlToValidate="txtCount" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator123" runat="server"
                        ControlToValidate="txtCount" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red" style="display:none;"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div>بن</div>
                <asp:TextBox ID="txtBon" runat="server" CssClass="txtBon"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RVtxtBon" runat="server"
                        ControlToValidate="txtBon" Display="Dynamic" ErrorMessage="فقط عدد وارد کنید"
                        ValidationExpression="^[+]?\d*$" SetFocusOnError="True"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtBon" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <div>تاریخ</div>
<%--                <uc1:CtlDatePick runat="server" ID="CtlDatePick" />--%>
                <asp:TextBox runat="server" ID="CtlDatePick" CssClass="CtlDatePick"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:DropDownList runat="server" ID="ddRegion" CssClass="ddRegion">
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </div>
                <div style="display:none" class="col-md-6"><span style="color:red">*</span>
                <asp:CheckBox ID="chkMojavez" runat="server" TextAlign="Right" Text="مجوز" />
                </div>
        </div>
        <div class="row">           
            <div class="col-md-6">
                <div>  <span style="color:red">*</span>آدرس
                </div>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="txtAddress" TextMode="MultiLine"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="txtAddress" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            

           <div class="col-md-6">
                <div><span style="color:red">*</span>
                    توضیحات</div>
                <asp:TextBox  runat="server" class="form-control pdp-el" id="txtcomment"   TextMode="MultiLine"/>
               <asp:RequiredFieldValidator ID="txtcomment13" runat="server"
                        ControlToValidate="txtcomment" ErrorMessage="لطفا پر کنید"
                        ValidationGroup="RegTree" ForeColor="Red"></asp:RequiredFieldValidator>
             </div>
        </div>

        <div class="row">
            <input type="button" onclick="save()" value="ثبت اطلاعات"  id="reginfo"/>
            <input type="button" onclick="deletetee()" value="حذف" id="delinfo"/>

<%--            <asp:Button runat="server" ID="btnInsert" Text="ثبت اطلاعات"   ValidationGroup="RegTree"/>--%>
        </div>
        <div></div>
        <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label>
    </div>
 </div> 
           
                  </div>
        </div>
  <div id="tabs-2">
 <div style="height:200px;overflow:auto;width:400px"> 
     <iframe style="width:100%" runat="server" src="~/CityZen/attach.aspx" id="iframpic"></iframe>
     </div>
        </div>
 </div>
 

			 

          

           
      <div id="popup-content"></div>
    </div>
   
  </div>
             <div class="row col-md-12">
       
<%--    </div>
    <div class="row col-md-12">--%>
        <div class="wizard-actions" style="float: left">
            <a href="RequestList.aspx" data-last="Finish" class="btn btn-success btn-next">مرحله بعدی													
            <i class="ace-icon fa fa-arrow-left icon-on-left"></i></a>
        </div>
          <div class="wizard-actions" style="float: left">
            <a href="PersonalView.aspx" data-last="Finish" class="btn btn-success btn-next">مرحله قبلی													
            <i class="ace-icon fa fa-arrow-right icon-on-left"></i></a>
        </div>
    </div>

        <input type="hidden" id="latlong" value="0"/>
        <input type="hidden" id="txtid" value="0"/>
        <input type="hidden" id="txtPersonalID" value="1" runat="server" />
        <script src="/App_Themes/bootstrap-2.js"></script>
        <script src="/Scripts/jquery-1.8.2.js"></script>
      <script src="/Scripts/ol.js"></script>
        <script src="/App_Themes/jquery.js"></script>
     <script src="/Scripts/mapCopy.js"></script>
        <script src="../App_Themes/jquery-ui.js"></script>
        <script src="/App_Themes/Theme1/js/persianDatepicker.js"></script>


         <script>
             var pid = document.getElementById('<%= txtPersonalID.ClientID %>').value;
             setTimeout(function () { showReport(); }, 2000);
             function save() {
                  var TreeTypeId = document.getElementById('<%= ddlStreetType.ClientID %>').value;
                 var ddlStreetType = document.getElementById('<%= ddlStreetType.ClientID %>').value;
                 var ddlLicesnceType = document.getElementById('<%= ddlLicesnceType.ClientID %>').value;
                 var ddRegion = document.getElementById('<%= ddRegion.ClientID %>').value;
                 var txtCount = document.getElementById('<%= txtCount.ClientID %>').value;
                 var txtBon = document.getElementById('<%= txtBon.ClientID %>').value;
                 var CtlDatePick = document.getElementById('<%= CtlDatePick.ClientID %>').value;
                 var txtAddress = document.getElementById('<%= txtAddress.ClientID %>').value;
                 var txtcomment = document.getElementById('<%= txtcomment.ClientID %>').value;


                 var object = {};
                 object.TreeTypeId = TreeTypeId;
                 object.Count = txtCount;
                 object.Bon = txtBon;
                 object.date = CtlDatePick;
                 object.Address = txtAddress;
                 object.StreetTypeid = ddlStreetType;
                 object.Desc = txtcomment;
                 object.Region = ddRegion;
                 object.LicesnceTypeid = ddlLicesnceType;
                 object.PointGeo = $('#latlong').val();
                 object.PersonalId = document.getElementById('<%= txtPersonalID.ClientID %>').value;
                 object.id = document.getElementById('txtid').value;
                 // alert('');

                 $.ajax({
                     url: "/WebService1.asmx/savepoint",
                     data: '{objectt: ' + JSON.stringify(object) + '}', //"{ 'TreeTypeId':'" + TreeTypeId + "','ddlStreetType':'" + ddlStreetType + "','ddlLicesnceType':'" + ddlLicesnceType + "','ddRegion':'" + ddRegion + "','txtCount':'" + txtCount + "','txtBon':'" + txtBon + "','CtlDatePick':'" + CtlDatePick + "','txtAddress':'" + txtAddress + "'  }",
                     dataType: "json",
                     type: "POST",
                     contentType: "application/json; charset=utf-8",

                     success: function (data) {
                         //if (addnew == "1")
                         //    bbox.getSource().clear();

                       //  alert('yyy');

                         var format = new ol.format.GeoJSON({
                             defaultDataProjection: 'EPSG:32639'
                         })

                         var features = format.readFeatures(data.d, {
                             dataProjection: 'EPSG:32639',
                             featureProjection: 'EPSG:32639'
                         });

 
                         bbox.getSource().addFeatures(features);

                         console.log(features);
                         console.log(
                         format.writeFeatures(features, {
                             dataProjection: 'EPSG:32639',
                             featureProjection: 'EPSG:32639'
                         })
                         );
                         if (data.d == '0')
                             alert('خطا در ثبت');
                         else {
                             alert('ثبت درخت انجام شد.');
                             loadIframe("iframpic", "/CityZen/attach.aspx?id=" + data.d)
                         }
                     },
                     error: function (XMLHttpRequest, textStatus, errorThrown) {
                         alert('خطا در ثبت درخت');
                     }
                 });
                 setTimeout(function () { showReport(); }, 500);
                 loadIframe("iframpic", "/CityZen/attach.aspx?id=" + data.d)
               //  document.getElementById('txtid').value = '0';

             }
             function deletetee() {
                 var oobbjj2 = {};
                 var id = document.getElementById('txtid').value;

                 oobbjj2.id = id;

                 $.ajax({
                     url: "/WebService1.asmx/deleteTree",
                     data: '{objectt: ' + JSON.stringify(oobbjj2) + '}', //"{ 'TreeTypeId':'" + TreeTypeId + "','ddlStreetType':'" + ddlStreetType + "','ddlLicesnceType':'" + ddlLicesnceType + "','ddRegion':'" + ddRegion + "','txtCount':'" + txtCount + "','txtBon':'" + txtBon + "','CtlDatePick':'" + CtlDatePick + "','txtAddress':'" + txtAddress + "'  }",
                     dataType: "json",
                     type: "POST",
                     contentType: "application/json; charset=utf-8",
                     success: function (data) {
                         
                     },
                     error: function (XMLHttpRequest, textStatus, errorThrown) {
                         alert('خطا در حذف درخت');
                     }
                 });
                 setTimeout(function () { showReport(); }, 500);
              }

             function visidel() {
                 var TreeTypeId = document.getElementById('txtid').value;
                 if (TreeTypeId == "0")  
                     {$('#delinfo').css("visibility", "hidden");}
                 else
                 { $('#delinfo').css("visibility", "inherit");}
                  
             }

             visidel();
             function SetParameter(objectt) {
                 $("#<%= ddlStreetType.ClientID %>")[0].selectedIndex = objectt.StreetType;
                 $("#<%= ddlLicesnceType.ClientID %>")[0].selectedIndex = objectt.LicesnceType;
                 $("#<%= ddRegion.ClientID %>")[0].selectedIndex = objectt.Region;
                 
                 $("#<%= ddlStreetType.ClientID %>").prop('selectedIndex', objectt.StreetType);
                 $("#<%= ddlLicesnceType.ClientID %>").prop('selectedIndex', objectt.LicesnceType);
                 $("#<%= ddRegion.ClientID %>").prop('selectedIndex', objectt.Region);


                   document.getElementById('<%= txtCount.ClientID %>').value = objectt.Count;
                  document.getElementById('<%= txtBon.ClientID %>').value = objectt.Bon;
                  document.getElementById('<%= CtlDatePick.ClientID %>').value =objectt.DatePick;
                  document.getElementById('<%= txtAddress.ClientID %>').value = objectt.Address;
                  document.getElementById('<%= txtcomment.ClientID %>').value = objectt.comment;
                 document.getElementById('txtid').value = objectt.id;

                 loadIframe("iframpic", "/CityZen/attach.aspx?id="+objectt.id)
             }
             
  $(function () {
      $("#tabs").tabs();
  });
  
  function loadIframe(iframeName, url) {
    //  var $iframe = $('#' + iframeName);
     // if ($iframe.length) {
      //    $iframe.attr('src', url);
        //  return false;
      //}
      //return true;
      $("#ctl00_MainContentPlaceHolder_iframpic").attr("src", url);
  }
  $("#ctl00_MainContentPlaceHolder_CtlDatePick").persianDatepicker({
            theme: 'dark'
        });
         </script>
      
          <script>
         $("#<%= CtlDatePick.ClientID %>").persianDatepicker({
            theme: 'dark'
        });
        </script>

 </body>
</asp:Content>
