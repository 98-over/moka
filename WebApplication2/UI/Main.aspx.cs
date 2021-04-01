using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<FileModle> list = new List<FileModle>();
        protected void Page_Load(object sender, EventArgs e)
        {
            FileBLL fbl = new FileBLL();
            list = fbl.GetList();

        }

    }
}