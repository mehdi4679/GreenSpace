using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClExplanPrice:Grid
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
private int? _PriceExplan;
public int? PriceExplan {
get { return _PriceExplan; }
set { _PriceExplan = value; }
}
private int? _RepeatExplan;
public int? RepeatExplan {
get { return _RepeatExplan; }
set { _RepeatExplan = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}

}
}
