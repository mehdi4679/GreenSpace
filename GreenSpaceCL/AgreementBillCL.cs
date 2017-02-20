using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreementBill:Grid
  {
private int? _AgreementBillID;
public int? AgreementBillID {
get { return _AgreementBillID; }
set { _AgreementBillID = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _MonthID;
public int? MonthID {
get { return _MonthID; }
set { _MonthID = value; }
}
private int? _BillPrice;
public int? BillPrice {
get { return _BillPrice; }
set { _BillPrice = value; }
}
private string _SYSDate;
public string SYSDate
{
get { return _SYSDate; }
set { _SYSDate = value; }
}
private int? _SYSUser;
public int? SYSUser {
get { return _SYSUser; }
set { _SYSUser = value; }
}

}
}
