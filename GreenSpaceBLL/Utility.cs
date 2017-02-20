using GreenSpaceBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
  public   class Utility
    {
      public static bool IntToBool(int i){
          if(i==0)
              return false;
          else return true;
      }
      public static int BoolToInt(bool i){
          if(i)
              return 1;
          else return 0;
      }

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

        
              public static string RandomDigit(int length)
        {
            //It will generate string with combination of small,capital letters and numbers
            char[] charArr = "0123456789".ToCharArray();
            string randomString = string.Empty;
            Random objRandom = new Random();
            for (int i = 0; i < length; i++)
            {
                //Don't Allow Repetation of Characters
                int x = objRandom.Next(1, charArr.Length);
                if (!randomString.Contains(charArr.GetValue(x).ToString()))
                    randomString += charArr.GetValue(x);
                else
                    i--;
            }
            return randomString;
        }
         
    }
}
