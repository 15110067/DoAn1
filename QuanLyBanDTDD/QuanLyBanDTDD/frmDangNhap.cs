using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using QuanLyBanDTDD.BLLayer;

namespace QuanLyBanDTDD
{
    public partial class frmDangNhap : MetroForm
    {
        DataTable dt= null;

        BLDangNhap bl = new BLDangNhap();
        FrmMain main = new FrmMain();

        public static bool isPoss;    // chủ
        public static bool isNV;      // nhân viên
        public static bool isNVK;     // nhân viên kho
        public static string tenNV, maNV;
        public static bool isLogin;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                KiemTra();
                TenNguoiDung();
                LayMaNV();
                isLogin = true;

                FrmMain main = new FrmMain();
                this.Visible = false;
                main.ShowDialog();
            }
            else
            {
                lblSai.Visible = true;
                txtTenDangNhap.ResetText();
                txtMatKhau.ResetText();
            }
        }

        private void KiemTra()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.KiemTra(txtTenDangNhap.Text, txtMatKhau.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                string maNV = dt.Rows[0][0].ToString(); // mã nhân viên lấy từ CSDL
                string maCat = maNV.Substring(0, 2);    // cắt mã xét các chữ cái đầu để phân quyền

                if (maCat == "CH")
                {
                    isPoss = true;
                    isNV = false;
                    isNVK = false;
                }
                else if (maCat == "NV")
                {
                    isNV = true;
                    isPoss = false;
                    isNVK = false;
                }
                else
                {
                    isNVK = true;
                    isPoss = false;
                    isNV = false;
                }
            }
        }

        private void TenNguoiDung()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.LayTen(txtTenDangNhap.Text, txtMatKhau.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                tenNV = dt.Rows[0][0].ToString(); // mã nhân viên lấy từ CSDL
            }
        }

        private void LayMaNV()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.KiemTra(txtTenDangNhap.Text, txtMatKhau.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                maNV = dt.Rows[0][0].ToString(); // mã nhân viên lấy từ CSDL
            }
        }
    }
}
