using Model;
using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IDAL;
namespace DAL
{
    public class SqlServerDAL : FileIDAL
    {
        public void FileListUpload(List<FileModle> list)
        {
            string fName;
            byte[] buffer;
            string sql = "insert into hs(fName,fContent) values(@fName,@fileContent)";


            foreach (var fileModle in list)
            {
                fName = fileModle.Fname;
                buffer = fileModle.Fcontent;

                SqlParameter[] pars = new SqlParameter[] { new SqlParameter("@fileContent", SqlDbType.VarBinary) { Value = buffer },
                new SqlParameter("@fName", SqlDbType.VarChar) { Value = fName }
            };
                SqlServerHelper.Insert(sql, pars);




            }


        }

        public List<FileModle> GetFileModleList()
        {

            List<FileModle> list = new List<FileModle>();
            string sql = "select fId,fName from hs ";

            SqlDataReader dr = SqlServerHelper.GetReader(sql);
            while (dr.Read())
            {
                FileModle fileModle = new FileModle();
                fileModle.Fid = (int)dr["fId"];
                fileModle.Fname = dr.GetString(1);
                list.Add(fileModle);


            }
            return list;


        }
        public FileModle GetModleById(int id)
        {
            FileModle fileModle = new FileModle();
            string sql = "select * from hs where fId=@id";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@id", SqlDbType.Int) { Value = id } };
            SqlDataReader dr = SqlServerHelper.GetReader(sql, para);
            while (dr.Read())
            {

                fileModle.Fid = (int)dr["fId"];
                fileModle.Fname = dr.GetString(1);
                fileModle.Fcontent = (byte[])dr["fContent"];


            }
            return fileModle;
        }
        public void UpdateById(int id,string fname)
        {
            string sql = "update hs set fName=@fname where fId=@id";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@id", SqlDbType.Int) { Value = id }, new SqlParameter("@fname", SqlDbType.NVarChar) { Value = fname } };
            Common.SqlServerHelper.Insert(sql,para);

        }
        public void DeleteById(int id)
        {

            string sql = "delete from hs where fId=@id";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@id", SqlDbType.Int) { Value = id } } ;
            Common.SqlServerHelper.Insert(sql, para);




        }
        public  void UplodeFile(FileModle fileModle)
        {
            string sql = "insert into hs(fName,fContent) values(@fName,@fileContent)";
            SqlParameter[] pars = new SqlParameter[] { new SqlParameter("@fileContent", SqlDbType.VarBinary) { Value = fileModle.Fcontent },
             new SqlParameter("@fName", SqlDbType.VarChar) { Value = fileModle.Fname } };

            SqlServerHelper.Insert(sql, pars);

        }
    }

}
