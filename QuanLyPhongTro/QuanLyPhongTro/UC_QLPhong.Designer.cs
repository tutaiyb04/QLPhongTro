namespace QuanLyPhongTro
{
    partial class UC_QLPhong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            label1 = new Label();
            pnlInput = new Panel();
            cbTinhTrang = new ComboBox();
            txtGia = new TextBox();
            cbLoaiPhong = new ComboBox();
            txtTenPhong = new TextBox();
            txtMaPhong = new TextBox();
            lbTinhTrang = new Label();
            lbGiaThue = new Label();
            lbLoaiPhong = new Label();
            lbTenPhong = new Label();
            lbMaPhong = new Label();
            pnlButtons = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            pnlGrid = new Panel();
            dgvPhong = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
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
            label1.BackColor = Color.FromArgb(163, 93, 39);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(272, 36);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÒNG TRỌ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.FromArgb(255, 246, 229);
            pnlInput.Controls.Add(cbTinhTrang);
            pnlInput.Controls.Add(txtGia);
            pnlInput.Controls.Add(cbLoaiPhong);
            pnlInput.Controls.Add(txtTenPhong);
            pnlInput.Controls.Add(txtMaPhong);
            pnlInput.Controls.Add(lbTinhTrang);
            pnlInput.Controls.Add(lbGiaThue);
            pnlInput.Controls.Add(lbLoaiPhong);
            pnlInput.Controls.Add(lbTenPhong);
            pnlInput.Controls.Add(lbMaPhong);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 60);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(829, 130);
            pnlInput.TabIndex = 1;
            // 
            // cbTinhTrang
            // 
            cbTinhTrang.Font = new Font("Times New Roman", 11.25F);
            cbTinhTrang.ForeColor = Color.Red;
            cbTinhTrang.FormattingEnabled = true;
            cbTinhTrang.Items.AddRange(new object[] { "Trống ", "Đang thuê" });
            cbTinhTrang.Location = new Point(120, 98);
            cbTinhTrang.Name = "cbTinhTrang";
            cbTinhTrang.Size = new Size(139, 25);
            cbTinhTrang.TabIndex = 9;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Font = new Font("Times New Roman", 11.25F);
            txtGia.Location = new Point(380, 58);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(139, 25);
            txtGia.TabIndex = 8;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.Font = new Font("Times New Roman", 11.25F);
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi" });
            cbLoaiPhong.Location = new Point(120, 58);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(139, 25);
            cbLoaiPhong.TabIndex = 7;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTenPhong.Font = new Font("Times New Roman", 11.25F);
            txtTenPhong.Location = new Point(380, 18);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(139, 25);
            txtTenPhong.TabIndex = 6;
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhong.Font = new Font("Times New Roman", 11.25F);
            txtMaPhong.Location = new Point(120, 18);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(139, 25);
            txtMaPhong.TabIndex = 5;
            // 
            // lbTinhTrang
            // 
            lbTinhTrang.AutoSize = true;
            lbTinhTrang.Font = new Font("Times New Roman", 12F);
            lbTinhTrang.ForeColor = Color.Red;
            lbTinhTrang.Location = new Point(20, 100);
            lbTinhTrang.Name = "lbTinhTrang";
            lbTinhTrang.Size = new Size(72, 19);
            lbTinhTrang.TabIndex = 4;
            lbTinhTrang.Text = "Tình trạng:";
            // 
            // lbGiaThue
            // 
            lbGiaThue.AutoSize = true;
            lbGiaThue.Font = new Font("Times New Roman", 12F);
            lbGiaThue.ForeColor = Color.FromArgb(140, 90, 30);
            lbGiaThue.Location = new Point(280, 60);
            lbGiaThue.Name = "lbGiaThue";
            lbGiaThue.Size = new Size(62, 19);
            lbGiaThue.TabIndex = 3;
            lbGiaThue.Text = "Giá thuê:";
            // 
            // lbLoaiPhong
            // 
            lbLoaiPhong.AutoSize = true;
            lbLoaiPhong.Font = new Font("Times New Roman", 12F);
            lbLoaiPhong.ForeColor = Color.FromArgb(140, 90, 30);
            lbLoaiPhong.Location = new Point(20, 60);
            lbLoaiPhong.Name = "lbLoaiPhong";
            lbLoaiPhong.Size = new Size(80, 19);
            lbLoaiPhong.TabIndex = 2;
            lbLoaiPhong.Text = "Loại phòng:";
            // 
            // lbTenPhong
            // 
            lbTenPhong.AutoSize = true;
            lbTenPhong.Font = new Font("Times New Roman", 12F);
            lbTenPhong.ForeColor = Color.FromArgb(140, 90, 30);
            lbTenPhong.Location = new Point(280, 20);
            lbTenPhong.Name = "lbTenPhong";
            lbTenPhong.Size = new Size(76, 19);
            lbTenPhong.TabIndex = 1;
            lbTenPhong.Text = "Tên phòng:";
            // 
            // lbMaPhong
            // 
            lbMaPhong.AutoSize = true;
            lbMaPhong.Font = new Font("Times New Roman", 12F);
            lbMaPhong.ForeColor = Color.FromArgb(140, 90, 30);
            lbMaPhong.Location = new Point(20, 20);
            lbMaPhong.Name = "lbMaPhong";
            lbMaPhong.Size = new Size(78, 19);
            lbMaPhong.TabIndex = 0;
            lbMaPhong.Text = "Mã phòng: ";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(243, 227, 195);
            pnlButtons.Controls.Add(btnTimKiem);
            pnlButtons.Controls.Add(txtTimKiem);
            pnlButtons.Controls.Add(btnLamMoi);
            pnlButtons.Controls.Add(btnLuu);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 190);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(829, 50);
            pnlButtons.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(232, 154, 61);
            btnTimKiem.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.FromArgb(90, 62, 27);
            btnTimKiem.Location = new Point(729, 8);
            btnTimKiem.Margin = new Padding(10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 35);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm 🔍";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(573, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(139, 23);
            txtTimKiem.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(211, 198, 178);
            btnLamMoi.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(90, 62, 27);
            btnLamMoi.Location = new Point(460, 8);
            btnLamMoi.Margin = new Padding(10);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 35);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(185, 216, 166);
            btnLuu.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnLuu.ForeColor = Color.FromArgb(90, 62, 27);
            btnLuu.Location = new Point(350, 8);
            btnLuu.Margin = new Padding(10);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 35);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(229, 138, 108);
            btnXoa.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnXoa.ForeColor = Color.FromArgb(90, 62, 27);
            btnXoa.Location = new Point(240, 8);
            btnXoa.Margin = new Padding(10);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(248, 225, 161);
            btnSua.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(90, 62, 27);
            btnSua.Location = new Point(130, 8);
            btnSua.Margin = new Padding(10);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 35);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(240, 199, 138);
            btnThem.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btnThem.ForeColor = Color.FromArgb(90, 62, 27);
            btnThem.Location = new Point(20, 8);
            btnThem.Margin = new Padding(10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvPhong);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 240);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(829, 223);
            pnlGrid.TabIndex = 3;
            // 
            // dgvPhong
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 227, 195);
            dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhong.BackgroundColor = Color.FromArgb(255, 246, 229);
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 154, 61);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhong.Dock = DockStyle.Fill;
            dgvPhong.GridColor = Color.FromArgb(199, 122, 48);
            dgvPhong.Location = new Point(0, 0);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.Size = new Size(829, 223);
            dgvPhong.TabIndex = 0;
            dgvPhong.CellContentClick += dgvPhong_CellContentClick;
            // 
            // UC_QLPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGrid);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            Name = "UC_QLPhong";
            Size = new Size(829, 463);
            Load += UC_QLPhong_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInput;
        private Panel pnlButtons;
        private Panel pnlGrid;
        private Label label1;
        private Label lbMaPhong;
        private Label lbTenPhong;
        private Label lbLoaiPhong;
        private Label lbGiaThue;
        private Label lbTinhTrang;
        private TextBox txtMaPhong;
        private TextBox txtTenPhong;
        private ComboBox cbLoaiPhong;
        private TextBox txtGia;
        private ComboBox cbTinhTrang;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private DataGridView dgvPhong;
    }
}
