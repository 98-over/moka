using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
namespace DALFactory
{
    public interface DBFactory
    {
       FileIDAL  GetDAL();
    }
}
