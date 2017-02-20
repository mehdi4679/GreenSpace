using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClExplanSubject:Grid
  {
private int? _ExplainSubjectID;
public int? ExplainSubjectID {
get { return _ExplainSubjectID; }
set { _ExplainSubjectID = value; }
}

private int? _Visible;
public int? Visible
{
    get { return _Visible; }
    set { _Visible = value; }
}
private int? _HavePlus;
public int? HavePlus
        {
    get { return _HavePlus; }
    set { _HavePlus = value; }
}

private int? _SubjectID;
public int? SubjectID {
get { return _SubjectID; }
set { _SubjectID = value; }
}
private String _ExplainName;
public String ExplainName {
get { return _ExplainName; }
set { _ExplainName = value; }
}
private int? _DayPriceDefualt;
public int? DayPriceDefualt {
get { return _DayPriceDefualt; }
set { _DayPriceDefualt = value; }
}
private int? _NightPriceDefualt;
public int? NightPriceDefualt {
get { return _NightPriceDefualt; }
set { _NightPriceDefualt = value; }
}
private int? _UnitNameID;
public int? UnitNameID {
get { return _UnitNameID; }
set { _UnitNameID = value; }
}
private int? _RotinOrNot;
public int? RotinOrNot {
get { return _RotinOrNot; }
set { _RotinOrNot = value; }
}

private int? _ErthAzKol;
public int? ErthAzKol
{
    get { return _ErthAzKol; }
    set { _ErthAzKol = value; }
}

private int? _UseFromKol;
public int? UseFromKol
{
    get { return _UseFromKol; }
    set { _UseFromKol = value; }
}


private int? _AgreeMentID;
public int? AgreeMentID
{
    get { return _AgreeMentID; }
    set { _AgreeMentID = value; }
}

private int? _OnlyActive;
public int? OnlyActive
{
    get { return _OnlyActive; }
    set { _OnlyActive = value; }
}

private string _FromDate;
public string FromDate
{
    get { return _FromDate; }
    set { _FromDate = value; }
}

private string _ToDate;
public string ToDate
{
    get { return _ToDate; }
    set { _ToDate = value; }
}



}
}
