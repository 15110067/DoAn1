using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;

namespace QuanLyBanDTDD.BSLayer
{
    class BLNhanVien
    {
        DBMain db = null;

        public BLNhanVien()
        {
            db = new DBMain();
        }

        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public bool Them(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values(" + "'" + manv + "',N'" + hoten + "',N'" + ngaysinh  + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "',N'" + cmnd + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, ref string err)
        {
            string sqlString = "Update NhanVien Set HoTen=N'" + hoten + "',NgaySinh=N'" + ngaysinh + "',GioiTinh=N'" + gioitinh + "',DiaChi=N'" + diachi + "',SDT=N'" + sdt + "',CMND=N'" + cmnd + "' Where MaNV='" + manv + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(string MaNV, ref string err)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayUser()
        {
            return db.ExecuteQueryDataSet("select TaiKhoan.MaNV, HoTen, UserName from NhanVien join TaiKhoan on NhanVien.MaNV = TaiKhoan.MaNV order by MaNV", CommandType.Text);
        }

        public bool XoaUser(string MaNV, ref string err)
        {
            string sqlString = "Delete From TaiKhoan Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
