<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/table.css" rel="stylesheet" />
    <script src="../js/js.js"></script>
    <script src="../javascript/js.js"></script>
</head>
    
<body>

    <form id="form1" method="post" enctype="multipart/form-data">

        <table class="gridtable">
            <tr>
                <th>文件id</th>
                <th>文件名</th>
                <th>操作</th>
            </tr>
            <%foreach (var item in list)
                {
            %>
             
            <tr >
                
                <td><%=item.Fid %></td>
                <td>
                    <input   value="<%=item.Fname %>"  style="border: 0px"  id="fname"  name="fname" onchange="changeValue(this)"/> 
                     <input  value="<%=item.Fname %>" type="hidden" /> 

                </td>
                   

                <td>
                    <button type="button" name="edit">修改文件名</button>
                    &nbsp;  &nbsp; 
                    <button type="button" name="delete">删除</button>&nbsp;  &nbsp;
                    <button   type="button" name="download">下载</button>
                  

                </td>
            </tr>
            <%  } %>
        </table>
        <input name="file" type="file" style="position: fixed; left: 1300px; top: 300px" id="file" />
        <button style="position: fixed; left: 1300px; top: 350px ;width:58px" onclick="upLoad()" >上传</button>


    </form>

</body>
   



</html>
