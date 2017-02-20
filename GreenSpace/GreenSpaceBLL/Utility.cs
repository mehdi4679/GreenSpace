using GreenSpaceBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
  public   class Utility
    {
        public static void ShowMsg(System.Web.UI.Page page,ProPertyData.MsgType type, string msg )
        {
            switch (type)
            {
                case ProPertyData.MsgType.General_Fault:
                    msg = "متاسفانه مشکلی پیش بینی نشده به وجود آمد.لطفا لحظاتی بعد مجددا سعی نمایید";
                    type = ProPertyData.MsgType.warning;
                    break;
                case ProPertyData.MsgType.General_Success:
                    msg = "انجام عملیات با موفقیت به پایان رسید";
                    type = ProPertyData.MsgType.accept;
                    break;
                default:
                    break;
            }

            string myScript2 = "showMsg('" + type.ToString() + "','" + msg + "') ";
            page.ClientScript.RegisterStartupScript(page.GetType(), "key" + DateTime.Now.Millisecond.ToString(), myScript2, true);
        }
    }
}
