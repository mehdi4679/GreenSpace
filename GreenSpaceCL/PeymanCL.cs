using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClPeyman:Grid
  {
private int? _PeymanID;
public int? PeymanID {
get { return _PeymanID; }
set { _PeymanID = value; }
}
private String _PeymanName;
public String PeymanName {
get { return _PeymanName; }
set { _PeymanName = value; }
}
private String _PeymanNumber;
public String PeymanNumber {
get { return _PeymanNumber; }
set { _PeymanNumber = value; }
}

}
}
