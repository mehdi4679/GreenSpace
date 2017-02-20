using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreementPercent:Grid
  {
private int? _AgreementPercentID;
public int? AgreementPercentID {
get { return _AgreementPercentID; }
set { _AgreementPercentID = value; }
}

        private int? _agreementpeymankarid;
        public int? agreementpeymankarid
        {
            get { return _agreementpeymankarid; }
            set { _agreementpeymankarid = value; }
        }

        private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _ExplainID;
public int? ExplainID {
get { return _ExplainID; }
set { _ExplainID = value; }
}

        private decimal? _UnitNumberPeymankar;
        public decimal? UnitNumberPeymankar
        {
            get { return _UnitNumberPeymankar; }
            set { _UnitNumberPeymankar = value; }
        }


        private decimal ?   _utilityPersent;
public decimal ? utilityPersent {
get { return _utilityPersent; }
set { _utilityPersent = value; }
}

private decimal? _unitNumberNazer;
public decimal? unitNumberNazer
{
    get { return _unitNumberNazer; }
    set { _unitNumberNazer = value; }
}
private string _VisitDate;
public string VisitDate
{
get { return _VisitDate; }
set { _VisitDate = value; }
}

private string _commentdarsad;
public string commentdarsad
{
    get { return _commentdarsad; }
    set { _commentdarsad = value; }
}


private string _JarimeComment;
public string JarimeComment
{
    get { return _JarimeComment; }
    set { _JarimeComment = value; }
}

private int? _SubjectID;
public int? SubjectID
{
    get { return _SubjectID; }
    set { _SubjectID = value; }
}

private int? _SuperVisorID;
public int? SuperVisorID {
get { return _SuperVisorID; }
set { _SuperVisorID = value; }
}
private int? _FineMeterOrRepeat;
public int? FineMeterOrRepeat {
get { return _FineMeterOrRepeat; }
set { _FineMeterOrRepeat = value; }
}
private string _FineFactor;
public string FineFactor {
get { return _FineFactor; }
set { _FineFactor = value; }
}

}
}
