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

                cmd.Parameters.AddRange(param);
            }

            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);






        }
        public static int Insert(string sql, params SqlParameter[] param)
        {


            using (SqlConnection conn = new SqlConnection(conStr))
            {

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (param != null && param.Length > 0)
                    {

                        cmd.Parameters.AddRange(param);
                    }

                    conn.Open();

                    int row = cmd.ExecuteNonQuery();

                    return row;
                }


            }






        }




    }

}
