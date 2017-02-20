using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClPark:Grid
  {
private int? _ParkID;
public int? ParkID {
get { return _ParkID; }
set { _ParkID = value; }
}
private String _ParkName;
public String ParkName {
get { return _ParkName; }
set { _ParkName = value; }
}
private String _ParkAdress;
public String ParkAdress {
get { return _ParkAdress; }
set { _ParkAdress = value; }
}
private String _ParkArea;
public String ParkArea
{
get { return _ParkArea; }
set { _ParkArea = value; }
}
private int? _ParkDistrict;
public int? ParkDistrict {
get { return _ParkDistrict; }
set { _ParkDistrict = value; }
}

private int? _PeymanID;
public int? PeymanId {
    get { return _PeymanID; }
    set { _PeymanID = value; }
}


}
}
