using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenSpaceCL;
using System.Data;

namespace GreenSpaceDAL
{
    public class ErrorDAL
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(clError c)

        {

            SqlCommand cmd = new SqlCommand("Prc_Error_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("ErrorLog", SqlDbType.NVarChar)).Value = c.ErrorLog;
            cmd.Parameters.Add(new SqlParameter("createDate", SqlDbType.NVarChar)).Value = c.createDate;
            cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = c.IP;
            cmd.Parameters.Add(new SqlParameter("page", SqlDbType.NVarChar)).Value = c.Page;
            cmd.Parameters.Add(new SqlParameter("ConnectionOpen", SqlDbType.NVarChar)).Value = c.ConnectionOpen;
            cmd.Parameters.Add(new SqlParameter("timeLeft", SqlDbType.NVarChar)).Value = c.timeLeft;

            SqlParameter result = new SqlParameter("Result", System.Data.SqlDbType.Int);
            result.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(result);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(result.Value);

            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
            }

        }
    }

}
