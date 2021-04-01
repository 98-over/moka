var xmlHttp;

function ajaxFunction() {
    if (XMLHttpRequest) {
        xmlHttp = new XMLHttpRequest();
    }
    else {

        xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
    }

}

function upLoad() {


    var fileObj = document.getElementById("file").files[0]; // js 获取文件对象
    if (fileObj == null) {

        alert("请选择文件")
    }
    else {

        var url = "Upload.aspx"; // 接收上传文件的后台地址

        var form = new FormData(); // FormData 对象

        form.append("file", fileObj); // 文件对象

        ajaxFunction(); // XMLHttpRequest 对象

        xmlHttp.open("post", url, false); //post方式，url为服务器请求地址，true 该参数规定请求是否异步处理。





        xmlHttp.onreadystatechange = function () {
            if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {


                alert("上传成功");
            }

        }

        xmlHttp.send(form); //开始上传，发送form数据

    }




}

function downLoad() {

    var dl = document.getElementsByName("download");

    for (var i = 0; i < dl.length; i++) {
        var t = dl[i]

        t.onclick = function () {



            var fid = this.parentElement.previousElementSibling.previousElementSibling.textContent;

            window.location.href = "download.aspx?id=" + fid;




        }
    }




}

function deleteFile() {
    var tdelete = document.getElementsByName("delete");
    for (var i = 0; i < tdelete.length; i++) {
        var t = tdelete[i]

        t.onclick = function () {

            if (confirm("确定要删除吗？")) {

                var fid = this.parentElement.previousElementSibling.previousElementSibling.textContent;
                ajaxFunction();
                var url = "delete.aspx?id=" + fid;
                xmlHttp.open("get", url, true);

                xmlHttp.send();
                xmlHttp.onreadystatechange = function () {
                    if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {

                        window.location.href = document.URL
                        alert("删除成功");


                    }

                }

            }
        }
    }



}

function edit() {

    var td = document.getElementsByName("edit");

    for (var i = 0; i < td.length; i++) {
        var t = td[i]

        t.onclick = function () {
           
            var fid = this.parentElement.previousElementSibling.previousElementSibling.textContent;
            var fname = this.parentElement.previousElementSibling.children[0].value;
            var oldfname = this.parentElement.previousElementSibling.children[1].value;
            if (fname == oldfname) {

                alert("请输入文件名");

            }
            else if(confirm("确定要修改吗？")) {


                ajaxFunction();
                var url = "edit.aspx?id=" + fid + "&&fname="+ fname;
                xmlHttp.open("get", url, true);

                xmlHttp.send();
                xmlHttp.onreadystatechange = function () {
                    if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {


                        alert("修改成功");
                        window.location.href = document.URL;


                    }

                }

            }



            ;
        }




    }
}

function changeValue(obj) {

    $(obj).attr("value", $(obj).val());

}



window.onload = function () {

    deleteFile();
    downLoad();
    edit();




}
