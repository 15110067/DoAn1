using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;

namespace QuanLyBanDTDD.BLLayer
{
    class BLImport
    {
        DBMain dbImport = null;

        public BLImport()
        {
            dbImport = new DBMain();
        }

        public DataSet LayNhapHang()
        {
            return dbImport.ExecuteQueryDataSet("select * from NhapHang", CommandType.Text);
        }

        public bool Them(string mapn, string mancc, string manv, DateTime ngaynhap, int thanhtien, ref string err)
        {
            string sqlString = "Insert Into NhapHang Values(" + "'" + mapn + "',N'" + mancc + "',N'" + manv + "',N'" + ngaynhap + "',N'" + thanhtien + "')";
            return dbImport.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhat(string mapn, string mancc, string manv, DateTime ngaynhap, int thanhtien, ref string err)
        {
            string sqlString = "Update NhapHang Set MaNCC=N'" + mancc + "',MaNV=N'" + manv + "',NgayNhap=N'" + ngaynhap + "',ThanhTien=N'" + thanhtien + "' Where MaPN='" + mapn + "'";
            return dbImport.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Xoa(ref string err, string mapn)
        {
            string sqlString = "Delete From BaoHanh Where MaPN='" + mapn + "'";
            return dbImport.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
