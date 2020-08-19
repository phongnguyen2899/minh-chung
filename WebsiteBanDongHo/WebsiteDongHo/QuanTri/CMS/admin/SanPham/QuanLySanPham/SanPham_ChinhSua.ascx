<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham_ChinhSua.ascx.cs" Inherits="WebsiteDongHo.cms.admin.SanPham.QuanLySanPham.SanPham_ChinhSua" %>

<div class="themmoisanpham">
<div class="head">Thêm mới chỉnh sửa sản phẩm</div>

    <div>
        <div class="tentruong">Tên</div>
        <div>
            <input type="text" value="" name="ten" class="ip" id="tencs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Ảnh sản phẩm</div>
        <div>
           
            <asp:FileUpload ID="FileUpload1cs" runat="server" CssClass="ip" />
        </div>
    </div>
        <br />
    <div>
        <div class="tentruong">Đơn Giá</div>
        <div>
            <input type="text" value="" name="dongia" class="ip" id="dongiacs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Xuất xứ</div>
        <div>
            <input type="text" value="" name="xuatxu" class="ip" id="xuatxucs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Thương Hiệu</div>
        <div>
            <asp:DropDownList ID="DropDownList1cs" runat="server" CssClass="ip"></asp:DropDownList>
        </div>
    </div>

    <div>
        <div class="tentruong">Kiểu giáng</div>
        <div>
            <input type="text" value="" name="kieudang" class="ip" id="kieudangcs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Năng Lượng</div>
        <div>
            <input type="text" value="" name="nangluong" class="ip" id="nangluongcs" runat="server" />
        </div>
    </div>

    <div>
        <div class="tentruong">Chống Nước</div>
        <div>
            <input type="text" value="" name="chongnuoc" class="ip" id="chongnuoccs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Chất liệu mặt</div>
        <div>
            <input type="text" value="" name="chatlieumat" class="ip" id="chatlieumatcs"  runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Chất liệu dây</div>
        <div>
            <input type="text" value="" name="chatlieuday" class="ip" id="chatlieudaycs" runat="server"/>
        </div>
    </div>

    <div>
        <div class="tentruong">Đường kính mặt</div>
        <div>
            <input type="text" value="" name="duongkinhmat" class="ip" id="duongkinhmatcs" runat="server"/>
        </div>
    </div>


    <div>
        
        <asp:Button ID="Button1cs" runat="server" Text="Chỉnh Sửa" OnClick="Button1cs_Click"/>
    </div>
</div>
   