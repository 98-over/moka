using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using IDAL;

namespace DALFactory
{
    public class SqlServerFactory:DBFactory
    {
        public FileIDAL GetDAL()
        {
            return new SqlServerDAL();
        }

     
    }
}
