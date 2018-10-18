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
using QuanLyBanDTDD.BSLayer;
using System.Data.SqlClient;

namespace QuanLyBanDTDD
{
    public partial class FrmMain : MetroForm
    {
        DataTable dt = null;
        BLBackupAndRestore bl = new BLBackupAndRestore();
        public static bool themHDB;
        public static bool themHDN;
        public static bool timkiem;
        private DialogResult traloi;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.isLogin == true)
                DangNhapTool.Enabled = false;

            if (frmDangNhap.isPoss == false && frmDangNhap.isNV == false && frmDangNhap.isNVK == false)
            {
                lblKhongCo.Visible = true;
                lblTen.Visible = false;

                DangXuatTool.Enabled = false;
                DoiMKTool.Enabled = false;
                QLyTool.Enabled = false;
                SaoLuuTool.Enabled = false;
                KhoiPhucTool.Enabled = false;
                QLyDownTool.Enabled = false;
                TKeDownTool.Enabled = false;
            }
            else if (frmDangNhap.isPoss == true || frmDangNhap.isNV == true || frmDangNhap.isNVK == true)
            {
                lblTen.Text = frmDangNhap.tenNV;
                lblTen.Visible = true;
                lblKhongCo.Visible = false;

            }

            if (frmDangNhap.isNV == true)
            {
                QLyTool.Visible = false;
                NhanVienTool.Visible = false;
                HoaDonNhapTool.Visible = false;
                themHDNTool.Visible = false;
                themHDTool.Visible = true;
            }
            else if(frmDangNhap.isNVK == true)
            {
                QLyTool.Visible = false;
                NhanVienTool.Visible = false;
                HoaDonTool.Visible = false;
                themHDNTool.Visible = true;
                themHDTool.Visible = false;
            }
            else
            {
                QLyTool.Visible = true;
                NhanVienTool.Visible = true;
                HoaDonNhapTool.Visible = true;
                themHDNTool.Visible = true;
                themHDTool.Visible = true;
            }
        }

        private void DangNhapTool_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
        }

        private void DangXuatTool_Click(object sender, EventArgs e)
        {
            //trả về giá trị ban đầu  
            frmDangNhap.isPoss = false;
            frmDangNhap.isNV = false;
            frmDangNhap.isNVK = false;
            frmDangNhap.isLogin = false;

            //cho các lbl trở lại trạng thái ban đầu
            lblKhongCo.Visible = false;
            lblTen.Visible = false;

            this.Visible = false;

            //mở form đăng nhập
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.ShowDialog();

            //mở các tool
            QLyTool.Visible = true;
            NhanVienTool.Visible = true;
            HoaDonNhapTool.Visible = true;
            HoaDonTool.Visible = true;
            DangXuatTool.Enabled = true;
            DoiMKTool.Enabled = true;
            SaoLuuTool.Enabled = true;
            KhoiPhucTool.Enabled = true;
            QLyDownTool.Enabled = true;
            TKeDownTool.Enabled = true;
        }

        private void DoiMKTool_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void SaoLuuTool_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.Backup();
                MessageBox.Show("Sao lưu thành công!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Sao lưu không thành công! Thử lại.");
            }
        }

        private void KhoiPhucTool_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.Restore();
                MessageBox.Show("Khôi phục dữ liệu thành công!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Sao lưu dữ liệu không thành công! Thử lại.");
            }
        }

        private void QLyTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLNguoiDung frmQLNguoi = new frmQLNguoiDung();
            frmQLNguoi.ShowDialog();
        }

        private void SanPhamTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSanPham frmSPham = new frmSanPham();
            frmSPham.ShowDialog();
        }

        private void KhachHangTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang frmKhHang = new frmKhachHang();
            frmKhHang.ShowDialog();
        }

        private void HoaDonTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonBan frmHoaDon = new frmHoaDonBan();
            frmHoaDon.ShowDialog();
        }

        private void HoaDonNhapTool_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHoaDonNhap frmHDNhap = new frmHoaDonNhap();
            frmHDNhap.ShowDialog();
        }

        private void NhanVienTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVien frmNVien = new FrmNhanVien();
            frmNVien.ShowDialog();
        }

        private void themHDTool_Click(object sender, EventArgs e)
        {
            themHDB = true;
            themHDN = false;
            this.Hide();
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }

        private void themHDNTool_Click(object sender, EventArgs e)
        {
            themHDN = true;
            themHDB = false;
            this.Hide();
            frmNhacCungCap frmNCC = new frmNhacCungCap();
            frmNCC.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DienThoaiTool_Click(object sender, EventArgs e)
        {
            timkiem = true;
            this.Hide();
            frmSanPham frmSPham = new frmSanPham();
            frmSPham.ShowDialog();
        }

        private void DoanhThuTool_Click(object sender, EventArgs e)
        {

        }

        private void DSKHTool_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmDSKH frmds = new FrmDSKH();
            frmds.ShowDialog();
        }

        private void DSNVTool_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmDSNV frmds = new FrmDSNV();
            frmds.ShowDialog();
        }
    }
}
