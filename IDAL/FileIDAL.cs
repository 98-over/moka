using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public  interface FileIDAL
    {
        void FileListUpload(List<FileModle> list);

        List<FileModle> GetFileModleList();

        FileModle GetModleById(int id);

        void UpdateById(int id, string fname);

        void DeleteById(int id);

        void UplodeFile(FileModle fileModle);
    }
}
