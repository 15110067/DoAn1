namespace QuanLyBanDTDD
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.txtSDT = new MetroFramework.Controls.MetroTextBox();
            this.txtDiaChi = new MetroFramework.Controls.MetroTextBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.txtMaKH = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.tabDanhSach = new MetroFramework.Controls.MetroTabPage();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            this.tabTimKiem = new MetroFramework.Controls.MetroTabPage();
            this.txtTimSDT = new MetroFramework.Controls.MetroTextBox();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.txtTimTen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dgvTim = new MetroFramework.Controls.MetroGrid();
            this.groupThongTin.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_plus_24;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(20, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_refresh_24;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(384, 203);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 30);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_unavailable_24;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(529, 203);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 30);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_edit_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(145, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyBanDTDD.Properties.Resources.icons8_save_24;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(268, 203);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 30);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.txtSDT);
            this.groupThongTin.Controls.Add(this.txtDiaChi);
            this.groupThongTin.Controls.Add(this.txtTen);
            this.groupThongTin.Controls.Add(this.txtMaKH);
            this.groupThongTin.Controls.Add(this.metroLabel4);
            this.groupThongTin.Controls.Add(this.metroLabel5);
            this.groupThongTin.Controls.Add(this.metroLabel2);
            this.groupThongTin.Controls.Add(this.metroLabel1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTin.Location = new System.Drawing.Point(20, 60);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(577, 129);
            this.groupThongTin.TabIndex = 11;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thông tin khách hàng";
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.CustomButton.Image = null;
            this.txtSDT.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtSDT.CustomButton.Name = "";
            this.txtSDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDT.CustomButton.TabIndex = 1;
            this.txtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDT.CustomButton.UseSelectable = true;
            this.txtSDT.CustomButton.Visible = false;
            this.txtSDT.Lines = new string[0];
            this.txtSDT.Location = new System.Drawing.Point(417, 82);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(140, 23);
            this.txtSDT.TabIndex = 11;
            this.txtSDT.UseSelectable = true;
            this.txtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.CustomButton.Image = null;
            this.txtDiaChi.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtDiaChi.CustomButton.Name = "";
            this.txtDiaChi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiaChi.CustomButton.TabIndex = 1;
            this.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiaChi.CustomButton.UseSelectable = true;
            this.txtDiaChi.CustomButton.Visible = false;
            this.txtDiaChi.Lines = new string[0];
            this.txtDiaChi.Location = new System.Drawing.Point(417, 35);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.ShortcutsEnabled = true;
            this.txtDiaChi.Size = new System.Drawing.Size(140, 23);
            this.txtDiaChi.TabIndex = 10;
            this.txtDiaChi.UseSelectable = true;
            this.txtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiaChi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(137, 78);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(140, 23);
            this.txtTen.TabIndex = 9;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.CustomButton.Image = null;
            this.txtMaKH.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtMaKH.CustomButton.Name = "";
            this.txtMaKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKH.CustomButton.TabIndex = 1;
            this.txtMaKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKH.CustomButton.UseSelectable = true;
            this.txtMaKH.CustomButton.Visible = false;
            this.txtMaKH.Lines = new string[0];
            this.txtMaKH.Location = new System.Drawing.Point(137, 35);
            this.txtMaKH.MaxLength = 32767;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.SelectionLength = 0;
            this.txtMaKH.SelectionStart = 0;
            this.txtMaKH.ShortcutsEnabled = true;
            this.txtMaKH.Size = new System.Drawing.Size(140, 23);
            this.txtMaKH.TabIndex = 8;
            this.txtMaKH.UseSelectable = true;
            this.txtMaKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(320, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Số điện thoại:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(320, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Địa chỉ:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Tên khách hàng:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã khách hàng:";
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.tabDanhSach);
            this.metroTab.Controls.Add(this.tabTimKiem);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTab.Location = new System.Drawing.Point(20, 224);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 0;
            this.metroTab.Size = new System.Drawing.Size(577, 292);
            this.metroTab.TabIndex = 10;
            this.metroTab.UseSelectable = true;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.dgv);
            this.tabDanhSach.HorizontalScrollbarBarColor = true;
            this.tabDanhSach.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDanhSach.HorizontalScrollbarSize = 10;
            this.tabDanhSach.Location = new System.Drawing.Point(4, 38);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(569, 250);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "Danh sách nhân viên";
            this.tabDanhSach.VerticalScrollbarBarColor = true;
            this.tabDanhSach.VerticalScrollbarHighlightOnWheel = false;
            this.tabDanhSach.VerticalScrollbarSize = 10;
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(0, 3);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(569, 247);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.txtTimSDT);
            this.tabTimKiem.Controls.Add(this.btnTim);
            this.tabTimKiem.Controls.Add(this.txtTimTen);
            this.tabTimKiem.Controls.Add(this.metroLabel8);
            this.tabTimKiem.Controls.Add(this.dgvTim);
            this.tabTimKiem.HorizontalScrollbarBarColor = true;
            this.tabTimKiem.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTimKiem.HorizontalScrollbarSize = 10;
            this.tabTimKiem.Location = new System.Drawing.Point(4, 38);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.Size = new System.Drawing.Size(569, 250);
            this.tabTimKiem.TabIndex = 1;
            this.tabTimKiem.Text = "Tìm kiếm thông tin";
            this.tabTimKiem.VerticalScrollbarBarColor = true;
            this.tabTimKiem.VerticalScrollbarHighlightOnWheel = false;
            this.tabTimKiem.VerticalScrollbarSize = 10;
            // 
            // txtTimSDT
            // 
            // 
            // 
            // 
            this.txtTimSDT.CustomButton.Image = null;
            this.txtTimSDT.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtTimSDT.CustomButton.Name = "";
            this.txtTimSDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimSDT.CustomButton.TabIndex = 1;
            this.txtTimSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimSDT.CustomButton.UseSelectable = true;
            this.txtTimSDT.CustomButton.Visible = false;
            this.txtTimSDT.Lines = new string[0];
            this.txtTimSDT.Location = new System.Drawing.Point(0, 99);
            this.txtTimSDT.MaxLength = 32767;
            this.txtTimSDT.Name = "txtTimSDT";
            this.txtTimSDT.PasswordChar = '\0';
            this.txtTimSDT.PromptText = "Tìm theo số điện thoại";
            this.txtTimSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimSDT.SelectedText = "";
            this.txtTimSDT.SelectionLength = 0;
            this.txtTimSDT.SelectionStart = 0;
            this.txtTimSDT.ShortcutsEnabled = true;
            this.txtTimSDT.Size = new System.Drawing.Size(142, 23);
            this.txtTimSDT.TabIndex = 14;
            this.txtTimSDT.UseSelectable = true;
            this.txtTimSDT.WaterMark = "Tìm theo số điện thoại";
            this.txtTimSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimSDT.TextChanged += new System.EventHandler(this.txtTimSDT_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(0, 138);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(142, 23);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseSelectable = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimTen
            // 
            // 
            // 
            // 
            this.txtTimTen.CustomButton.Image = null;
            this.txtTimTen.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtTimTen.CustomButton.Name = "";
            this.txtTimTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimTen.CustomButton.TabIndex = 1;
            this.txtTimTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimTen.CustomButton.UseSelectable = true;
            this.txtTimTen.CustomButton.Visible = false;
            this.txtTimTen.Lines = new string[0];
            this.txtTimTen.Location = new System.Drawing.Point(0, 61);
            this.txtTimTen.MaxLength = 32767;
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.PasswordChar = '\0';
            this.txtTimTen.PromptText = "Tìm theo tên khách hàng";
            this.txtTimTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimTen.SelectedText = "";
            this.txtTimTen.SelectionLength = 0;
            this.txtTimTen.SelectionStart = 0;
            this.txtTimTen.ShortcutsEnabled = true;
            this.txtTimTen.Size = new System.Drawing.Size(142, 23);
            this.txtTimTen.TabIndex = 8;
            this.txtTimTen.UseSelectable = true;
            this.txtTimTen.WaterMark = "Tìm theo tên khách hàng";
            this.txtTimTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 29);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(144, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Nhập thông tin cần tìm";
            // 
            // dgvTim
            // 
            this.dgvTim.AllowUserToResizeRows = false;
            this.dgvTim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTim.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTim.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTim.EnableHeadersVisualStyles = false;
            this.dgvTim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTim.Location = new System.Drawing.Point(150, 0);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTim.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(419, 250);
            this.dgvTim.TabIndex = 3;
            this.dgvTim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTim_CellDoubleClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 536);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.metroTab);
            this.Name = "frmKhachHang";
            this.Text = "KHÁCH HÀNG";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            this.metroTab.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabTimKiem.ResumeLayout(false);
            this.tabTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupThongTin;
        private MetroFramework.Controls.MetroTextBox txtSDT;
        private MetroFramework.Controls.MetroTextBox txtDiaChi;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroTextBox txtMaKH;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTabPage tabDanhSach;
        private MetroFramework.Controls.MetroGrid dgv;
        private MetroFramework.Controls.MetroTabPage tabTimKiem;
        private MetroFramework.Controls.MetroTextBox txtTimTen;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid dgvTim;
        private MetroFramework.Controls.MetroButton btnTim;
        private MetroFramework.Controls.MetroTextBox txtTimSDT;
    }
}