namespace QuanLyPhongTro
{
    partial class UC_TaiKhoan
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            cbQuyen = new ComboBox();
            txtXNMK = new TextBox();
            txtMK = new TextBox();
            txtTenDN = new TextBox();
            txtMaTK = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btLamMoi = new Button();
            btLuu = new Button();
            btXoa = new Button();
            btSua = new Button();
            txtTK = new TextBox();
            btTimKiem = new Button();
            btThem = new Button();
            panel4 = new Panel();
            dgvTaiKhoan = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(163, 93, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(229, 34);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 239, 211);
            panel2.Controls.Add(cbQuyen);
            panel2.Controls.Add(txtXNMK);
            panel2.Controls.Add(txtMK);
            panel2.Controls.Add(txtTenDN);
            panel2.Controls.Add(txtMaTK);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 187);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // cbQuyen
            // 
            cbQuyen.Font = new Font("Times New Roman", 12F);
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "Admin\t", "Nhanvien" });
            cbQuyen.Location = new Point(181, 143);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(194, 27);
            cbQuyen.TabIndex = 9;
            // 
            // txtXNMK
            // 
            txtXNMK.BorderStyle = BorderStyle.FixedSingle;
            txtXNMK.Font = new Font("Times New Roman", 12F);
            txtXNMK.Location = new Point(590, 85);
            txtXNMK.Name = "txtXNMK";
            txtXNMK.Size = new Size(183, 26);
            txtXNMK.TabIndex = 8;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.FixedSingle;
            txtMK.Font = new Font("Times New Roman", 12F);
            txtMK.Location = new Point(181, 85);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(194, 26);
            txtMK.TabIndex = 7;
            // 
            // txtTenDN
            // 
            txtTenDN.BorderStyle = BorderStyle.FixedSingle;
            txtTenDN.Font = new Font("Times New Roman", 12F);
            txtTenDN.Location = new Point(590, 29);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(183, 26);
            txtTenDN.TabIndex = 6;
            // 
            // txtMaTK
            // 
            txtMaTK.BorderStyle = BorderStyle.FixedSingle;
            txtMaTK.Font = new Font("Times New Roman", 12F);
            txtMaTK.Location = new Point(181, 29);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(194, 26);
            txtMaTK.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(140, 90, 30);
            label6.Location = new Point(49, 146);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 4;
            label6.Text = "Quyền hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.FromArgb(140, 90, 30);
            label5.Location = new Point(422, 88);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 3;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.FromArgb(140, 90, 30);
            label4.Location = new Point(49, 88);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.FromArgb(140, 90, 30);
            label3.Location = new Point(422, 32);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 1;
            label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.FromArgb(140, 90, 30);
            label2.Location = new Point(49, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã tài khoản";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(243, 227, 195);
            panel3.Controls.Add(btLamMoi);
            panel3.Controls.Add(btLuu);
            panel3.Controls.Add(btXoa);
            panel3.Controls.Add(btSua);
            panel3.Controls.Add(txtTK);
            panel3.Controls.Add(btTimKiem);
            panel3.Controls.Add(btThem);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 237);
            panel3.Name = "panel3";
            panel3.Size = new Size(829, 60);
            panel3.TabIndex = 2;
            // 
            // btLamMoi
            // 
            btLamMoi.BackColor = Color.FromArgb(213, 219, 219);
            btLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLamMoi.Location = new Point(406, 13);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(90, 35);
            btLamMoi.TabIndex = 11;
            btLamMoi.Text = "Làm mới";
            btLamMoi.UseVisualStyleBackColor = false;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // btLuu
            // 
            btLuu.BackColor = Color.FromArgb(174, 214, 241);
            btLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLuu.ForeColor = Color.FromArgb(90, 62, 27);
            btLuu.Location = new Point(310, 13);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(90, 35);
            btLuu.TabIndex = 10;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            btLuu.Click += btLuu_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.FromArgb(230, 176, 170);
            btXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btXoa.ForeColor = Color.FromArgb(90, 62, 27);
            btXoa.Location = new Point(214, 13);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(90, 35);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.BackColor = Color.FromArgb(250, 215, 160);
            btSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btSua.ForeColor = Color.FromArgb(90, 62, 27);
            btSua.Location = new Point(118, 13);
            btSua.Name = "btSua";
            btSua.Size = new Size(90, 35);
            btSua.TabIndex = 8;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.FixedSingle;
            txtTK.Location = new Point(534, 19);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(167, 23);
            txtTK.TabIndex = 7;
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.FromArgb(232, 154, 61);
            btTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btTimKiem.Location = new Point(707, 13);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(104, 35);
            btTimKiem.TabIndex = 6;
            btTimKiem.Text = "Tìm kiếm 🔍";
            btTimKiem.UseVisualStyleBackColor = false;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.FromArgb(162, 217, 162);
            btThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btThem.ForeColor = Color.FromArgb(90, 62, 27);
            btThem.Location = new Point(22, 13);
            btThem.Name = "btThem";
            btThem.Size = new Size(90, 35);
            btThem.TabIndex = 1;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvTaiKhoan);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 297);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 166);
            panel4.TabIndex = 3;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.BackgroundColor = Color.FromArgb(255, 249, 240);
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.Size = new Size(829, 166);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // UC_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_TaiKhoan";
            Size = new Size(829, 463);
            Load += UC_TaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbQuyen;
        private TextBox txtXNMK;
        private TextBox txtMK;
        private TextBox txtTenDN;
        private TextBox txtMaTK;
        private Panel panel3;
        private Button btThem;
        private Button btTimKiem;
        private TextBox txtTK;
        private Button btSua;
        private Button btXoa;
        private Button btLuu;
        private Button btLamMoi;
        private Panel panel4;
        private DataGridView dgvTaiKhoan;
    }
}
