<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham_ThemMoi.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLySanPham.SanPham_ThemMoi" %>
<div class="themmoisanpham">
<div class="head" style="margin-left:-20%">Thêm mới chỉnh sửa sản phẩm</div>
    <br />
    <div>
        <div class="tentruong">Tên</div>
        <div class="onhap">
            <input type="text" value="" name="ten" class="ip" id="tendh" />
            <label id="err_ten">ban can nhap thong tin san pham</label>
        </div>
    </div>

    <div>
        <div class="tentruong">Ảnh sản phẩm</div>
       <div class="onhap">
           
            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="ip"/>
        </div>
    </div>
      
    <div>
        <div class="tentruong">Đơn Giá</div>
       <div class="onhap">
            <input type="text" value="" name="dongia" class="ip" id="dongia"/>
           <label id="err_dongia">ban can nhap thong tin san pham</label>
        </div>
    </div>
    
    
    <div >
         <div class="tentruong">Xuất xứ</div>
        <select runat="server" id="bochon" class="ip" style="float:left">
            <option value="a" runat="server">a</option>
            <option value="b" runat="server">b</option>
            <option value="c" runat="server">c</option>
        </select>
    </div>
    
    <div>
        <div class="tentruong">Thương Hiệu</div>
        <div class="onhap">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ip"></asp:DropDownList>
        </div>
    </div>
   
    <div>
        <div class="tentruong">Kiểu giáng</div>
        <div class="onhap">
            <input type="text" value="" name="kieudang" class="ip" id="kieudang"/>
        </div>
    </div>
  
    <div>
        <div class="tentruong">Năng Lượng</div>
       <div class="onhap">
            <input type="text" value="" name="nangluong" class="ip" id="nangluong"/>
        </div>
    </div>
 
    <div>
        <div class="tentruong">Chống Nước</div>
        <div class="onhap">
            <input type="text" value="" name="chongnuoc" class="ip" id="chongnuoc"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Chất liệu mặt</div>
       <div class="onhap">
            <input type="text" value="" name="chatlieumat" class="ip" id="chatlieumat"/>
        </div>
    </div>
   
    <div>
        <div class="tentruong">Chất liệu dây</div>
       <div class="onhap">
            <input type="text" value="" name="chatlieuday" class="ip" id="chatlieuday"/>
        </div>
    </div>
    
    <div class="tentruong">Đường kính mặt</div>
       <div class="onhap">
            <input type="text" value="" name="duongkinhmat" class="ip" id="duongkinhmat"/>
       </div>
    <div style="clear:left;margin-left:20%">
       <asp:Button ID="Button1" runat="server" Text="Thêm Mới" OnClick="Button1_Click" CssClass="btthem" OnClientClick="if(them()){return false;}"/> 
    </div>
</div>
   
<script type="text/javascript">
    document.getElementById('err_ten').style.display = 'none';
    document.getElementById('err_dongia').style.display = 'none';
    document.getElementById('err_ten').style.color = "red";
    document.getElementById('err_dongia').style.color = "red";
    function them()
    {
        var tendh = document.getElementById('tendh');
        var dongia = document.getElementById('dongia');
        var xuatxu = document.getElementById('xuatxu');
        var kieudang = document.getElementById('kieudang');
        var nangluong = document.getElementById('nangluong');
        var chongnuoc = document.getElementById('chongnuoc');
        var chatlieumat = document.getElementById('chatlieumat');
        var chatlieuday = document.getElementById('chatlieuday');
        var duongkinhmat = document.getElementById('duongkinhmat');
        if (tendh.value == "" && dongia.value == "") {
            document.getElementById('err_ten').style.display = 'inline';
            document.getElementById('err_dongia').style.display = 'inline';
            return true;
        }
        else if(tendh.value == "")
        {
            document.getElementById('err_ten').style.display = 'inline';
            return true;
        }
        else if (dongia.value == "") {
            document.getElementById('err_ten').style.display = 'inline';
            return true;
        }

            
        else if(isNaN(duongkinhmat.value)==true)
        {
            alert('Bạn cần nhập giá trị kiểu số');
            return true;
        }
        else {
            return false;
        }
        
    }
</script>
