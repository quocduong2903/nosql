namespace QL_TuyenDung
{
    partial class frm_vieccantuyen
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
            btn_themcv = new Button();
            groupBox4 = new GroupBox();
            dgv_congviec = new DataGridView();
            groupBox5 = new GroupBox();
            dgv_nhiemVu = new DataGridView();
            groupBox6 = new GroupBox();
            btn_xoacv = new Button();
            btn_sua_cv = new Button();
            label1 = new Label();
            label9 = new Label();
            txt_macv = new TextBox();
            label8 = new Label();
            txt_tencv = new TextBox();
            label7 = new Label();
            txt_luong = new TextBox();
            label2 = new Label();
            txt_mota = new RichTextBox();
            txt_yeucau = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dtb_ngaybatdau = new DateTimePicker();
            label6 = new Label();
            txt_idCV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_phongban = new TextBox();
            groupBox1 = new GroupBox();
            txt_nhiemvu = new TextBox();
            btn_xoa_NV = new Button();
            btn_themNV = new Button();
            btn_suaNV = new Button();
            txt_tennguoiLH = new TextBox();
            label10 = new Label();
            txt_email = new TextBox();
            label11 = new Label();
            txt_soDT = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            btn_timkiem_TenCV = new Button();
            btn_lammoi = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_congviec).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhiemVu).BeginInit();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_themcv
            // 
            btn_themcv.Location = new Point(18, 20);
            btn_themcv.Name = "btn_themcv";
            btn_themcv.Size = new Size(94, 29);
            btn_themcv.TabIndex = 7;
            btn_themcv.Text = "Thêm cv";
            btn_themcv.UseVisualStyleBackColor = true;
            btn_themcv.Click += btn_themcv_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_congviec);
            groupBox4.Location = new Point(431, 40);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(900, 252);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách công công việc";
            // 
            // dgv_congviec
            // 
            dgv_congviec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_congviec.Dock = DockStyle.Fill;
            dgv_congviec.Location = new Point(3, 23);
            dgv_congviec.Name = "dgv_congviec";
            dgv_congviec.RowHeadersWidth = 51;
            dgv_congviec.RowTemplate.Height = 29;
            dgv_congviec.Size = new Size(894, 226);
            dgv_congviec.TabIndex = 0;
            dgv_congviec.CellClick += dgv_congviec_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_nhiemVu);
            groupBox5.Location = new Point(805, 324);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(543, 175);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách Nhiệm vụ";
            // 
            // dgv_nhiemVu
            // 
            dgv_nhiemVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhiemVu.Dock = DockStyle.Fill;
            dgv_nhiemVu.Location = new Point(3, 23);
            dgv_nhiemVu.Name = "dgv_nhiemVu";
            dgv_nhiemVu.RowHeadersWidth = 51;
            dgv_nhiemVu.RowTemplate.Height = 29;
            dgv_nhiemVu.Size = new Size(537, 149);
            dgv_nhiemVu.TabIndex = 0;
            dgv_nhiemVu.CellClick += dgv_nhiemVu_CellClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_xoacv);
            groupBox6.Controls.Add(btn_themcv);
            groupBox6.Controls.Add(btn_sua_cv);
            groupBox6.Location = new Point(15, 549);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(400, 55);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chức năng công việc";
            // 
            // btn_xoacv
            // 
            btn_xoacv.Location = new Point(259, 20);
            btn_xoacv.Name = "btn_xoacv";
            btn_xoacv.Size = new Size(94, 29);
            btn_xoacv.TabIndex = 17;
            btn_xoacv.Text = "Xóa CV";
            btn_xoacv.UseVisualStyleBackColor = true;
            btn_xoacv.Click += btn_xoacv_Click;
            // 
            // btn_sua_cv
            // 
            btn_sua_cv.Location = new Point(130, 20);
            btn_sua_cv.Name = "btn_sua_cv";
            btn_sua_cv.Size = new Size(94, 29);
            btn_sua_cv.TabIndex = 8;
            btn_sua_cv.Text = "Sửa CV";
            btn_sua_cv.UseVisualStyleBackColor = true;
            btn_sua_cv.Click += btn_sua_cv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(546, -5);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 10;
            label1.Text = "VIÊC CẦN TUYỂN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 60);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 2;
            label9.Text = "Mã CV:";
            // 
            // txt_macv
            // 
            txt_macv.Location = new Point(112, 60);
            txt_macv.Name = "txt_macv";
            txt_macv.Size = new Size(291, 27);
            txt_macv.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 107);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 4;
            label8.Text = "Tên CV:";
            // 
            // txt_tencv
            // 
            txt_tencv.Location = new Point(112, 107);
            txt_tencv.Name = "txt_tencv";
            txt_tencv.Size = new Size(291, 27);
            txt_tencv.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 154);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 6;
            label7.Text = "Lương:";
            // 
            // txt_luong
            // 
            txt_luong.Location = new Point(112, 154);
            txt_luong.Name = "txt_luong";
            txt_luong.Size = new Size(291, 27);
            txt_luong.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 191);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Mô tả:";
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(112, 194);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(291, 47);
            txt_mota.TabIndex = 9;
            txt_mota.Text = "";
            // 
            // txt_yeucau
            // 
            txt_yeucau.Location = new Point(112, 254);
            txt_yeucau.Name = "txt_yeucau";
            txt_yeucau.Size = new Size(291, 27);
            txt_yeucau.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 251);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Yêu cầu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtb_ngaybatdau);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_idCV);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_phongban);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_yeucau);
            groupBox2.Controls.Add(txt_mota);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_luong);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_tencv);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_macv);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(12, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 469);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Công việc";
            // 
            // dtb_ngaybatdau
            // 
            dtb_ngaybatdau.Location = new Point(114, 321);
            dtb_ngaybatdau.Name = "dtb_ngaybatdau";
            dtb_ngaybatdau.Size = new Size(289, 27);
            dtb_ngaybatdau.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 324);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 16;
            label6.Text = "Ngày bắt đầu:";
            // 
            // txt_idCV
            // 
            txt_idCV.Location = new Point(112, 26);
            txt_idCV.Name = "txt_idCV";
            txt_idCV.Size = new Size(291, 27);
            txt_idCV.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 14;
            label5.Text = "_id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 284);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 13;
            label4.Text = "Phòng ban:";
            // 
            // txt_phongban
            // 
            txt_phongban.Location = new Point(112, 287);
            txt_phongban.Name = "txt_phongban";
            txt_phongban.Size = new Size(291, 27);
            txt_phongban.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_nhiemvu);
            groupBox1.Controls.Add(btn_xoa_NV);
            groupBox1.Controls.Add(btn_themNV);
            groupBox1.Controls.Add(btn_suaNV);
            groupBox1.Location = new Point(443, 472);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 111);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhiệm vụ";
            // 
            // txt_nhiemvu
            // 
            txt_nhiemvu.Location = new Point(16, 34);
            txt_nhiemvu.Name = "txt_nhiemvu";
            txt_nhiemvu.Size = new Size(322, 27);
            txt_nhiemvu.TabIndex = 18;
            // 
            // btn_xoa_NV
            // 
            btn_xoa_NV.Location = new Point(244, 67);
            btn_xoa_NV.Name = "btn_xoa_NV";
            btn_xoa_NV.Size = new Size(94, 29);
            btn_xoa_NV.TabIndex = 17;
            btn_xoa_NV.Text = "Xóa NV";
            btn_xoa_NV.UseVisualStyleBackColor = true;
            btn_xoa_NV.Click += btn_xoa_NV_Click;
            // 
            // btn_themNV
            // 
            btn_themNV.Location = new Point(16, 67);
            btn_themNV.Name = "btn_themNV";
            btn_themNV.Size = new Size(94, 29);
            btn_themNV.TabIndex = 7;
            btn_themNV.Text = "Thêm NV";
            btn_themNV.UseVisualStyleBackColor = true;
            btn_themNV.Click += btn_themNV_Click;
            // 
            // btn_suaNV
            // 
            btn_suaNV.Location = new Point(128, 67);
            btn_suaNV.Name = "btn_suaNV";
            btn_suaNV.Size = new Size(94, 29);
            btn_suaNV.TabIndex = 8;
            btn_suaNV.Text = "Sửa NV";
            btn_suaNV.UseVisualStyleBackColor = true;
            btn_suaNV.Click += btn_suaNV_Click;
            // 
            // txt_tennguoiLH
            // 
            txt_tennguoiLH.Location = new Point(126, 391);
            txt_tennguoiLH.Name = "txt_tennguoiLH";
            txt_tennguoiLH.Size = new Size(291, 27);
            txt_tennguoiLH.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 391);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 22;
            label10.Text = "Tên người LH:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(126, 472);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(291, 27);
            txt_email.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 472);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 20;
            label11.Text = "Email:";
            // 
            // txt_soDT
            // 
            txt_soDT.Location = new Point(126, 425);
            txt_soDT.Name = "txt_soDT";
            txt_soDT.Size = new Size(291, 27);
            txt_soDT.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 425);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 18;
            label12.Text = "Số DT:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_timkiem_TenCV);
            groupBox3.Location = new Point(443, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 105);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "tìm kiếm";
            // 
            // btn_timkiem_TenCV
            // 
            btn_timkiem_TenCV.Location = new Point(42, 34);
            btn_timkiem_TenCV.Name = "btn_timkiem_TenCV";
            btn_timkiem_TenCV.Size = new Size(130, 29);
            btn_timkiem_TenCV.TabIndex = 0;
            btn_timkiem_TenCV.Text = "Tên công việc";
            btn_timkiem_TenCV.UseVisualStyleBackColor = true;
            btn_timkiem_TenCV.Click += btn_timkiem_TenCV_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(431, 312);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 9;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // frm_vieccantuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1348, 635);
            Controls.Add(btn_lammoi);
            Controls.Add(groupBox3);
            Controls.Add(txt_tennguoiLH);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(groupBox4);
            Controls.Add(txt_email);
            Controls.Add(label11);
            Controls.Add(groupBox5);
            Controls.Add(txt_soDT);
            Controls.Add(groupBox6);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "frm_vieccantuyen";
            Text = "frm_vieccantuyen";
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_congviec).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_nhiemVu).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_themcv;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btn_sua_cv;
        private Label label1;
        private Label label9;
        private TextBox txt_macv;
        private Label label8;
        private TextBox txt_tencv;
        private Label label7;
        private TextBox txt_luong;
        private Label label2;
        private RichTextBox txt_mota;
        private TextBox txt_yeucau;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txt_phongban;
        private DataGridView dgv_congviec;
        private DataGridView dgv_nhiemVu;
        private TextBox txt_idCV;
        private Label label5;
        private DateTimePicker dtb_ngaybatdau;
        private Label label6;
        private Button btn_xoacv;
        private GroupBox groupBox1;
        private Button btn_xoa_NV;
        private Button btn_themNV;
        private Button btn_suaNV;
        private TextBox txt_nhiemvu;
        private TextBox txt_tennguoiLH;
        private Label label10;
        private TextBox txt_email;
        private Label label11;
        private TextBox txt_soDT;
        private Label label12;
        private GroupBox groupBox3;
        private Button btn_timkiem_TenCV;
        private Button btn_lammoi;
    }
}