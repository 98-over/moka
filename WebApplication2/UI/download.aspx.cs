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
    
    public partial class download : System.Web.UI.Page
    {
        FileBLL fileBLL = new FileBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            FileModle fileModle = new FileModle();
            string id = Request.QueryString["id"].ToString();
            fileModle= fileBLL.GetModleById(Convert.ToInt32(id));

            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileModle.Fname, System.Text.Encoding.UTF8));
            Response.ContentType = "application/octet-stream";
            Response.BinaryWrite(fileModle.Fcontent);
            Response.End();
            
            
     
        }
    }
}