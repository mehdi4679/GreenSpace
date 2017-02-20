using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreenSpaceCL;

namespace TaxiCL
{
 public   class ClUserRole:Grid
  {
private int? _UserRoleID;
public int? UserRoleID {
get { return _UserRoleID; }
set { _UserRoleID = value; }
}
private int? _RoleID;
public int? RoleID {
get { return _RoleID; }
set { _RoleID = value; }
}
private int? _UserID;
public int? UserID {
get { return _UserID; }
set { _UserID = value; }
}
private String  _CreateDate;
public String CreateDate
{
get { return _CreateDate; }
set { _CreateDate = value; }
}
private int? _CreateUser;
public int? CreateUser {
get { return _CreateUser; }
set { _CreateUser = value; }
}

}
}
