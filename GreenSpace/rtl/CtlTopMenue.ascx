<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtlTopMenue.ascx.cs" Inherits="Taxi.rtl.CtlTopMenue" %>
 <%--======top menu========--%>
               <!-- Static navbar -->
      <nav class="navbar navbar-default" role="navigation">
        <div class="container-fluid">
          <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
              <span class="sr-only">Toggle navigation</span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="#"></a>
          </div>
          <div id="navbar" class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
          <%--class="active"--%>
              <li ><a href='<%=Page.ResolveUrl("~/Personal/Person.aspx?pname=مشخصات فرد&Pid=")+ Request.QueryString["pID"] %>'>مشخصات فرد    </a></li>
            
              <li><a href='<%=Page.ResolveUrl("~/Personal/PersonFish1.aspx?pname=ثبت فیش ها&pid=")+ Request.QueryString["pID"] %>'>ثبت فیش ها</a></li>
                   <li><a href='<%=Page.ResolveUrl("~/Personal/PersonalLetter.aspx?pname=صدور نامه&pid=")+ Request.QueryString["pID"] %>'>صدور نامه</a></li>
                   <li><a href='<%=Page.ResolveUrl("~/Personal/PersonServicee.aspx?pname=سرویس  &pid=")+ Request.QueryString["pID"] %>'>سرویس  </a></li>
              <li><a href='<%= Page.ResolveUrl("~/Personal/PersonActive.aspx?pname=فعال /راکد&pid=")+ Request.QueryString["pID"] %>'>فعال /راکد</a></li>
               

             
              <li class="dropdown">
                <a href='#' class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">پذیرش <span class="caret"></span></a>
                <ul class="dropdown-menu" role="menu">
              <li><a href='<%=Page.ResolveUrl("~/Personal/PesonLearn.aspx?pname=دوره های آموزشی&Pid=")+ Request.QueryString["pID"] %>'>دوره های آموزشی</a></li>
              <li><a href='<%=Page.ResolveUrl("~/Personal/PersonEstelam.aspx?pname=استعلامات&Pid=")+ Request.QueryString["pID"] %>'>استعلامات</a></li>
              <li><a href='<%=Page.ResolveUrl("~/Personal/PesonMadrak.aspx?pname=مدارک&Pid=")+ Request.QueryString["pID"] %>'>مدارک</a></li>

              </ul>
              </li>


              <li ><a href='<%=Page.ResolveUrl("~/Personal/Parvaneh.aspx?pname=پروانه بهره برداری&Pid=")+ Request.QueryString["pID"] %>'>پروانه بهره برداری    </a></li>
              <li ><a href='<%=Page.ResolveUrl("~/Personal/ParvanehTaxi.aspx?pname=پروانه تاکسیرانی&Pid=")+ Request.QueryString["pID"] %>'>پروانه تاکسیرانی   </a></li>
              <li ><a href='<%=Page.ResolveUrl("~/Personal/PersonViolation.aspx?pname=ثبت تخلف&Pid=")+ Request.QueryString["pID"] %>'>ثبت تخلف  </a></li>

              <li  ><a href='<%=Page.ResolveUrl("~/Personal/PersonAllCar.aspx?pname=سابقه مالکیت خورو&Pid=")+ Request.QueryString["pID"] %>' >  سابقه مالکیت خورو   </a></li>
         

                <li class="dropdown">
                <a href='#' class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">مرخصی <span class="caret"></span></a>
                <ul class="dropdown-menu dropdownmo" role="menu">
              <li><a href='<%=Page.ResolveUrl("~/Personal/Morakhasi.aspx?pname=ثبت مرخصی&Pid=")+ Request.QueryString["pID"] %>'>ثبت مرخصی</a></li>
              <li><a href='<%=Page.ResolveUrl("~/Personal/Mo_PersonPermision.aspx?pname=تعیین حداکثر مرخصی&Pid=")+ Request.QueryString["pID"] %>'>تعیین حداکثر مرخصی</a></li>
 
              </ul>
              </li>


            </ul>
          </div><!--/.nav-collapse -->
        </div><!--/.container-fluid -->
      </nav>

            <%--=============--%>