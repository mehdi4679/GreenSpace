using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreementPercent:Grid
  {
private int? _AgreementPercentID;
public int? AgreementPercentID {
get { return _AgreementPercentID; }
set { _AgreementPercentID = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _ExplainID;
public int? ExplainID {
get { return _ExplainID; }
set { _ExplainID = value; }
}
private int? _utilityPersent;
public int? utilityPersent {
get { return _utilityPersent; }
set { _utilityPersent = value; }
}
private string _VisitDate;
public string VisitDate
{
get { return _VisitDate; }
set { _VisitDate = value; }
}
private string _JarimeComment;
public string JarimeComment
{
    get { return _JarimeComment; }
    set { _JarimeComment = value; }
}

private int? _SuperVisorID;
public int? SuperVisorID {
get { return _SuperVisorID; }
set { _SuperVisorID = value; }
}
private int? _FineMeterOrRepeat;
public int? FineMeterOrRepeat {
get { return _FineMeterOrRepeat; }
set { _FineMeterOrRepeat = value; }
}
private int? _FineFactor;
public int? FineFactor {
get { return _FineFactor; }
set { _FineFactor = value; }
}

}
}
