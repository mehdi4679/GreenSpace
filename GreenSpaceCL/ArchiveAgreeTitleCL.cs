using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
 public   class ClArchiveAgreeTitle:Grid
  {
private int? _tbl_ArchiveAgreeTitle;
public int? tbl_ArchiveAgreeTitle {
get { return _tbl_ArchiveAgreeTitle; }
set { _tbl_ArchiveAgreeTitle = value; }
}
private string  _FromDate;
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
private string _Title;
public string Title
{
get { return _Title; }
set { _Title = value; }
}
private int? _IsDelete;
public int? IsDelete {
get { return _IsDelete; }
set { _IsDelete = value; }
}
private int? _AgreeID;
public int? AgreeID {
get { return _AgreeID; }
set { _AgreeID = value; }
}
        private int? _SoratJalase;
        public int? SoratJalase
        {
            get { return _SoratJalase; }
            set { _SoratJalase = value; }
        }

        private int? _SoratJalase_Manfi;
        public int? SoratJalase_Manfi
        {
            get { return _SoratJalase_Manfi; }
            set { _SoratJalase_Manfi = value; }
        }



    }
}
