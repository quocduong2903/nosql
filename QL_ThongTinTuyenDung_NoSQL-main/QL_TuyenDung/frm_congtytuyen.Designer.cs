namespace QL_TuyenDung
{
    partial class frm_congtytuyen
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_id = new TextBox();
            label6 = new Label();
            txt_sdt = new TextBox();
            label5 = new Label();
            txt_diachi = new TextBox();
            label4 = new Label();
            txt_tencty = new TextBox();
            label3 = new Label();
            txt_macty = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btn_suacty = new Button();
            btn_xoacty = new Button();
            btn_themcty = new Button();
            groupBox4 = new GroupBox();
            dgv_cty = new DataGridView();
            groupBox5 = new GroupBox();
            dgv_listCV = new DataGridView();
            groupBox2 = new GroupBox();
            btn_xoaCV_CTY = new Button();
            btn_suaCV_CTY = new Button();
            btn_themCV_CTY = new Button();
            label7 = new Label();
            cbb_motaCV = new ComboBox();
            groupBox6 = new GroupBox();
            btn_timkiem_TenCTY = new Button();
            btn_lammoi = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cty).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listCV).BeginInit();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(434, 9);
            label1.Name = "label1";
            label1.Size = new Size(662, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÔNG TY CẦN TUYỂN NHÂN SỰ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_diachi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_tencty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_macty);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 301);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công ty";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(90, 20);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(291, 27);
            txt_id.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 10;
            label6.Text = "ID :";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(90, 208);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(291, 27);
            txt_sdt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 211);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 8;
            label5.Text = "SDT :";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(90, 162);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(291, 27);
            txt_diachi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 165);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Dia chi :";
            // 
            // txt_tencty
            // 
            txt_tencty.Location = new Point(90, 115);
            txt_tencty.Name = "txt_tencty";
            txt_tencty.Size = new Size(291, 27);
            txt_tencty.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 118);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Ten CTY:";
            // 
            // txt_macty
            // 
            txt_macty.Location = new Point(90, 68);
            txt_macty.Name = "txt_macty";
            txt_macty.Size = new Size(291, 27);
            txt_macty.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Ma CTY:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_suacty);
            groupBox3.Controls.Add(btn_xoacty);
            groupBox3.Controls.Add(btn_themcty);
            groupBox3.Location = new Point(12, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 65);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng công ty";
            // 
            // btn_suacty
            // 
            btn_suacty.Location = new Point(245, 26);
            btn_suacty.Name = "btn_suacty";
            btn_suacty.Size = new Size(94, 29);
            btn_suacty.TabIndex = 6;
            btn_suacty.Text = "Sửa";
            btn_suacty.UseVisualStyleBackColor = true;
            btn_suacty.Click += btn_suacty_Click;
            // 
            // btn_xoacty
            // 
            btn_xoacty.Location = new Point(130, 26);
            btn_xoacty.Name = "btn_xoacty";
            btn_xoacty.Size = new Size(94, 29);
            btn_xoacty.TabIndex = 5;
            btn_xoacty.Text = "Xóa";
            btn_xoacty.UseVisualStyleBackColor = true;
            btn_xoacty.Click += btn_xoacty_Click;
            // 
            // btn_themcty
            // 
            btn_themcty.Location = new Point(18, 26);
            btn_themcty.Name = "btn_themcty";
            btn_themcty.Size = new Size(94, 29);
            btn_themcty.TabIndex = 4;
            btn_themcty.Text = "Thêm";
            btn_themcty.UseVisualStyleBackColor = true;
            btn_themcty.Click += btn_themcty_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgv_cty);
            groupBox4.Location = new Point(428, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(900, 252);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách công ty tuyển";
            // 
            // dgv_cty
            // 
            dgv_cty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cty.Dock = DockStyle.Fill;
            dgv_cty.Location = new Point(3, 23);
            dgv_cty.Name = "dgv_cty";
            dgv_cty.RowHeadersWidth = 51;
            dgv_cty.RowTemplate.Height = 29;
            dgv_cty.Size = new Size(894, 226);
            dgv_cty.TabIndex = 0;
            dgv_cty.CellClick += dgv_cty_CellClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_listCV);
            groupBox5.Location = new Point(707, 360);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(640, 217);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách các công việc cần tuyển nhân sự của công ty";
            // 
            // dgv_listCV
            // 
            dgv_listCV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listCV.Dock = DockStyle.Fill;
            dgv_listCV.Location = new Point(3, 23);
            dgv_listCV.Name = "dgv_listCV";
            dgv_listCV.RowHeadersWidth = 51;
            dgv_listCV.RowTemplate.Height = 29;
            dgv_listCV.Size = new Size(634, 191);
            dgv_listCV.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xoaCV_CTY);
            groupBox2.Controls.Add(btn_suaCV_CTY);
            groupBox2.Controls.Add(btn_themCV_CTY);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbb_motaCV);
            groupBox2.Location = new Point(12, 471);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 130);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách công việc";
            // 
            // btn_xoaCV_CTY
            // 
            btn_xoaCV_CTY.Location = new Point(272, 75);
            btn_xoaCV_CTY.Name = "btn_xoaCV_CTY";
            btn_xoaCV_CTY.Size = new Size(94, 29);
            btn_xoaCV_CTY.TabIndex = 18;
            btn_xoaCV_CTY.Text = "Xóa CV";
            btn_xoaCV_CTY.UseVisualStyleBackColor = true;
            btn_xoaCV_CTY.Click += btn_xoaCV_CTY_Click;
            // 
            // btn_suaCV_CTY
            // 
            btn_suaCV_CTY.Location = new Point(146, 75);
            btn_suaCV_CTY.Name = "btn_suaCV_CTY";
            btn_suaCV_CTY.Size = new Size(94, 29);
            btn_suaCV_CTY.TabIndex = 17;
            btn_suaCV_CTY.Text = "Sửa CV";
            btn_suaCV_CTY.UseVisualStyleBackColor = true;
            btn_suaCV_CTY.Click += btn_suaCV_CTY_Click;
            // 
            // btn_themCV_CTY
            // 
            btn_themCV_CTY.Location = new Point(21, 75);
            btn_themCV_CTY.Name = "btn_themCV_CTY";
            btn_themCV_CTY.Size = new Size(99, 29);
            btn_themCV_CTY.TabIndex = 16;
            btn_themCV_CTY.Text = "Thêm CV";
            btn_themCV_CTY.UseVisualStyleBackColor = true;
            btn_themCV_CTY.Click += btn_themCV_CTY_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 35);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 15;
            label7.Text = "Mô tả CV:";
            // 
            // cbb_motaCV
            // 
            cbb_motaCV.FormattingEnabled = true;
            cbb_motaCV.Location = new Point(97, 32);
            cbb_motaCV.Name = "cbb_motaCV";
            cbb_motaCV.Size = new Size(291, 28);
            cbb_motaCV.TabIndex = 14;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_timkiem_TenCTY);
            groupBox6.Location = new Point(434, 383);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(250, 105);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "tìm kiếm";
            // 
            // btn_timkiem_TenCTY
            // 
            btn_timkiem_TenCTY.Location = new Point(58, 35);
            btn_timkiem_TenCTY.Name = "btn_timkiem_TenCTY";
            btn_timkiem_TenCTY.Size = new Size(94, 29);
            btn_timkiem_TenCTY.TabIndex = 0;
            btn_timkiem_TenCTY.Text = "Tên công ty";
            btn_timkiem_TenCTY.UseVisualStyleBackColor = true;
            btn_timkiem_TenCTY.Click += btn_timkiem_TenCTY_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(434, 326);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 8;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // frm_congtytuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1340, 649);
            Controls.Add(btn_lammoi);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frm_congtytuyen";
            Text = "frm_congtytuyen";
            Load += frm_congtytuyen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_cty).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listCV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_sdt;
        private Label label5;
        private TextBox txt_diachi;
        private Label label4;
        private TextBox txt_tencty;
        private Label label3;
        private TextBox txt_macty;
        private Label label2;
        private GroupBox groupBox3;
        private Button btn_suacty;
        private Button btn_xoacty;
        private Button btn_themcty;
        private GroupBox groupBox4;
        private TextBox txt_id;
        private Label label6;
        private GroupBox groupBox5;
        private DataGridView dgv_cty;
        private DataGridView dgv_listCV;
        private GroupBox groupBox2;
        private Button btn_xoaCV_CTY;
        private Button btn_suaCV_CTY;
        private Button btn_themCV_CTY;
        private Label label7;
        private ComboBox cbb_motaCV;
        private GroupBox groupBox6;
        private Button btn_timkiem_TenCTY;
        private Button btn_lammoi;
    }
}