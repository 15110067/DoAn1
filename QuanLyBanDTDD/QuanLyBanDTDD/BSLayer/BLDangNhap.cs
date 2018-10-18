using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanDTDD.DBLayer; // sử dụng folder DBLayer trong project DoAn1

namespace QuanLyBanDTDD.BLLayer
{
    class BLDangNhap
    {
        DBMain db = null;

        public BLDangNhap() // khởi tạo Constructor
        {
            db = new DBMain();
        }

        public DataSet DangNhap(string taikhoan, string matkhau)
        {
            return db.ExecuteQueryDataSet("select * from TaiKhoan where UserName='" + taikhoan + "' and Password='" + matkhau + "'", CommandType.Text);
        }

        public DataSet KiemTra(string taikhoan, string matkhau)
        {
            return db.ExecuteQueryDataSet("select MaNV from TaiKhoan where UserName = '" + taikhoan + "' and Password = '" + matkhau + "'", CommandType.Text);
        }

        public DataSet LayTen(string taikhoan, string matkhau)
        {
            return db.ExecuteQueryDataSet("select NhanVien.HoTen from nhanvien join TaiKhoan on nhanvien.MaNV = TaiKhoan.MaNV Where TaiKhoan.UserName = '" + taikhoan + "' and TaiKhoan.Password = '" + matkhau + "'", CommandType.Text);
        }

        public DataSet DoiMatKhau(string taikhoan, string matkhau)
        {
            return db.ExecuteQueryDataSet("Update TaiKhoan Set Password =N'" + matkhau + "' where UserName=N'" + taikhoan + "'", CommandType.Text);
        }
    }
}