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
using QuanLyBanDTDD.BLLayer;

namespace QuanLyBanDTDD
{
    public partial class frmHoaDonNhap : MetroForm
    {
        DataTable dt = null;
        DataTable dt1 = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        bool Them;
        string err;
        int index, soluong;
        BLHoaDonNhap bl = new BLHoaDonNhap();
        BLDienThoai bl2 = new BLDienThoai();

        // Khai báo biến traloi
        DialogResult traloi;

        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt1 = new DataTable();
                dt.Clear();
                dt1.Clear();

                DataSet ds = bl.Lay();
                DataSet ds1 = bl.LayChiTiet();
                dt = ds.Tables[0];
                dt1 = ds1.Tables[0];

                // Đưa dữ liệu lên DataGridView
                dgvHoaDon.DataSource = dt;
                dgvChiTiet.DataSource = dt1;

                // Thay đổi độ rộng cột
                dgvHoaDon.AutoResizeColumns();
                dgvChiTiet.AutoResizeColumns();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Xem lại kết nối với SQL Server");
            }
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();

            this.txtMaPN.Text = dgvHoaDon.Rows[0].Cells[0].Value.ToString();
            this.txtMaNCC.Text = dgvHoaDon.Rows[0].Cells[1].Value.ToString();
            this.txtMaNV.Text = dgvHoaDon.Rows[0].Cells[2].Value.ToString();
            this.ngayNhap.Text = dgvHoaDon.Rows[0].Cells[3].Value.ToString();
            this.txtThanhTien.Text = dgvHoaDon.Rows[0].Cells[4].Value.ToString();
            this.txtMaDT.Text = dgvChiTiet.Rows[0].Cells[1].Value.ToString();
            this.nbSoLuong.Text = dgvChiTiet.Rows[0].Cells[2].Value.ToString();
            this.txtDonGia.Text = dgvChiTiet.Rows[0].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaPN.Enabled = false;
            this.txtMaNCC.Text = frmNhacCungCap.mancc;
            this.txtMaNV.Text = frmDangNhap.maNV;
            this.txtMaDT.Text = frmSanPham.madt;
            this.txtTenNCC.Text = frmNhacCungCap.tenncc;
            this.txtTenNV.Text = frmDangNhap.tenNV.Trim();

            dt = new DataTable();
            dt.Clear();

            DataSet ds2 = bl.LayTenDT();
            dt = ds2.Tables[0];

            if(dt.Rows.Count > 0)
            {
                cbbTenDt.DataSource = dt;
                cbbTenDt.DisplayMember = "TenDT";
                cbbTenDt.ValueMember = "TenDT";
            }

            this.nbSoLuong.Value = 1;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            dt = new DataTable();
            dt.Clear();

