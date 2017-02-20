using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreenSpaceCL;

namespace TaxiCL
{
 public   class ClUserPermission:Grid
  {
private int? _UserPermissinID;
public int? UserPermissinID {
get { return _UserPermissinID; }
set { _UserPermissinID = value; }
}
private int? _UserID;
public int? UserID {
get { return _UserID; }
set { _UserID = value; }
}
private int? _PermissionID;
public int? PermissionID {
get { return _PermissionID; }
set { _PermissionID = value; }
}
private bool? _CanView;
public bool? CanView {
get { return _CanView; }
set { _CanView = value; }
}
private bool? _CanUpdate;
public bool? CanUpdate {
get { return _CanUpdate; }
set { _CanUpdate = value; }
}
private bool? _CanDel;
public bool? CanDel {
get { return _CanDel; }
set { _CanDel = value; }
}
private bool? _CanInsert;
public bool? CanInsert {
get { return _CanInsert; }
set { _CanInsert = value; }
}

private string _PageName;
     public string  PageName {
         get { return _PageName; }
         set { _PageName = value; }
}
}
}
