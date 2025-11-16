namespace QuanLyPhongTro
{
    partial class FormMain
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
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu = new Panel();
            lbQuyen = new Label();
            btDangXuat = new Button();
            btBaoCao = new Button();
            btTaiKhoan = new Button();
            btHoaDon = new Button();
            btKhachHang = new Button();
            btQLPhong = new Button();
            btTrangChu = new Button();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Peru;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1029, 145);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(43, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(297, 49);
            label1.Name = "label1";
            label1.Size = new Size(593, 40);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ PHÒNG TRỌ";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SaddleBrown;
            panelMenu.Controls.Add(lbQuyen);
            panelMenu.Controls.Add(btDangXuat);
            panelMenu.Controls.Add(btBaoCao);
            panelMenu.Controls.Add(btTaiKhoan);
            panelMenu.Controls.Add(btHoaDon);
            panelMenu.Controls.Add(btKhachHang);
            panelMenu.Controls.Add(btQLPhong);
            panelMenu.Controls.Add(btTrangChu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 145);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 463);
            panelMenu.TabIndex = 1;
            // 
            // lbQuyen
            // 
            lbQuyen.AutoSize = true;
            lbQuyen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuyen.ForeColor = Color.AntiqueWhite;
            lbQuyen.Location = new Point(3, 435);
            lbQuyen.Name = "lbQuyen";
            lbQuyen.Size = new Size(58, 19);
            lbQuyen.TabIndex = 9;
            lbQuyen.Text = "Quyền:";
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = Color.AntiqueWhite;
            btDangXuat.Dock = DockStyle.Top;
            btDangXuat.FlatStyle = FlatStyle.Flat;
            btDangXuat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDangXuat.Location = new Point(0, 294);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(200, 49);
            btDangXuat.TabIndex = 8;
            btDangXuat.Text = "Đăng Xuất";
            btDangXuat.UseVisualStyleBackColor = false;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // btBaoCao
            // 
            btBaoCao.BackColor = Color.AntiqueWhite;
            btBaoCao.Dock = DockStyle.Top;
            btBaoCao.FlatStyle = FlatStyle.Flat;
            btBaoCao.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBaoCao.Location = new Point(0, 245);
            btBaoCao.Name = "btBaoCao";
            btBaoCao.Size = new Size(200, 49);
            btBaoCao.TabIndex = 7;
            btBaoCao.Text = "Báo Cáo";
            btBaoCao.UseVisualStyleBackColor = false;
            btBaoCao.Visible = false;
            btBaoCao.Click += btBaoCao_Click;
            // 
            // btTaiKhoan
            // 
            btTaiKhoan.BackColor = Color.AntiqueWhite;
            btTaiKhoan.Dock = DockStyle.Top;
            btTaiKhoan.FlatStyle = FlatStyle.Flat;
            btTaiKhoan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTaiKhoan.Location = new Point(0, 196);
            btTaiKhoan.Name = "btTaiKhoan";
            btTaiKhoan.Size = new Size(200, 49);
            btTaiKhoan.TabIndex = 6;
            btTaiKhoan.Text = "Tài Khoản";
            btTaiKhoan.UseVisualStyleBackColor = false;
            btTaiKhoan.Visible = false;
            btTaiKhoan.Click += btTaiKhoan_Click;
            // 
            // btHoaDon
            // 
            btHoaDon.BackColor = Color.AntiqueWhite;
            btHoaDon.Dock = DockStyle.Top;
            btHoaDon.FlatStyle = FlatStyle.Flat;
            btHoaDon.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btHoaDon.Location = new Point(0, 147);
            btHoaDon.Name = "btHoaDon";
            btHoaDon.Size = new Size(200, 49);
            btHoaDon.TabIndex = 5;
            btHoaDon.Text = "Hóa Đơn";
            btHoaDon.UseVisualStyleBackColor = false;
            btHoaDon.Click += btHoaDon_Click;
            // 
            // btKhachHang
            // 
            btKhachHang.BackColor = Color.AntiqueWhite;
            btKhachHang.Dock = DockStyle.Top;
            btKhachHang.FlatStyle = FlatStyle.Flat;
            btKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btKhachHang.Location = new Point(0, 98);
            btKhachHang.Name = "btKhachHang";
            btKhachHang.Size = new Size(200, 49);
            btKhachHang.TabIndex = 4;
            btKhachHang.Text = "Khách Thuê";
            btKhachHang.UseVisualStyleBackColor = false;
            btKhachHang.Click += btKhachHang_Click;
            // 
            // btQLPhong
            // 
            btQLPhong.BackColor = Color.AntiqueWhite;
            btQLPhong.Dock = DockStyle.Top;
            btQLPhong.FlatStyle = FlatStyle.Flat;
            btQLPhong.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQLPhong.Location = new Point(0, 49);
            btQLPhong.Name = "btQLPhong";
            btQLPhong.Size = new Size(200, 49);
            btQLPhong.TabIndex = 3;
            btQLPhong.Text = "Quản Lý Phòng";
            btQLPhong.UseVisualStyleBackColor = false;
            btQLPhong.Click += btQLPhong_Click;
            // 
            // btTrangChu
            // 
            btTrangChu.BackColor = Color.AntiqueWhite;
            btTrangChu.Dock = DockStyle.Top;
            btTrangChu.FlatStyle = FlatStyle.Flat;
            btTrangChu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTrangChu.ForeColor = Color.Black;
            btTrangChu.Location = new Point(0, 0);
            btTrangChu.Name = "btTrangChu";
            btTrangChu.Size = new Size(200, 49);
            btTrangChu.TabIndex = 0;
            btTrangChu.Text = "Trang Chủ";
            btTrangChu.UseVisualStyleBackColor = false;
            btTrangChu.Click += btTrangChu_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.BurlyWood;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 145);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(829, 463);
            panelContent.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 608);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý phòng trọ";
            Load += FormMain_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Panel panelMenu;
        private Button btTrangChu;
        private Panel panelContent;
        private PictureBox pictureBox1;
        private Button btTaiKhoan;
        private Button btHoaDon;
        private Button btKhachHang;
        private Button btQLPhong;
        private Button btDangXuat;
        private Button btBaoCao;
        private Label lbQuyen;
    }
}