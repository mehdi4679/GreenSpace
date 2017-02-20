using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Report
{
    public partial class CtlFromDateToDate : System.Web.UI.UserControl
    {
        public string FromDate
        {
            get { return DateConvert.sh2m(txtFormDate.Text).ToString(); }
            set { txtFormDate.Text = DateConvert.m2sh(value); }
        }
        public string ToDate
        {
            get { return DateConvert.sh2m(txttoDate.Text).ToString(); }
            set { txttoDate.Text = DateConvert.m2sh(value); }
        }
    }
}