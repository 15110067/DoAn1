using QuanLyBanDTDD.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.BSLayer
{
    class BLHoaDonNhap
    {
        DBMain db = null;

        public BLHoaDonNhap()
        {
            db = new DBMain();
        }

        public DataSet Lay()
        {
            return db.ExecuteQueryDataSet("select * from NhapHang", CommandType.Text);
        }

        public bool Them(string mapn, string mancc, string manv, string ngaynhap, int thanhtien, ref string err)
        {
            string sqlString = "Insert Into NhapHang Values(" + "'" + mapn + "','" + mancc + "','" + manv + "','" + ngaynhap + "'," + thanhtien + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string mapn, string mancc, string manv, string ngaynhap, int thanhtien, ref string err)
        {
            string sqlString = "Update NhapHang Set MaNCC='" + mancc + "',MaNV='" + manv + "',NgayNhap='" + ngaynhap + "',ThanhTien=" + thanhtien + " Where MaPN='" + mapn + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string mapn)
        {
            string sqlString = "Delete From NhapHang Where MaPN='" + mapn + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayChiTiet()
        {
            return db.ExecuteQueryDataSet("select * from ChiTiet_HDNhap", CommandType.Text);
        }

        public bool ThemChiTiet(string mapn, string madt, int soluong, int dongia, ref string err)
        {
            string sqlString = "Insert Into ChiTiet_HDNhap Values(" + "'" + mapn + "','" + madt + "'," + soluong + "," + dongia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatChiTiet(string mapn, string madt, int soluong, int dongia, ref string err)
        {
            string sqlString = "Update ChiTiet_HDNhap Set MaDT='" + madt + "',SoLuong=" + soluong + ",DonGia=" + dongia + " Where MaPN='" + mapn + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaChiTiet(ref string err, string mapn)
        {
            string sqlString = "Delete From ChiTiet_HDNhap Where MaPN='" + mapn + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayTenNCC(string mancc)
        {
            return db.ExecuteQueryDataSet("select TenNCC from NhaCungCap where MaNCC = '" + mancc + "'", CommandType.Text);
        }

        public DataSet LayDonGiaNhap(string madt)
        {
            return db.ExecuteQueryDataSet("select DonGia from ChiTiet_HDNhap where MaDT = '" + madt + "'", CommandType.Text);
        }

        public DataSet LayTenDT()
        {
            return db.ExecuteQueryDataSet("select TenDT from DienThoai", CommandType.Text);
        }

        public DataSet LayTenDT(string madt)
        {
            return db.ExecuteQueryDataSet("select TenDT from DienThoai where MaDT = '" + madt + "'", CommandType.Text);
        }

        public DataSet LayMaDT(string ten)
        {
            return db.ExecuteQueryDataSet("select MaDT from DienThoai where TenDT = N'" + ten + "'", CommandType.Text);
        }

        public DataSet LayTenNV(string manv)
        {
            return db.ExecuteQueryDataSet("select HoTen from NhanVien where MaNV = '" + manv + "'", CommandType.Text);
        }

        public DataSet DemHoaDon()
        {
            return db.ExecuteQueryDataSet("select count(*) from NhapHang", CommandType.Text);
        }
    }
}
