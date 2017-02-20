using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiCL
{
 public   class ClRole 
  {
private int? _RoleID;
public int? RoleID {
get { return _RoleID; }
set { _RoleID = value; }
}
private String _RoleName;
public String RoleName {
get { return _RoleName; }
set { _RoleName = value; }
}
private String _RoleDesc;
public String RoleDesc {
get { return _RoleDesc; }
set { _RoleDesc = value; }
}

}
}
