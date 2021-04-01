﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using IDAL;

namespace DALFactory
{
  public   class MySqlFactory:DBFactory
    {
      

        FileIDAL DBFactory.GetDAL()
        {
            return new MySqlDAL();
        }
    }
}
