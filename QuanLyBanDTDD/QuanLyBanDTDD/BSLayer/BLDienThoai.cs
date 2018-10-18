using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanDTDD.DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanDTDD.BLLayer
{
    class BLDienThoai
    {
        DBMain db = null;

        public BLDienThoai()
        {
            db = new DBMain();
        }

        public DataSet LayDienThoai()
        {
            return db.ExecuteQueryDataSet("select * from DienThoai", CommandType.Text);
        }

        public bool Them(string MaDT, string TenDT, byte[] image, int GiaBan, string DonViTinh, int SoLuongCon, string MoTa)
        {
            return db.MyExecuteNonQuery("pdProductsInsert", CommandType.StoredProcedure, new SqlParameter("@MaDT", MaDT), new SqlParameter("@TenDT", TenDT), new SqlParameter("@image", image), new SqlParameter("@GiaBan", GiaBan), new SqlParameter("@DonViTinh", DonViTinh), new SqlParameter("@SoLuongCon", SoLuongCon), new SqlParameter("@MoTa", MoTa));
        }

        public bool SuaDienThoai(string MaDT, string TenDT, byte[] image, int GiaBan, string DonViTinh, int SoLuongCon, string MoTa)
        {
            return db.MyExecuteNonQuery("pdProductsEdit", CommandType.StoredProcedure, new SqlParameter("@TenDT", TenDT), new SqlParameter("@image", image), new SqlParameter("@GiaBan", GiaBan), new SqlParameter("@DonViTinh", DonViTinh), new SqlParameter("@SoLuongCon", SoLuongCon), new SqlParameter("@MoTa", MoTa), new SqlParameter("@MaDT", MaDT));
        }

        public bool Xoa(ref string err, string madt)
        {
            string sqlString = "Delete From DienThoai Where MaDT='" + madt + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        
        public DataSet DemSP()
        {
            return db.ExecuteQueryDataSet("select count(*) from DienThoai", CommandType.Text);
        }

        public DataSet SuaSoLuong(string ma, int soluong)
        {
            return db.ExecuteQueryDataSet("update DienThoai set SoLuongCon = " + soluong + "Where MaDT='" + ma + "'", CommandType.Text);
        }

        public DataSet LaySoLuong(string ma)
        {
            return db.ExecuteQueryDataSet("select soluongcon from DienThoai where MaDT = '" + ma + "'", CommandType.Text);
        }
    }
}
