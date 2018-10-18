namespace QuanLyBanDTDD
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.lblSai = new System.Windows.Forms.Label();
            this.btnDongY = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatKhauCu = new MetroFramework.Controls.MetroTextBox();
            this.txtTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.txtMatKhauMoi = new MetroFramework.Controls.MetroTextBox();
            this.txtXacNhan = new MetroFramework.Controls.MetroTextBox();
            this.lblSai2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSai
            // 
            this.lblSai.AutoSize = true;
            this.lblSai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSai.ForeColor = System.Drawing.Color.Red;
            this.lblSai.Location = new System.Drawing.Point(139, 91);
            this.lblSai.Name = "lblSai";
            this.lblSai.Size = new System.Drawing.Size(261, 15);
            this.lblSai.TabIndex = 11;
            this.lblSai.Text = "Tên đăng nhập / mật khẩu cũ sai. Mời nhập lại!!!";
            this.lblSai.Visible = false;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(450, 171);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(70, 34);
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseSelectable = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanDTDD.Properties.Resources.password_reset_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatKhauCu
            // 
            // 
            // 
            // 
            this.txtMatKhauCu.CustomButton.Image = null;
            this.txtMatKhauCu.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtMatKhauCu.CustomButton.Name = "";
            this.txtMatKhauCu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhauCu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhauCu.CustomButton.TabIndex = 1;
            this.txtMatKhauCu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhauCu.CustomButton.UseSelectable = true;
            this.txtMatKhauCu.CustomButton.Visible = false;
            this.txtMatKhauCu.DisplayIcon = true;
            this.txtMatKhauCu.Icon = ((System.Drawing.Image)(resources.GetObject("txtMatKhauCu.Icon")));
            this.txtMatKhauCu.IconRight = true;
            this.txtMatKhauCu.Lines = new string[0];
            this.txtMatKhauCu.Location = new System.Drawing.Point(347, 63);
            this.txtMatKhauCu.MaxLength = 32767;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '●';
            this.txtMatKhauCu.PromptText = "Mật khẩu cũ";
            this.txtMatKhauCu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.SelectionLength = 0;
            this.txtMatKhauCu.SelectionStart = 0;
            this.txtMatKhauCu.ShortcutsEnabled = true;
            this.txtMatKhauCu.Size = new System.Drawing.Size(173, 23);
            this.txtMatKhauCu.TabIndex = 8;
            this.txtMatKhauCu.UseSelectable = true;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.WaterMark = "Mật khẩu cũ";
            this.txtMatKhauCu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhauCu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.CustomButton.Image = null;
            this.txtTenDangNhap.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtTenDangNhap.CustomButton.Name = "";
            this.txtTenDangNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenDangNhap.CustomButton.TabIndex = 1;
            this.txtTenDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenDangNhap.CustomButton.UseSelectable = true;
            this.txtTenDangNhap.CustomButton.Visible = false;
            this.txtTenDangNhap.DisplayIcon = true;
            this.txtTenDangNhap.Icon = global::QuanLyBanDTDD.Properties.Resources.icons8_customer_24;
            this.txtTenDangNhap.IconRight = true;
            this.txtTenDangNhap.Lines = new string[0];
            this.txtTenDangNhap.Location = new System.Drawing.Point(139, 63);
            this.txtTenDangNhap.MaxLength = 32767;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PromptText = "Tên đăng nhập";
            this.txtTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionLength = 0;
            this.txtTenDangNhap.SelectionStart = 0;
            this.txtTenDangNhap.ShortcutsEnabled = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(187, 23);
            this.txtTenDangNhap.TabIndex = 7;
            this.txtTenDangNhap.UseSelectable = true;
            this.txtTenDangNhap.WaterMark = "Tên đăng nhập";
            this.txtTenDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMatKhauMoi
            // 
            // 
            // 
            // 
            this.txtMatKhauMoi.CustomButton.Image = null;
            this.txtMatKhauMoi.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtMatKhauMoi.CustomButton.Name = "";
            this.txtMatKhauMoi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhauMoi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhauMoi.CustomButton.TabIndex = 1;
            this.txtMatKhauMoi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhauMoi.CustomButton.UseSelectable = true;
            this.txtMatKhauMoi.CustomButton.Visible = false;
            this.txtMatKhauMoi.DisplayIcon = true;
            this.txtMatKhauMoi.Icon = ((System.Drawing.Image)(resources.GetObject("txtMatKhauMoi.Icon")));
            this.txtMatKhauMoi.IconRight = true;
            this.txtMatKhauMoi.Lines = new string[0];
            this.txtMatKhauMoi.Location = new System.Drawing.Point(139, 116);
            this.txtMatKhauMoi.MaxLength = 32767;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PromptText = "Mật khẩu mới";
            this.txtMatKhauMoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.SelectionLength = 0;
            this.txtMatKhauMoi.SelectionStart = 0;
            this.txtMatKhauMoi.ShortcutsEnabled = true;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(187, 23);
            this.txtMatKhauMoi.TabIndex = 12;
            this.txtMatKhauMoi.UseSelectable = true;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.WaterMark = "Mật khẩu mới";
            this.txtMatKhauMoi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhauMoi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtXacNhan
            // 
            // 
            // 
            // 
            this.txtXacNhan.CustomButton.Image = null;
            this.txtXacNhan.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtXacNhan.CustomButton.Name = "";
            this.txtXacNhan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtXacNhan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtXacNhan.CustomButton.TabIndex = 1;
            this.txtXacNhan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtXacNhan.CustomButton.UseSelectable = true;
            this.txtXacNhan.CustomButton.Visible = false;
            this.txtXacNhan.DisplayIcon = true;
            this.txtXacNhan.Icon = ((System.Drawing.Image)(resources.GetObject("txtXacNhan.Icon")));
            this.txtXacNhan.IconRight = true;
            this.txtXacNhan.Lines = new string[0];
            this.txtXacNhan.Location = new System.Drawing.Point(347, 116);
            this.txtXacNhan.MaxLength = 32767;
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '●';
            this.txtXacNhan.PromptText = "Xác nhận mật khẩu";
            this.txtXacNhan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtXacNhan.SelectedText = "";
            this.txtXacNhan.SelectionLength = 0;
            this.txtXacNhan.SelectionStart = 0;
            this.txtXacNhan.ShortcutsEnabled = true;
            this.txtXacNhan.Size = new System.Drawing.Size(173, 23);
            this.txtXacNhan.TabIndex = 13;
            this.txtXacNhan.UseSelectable = true;
            this.txtXacNhan.UseSystemPasswordChar = true;
            this.txtXacNhan.WaterMark = "Xác nhận mật khẩu";
            this.txtXacNhan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtXacNhan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSai2
            // 
            this.lblSai2.AutoSize = true;
            this.lblSai2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSai2.ForeColor = System.Drawing.Color.Red;
            this.lblSai2.Location = new System.Drawing.Point(139, 144);
            this.lblSai2.Name = "lblSai2";
            this.lblSai2.Size = new System.Drawing.Size(250, 15);
            this.lblSai2.TabIndex = 14;
            this.lblSai2.Text = "Hai mật khẩu mới không khớp. Mời nhập lại!!!";
            this.lblSai2.Visible = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 219);
            this.Controls.Add(this.lblSai2);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblSai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtTenDangNhap);
            this.Name = "frmDoiMatKhau";
            this.Text = "ĐỔI MẬT KHẨU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnDongY;
        private MetroFramework.Controls.MetroTextBox txtMatKhauCu;
        private MetroFramework.Controls.MetroTextBox txtTenDangNhap;
        private MetroFramework.Controls.MetroTextBox txtMatKhauMoi;
        private MetroFramework.Controls.MetroTextBox txtXacNhan;
        private System.Windows.Forms.Label lblSai2;
    }
}