            DataSet ds = bl.DemHoaDon();
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
                this.txtMaPN.Text = "NCC" + (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // Không cho thao tác trên txtMaNV
            this.txtMaPN.Enabled = false;
            this.txtMaNCC.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.txtMaDT.Enabled = false;
            // Đưa con trỏ đến txtTen
            this.txtTenNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    bl.Them(this.txtMaPN.Text, this.txtMaNCC.Text, this.txtMaNV.Text,
                                this.ngayNhap.Text, Convert.ToInt32(this.txtThanhTien.Text), ref err);

                    bl.ThemChiTiet(this.txtMaPN.Text, this.txtMaDT.Text, Convert.ToInt32(this.nbSoLuong.Text),
                        Convert.ToInt32(this.txtDonGia.Text), ref err);

                    dt = new DataTable();
                    dt.Clear();

                    DataSet ds = bl2.LaySoLuong(txtMaDT.Text);
                    dt = ds.Tables[0];

                    if(dt.Rows.Count > 0)
                    {
                        soluong = Convert.ToInt32(dt.Rows[0][0].ToString());
                    }

                    bl2.SuaSoLuong(txtMaDT.Text, soluong + Convert.ToInt32(this.nbSoLuong.Text));
                    
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");

                    if (FrmMain.themHDN == true)
                    {
                        this.Hide();
                        FrmMain main = new FrmMain();
                        main.ShowDialog();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                bl.CapNhat(this.txtMaPN.Text, this.txtMaNCC.Text, this.txtMaNV.Text,
                                this.ngayNhap.Text, Convert.ToInt32(this.txtThanhTien.Text), ref err);
                bl.CapNhatChiTiet(this.txtMaPN.Text, this.txtMaDT.Text, Convert.ToInt32(this.nbSoLuong.Text),
                        Convert.ToInt32(this.txtDonGia.Text), ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvHoaDon.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string str = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                string str1 = dgvChiTiet.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin

                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    bl.Xoa(ref err, str);
                    bl.XoaChiTiet(ref err, str1);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaPN.ResetText();
            this.txtMaNCC.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaDT.ResetText();
            this.txtTenNCC.ResetText();
            this.txtTenNV.ResetText();
            this.cbbTenDt.ResetText();
            this.nbSoLuong.ResetText();
            this.txtDonGia.ResetText();
            this.txtThanhTien.ResetText();
            this.ngayNhap.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaPN.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaNCC.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            this.ngayNhap.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            this.txtThanhTien.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
            this.txtMaDT.Text = dgvChiTiet.Rows[r].Cells[1].Value.ToString();
            this.nbSoLuong.Text = dgvChiTiet.Rows[r].Cells[2].Value.ToString();
            this.txtDonGia.Text = dgvChiTiet.Rows[r].Cells[3].Value.ToString();

            foreach (DataGridViewRow rows in dgvChiTiet.Rows)
            {
                if (rows.Cells[0].Value.ToString().Equals(txtMaPN.Text))
                {
                    index = rows.Index;
                    break;
                }
            }
            dgvChiTiet.ClearSelection();
            dgvChiTiet.Rows[index].Selected = true;
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChiTiet.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaPN.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaNCC.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            this.ngayNhap.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            this.txtThanhTien.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
            this.txtMaDT.Text = dgvChiTiet.Rows[r].Cells[1].Value.ToString();
            this.nbSoLuong.Text = dgvChiTiet.Rows[r].Cells[2].Value.ToString();
            this.txtDonGia.Text = dgvChiTiet.Rows[r].Cells[3].Value.ToString();

            foreach (DataGridViewRow rows in dgvHoaDon.Rows)
            {
                if (rows.Cells[0].Value.ToString().Equals(txtMaPN.Text))
                {
                    index = rows.Index;
                    break;
                }
            }
            dgvHoaDon.ClearSelection();
            dgvHoaDon.Rows[index].Selected = true;
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();

            DataSet ds = bl.LayTenNCC(this.txtMaNCC.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                this.txtTenNCC.Text = dt.Rows[0][0].ToString();
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();

            DataSet ds = bl.LayTenNV(this.txtMaNV.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                this.txtTenNV.Text = dt.Rows[0][0].ToString();
            }
        }

        private void nbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (nbSoLuong.Value == 0)
                txtThanhTien.Text = Convert.ToString((Convert.ToInt32(nbSoLuong.Text) - 1) * Convert.ToInt32(txtDonGia.Text));
            else if (nbSoLuong.Value == 1)
                txtThanhTien.Text = Convert.ToString((Convert.ToInt32(nbSoLuong.Text) + 1) * Convert.ToInt32(txtDonGia.Text));
            else
                txtThanhTien.Text = Convert.ToString((Convert.ToInt32(nbSoLuong.Text) + 1) * Convert.ToInt32(txtDonGia.Text));
        }

        private void cbbTenDt_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = bl.LayMaDT(this.cbbTenDt.Text);
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                this.txtMaDT.Text = dt.Rows[0][0].ToString();
            }
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            dt1 = new DataTable();
            dt1.Clear();

            DataSet ds = bl.LayTenDT(this.txtMaDT.Text);
            DataSet ds1 = bl.LayDonGiaNhap(this.txtMaDT.Text);

            dt = ds.Tables[0];
            dt1 = ds1.Tables[0];

            if (dt.Rows.Count > 0)
            {
                this.cbbTenDt.Text = dt.Rows[0][0].ToString();
            }

            if (dt1.Rows.Count > 0)
            {
                this.txtDonGia.Text = dt1.Rows[0][0].ToString();
            }
        }
    }
}
