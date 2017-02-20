using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.Controls
{
    public partial class CtlDatePick : System.Web.UI.UserControl
    {
        public string Text {
            get { return txtDate.Value; }
            set { txtDate.Value = value; }
        }
    }
}