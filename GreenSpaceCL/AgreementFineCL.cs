using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreementFine:Grid
  {
private int? _AgreementFineID;
public int? AgreementFineID {
get { return _AgreementFineID; }
set { _AgreementFineID = value; }
}
private int? _FineID;
public int? FineID {
get { return _FineID; }
set { _FineID = value; }
}
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _ArchivID;
public int? ArchivID {
get { return _ArchivID; }
set { _ArchivID = value; }
}

private string  _FineDate;
public string FineDate
{
get { return _FineDate; }
set { _FineDate = value; }
}

private int? _FinePrice;
public int? FinePrice
{
    get { return _FinePrice; }
    set { _FinePrice = value; }
}

private int? _NumberFine;
public int? NumberFine
{
    get { return _NumberFine; }
    set { _NumberFine = value; }
}

private String _FineComment;
public String FineComment {
get { return _FineComment; }
set { _FineComment = value; }
}

private String _AdressFine;
public String AdressFine
{
    get { return _AdressFine; }
    set { _AdressFine = value; }
}

}
}
