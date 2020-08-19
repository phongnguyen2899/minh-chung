using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebsiteBanDongHo.Class
{
    public class DongHo
    {
        private int id;
        private string ten;
        private float donGia;
        private string tenAnh;
        private string xuatXu;
        private int idthuongHieu;
        private int kieuDang; //1 là đồng hồ nam, 2 là nữ, 3 là đôi, 4 là phụ kiện
        private string nangLuong;
        private string chongNuoc;
        private string chatLieuMat;
        private string duongKinhMat;
        private string chatLieuDay;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public string TenAnh
        {
            get
            {
                return tenAnh;
            }

            set
            {
                tenAnh = value;
            }
        }

        public string XuatXu
        {
            get
            {
                return xuatXu;
            }

            set
            {
                xuatXu = value;
            }
        }

        public int IdthuongHieu
        {
            get
            {
                return idthuongHieu;
            }

            set
            {
                idthuongHieu = value;
            }
        }

        public int KieuDang
        {
            get
            {
                return kieuDang;
            }

            set
            {
                kieuDang = value;
            }
        }

        public string NangLuong
        {
            get
            {
                return nangLuong;
            }

            set
            {
                nangLuong = value;
            }
        }

        public string ChongNuoc
        {
            get
            {
                return chongNuoc;
            }

            set
            {
                chongNuoc = value;
            }
        }

        public string ChatLieuMat
        {
            get
            {
                return chatLieuMat;
            }

            set
            {
                chatLieuMat = value;
            }
        }

        public string DuongKinhMat
        {
            get
            {
                return duongKinhMat;
            }

            set
            {
                duongKinhMat = value;
            }
        }

        public string ChatLieuDay
        {
            get
            {
                return chatLieuDay;
            }

            set
            {
                chatLieuDay = value;
            }
        }

        public DongHo(DataRow row)
        {
            Id = (int)row["id"];
            Ten = row["ten"].ToString();
            DonGia = float.Parse(row["donGia"].ToString());
            XuatXu = row["xuatXu"].ToString();
            IdthuongHieu = (int)row["idthuongHieu"];
            KieuDang =(int) row["kieuDang"];
            NangLuong = row["nangLuong"].ToString();
            TenAnh = row["tenAnh"].ToString();
        }

        
    }
}