using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class FileDal
    {
        public void FileListUpload(List<FileModle> list)
        {
            string sql = "insert into hs(fName,fContent) values(@fName,@fileContent)";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string fName;
                byte[] buffer;
                con.Open();
                foreach (var fileModle in list)
                {
                    fName = fileModle.Fname;
                    buffer = fileModle.Fcontent;

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlParameter par = new SqlParameter("@fileContent", SqlDbType.VarBinary) { Value = buffer };
                        SqlParameter par1 = new SqlParameter("@fName", SqlDbType.VarChar) { Value = fName };
                        cmd.Parameters.Add(par);
                        cmd.Parameters.Add(par1);
                        cmd.ExecuteNonQuery();


                    }

                }



            }


        }

        public static List<DAL.FileModle> GetFileModleList()
        {
            FileModle fileModle = new FileModle();
            List<DAL.FileModle> list = new List<DAL.FileModle>();
            string sql = "select * from hs ";

            SqlDataReader dr = SqlServerHelper.GetReader(sql);
            while (dr.Read())
            {
                fileModle.Fid = dr.GetInt32(0);
                fileModle.Fname = dr.GetString(1);
                fileModle.Fcontent = (byte[])dr["fContent"];
                list.Add(fileModle);


            }
            return list;


        }

    }
}
