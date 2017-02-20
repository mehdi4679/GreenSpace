using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreeStatus:Grid
  {
private int? _AgreeStatus;
public int? AgreeStatus {
get { return _AgreeStatus; }
set { _AgreeStatus = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _StatusID;
public int? StatusID {
get { return _StatusID; }
set { _StatusID = value; }
}
private string _StatusDate;
public string StatusDate
{
get { return _StatusDate; }
set { _StatusDate = value; }
}
private int? _RegUser;
public int? RegUser {
get { return _RegUser; }
set { _RegUser = value; }
}
private string _RegDate;
public string RegDate
{
get { return _RegDate; }
set { _RegDate = value; }
}
private String _AgreeStatusComment;
public String AgreeStatusComment {
get { return _AgreeStatusComment; }
set { _AgreeStatusComment = value; }
}

}
}
