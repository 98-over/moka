using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DAL;
using Model;
using DALFactory;
using IDAL;
namespace BLL
{
    public class FileBLL
    {
        public DBFactory factory = new MySqlFactory();
        
        public List<FileModle> GetList()
        {
            List<FileModle> list = new List<FileModle>();
           
            return factory.GetDAL().GetFileModleList();
        }

        public FileModle GetModleById(int id)
        {

            FileModle modle;

            return modle = factory.GetDAL().GetModleById(id);



        }

        public void UpdateFile(int id, string fname)
        {

            factory.GetDAL().UpdateById(id, fname);

        }
        public void Delete(int id)
        {

            factory.GetDAL().DeleteById(id);

        }
        
        public void Upload(FileModle modle)
        {

            factory.GetDAL().UplodeFile(modle);

        }
    }
}
