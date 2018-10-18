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
    public partial class frmQLNguoiDung : MetroForm
    {
        DataTable dt = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 

        string err;
        BLNhanVien bl = new BLNhanVien();

        // Khai báo biến traloi
        DialogResult traloi;

        public frmQLNguoiDung()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet ds = bl.LayUser();
                dt = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv.DataSource = dt;
                // Thay đổi độ rộng cột
                dgv.AutoResizeColumns();
                //Xóa trống các đối tượng trong Panel
                this.txtMaNV.ResetText();
                this.txtTen.ResetText();
                this.txtTenTK.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnHuy.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnXoa.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung. Xem lại kết nối với SQL Server");
            }
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
                traloi = MessageBox.Show("Chắc xóa người dùng này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    bl.XoaUser(str, ref err);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa người dùng!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không xóa người dùng!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNV.ResetText();
            this.txtTen.ResetText();
            this.txtTenTK.ResetText();

            this.btnXoa.Enabled = true;

            this.btnHuy.Enabled = false;
            dgv_CellClick(null, null);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.txtTenTK.Text = dgv.Rows[r].Cells[2].Value.ToString();
        }

        private void frmQLNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmQLNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain frmain = new FrmMain();
            frmain.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmmain = new FrmMain();
            frmmain.ShowDialog();
        }
    }
}
