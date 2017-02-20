using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using GreenSpaceCL;

namespace TaxiCL
{
  public   class ClCatalog:Grid
    {
 
        private int? _CID;
        public int? CID {
            get { return _CID; }
            set { _CID = value; }
        }

        private string _CatalogName;
        public string CatalogName {
            get { return _CatalogName; }
            set { _CatalogName = value; }
        }

        private string _CatalogValue;
        public string CatalogValue
        {
            get { return _CatalogValue; }
            set { _CatalogValue = value; }
        }
       
        private int? _parentID;
        public int? parentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        private int? _OrderID;
        public int? OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        private int? _CatalogTypeID;
        public int? CatalogTypeID
        {
            get { return _CatalogTypeID; }
            set { _CatalogTypeID = value; }
        }
    }
}
