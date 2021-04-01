using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Common
{
    public static class SqlServerHelper
    {

        public static string conStr = "Data Source=DESKTOP-L44M15U;Initial Catalog=test;User ID=sa;Pwd=123";

       

       
        public static SqlDataReader GetReader(string sql, params SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (param != null && param.Length > 0)
            {
                //添加参数
                cmd.Parameters.AddRange(param);
            }
            try
            {
                //打开数据库
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }





    }

}
