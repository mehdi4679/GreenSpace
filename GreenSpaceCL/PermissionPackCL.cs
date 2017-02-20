using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreenSpaceCL;
namespace TaxiCL
{
 public   class ClPermissionPack:Grid
  {
private int? _PermissionPAckID;
public int? PermissionPAckID {
get { return _PermissionPAckID; }
set { _PermissionPAckID = value; }
}
private int? _PermissionID;
public int? PermissionID {
get { return _PermissionID; }
set { _PermissionID = value; }
}
private int? _PackID;
public int? PackID {
get { return _PackID; }
set { _PackID = value; }
}
private bool? _Canview;
public bool? Canview {
get { return _Canview; }
set { _Canview = value; }
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

}
}
