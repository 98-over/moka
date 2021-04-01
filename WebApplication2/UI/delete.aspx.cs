using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace UI.uploadfile
{
    public partial class delete : System.Web.UI.Page
    {
        FileBLL fbll = new FileBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            fbll.Delete(id);
        }
    }
}