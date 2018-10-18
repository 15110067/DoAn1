using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;

namespace QuanLyBanDTDD.BLLayer
{
    class BLHoaDon
    {
        DBMain db = null;

        public BLHoaDon()
        {
            db = new DBMain();
        }

        public DataSet Lay()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text);
        }

        public bool Them(string mahd, string makh, string manv, DateTime ngayban, int thanhtien, ref string err)
        {
            string sqlString = "Insert Into HoaDon Values(" + "'" + mahd + "','" + makh + "','" + manv + "','" + ngayban + "'," + thanhtien + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string mahd, string makh, string manv, DateTime ngayban, int thanhtien, ref string err)
        {
            string sqlString = "Update HoaDon Set MaKH='" + makh + "',MaNV='" + manv + "',NgayBan='" + ngayban + "',ThanhTien=" + thanhtien + " Where MaHD='" + mahd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string mahd)
        {
            string sqlString = "Delete From HoaDon Where MaHD='" + mahd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayChiTiet()
        {
            return db.ExecuteQueryDataSet("select * from ChiTiet_HDBan", CommandType.Text);
        }

        public bool ThemChiTiet(string mahd, string madt, int soluong, int dongia, ref string err)
        {
            string sqlString = "Insert Into ChiTiet_HDBan Values(" + "'" + mahd + "','" + madt + "'," + soluong + "," + dongia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatChiTiet(string mahd, string madt, int soluong, int dongia, ref string err)
        {
            string sqlString = "Update ChiTiet_HDBan Set MaDT='" + madt + "',SoLuong=" + soluong + ",DonGia=" + dongia + " Where mahd='" + mahd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaChiTiet(ref string err, string mahd)
        {
            string sqlString = "Delete From ChiTiet_HDBan Where MaHD='" + mahd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayTenKH(string makh)
        {
            return db.ExecuteQueryDataSet("select TenKH from KhachHang where MaKH = '" + makh + "'", CommandType.Text);
        }

        public DataSet LayTenDTDG(string madt)
        {
            return db.ExecuteQueryDataSet("select TenDT, GiaBan from DienThoai where MaDT = '" + madt + "'", CommandType.Text);
        }

        public DataSet LayTenNV(string manv)
        {
            return db.ExecuteQueryDataSet("select HoTen from NhanVien where MaNV = '" + manv + "'", CommandType.Text);
        }

        public DataSet LayMaDT(string tendt)
        {
            return db.ExecuteQueryDataSet("select MaDT from DienThoai where TenDT = N'" + tendt + "'", CommandType.Text);
        }

        public DataSet LayTenDT()
        {
            return db.ExecuteQueryDataSet("select TenDT from DienThoai'", CommandType.Text);
        }

        public DataSet DemHoaDon()
        {
            return db.ExecuteQueryDataSet("select count(*) from HoaDon", CommandType.Text);
        }
    }
}
