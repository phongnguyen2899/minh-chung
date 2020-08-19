<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="WebsiteDongHo.dangky" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="cms/admin/css/dangky.css" rel="stylesheet" />
    <link href="CMS/admin/css/dangnhap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form" method="post">
        <input type="text" name="tk" placeholder="Username" id="tk"/>
        <br />
        <input type="password" name="mk" placeholder="Password" id="mk"/>
        <br />
        <input type="password" name="mk1" placeholder="Confirm Password" id="remk" />
        <label style="margin-bottom:10px;margin-top:5px;float:left;color:#FF0000" id="lb">Mật khẩu nhập lại chưa đúng</label>
        <br />
        <input type="submit" value="Đăng Ký" class="button" onclick="if (dangky()) { return false }" />

        <a href="/QuanTri/dangnhap.aspx" class="dangky">Đăng Nhập</a>
        
    </form>
</body>
</html>

<script>
    document.getElementById('lb').style.display = 'none';
    function dangky() {
        var tk = document.getElementById('tk');
        var mk = document.getElementById('mk');
        var remk = document.getElementById('remk');


        if (tk.value == "" || mk.value == "" || remk.value == "") {
            alert('Bạn cần điền đầy đủ thông tin');
            return true;
        }
        else if (mk.value != remk.value) {
            //alert('Mật khẩu bạn nhập lại không đúng! Mời bạn nhập lại');
            document.getElementById('lb').style.display = 'block';
            return true;

        }

        else {
            return false;
        }
    }

</script>
