using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreePercentProtest:Grid
  {
private int? _AgreePercentProtestID;
public int? AgreePercentProtestID {
get { return _AgreePercentProtestID; }
set { _AgreePercentProtestID = value; }
}
private int? _AgreementPercentID;
public int? AgreementPercentID {
get { return _AgreementPercentID; }
set { _AgreementPercentID = value; }
}
private int? _ProtestStatusID;
public int? ProtestStatusID {
get { return _ProtestStatusID; }
set { _ProtestStatusID = value; }
}
private string _ProtestDate;
public string ProtestDate
{
get { return _ProtestDate; }
set { _ProtestDate = value; }
}
private int? _UserResponseID;
public int? UserResponseID {
get { return _UserResponseID; }
set { _UserResponseID = value; }
}
private String _ProtestComment;
public String ProtestComment {
get { return _ProtestComment; }
set { _ProtestComment = value; }
}

}
}
