namespace QuanLyPhongTro
{
    partial class UC_KhachThue
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
            pnlThongTin = new Panel();
            dtpNgayThue = new DateTimePicker();
            cbPhongThue = new ComboBox();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtTenKT = new TextBox();
            txtMaKhach = new TextBox();
            lbNgayThue = new Label();
            lbPhongThue = new Label();
            lbDC = new Label();
            lbSDT = new Label();
            lbCCCD = new Label();
            lbTenKT = new Label();
            lbMaKhachThue = new Label();
            pnlButton = new Panel();
            txtTK = new TextBox();
            btTimKiem = new Button();
            btLamMoi = new Button();
            btLuu = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            pnlHienThi = new Panel();
            dgvKhachThue = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlThongTin.SuspendLayout();
            pnlButton.SuspendLayout();
            pnlHienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(163, 93, 39);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(829, 50);
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
            label1.Size = new Size(252, 34);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH THUÊ";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.FromArgb(250, 243, 224);
            pnlThongTin.Controls.Add(dtpNgayThue);
            pnlThongTin.Controls.Add(cbPhongThue);
            pnlThongTin.Controls.Add(txtDC);
            pnlThongTin.Controls.Add(txtSDT);
            pnlThongTin.Controls.Add(txtCCCD);
            pnlThongTin.Controls.Add(txtTenKT);
            pnlThongTin.Controls.Add(txtMaKhach);
            pnlThongTin.Controls.Add(lbNgayThue);
            pnlThongTin.Controls.Add(lbPhongThue);
            pnlThongTin.Controls.Add(lbDC);
            pnlThongTin.Controls.Add(lbSDT);
            pnlThongTin.Controls.Add(lbCCCD);
            pnlThongTin.Controls.Add(lbTenKT);
            pnlThongTin.Controls.Add(lbMaKhachThue);
            pnlThongTin.Dock = DockStyle.Top;
            pnlThongTin.Location = new Point(0, 50);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(829, 140);
            pnlThongTin.TabIndex = 1;
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.Font = new Font("Times New Roman", 12F);
            dtpNgayThue.Location = new Point(125, 99);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(248, 26);
            dtpNgayThue.TabIndex = 13;
            // 
            // cbPhongThue
            // 
            cbPhongThue.Font = new Font("Times New Roman", 12F);
            cbPhongThue.FormattingEnabled = true;
            cbPhongThue.Location = new Point(644, 57);
            cbPhongThue.Name = "cbPhongThue";
            cbPhongThue.Size = new Size(155, 27);
            cbPhongThue.TabIndex = 12;
            // 
            // txtDC
            // 
            txtDC.BorderStyle = BorderStyle.FixedSingle;
            txtDC.Font = new Font("Times New Roman", 12F);
            txtDC.Location = new Point(394, 58);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(150, 26);
            txtDC.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Times New Roman", 12F);
            txtSDT.Location = new Point(125, 58);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(149, 26);
            txtSDT.TabIndex = 10;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Times New Roman", 12F);
            txtCCCD.Location = new Point(644, 18);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(155, 26);
            txtCCCD.TabIndex = 9;
            // 
            // txtTenKT
            // 
            txtTenKT.BorderStyle = BorderStyle.FixedSingle;
            txtTenKT.Font = new Font("Times New Roman", 12F);
            txtTenKT.Location = new Point(394, 18);
            txtTenKT.Name = "txtTenKT";
            txtTenKT.Size = new Size(150, 26);
            txtTenKT.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            txtMaKhach.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhach.Font = new Font("Times New Roman", 12F);
            txtMaKhach.Location = new Point(125, 18);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(149, 26);
            txtMaKhach.TabIndex = 7;
            // 
            // lbNgayThue
            // 
            lbNgayThue.AutoSize = true;
            lbNgayThue.Font = new Font("Times New Roman", 12F);
            lbNgayThue.ForeColor = Color.FromArgb(140, 90, 30);
            lbNgayThue.Location = new Point(20, 100);
            lbNgayThue.Name = "lbNgayThue";
            lbNgayThue.Size = new Size(71, 19);
            lbNgayThue.TabIndex = 6;
            lbNgayThue.Text = "Ngày thuê";
            // 
            // lbPhongThue
            // 
            lbPhongThue.AutoSize = true;
            lbPhongThue.Font = new Font("Times New Roman", 12F);
            lbPhongThue.ForeColor = Color.FromArgb(140, 90, 30);
            lbPhongThue.Location = new Point(550, 60);
            lbPhongThue.Name = "lbPhongThue";
            lbPhongThue.Size = new Size(76, 19);
            lbPhongThue.TabIndex = 5;
            lbPhongThue.Text = "Phòng thuê";
            // 
            // lbDC
            // 
            lbDC.AutoSize = true;
            lbDC.Font = new Font("Times New Roman", 12F);
            lbDC.ForeColor = Color.FromArgb(140, 90, 30);
            lbDC.Location = new Point(284, 60);
            lbDC.Name = "lbDC";
            lbDC.Size = new Size(51, 19);
            lbDC.TabIndex = 4;
            lbDC.Text = "Địa chỉ";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Times New Roman", 12F);
            lbSDT.ForeColor = Color.FromArgb(140, 90, 30);
            lbSDT.Location = new Point(20, 60);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(88, 19);
            lbSDT.TabIndex = 3;
            lbSDT.Text = "Số điện thoại";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Font = new Font("Times New Roman", 12F);
            lbCCCD.ForeColor = Color.FromArgb(140, 90, 30);
            lbCCCD.Location = new Point(550, 20);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(53, 19);
            lbCCCD.TabIndex = 2;
            lbCCCD.Text = "CCCD";
            // 
            // lbTenKT
            // 
            lbTenKT.AutoSize = true;
            lbTenKT.Font = new Font("Times New Roman", 12F);
            lbTenKT.ForeColor = Color.FromArgb(140, 90, 30);
            lbTenKT.Location = new Point(280, 20);
            lbTenKT.Name = "lbTenKT";
            lbTenKT.Size = new Size(105, 19);
            lbTenKT.TabIndex = 1;
            lbTenKT.Text = " Tên khách thuê";
            // 
            // lbMaKhachThue
            // 
            lbMaKhachThue.AutoSize = true;
            lbMaKhachThue.Font = new Font("Times New Roman", 12F);
            lbMaKhachThue.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaKhachThue.Location = new Point(20, 20);
            lbMaKhachThue.Name = "lbMaKhachThue";
            lbMaKhachThue.Size = new Size(99, 19);
            lbMaKhachThue.TabIndex = 0;
            lbMaKhachThue.Text = "Mã khách thuê";
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.FromArgb(243, 227, 195);
            pnlButton.BorderStyle = BorderStyle.FixedSingle;
            pnlButton.Controls.Add(txtTK);
            pnlButton.Controls.Add(btTimKiem);
            pnlButton.Controls.Add(btLamMoi);
            pnlButton.Controls.Add(btLuu);
            pnlButton.Controls.Add(btXoa);
            pnlButton.Controls.Add(btSua);
            pnlButton.Controls.Add(btThem);
            pnlButton.Dock = DockStyle.Top;
            pnlButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            pnlButton.Location = new Point(0, 190);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(829, 60);
            pnlButton.TabIndex = 2;
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.FixedSingle;
            txtTK.Location = new Point(515, 18);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(167, 26);
            txtTK.TabIndex = 6;
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.FromArgb(232, 154, 61);
            btTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btTimKiem.Location = new Point(705, 12);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(104, 35);
            btTimKiem.TabIndex = 5;
            btTimKiem.Text = "Tìm kiếm 🔍";
            btTimKiem.UseVisualStyleBackColor = false;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // btLamMoi
            // 
            btLamMoi.BackColor = Color.FromArgb(213, 219, 219);
            btLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLamMoi.Location = new Point(401, 12);
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
            btLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLuu.ForeColor = Color.FromArgb(90, 62, 27);
            btLuu.Location = new Point(305, 12);
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
            btXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btXoa.ForeColor = Color.FromArgb(90, 62, 27);
            btXoa.Location = new Point(209, 12);
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
            btSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btSua.ForeColor = Color.FromArgb(90, 62, 27);
            btSua.Location = new Point(113, 12);
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
            btThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btThem.ForeColor = Color.FromArgb(90, 62, 27);
            btThem.Location = new Point(17, 12);
            btThem.Name = "btThem";
            btThem.Size = new Size(90, 35);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // pnlHienThi
            // 
            pnlHienThi.BackColor = Color.FromArgb(255, 249, 230);
            pnlHienThi.Controls.Add(dgvKhachThue);
            pnlHienThi.Dock = DockStyle.Fill;
            pnlHienThi.Location = new Point(0, 250);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(829, 213);
            pnlHienThi.TabIndex = 3;
            // 
            // dgvKhachThue
            // 
            dgvKhachThue.BackgroundColor = Color.FromArgb(255, 246, 229);
            dgvKhachThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachThue.Dock = DockStyle.Fill;
            dgvKhachThue.Location = new Point(0, 0);
            dgvKhachThue.Name = "dgvKhachThue";
            dgvKhachThue.Size = new Size(829, 213);
            dgvKhachThue.TabIndex = 0;
            dgvKhachThue.CellContentClick += dgvKhachThue_CellContentClick;
            // 
            // UC_KhachThue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlHienThi);
            Controls.Add(pnlButton);
            Controls.Add(pnlThongTin);
            Controls.Add(pnlHeader);
            Name = "UC_KhachThue";
            Size = new Size(829, 463);
            Load += UC_KhachThue_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            pnlButton.ResumeLayout(false);
            pnlButton.PerformLayout();
            pnlHienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachThue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel pnlThongTin;
        private Panel pnlButton;
        private Panel pnlHienThi;
        private Label lbCCCD;
        private Label lbTenKT;
        private Label lbMaKhachThue;
        private Label lbSDT;
        private Label lbNgayThue;
        private Label lbPhongThue;
        private Label lbDC;
        private DateTimePicker dtpNgayThue;
        private ComboBox cbPhongThue;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private TextBox txtTenKT;
        private TextBox txtMaKhach;
        private Button btThem;
        private TextBox txtTK;
        private Button btTimKiem;
        private Button btLamMoi;
        private Button btLuu;
        private Button btXoa;
        private Button btSua;
        private DataGridView dgvKhachThue;
    }
}
