using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace UI.uploadfile
{
    public partial class edit : System.Web.UI.Page
    {
        FileBLL fbll = new FileBLL();
       public FileModle modle = new FileModle();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id= Request.QueryString["id"].ToString();
            string fname = Request.QueryString["fname"];
            fbll.UpdateFile(Convert.ToInt32(id), fname);
            Response.Redirect("Main.aspx");
        }
    }
}