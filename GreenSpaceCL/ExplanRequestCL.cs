using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenSpaceCL
{
    public class ClExplanRequest : Grid
    {
        private int? _ExplanRequestOpenID;
        public int? ExplanRequestOpenID
        {
            get { return _ExplanRequestOpenID; }
            set { _ExplanRequestOpenID = value; }
        }
        private int? _ExplanID;
        public int? ExplanID
        {
            get { return _ExplanID; }
            set { _ExplanID = value; }
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
        private int? _IsOK;
        public int? IsOK
        {
            get { return _IsOK; }
            set { _IsOK = value; }
        }
        private int? _ForUserID;
        public int? ForUserID
        {
            get { return _ForUserID; }
            set { _ForUserID = value; }
        }
        private string _RegDate;
        public string RegDate
        {
            get { return _RegDate; }
            set { _RegDate = value; }
        }
        private int? _ByUserID;
        public int? ByUserID
        {
            get { return _ByUserID; }
            set { _ByUserID = value; }
        }
        private string _SYSOKDate;
        public string SYSOKDate
        {
            get { return _SYSOKDate; }
            set { _SYSOKDate = value; }
        }
        private int? _ForAgreementID;
        public int? ForAgreementID
        {
            get { return _ForAgreementID; }
            set { _ForAgreementID = value; }
        }

    }
}
