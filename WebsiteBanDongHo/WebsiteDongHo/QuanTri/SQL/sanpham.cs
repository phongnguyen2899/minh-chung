using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace WebsiteDongHo
{
    public class sanpham
    {
        public static DataTable thongtin_sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("DongHo_select");
            cmd.CommandType = CommandType.StoredProcedure;
            return sqldatabase.GetData(cmd);
        }

        public static void DongHo_Inser(string ten, string tenanh, string dongia, string xuatxu, string tenth, string kieudang, string nangluong, string chongnuoc, string chatlieumat, string duongkinhmat, string chatlieuday)
        {
            OleDbCommand cmd = new OleDbCommand("DongHo_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@tenAnh", tenanh);
            cmd.Parameters.AddWithValue("@donGia", dongia);
            cmd.Parameters.AddWithValue("@xuatXu", xuatxu);
            cmd.Parameters.AddWithValue("@tenThuongHieu", tenth);
            cmd.Parameters.AddWithValue("@kieuDang", kieudang);
            cmd.Parameters.AddWithValue("@nangLuong", nangluong);
            cmd.Parameters.AddWithValue("@chongNuoc", chongnuoc);
            cmd.Parameters.AddWithValue("@chatLieuMat", chatlieumat);
            cmd.Parameters.AddWithValue("@@duongkinhmat", duongkinhmat);
            cmd.Parameters.AddWithValue("@chatLieuDay", chatlieuday);
            sqldatabase.ExecuteNoneQuery(cmd);
        }

        public static void DongHo_delete(string ma)
        {
            OleDbCommand cmd = new OleDbCommand("DongHo_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            sqldatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable Dongho_select_byid(string id)
        {
            OleDbCommand cmd = new OleDbCommand("Dongho_select_byID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", id);
            return sqldatabase.GetData(cmd);
        }

        public static void DongHo_update(string ma, string ten, string tenanh, string dongia, string xuatxu, string tenth, string kieudang, string nangluong, string chongnuoc, string chatlieumat, string duongkinhmat, string chatlieuday)
        {
            OleDbCommand cmd = new OleDbCommand("DongHo_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@tenAnh", tenanh);
            cmd.Parameters.AddWithValue("@donGia", dongia);
            cmd.Parameters.AddWithValue("@xuatXu", xuatxu);
            cmd.Parameters.AddWithValue("@tenThuongHieu", tenth);
            cmd.Parameters.AddWithValue("@kieuDang", kieudang);
            cmd.Parameters.AddWithValue("@nangLuong", nangluong);
            cmd.Parameters.AddWithValue("@chongNuoc", chongnuoc);
            cmd.Parameters.AddWithValue("@chatLieuMat", chatlieumat);
            cmd.Parameters.AddWithValue("@@duongkinhmat", duongkinhmat);
            cmd.Parameters.AddWithValue("@chatLieuDay", chatlieuday);
            sqldatabase.ExecuteNoneQuery(cmd);
        }
    }
}