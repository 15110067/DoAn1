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
    public partial class frmKhachHang : MetroForm
    {
        DataTable dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        bool Them;
        string err;
        BLKhachHang bl = new BLKhachHang();
        public static string makh, tenkh;

        // Khai báo biến traloi
        DialogResult traloi;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.Lay();
                dt = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dt;
                // Thay đổi độ rộng cột
                dgv.AutoResizeColumns();
                //Xóa trống các đối tượng trong Panel
                this.txtMaKH.ResetText();
                this.txtTen.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSua.Enabled = false;
                this.btnHuy.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnCapNhat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Xem lại kết nối với SQL Server");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtTen.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;

            dt = new DataTable();
            dt.Clear();

            DataSet ds = bl.DemKH();
            dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
                this.txtMaKH.Text = "KH" + (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            this.dgv_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            // Không cho thao tác trên txtMaNV
            this.txtMaKH.Enabled = false;
            // Đưa con trỏ đến txtTen
            this.txtTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    bl.Them(this.txtMaKH.Text, this.txtTen.Text, this.txtDiaChi.Text, this.txtSDT.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");

                    if(FrmMain.themHDB == true)
                    {
                        this.Hide();
                        frmHoaDonBan frmHDB = new frmHoaDonBan();
                        frmHDB.ShowDialog();
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
                bl.CapNhat(this.txtMaKH.Text, this.txtTen.Text, this.txtDiaChi.Text, this.txtSDT.Text, ref err);
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaKH.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgv.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text = dgv.Rows[r].Cells[3].Value.ToString();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.isNVK == true)
                btnThem.Enabled = false;
            else if (frmDangNhap.isNV == true)
                btnThem.Enabled = true;
            else
                btnThem.Enabled = true;

            LoadData();

            if (FrmMain.themHDB == true)
                metroTab.SelectedTab = tabTimKiem;
            else
                metroTab.SelectedTab = tabDanhSach;
           
            this.txtMaKH.Text = dgv.Rows[0].Cells[0].Value.ToString();
            this.txtTen.Text = dgv.Rows[0].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgv.Rows[0].Cells[2].Value.ToString();
            this.txtSDT.Text = dgv.Rows[0].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgv.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string str = dgv.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin

                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    bl.Xoa(ref err, str);
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
            this.txtMaKH.ResetText();
            this.txtTen.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgv_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataSet ds = bl.timKiembtn(this.txtTimTen.Text, this.txtTimSDT.Text);

            if (this.txtTimTen.Text == "" && this.txtTimSDT.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dữ Liệu Cần Tìm!");
                this.txtTimTen.Focus();
            }

            dt = ds.Tables[0];

            dgvTim.DataSource = dt;
            // Thay đổi độ rộng cột
            dgvTim.AutoResizeColumns();

            if (FrmMain.themHDB == true)
            {
                if (dt.Rows.Count == 0)
                {
                    traloi = MessageBox.Show("Không có dữ liệu cho tên này!!! Bấm nút Thêm để thêm khách hàng mới.", "THÔNG BÁO",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.None);

                    if (traloi == DialogResult.Yes)
                        metroTab.SelectedTab = tabDanhSach;
                    else
                        metroTab.SelectedTab = tabTimKiem;
                }
            }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = bl.timKiemText(this.txtTimTen.Text, this.txtTimSDT.Text);
            dt = ds.Tables[0];
            // Đưa dữ liệu lên DataGridView
            dgvTim.DataSource = dt;
            // Thay đổi độ rộng cột
            dgvTim.AutoResizeColumns();
        }

        private void dgvTim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmMain.themHDB == true)
            {
                makh= dgvTim.Rows[e.RowIndex].Cells[0].Value.ToString();
                tenkh = dgvTim.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Hide();
                frmHoaDonBan frmHDB = new frmHoaDonBan();
                frmHDB.ShowDialog();
            }
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            traloi = MessageBox.Show("Thoát chương trình và quay về màn hình chính ?", "THOÁT CHƯƠNG TRÌNH",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                this.Hide();
                FrmMain frmmain = new FrmMain();
                frmmain.ShowDialog();
            }
        }

        private void txtTimSDT_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = bl.timKiemText(this.txtTimTen.Text, this.txtTimSDT.Text);
            dt = ds.Tables[0];
            // Đưa dữ liệu lên DataGridView
            dgvTim.DataSource = dt;
            // Thay đổi độ rộng cột
            dgvTim.AutoResizeColumns();
        }
    }
}
