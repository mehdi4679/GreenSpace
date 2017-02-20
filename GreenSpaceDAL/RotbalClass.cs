using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace GreenSpaceDAL
{
  public   class RotbalClass
    {

        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(String Money, String Year, String RotbalType)
        {

            SqlCommand cmd = new SqlCommand("PRC_Rotbal_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            //SqlParameter prmSupplyId = new SqlParameter("SupplyId", SqlDbType.Int);
            //prmSupplyId.Value = SupplyId;
            //cmd.Parameters.Add(prmSupplyId);


            //SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            //prmTitle.Value = Title;
            //cmd.Parameters.Add(prmTitle);


            SqlParameter prmMoney = new SqlParameter("Money", SqlDbType.Int);
            prmMoney.Value = Money;
            cmd.Parameters.Add(prmMoney);


            SqlParameter prmYear = new SqlParameter("Year", SqlDbType.Int);
            prmYear.Value = Year;
            cmd.Parameters.Add(prmYear);

            SqlParameter prmRotbalType = new SqlParameter("RotbalType", SqlDbType.Int);
            prmRotbalType.Value = RotbalType;
            cmd.Parameters.Add(prmRotbalType);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetList(String RotbalId, String Money, String Year, String RotbalType)
        {

            SqlCommand cmd = new SqlCommand("PRC_Rotbal_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();


            SqlParameter prmRotbalId = new SqlParameter("RotbalId", SqlDbType.Int);
            prmRotbalId.Value = RotbalId;
            cmd.Parameters.Add(prmRotbalId);


            //SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            //prmTitle.Value = Title;
            //cmd.Parameters.Add(prmTitle);


            SqlParameter prmMoney = new SqlParameter("Money", SqlDbType.Int);
            prmMoney.Value = Money;
            cmd.Parameters.Add(prmMoney);


            SqlParameter prmYear = new SqlParameter("Year", SqlDbType.Int);
            prmYear.Value = Year;
            cmd.Parameters.Add(prmYear);

            SqlParameter prmRotbalType = new SqlParameter("RotbalType", SqlDbType.Int);
            prmRotbalType.Value = RotbalType;
            cmd.Parameters.Add(prmRotbalType);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static int Update(String RotbalId, String Money, String Year, String RotbalType)
        {

            SqlCommand cmd = new SqlCommand("PRC_Rotbal_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();



            SqlParameter prmRotbalId = new SqlParameter("RotbalId", SqlDbType.Int);
            prmRotbalId.Value = RotbalId;
            cmd.Parameters.Add(prmRotbalId);


            //SqlParameter prmTitle = new SqlParameter("Title", SqlDbType.NVarChar);
            //prmTitle.Value = Title;
            //cmd.Parameters.Add(prmTitle);


            SqlParameter prmMoney = new SqlParameter("Money", SqlDbType.Int);
            prmMoney.Value = Money;
            cmd.Parameters.Add(prmMoney);


            SqlParameter prmYear = new SqlParameter("Year", SqlDbType.Int);
            prmYear.Value = Year;
            cmd.Parameters.Add(prmYear);

            SqlParameter prmRotbalType = new SqlParameter("RotbalType", SqlDbType.Int);
            prmRotbalType.Value = RotbalType;
            cmd.Parameters.Add(prmRotbalType);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static int Delete(int id)
        {

            SqlCommand cmd = new SqlCommand("PRC_Rotbal_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID(); cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress(); cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS(); cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion(); cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int);
            //prmid.Direction = ParameterDirection.Output;
            prmid.Value = id;
            cmd.Parameters.Add(prmid);
            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }
    }
}
