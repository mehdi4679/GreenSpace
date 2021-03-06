using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClAgreement:Grid
  {
private int? _AgreementID;
public int? AgreementID {
get { return _AgreementID; }
set { _AgreementID = value; }
}
private int? _UserID;
public int? UserID {
    get { return _UserID; }
    set { _UserID = value; }
}
private int? _IsTamdid;
public int? IsTamdid
{
    get { return _IsTamdid; }
    set { _IsTamdid = value; }
}

private int? _AgreeTamdid;
public int? AgreeTamdid
{
    get { return _AgreeTamdid; }
    set { _AgreeTamdid = value; }
}

private double ? _PricePayeAgreement;
public double? PricePayeAgreement
{
    get { return _PricePayeAgreement; }
    set { _PricePayeAgreement = value; }
}


private int? _SubjectID;
public int? SubjectID
{
    get { return _SubjectID; }
    set { _SubjectID = value; }
}
private decimal _Puls;
public decimal Puls
{
    get { return _Puls; }
    set { _Puls = value; }
}

private int? _PeymanID;
public int? PeymanID {
get { return _PeymanID; }
set { _PeymanID = value; }
}
private int? _PeymanKarID;
public int? PeymanKarID {
get { return _PeymanKarID; }
set { _PeymanKarID = value; }
}
private int? _supervisorStaticID;
public int? supervisorStaticID {
get { return _supervisorStaticID; }
set { _supervisorStaticID = value; }
}
private int? _MasterGreenSpaceID;
public int? MasterGreenSpaceID {
get { return _MasterGreenSpaceID; }
set { _MasterGreenSpaceID = value; }
}
private int? _supervisor2ID;
public int? supervisor2ID {
get { return _supervisor2ID; }
set { _supervisor2ID = value; }
}
private int? _supervisor3ID;
public int? supervisor3ID {
get { return _supervisor3ID; }
set { _supervisor3ID = value; }
}
private string  _StatrtDateAgreement;
public string StatrtDateAgreement
{
get { return _StatrtDateAgreement; }
set { _StatrtDateAgreement = value; }
}
private string _EndDateAgreement;
public string EndDateAgreement
{
get { return _EndDateAgreement; }
set { _EndDateAgreement = value; }
}

private string _AgreeSerial;
public string AgreeSerial
{
    get { return _AgreeSerial; }
    set { _AgreeSerial = value; }
}

private long? _PriceAgreementYear;
public long? PriceAgreementYear {
get { return _PriceAgreementYear; }
set { _PriceAgreementYear = value; }
}

private long? _EtabarAgreement;
public long? EtabarAgreement
{
    get { return _EtabarAgreement; }
    set { _EtabarAgreement = value; }
}


private int? _MonitorinOfficeID;
public int? MonitorinOfficeID {
get { return _MonitorinOfficeID; }
set { _MonitorinOfficeID = value; }
}


private string _FromDateReport;
public string FromDateReport
{
    get { return _FromDateReport; }
    set { _FromDateReport = value; }
}

private string _ToDateReport;
public string ToDateReport
{
    get { return _ToDateReport; }
    set { _ToDateReport = value; }
}



private string _AgreeName;
public string AgreeName
{
    get { return _AgreeName; }
    set { _AgreeName = value; }
}





}
}
