using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace UI
{
    public partial class upload : System.Web.UI.Page
    {
        FileBLL fileBLL = new FileBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            FileModle fileModle = new FileModle();
            HttpFileCollection httpFileCollection = HttpContext.Current.Request.Files;
            if (httpFileCollection.Count != 0)
            {
                HttpPostedFile file = httpFileCollection[0];
                Stream fileStream = (Stream)file.InputStream;

                byte[] fileContent = new byte[fileStream.Length];
                fileStream.Read(fileContent, 0, fileContent.Length);

                fileModle.Fcontent = fileContent;
                fileModle.Fname = file.FileName;
                fileStream.Close();
                fileBLL.Upload(fileModle);
                Response.Redirect("Main.aspx");
            }
            else
            {
                Response.Redirect("Main.aspx");
            }

        }
    }
}