using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClSubject:Grid
  {
private int? _SubjectID;
public int? SubjectID {
get { return _SubjectID; }
set { _SubjectID = value; }
}
private String _SubjectName;
public String SubjectName {
get { return _SubjectName; }
set { _SubjectName = value; }
}

}
}
