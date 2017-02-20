using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using TaxiCL;
using TaxiDAL;

namespace Taxi
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                BindEntity();
            }
        }
        public void BindEntity() {
            DataSet ds = TaxiDAL.CatalogType.GetList();
            txtCatalogType.DataSource = ds;
            txtCatalogType.DataTextField = "EntityName";
            txtCatalogType.DataValueField = "CatalogtypeID";
            txtCatalogType.DataBind();
            ds.Dispose();
        }
        [WebMethod]
        public static string get(ClCatalog cl)
        {
             ClCatalog cc =new ClCatalog ();
             cc.OrderDirection = cl.OrderDirection;
             cc.OrderBy = cl.OrderBy;
            cc.PageIndex = cl.PageIndex;
            cc.CID = cl.CID;
            cc.PageSize = 10;
            cc.CatalogTypeID = cl.CatalogTypeID;
            DataSet ds = TaxiDAL.CatalogClass.GetList2(cc);
            DataTable dt = new DataTable("Pager");
            dt.Columns.Add("PageIndex");
            dt.Columns.Add("PageSize");
            dt.Columns.Add("RecordCount");
            dt.Rows.Add();
            dt.Rows[0]["PageIndex"] = cl.PageIndex;// c.PageIndex;
            dt.Rows[0]["PageSize"] = 10;// c.PageSize;
            dt.Rows[0]["RecordCount"] = ds.Tables[0].Rows[0]["ROW_COUNT"];
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "Tbl_Catalog";
            return ds.GetXml();
        }

        [WebMethod]
        public static string delete(ClCatalog cl) {
            string caid = cl.CID.ToString();
          int i=  TaxiDAL.CatalogClass.Delete(caid);
          if (i == 0)
          {
              return "حذف با موفقیت انجام شد";
          }
          else {
              return "حذف با خطا مواجه شد.";
          }
        }

       [WebMethod]
        public static string Default(ClCatalog cl) {
            string caid = cl.CID.ToString();
            int i = TaxiDAL.CatalogClass.Default(caid);
          if (i == 0)
          {
              return "حذف با موفقیت انجام شد";
          }
          else {
              return "حذف با خطا مواجه شد.";
          }
        }

        [WebMethod]
        public static String Create(ClCatalog cl) {
            int i=0;
            ClCatalog c = new ClCatalog();
            c.CatalogName = cl.CatalogName;
            c.CatalogTypeID = cl.CatalogTypeID;
            c.CID = cl.CID;
            if (c.CID == null || c.CID==0)
                i = TaxiDAL.CatalogClass.insert(c);
            else
                i = TaxiDAL.CatalogClass.Update(c);

            if(i == 0) {
                return "خطا";
            }
            else{
            return "ثبت انجام شد";
            }
        }


     
        //protected void txtCatalogType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ClCatalog c = new ClCatalog();
        //    c.CatalogTypeID = txtCatalogType.SelectedValue();
        //    bind
        //}
    }
 
}