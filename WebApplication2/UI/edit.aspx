<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="UI.uploadfile.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    
            



        
        




</head>
<body>
    <form id="form1" runat="server" >
        <div>

            <label>文件ID</label>
            <input id="id" type="text" value="<%=modle.Fid %>"/><br />
              <label>文件名</label>
            <input id="name" type="text"  value="<%=modle.Fname %>" /><br />
            <input id="xiugai" type="submit" value="修改" />
        </div>
    </form>
</body>
</html>

