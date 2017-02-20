using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenSpace.Controls
{
    public partial class CtlPrice : System.Web.UI.UserControl
    {
        public string Text {
            get {
                return txtPrice.Text.Replace(",", "").Replace("ریال", "");


            }
            set {
                txtPrice.Text = value.ToString();
            }
        }
    }
}