﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using GreenSpaceDAL;
using GreenSpaceCL;

namespace GreenSpace.WebService
{
    /// <summary>
    /// Summary description for SubjectExplan
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubjectExplan : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SubjectExpaln() {
            ClExplanSubject cl = new ClExplanSubject();
            DataSet ds= ExplanSubjectClass.GetList(cl);
            return ds.GetXml();
        }
     



    }
}
