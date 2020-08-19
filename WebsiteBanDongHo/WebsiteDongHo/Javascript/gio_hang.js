function xacNhanXoa() {
    var result = confirm("Bạn có chắc muốn xóa sản phẩm này?");
    if (!result) {
        return false;
    } else
        return true;
}
var btn;
function kiemTraBtnSubmit(i) {
    btn = i;
}
function kiemTraForm() {
    var hoten = document.getElementById("customer_name").value;
    var sdt = document.getElementById("customer_phone");
    var diaChi = document.getElementById("customer_address").value;
    var email = document.getElementById("customer_email");
    console.log(btn);
    if (btn != '3') { //Nếu nút submit ko phải là nút update_cart 
        //if (hoten == "" || sdt == "" || diaChi == "") {
          //  alert("Bạn phải nhập đầy đủ thông tin");
            //return false;
        //}
        if(sdt.value=="")
        {
            sdt.focus();
            alert("ban can nhap sdt");
            return false;
        }
        else if(email.value=="")
        {
            email.focus();
            alert("ban can nhap email");
            return false;
        }
        else if (sdt.value.length < 10 || sdt.value.length>11)
        {
            sdt.focus();
            alert("ban can nhap sdt tu 10-11 ki tu");
            return false;
        }

    }
}