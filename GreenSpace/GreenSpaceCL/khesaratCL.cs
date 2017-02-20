using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class Clkhesarat:Grid
  {
private int? _KesaratID;
public int? KesaratID {
get { return _KesaratID; }
set { _KesaratID = value; }
}
private int? _KesaratPrice;
public int? KesaratPrice {
get { return _KesaratPrice; }
set { _KesaratPrice = value; }
}
private String _KhesaratDesc;
public String KhesaratDesc {
get { return _KhesaratDesc; }
set { _KhesaratDesc = value; }
}

}
}
