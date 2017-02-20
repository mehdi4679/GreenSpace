using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClPeymanPark:Grid
  {
private int? _PeymanParkID;
public int? PeymanParkID {
get { return _PeymanParkID; }
set { _PeymanParkID = value; }
}
private int? _PeymanID;
public int? PeymanID {
get { return _PeymanID; }
set { _PeymanID = value; }
}
private int? _ParkID;
public int? ParkID {
get { return _ParkID; }
set { _ParkID = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}

}
}
