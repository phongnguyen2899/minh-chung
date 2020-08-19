using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanDongHo.Class
{
    public class CartItem
    {
        private int idDongHo;
        private string ten;
        private string tenAnh;
        private float donGia;
        private int soLuong;

        public int IdDongHo
        {
            get
            {
                return idDongHo;
            }

            set
            {
                idDongHo = value;
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

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}