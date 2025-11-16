namespace QuanLyPhongTro
{
    partial class UC_HoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            pnlThongTIn = new Panel();
            cbTrangThai = new ComboBox();
            lbTrangThai = new Label();
            txtTongTien = new TextBox();
            txtTienNuoc = new TextBox();
            txtTienDien = new TextBox();
            txtTienPhong = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtMaPhong = new TextBox();
            txtTenKT = new TextBox();
            cbMaKT = new ComboBox();
            txtMaHD = new TextBox();
            lnTongTien = new Label();
            lbTienNuoc = new Label();
            lbTiendien = new Label();
            lbTienPhong = new Label();
            lbNgayLap = new Label();
            lbMaPhong = new Label();
            lbMaKhach = new Label();
            lbMaKT = new Label();
            lbMaHD = new Label();
            panel1 = new Panel();
            txtTK = new TextBox();
            btTK = new Button();
            btLamMoi = new Button();
            btLuu = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            pnlHienThi = new Panel();
            dgvHoaDon = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlThongTIn.SuspendLayout();
            panel1.SuspendLayout();
            pnlHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(163, 93, 39);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(829, 60);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(107, 34);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN";
            // 
            // pnlThongTIn
            // 
            pnlThongTIn.BackColor = Color.FromArgb(250, 243, 224);
            pnlThongTIn.Controls.Add(cbTrangThai);
            pnlThongTIn.Controls.Add(lbTrangThai);
            pnlThongTIn.Controls.Add(txtTongTien);
            pnlThongTIn.Controls.Add(txtTienNuoc);
            pnlThongTIn.Controls.Add(txtTienDien);
            pnlThongTIn.Controls.Add(txtTienPhong);
            pnlThongTIn.Controls.Add(dateTimePicker1);
            pnlThongTIn.Controls.Add(txtMaPhong);
            pnlThongTIn.Controls.Add(txtTenKT);
            pnlThongTIn.Controls.Add(cbMaKT);
            pnlThongTIn.Controls.Add(txtMaHD);
            pnlThongTIn.Controls.Add(lnTongTien);
            pnlThongTIn.Controls.Add(lbTienNuoc);
            pnlThongTIn.Controls.Add(lbTiendien);
            pnlThongTIn.Controls.Add(lbTienPhong);
            pnlThongTIn.Controls.Add(lbNgayLap);
            pnlThongTIn.Controls.Add(lbMaPhong);
            pnlThongTIn.Controls.Add(lbMaKhach);
            pnlThongTIn.Controls.Add(lbMaKT);
            pnlThongTIn.Controls.Add(lbMaHD);
            pnlThongTIn.Dock = DockStyle.Top;
            pnlThongTIn.Location = new Point(0, 60);
            pnlThongTIn.Name = "pnlThongTIn";
            pnlThongTIn.Size = new Size(829, 193);
            pnlThongTIn.TabIndex = 1;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Chưa Thanh Toán", "Đã Thanh Toán" });
            cbTrangThai.Location = new Point(673, 120);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(140, 23);
            cbTrangThai.TabIndex = 21;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbTrangThai.ForeColor = Color.FromArgb(140, 90, 30);
            lbTrangThai.Location = new Point(555, 120);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(77, 19);
            lbTrangThai.TabIndex = 20;
            lbTrangThai.Text = "Trạng thái";
            // 
            // txtTongTien
            // 
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Font = new Font("Times New Roman", 12F);
            txtTongTien.Location = new Point(126, 160);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(140, 26);
            txtTongTien.TabIndex = 19;
            // 
            // txtTienNuoc
            // 
            txtTienNuoc.BorderStyle = BorderStyle.FixedSingle;
            txtTienNuoc.Font = new Font("Times New Roman", 12F);
            txtTienNuoc.Location = new Point(400, 118);
            txtTienNuoc.Name = "txtTienNuoc";
            txtTienNuoc.Size = new Size(140, 26);
            txtTienNuoc.TabIndex = 18;
            txtTienNuoc.TextChanged += txtTienNuoc_TextChanged;
            // 
            // txtTienDien
            // 
            txtTienDien.BorderStyle = BorderStyle.FixedSingle;
            txtTienDien.Font = new Font("Times New Roman", 12F);
            txtTienDien.Location = new Point(126, 118);
            txtTienDien.Name = "txtTienDien";
            txtTienDien.Size = new Size(140, 26);
            txtTienDien.TabIndex = 17;
            txtTienDien.TextChanged += txtTienDien_TextChanged;
            // 
            // txtTienPhong
            // 
            txtTienPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTienPhong.Font = new Font("Times New Roman", 12F);
            txtTienPhong.Location = new Point(673, 71);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(140, 26);
            txtTienPhong.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 12F);
            dateTimePicker1.Location = new Point(400, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 26);
            dateTimePicker1.TabIndex = 15;
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhong.Font = new Font("Times New Roman", 12F);
            txtMaPhong.Location = new Point(126, 71);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(140, 26);
            txtMaPhong.TabIndex = 14;
            // 
            // txtTenKT
            // 
            txtTenKT.BorderStyle = BorderStyle.FixedSingle;
            txtTenKT.Font = new Font("Times New Roman", 12F);
            txtTenKT.Location = new Point(673, 23);
            txtTenKT.Name = "txtTenKT";
            txtTenKT.Size = new Size(140, 26);
            txtTenKT.TabIndex = 13;
            // 
            // cbMaKT
            // 
            cbMaKT.Font = new Font("Times New Roman", 12F);
            cbMaKT.FormattingEnabled = true;
            cbMaKT.Location = new Point(400, 22);
            cbMaKT.Name = "cbMaKT";
            cbMaKT.Size = new Size(140, 27);
            cbMaKT.TabIndex = 12;
            cbMaKT.SelectedIndexChanged += cbMaKT_SelectedIndexChanged;
            // 
            // txtMaHD
            // 
            txtMaHD.BorderStyle = BorderStyle.FixedSingle;
            txtMaHD.Font = new Font("Times New Roman", 12F);
            txtMaHD.Location = new Point(126, 23);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(140, 26);
            txtMaHD.TabIndex = 9;
            // 
            // lnTongTien
            // 
            lnTongTien.AutoSize = true;
            lnTongTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lnTongTien.ForeColor = Color.Red;
            lnTongTien.Location = new Point(30, 162);
            lnTongTien.Name = "lnTongTien";
            lnTongTien.Size = new Size(72, 19);
            lnTongTien.TabIndex = 8;
            lnTongTien.Text = "Tổng tiền";
            // 
            // lbTienNuoc
            // 
            lbTienNuoc.AutoSize = true;
            lbTienNuoc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbTienNuoc.ForeColor = Color.FromArgb(140, 90, 30);
            lbTienNuoc.Location = new Point(284, 120);
            lbTienNuoc.Name = "lbTienNuoc";
            lbTienNuoc.Size = new Size(77, 19);
            lbTienNuoc.TabIndex = 7;
            lbTienNuoc.Text = "Tiền nước";
            // 
            // lbTiendien
            // 
            lbTiendien.AutoSize = true;
            lbTiendien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbTiendien.ForeColor = Color.FromArgb(140, 90, 30);
            lbTiendien.Location = new Point(30, 120);
            lbTiendien.Name = "lbTiendien";
            lbTiendien.Size = new Size(71, 19);
            lbTiendien.TabIndex = 6;
            lbTiendien.Text = "Tiền điện";
            // 
            // lbTienPhong
            // 
            lbTienPhong.AutoSize = true;
            lbTienPhong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbTienPhong.ForeColor = Color.FromArgb(140, 90, 30);
            lbTienPhong.Location = new Point(555, 73);
            lbTienPhong.Name = "lbTienPhong";
            lbTienPhong.Size = new Size(83, 19);
            lbTienPhong.TabIndex = 5;
            lbTienPhong.Text = "Tiền phòng";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbNgayLap.ForeColor = Color.FromArgb(140, 90, 30);
            lbNgayLap.Location = new Point(284, 73);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(69, 19);
            lbNgayLap.TabIndex = 4;
            lbNgayLap.Text = "Ngày lập";
            // 
            // lbMaPhong
            // 
            lbMaPhong.AutoSize = true;
            lbMaPhong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbMaPhong.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaPhong.Location = new Point(30, 73);
            lbMaPhong.Name = "lbMaPhong";
            lbMaPhong.Size = new Size(77, 19);
            lbMaPhong.TabIndex = 3;
            lbMaPhong.Text = "Mã phòng";
            // 
            // lbMaKhach
            // 
            lbMaKhach.AutoSize = true;
            lbMaKhach.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbMaKhach.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaKhach.Location = new Point(555, 25);
            lbMaKhach.Name = "lbMaKhach";
            lbMaKhach.Size = new Size(112, 19);
            lbMaKhach.TabIndex = 2;
            lbMaKhach.Text = "Tên khách thuê";
            // 
            // lbMaKT
            // 
            lbMaKT.AutoSize = true;
            lbMaKT.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbMaKT.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaKT.Location = new Point(284, 25);
            lbMaKT.Name = "lbMaKT";
            lbMaKT.Size = new Size(110, 19);
            lbMaKT.TabIndex = 1;
            lbMaKT.Text = "Mã khách thuê";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbMaHD.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaHD.Location = new Point(30, 25);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(90, 19);
            lbMaHD.TabIndex = 0;
            lbMaHD.Text = "Mã hóa đơn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 227, 195);
            panel1.Controls.Add(txtTK);
            panel1.Controls.Add(btTK);
            panel1.Controls.Add(btLamMoi);
            panel1.Controls.Add(btLuu);
            panel1.Controls.Add(btXoa);
            panel1.Controls.Add(btSua);
            panel1.Controls.Add(btThem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 50);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.FixedSingle;
            txtTK.Location = new Point(555, 15);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(140, 23);
            txtTK.TabIndex = 6;
            // 
            // btTK
            // 
            btTK.BackColor = Color.FromArgb(204, 122, 41);
            btTK.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btTK.Location = new Point(710, 8);
            btTK.Name = "btTK";
            btTK.Size = new Size(103, 35);
            btTK.TabIndex = 5;
            btTK.Text = "Tìm kiếm 🔍";
            btTK.UseVisualStyleBackColor = false;
            btTK.Click += btTK_Click;
            // 
            // btLamMoi
            // 
            btLamMoi.BackColor = Color.FromArgb(213, 219, 219);
            btLamMoi.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btLamMoi.Location = new Point(400, 8);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(90, 35);
            btLamMoi.TabIndex = 4;
            btLamMoi.Text = "Làm mới";
            btLamMoi.UseVisualStyleBackColor = false;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.FromArgb(174, 214, 241);
            btLuu.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btLuu.Location = new Point(304, 8);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(90, 35);
            btLuu.TabIndex = 3;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.FromArgb(230, 176, 170);
            btXoa.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btXoa.Location = new Point(209, 8);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(90, 35);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.BackColor = Color.FromArgb(250, 215, 160);
            btSua.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btSua.Location = new Point(113, 8);
            btSua.Name = "btSua";
            btSua.Size = new Size(90, 35);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.FromArgb(162, 217, 162);
            btThem.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btThem.Location = new Point(17, 8);
            btThem.Name = "btThem";
            btThem.Size = new Size(90, 35);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // pnlHienThi
            // 
            pnlHienThi.BackColor = Color.FromArgb(255, 246, 229);
            pnlHienThi.Controls.Add(dgvHoaDon);
            pnlHienThi.Dock = DockStyle.Fill;
            pnlHienThi.Location = new Point(0, 303);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(829, 160);
            pnlHienThi.TabIndex = 3;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.BackgroundColor = Color.FromArgb(255, 246, 229);
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(829, 160);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // UC_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlHienThi);
            Controls.Add(panel1);
            Controls.Add(pnlThongTIn);
            Controls.Add(pnlHeader);
            Name = "UC_HoaDon";
            Size = new Size(829, 463);
            Load += UC_HoaDon_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlThongTIn.ResumeLayout(false);
            pnlThongTIn.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlThongTIn;
        private Panel panel1;
        private Panel pnlHienThi;
        private Label label1;
        private Label lnTongTien;
        private Label lbTienNuoc;
        private Label lbTiendien;
        private Label lbTienPhong;
        private Label lbNgayLap;
        private Label lbMaPhong;
        private Label lbMaKhach;
        private Label lbMaKT;
        private Label lbMaHD;
        private TextBox txtTenKT;
        private ComboBox cbMaKT;
        private TextBox txtMaHD;
        private TextBox txtTongTien;
        private TextBox txtTienNuoc;
        private TextBox txtTienDien;
        private TextBox txtTienPhong;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMaPhong;
        private Button btThem;
        private TextBox txtTK;
        private Button btTK;
        private Button btLamMoi;
        private Button btLuu;
        private Button btXoa;
        private Button btSua;
        private DataGridView dgvHoaDon;
        private Label lbTrangThai;
        private ComboBox cbTrangThai;
    }
}
