namespace QuanLyPhongTro
{
    partial class UC_BaoCao
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
            btLamMoi = new Button();
            InBC = new Button();
            btXuatEX = new Button();
            btThongKe = new Button();
            dtgDenNgay = new DateTimePicker();
            dtTuNgay = new DateTimePicker();
            lbDenNgay = new Label();
            lbTuNgay = new Label();
            lbLoaiBC = new Label();
            cbLoaiBC = new ComboBox();
            panel3 = new Panel();
            dgvBaoCao = new DataGridView();
            panel4 = new Panel();
            lbTongDT = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            panel4.SuspendLayout();
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
            label1.Size = new Size(224, 34);
            label1.TabIndex = 0;
            label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 231, 206);
            panel2.Controls.Add(btLamMoi);
            panel2.Controls.Add(InBC);
            panel2.Controls.Add(btXuatEX);
            panel2.Controls.Add(btThongKe);
            panel2.Controls.Add(dtgDenNgay);
            panel2.Controls.Add(dtTuNgay);
            panel2.Controls.Add(lbDenNgay);
            panel2.Controls.Add(lbTuNgay);
            panel2.Controls.Add(lbLoaiBC);
            panel2.Controls.Add(cbLoaiBC);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 187);
            panel2.TabIndex = 1;
            // 
            // btLamMoi
            // 
            btLamMoi.BackColor = Color.FromArgb(174, 214, 241);
            btLamMoi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLamMoi.Location = new Point(630, 138);
            btLamMoi.Name = "btLamMoi";
            btLamMoi.Size = new Size(149, 29);
            btLamMoi.TabIndex = 9;
            btLamMoi.Text = "Làm mới 🔄";
            btLamMoi.UseVisualStyleBackColor = false;
            btLamMoi.Click += btLamMoi_Click;
            // 
            // InBC
            // 
            InBC.BackColor = Color.FromArgb(230, 176, 170);
            InBC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InBC.Location = new Point(436, 138);
            InBC.Name = "InBC";
            InBC.Size = new Size(149, 29);
            InBC.TabIndex = 8;
            InBC.Text = "In báo cáo 🖨";
            InBC.UseVisualStyleBackColor = false;
            InBC.Click += InBC_Click;
            // 
            // btXuatEX
            // 
            btXuatEX.BackColor = Color.FromArgb(250, 215, 160);
            btXuatEX.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXuatEX.Location = new Point(236, 138);
            btXuatEX.Name = "btXuatEX";
            btXuatEX.Size = new Size(149, 29);
            btXuatEX.TabIndex = 7;
            btXuatEX.Text = "Xuất Excel 📂";
            btXuatEX.UseVisualStyleBackColor = false;
            btXuatEX.Click += btXuatEX_Click;
            // 
            // btThongKe
            // 
            btThongKe.BackColor = Color.FromArgb(162, 217, 162);
            btThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThongKe.Location = new Point(38, 138);
            btThongKe.Name = "btThongKe";
            btThongKe.Size = new Size(149, 29);
            btThongKe.TabIndex = 6;
            btThongKe.Text = "Thống kê 📊";
            btThongKe.UseVisualStyleBackColor = false;
            btThongKe.Click += btThongKe_Click;
            // 
            // dtgDenNgay
            // 
            dtgDenNgay.Location = new Point(475, 97);
            dtgDenNgay.Name = "dtgDenNgay";
            dtgDenNgay.Size = new Size(224, 23);
            dtgDenNgay.TabIndex = 5;
            // 
            // dtTuNgay
            // 
            dtTuNgay.Location = new Point(475, 30);
            dtTuNgay.Name = "dtTuNgay";
            dtTuNgay.Size = new Size(224, 23);
            dtTuNgay.TabIndex = 4;
            // 
            // lbDenNgay
            // 
            lbDenNgay.AutoSize = true;
            lbDenNgay.Font = new Font("Times New Roman", 12F);
            lbDenNgay.ForeColor = Color.FromArgb(140, 90, 30);
            lbDenNgay.Location = new Point(397, 97);
            lbDenNgay.Name = "lbDenNgay";
            lbDenNgay.Size = new Size(66, 19);
            lbDenNgay.TabIndex = 3;
            lbDenNgay.Text = "Đến ngày";
            // 
            // lbTuNgay
            // 
            lbTuNgay.AutoSize = true;
            lbTuNgay.Font = new Font("Times New Roman", 12F);
            lbTuNgay.ForeColor = Color.FromArgb(140, 90, 30);
            lbTuNgay.Location = new Point(397, 31);
            lbTuNgay.Name = "lbTuNgay";
            lbTuNgay.Size = new Size(59, 19);
            lbTuNgay.TabIndex = 2;
            lbTuNgay.Text = "Từ ngày";
            // 
            // lbLoaiBC
            // 
            lbLoaiBC.AutoSize = true;
            lbLoaiBC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLoaiBC.ForeColor = Color.FromArgb(140, 90, 30);
            lbLoaiBC.Location = new Point(9, 31);
            lbLoaiBC.Name = "lbLoaiBC";
            lbLoaiBC.Size = new Size(120, 19);
            lbLoaiBC.TabIndex = 1;
            lbLoaiBC.Text = "Chọn loại báo cáo";
            // 
            // cbLoaiBC
            // 
            cbLoaiBC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLoaiBC.FormattingEnabled = true;
            cbLoaiBC.Location = new Point(135, 28);
            cbLoaiBC.Name = "cbLoaiBC";
            cbLoaiBC.Size = new Size(164, 27);
            cbLoaiBC.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvBaoCao);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 237);
            panel3.Name = "panel3";
            panel3.Size = new Size(829, 180);
            panel3.TabIndex = 2;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.BackgroundColor = Color.FromArgb(255, 249, 240);
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Dock = DockStyle.Fill;
            dgvBaoCao.Location = new Point(0, 0);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.Size = new Size(829, 180);
            dgvBaoCao.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.Controls.Add(lbTongDT);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 46);
            panel4.TabIndex = 3;
            // 
            // lbTongDT
            // 
            lbTongDT.AutoSize = true;
            lbTongDT.BackColor = Color.Firebrick;
            lbTongDT.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTongDT.ForeColor = Color.White;
            lbTongDT.Location = new Point(9, 14);
            lbTongDT.Name = "lbTongDT";
            lbTongDT.Size = new Size(106, 19);
            lbTongDT.TabIndex = 0;
            lbTongDT.Text = "Tổng doanh thu:";
            // 
            // UC_BaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_BaoCao";
            Size = new Size(829, 463);
            Load += UC_BaoCao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lbLoaiBC;
        private ComboBox cbLoaiBC;
        private Label lbDenNgay;
        private Label lbTuNgay;
        private DateTimePicker dtTuNgay;
        private DateTimePicker dtgDenNgay;
        private Button btThongKe;
        private Button btLamMoi;
        private Button InBC;
        private Button btXuatEX;
        private Panel panel3;
        private DataGridView dgvBaoCao;
        private Panel panel4;
        private Label lbTongDT;
    }
}
