using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClPercentHistory:Grid
  {
private int? _HistoryPercentID;
public int? HistoryPercentID {
get { return _HistoryPercentID; }
set { _HistoryPercentID = value; }
}
private String _PercentNumber;
public String PercentNumber
{
get { return _PercentNumber; }
set { _PercentNumber = value; }
}
private String _IP;
public String IP {
get { return _IP; }
set { _IP = value; }
}
private String _OS;
public String OS {
get { return _OS; }
set { _OS = value; }
}
private String _DateReg;
public String DateReg
{
get { return _DateReg; }
set { _DateReg = value; }
}
private int? _UserID;
public int? UserID {
get { return _UserID; }
set { _UserID = value; }
}
private int? _UnitNumber;
public int? UnitNumber {
get { return _UnitNumber; }
set { _UnitNumber = value; }
}
private String _DescChange;
public String DescChange {
get { return _DescChange; }
set { _DescChange = value; }
}
private int? _AgreementPercentID;
public int? AgreementPercentID {
get { return _AgreementPercentID; }
set { _AgreementPercentID = value; }
}

}
}
