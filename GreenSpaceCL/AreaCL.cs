using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClArea:Grid
  {

private int? _PeymanID;
public int? PeymanID
{
    get { return _PeymanID; }
    set { _PeymanID = value; }
}


private int? _AreaID;
public int? AreaID {
get { return _AreaID; }
set { _AreaID = value; }
}
private int? _ParkID;
public int? ParkID {
get { return _ParkID; }
set { _ParkID = value; }
}
private int? _SubjectExplainID;
public int? SubjectExplainID {
get { return _SubjectExplainID; }
set { _SubjectExplainID = value; }
}

private int? _SubjectID;
public int? SubjectID
{
    get { return _SubjectID; }
    set { _SubjectID = value; }
}

private string   _UnitNumber;
public string  UnitNumber
{
get { return _UnitNumber; }
set { _UnitNumber = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}

private int? _OnlyActive;
public int? OnlyActive
{
    get { return _OnlyActive; }
    set { _OnlyActive = value; }
}



}
}
