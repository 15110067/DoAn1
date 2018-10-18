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
    public partial class FrmNhanVien : MetroForm
    {
        DataTable dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        bool Them;
        string err;
        BLNhanVien bl= new BLNhanVien();
        string gioiTinh;
        // Khai báo biến traloi
        DialogResult traloi;

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.LayNhanVien();
                dt = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dt;
                // Thay đổi độ rộng cột
                dgv.AutoResizeColumns();
                //Xóa trống các đối tượng trong Panel
                this.txtMaNV.ResetText();
                this.txtTen.ResetText();
                this.ngaySinh.ResetText();
                this.txtSDT.ResetText();
                this.txtDiaChi.ResetText();
                this.txtCMND.ResetText();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaNV.ResetText();
            this.txtTen.ResetText();
            this.ngaySinh.ResetText();
            this.txtSDT.ResetText();
            this.txtDiaChi.ResetText();
            this.txtCMND.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (radioNam.Checked == true)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";

            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    bl.Them(this.txtMaNV.Text, this.txtTen.Text, this.ngaySinh.Value,
                        gioiTinh , this.txtDiaChi.Text, this.txtSDT.Text, this.txtCMND.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                bl.CapNhat(this.txtMaNV.Text, this.txtTen.Text, this.ngaySinh.Value,
                        this.radioNam.Text, this.txtDiaChi.Text, this.txtSDT.Text, this.txtCMND.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
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
            this.btnXoa.Enabled = false;
            // Không cho thao tác trên txtMaNV
            this.txtMaNV.Enabled = false;
            // Đưa con trỏ đến txtTen
            this.txtTen.Focus();
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
                    bl.Xoa(str, ref err);
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
            this.txtMaNV.ResetText();
            this.txtTen.ResetText();
            this.ngaySinh.ResetText();
            this.txtSDT.ResetText();
            this.txtDiaChi.ResetText();
            this.txtCMND.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            dgv_CellClick(null, null);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.ngaySinh.Text = dgv.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.txtSDT.Text = dgv.Rows[r].Cells[5].Value.ToString();
            this.txtCMND.Text = dgv.Rows[r].Cells[6].Value.ToString();
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
