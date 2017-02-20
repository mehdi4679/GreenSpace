using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreeExplanPrice:Grid
  {
private int? _ExplanPriceID;
public int? ExplanPriceID {
get { return _ExplanPriceID; }
set { _ExplanPriceID = value; }
}
private int? _ExplanID;
public int? ExplanID {
get { return _ExplanID; }
set { _ExplanID = value; }
}
private int? _PriceNightExplan;
public int? PriceNightExplan {
get { return _PriceNightExplan; }
set { _PriceNightExplan = value; }
}
private int? _PriceDayExplan;
public int? PriceDayExplan {
get { return _PriceDayExplan; }
set { _PriceDayExplan = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private string _ZaribPrice;
public string ZaribPrice
{
    get { return _ZaribPrice; }
    set { _ZaribPrice = value; }
}

private int? _SubjectID;
public int? SubjectID
{
    get { return _SubjectID; }
    set { _SubjectID = value; }
}

private int? _ActID;
public int? ActID
{
    get { return _ActID; }
    set { _ActID = value; }
}

private string _FromDateActive;
public string FromDateActive
{
    get { return _FromDateActive; }
    set { _FromDateActive = value; }
}


private string _ToDateActive;
public string ToDateActive
{
    get { return _ToDateActive; }
    set { _ToDateActive = value; }
}
}
}
