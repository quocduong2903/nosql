namespace QL_TuyenDung
{
    partial class frm_taikhoan
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
            groupBox1 = new GroupBox();
            dgv_taikhoan = new DataGridView();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txt_id = new TextBox();
            cbb_quyen = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_pass = new TextBox();
            txt_tentk = new TextBox();
            groupBox3 = new GroupBox();
            btn_xoaTK = new Button();
            btn_suaTK = new Button();
            btn_themTK = new Button();
            groupBox4 = new GroupBox();
            btn_timkiem_tenTK = new Button();
            btn_lammoi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_taikhoan);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản";
            // 
            // dgv_taikhoan
            // 
            dgv_taikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_taikhoan.Dock = DockStyle.Fill;
            dgv_taikhoan.Location = new Point(3, 23);
            dgv_taikhoan.Name = "dgv_taikhoan";
            dgv_taikhoan.RowHeadersWidth = 51;
            dgv_taikhoan.RowTemplate.Height = 29;
            dgv_taikhoan.Size = new Size(532, 252);
            dgv_taikhoan.TabIndex = 0;
            dgv_taikhoan.CellClick += dgv_taikhoan_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_id);
            groupBox2.Controls.Add(cbb_quyen);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_pass);
            groupBox2.Controls.Add(txt_tentk);
            groupBox2.Location = new Point(624, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 233);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 39);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 7;
            label4.Text = "_id:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(124, 36);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(174, 27);
            txt_id.TabIndex = 6;
            // 
            // cbb_quyen
            // 
            cbb_quyen.FormattingEnabled = true;
            cbb_quyen.Location = new Point(124, 171);
            cbb_quyen.Name = "cbb_quyen";
            cbb_quyen.Size = new Size(174, 28);
            cbb_quyen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 179);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Quyền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 128);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 78);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên tài khoản:";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(124, 121);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(174, 27);
            txt_pass.TabIndex = 1;
            // 
            // txt_tentk
            // 
            txt_tentk.Location = new Point(124, 75);
            txt_tentk.Name = "txt_tentk";
            txt_tentk.Size = new Size(174, 27);
            txt_tentk.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_xoaTK);
            groupBox3.Controls.Add(btn_suaTK);
            groupBox3.Controls.Add(btn_themTK);
            groupBox3.Location = new Point(15, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(532, 90);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quản lý tài khoản";
            // 
            // btn_xoaTK
            // 
            btn_xoaTK.Location = new Point(364, 31);
            btn_xoaTK.Name = "btn_xoaTK";
            btn_xoaTK.Size = new Size(128, 29);
            btn_xoaTK.TabIndex = 2;
            btn_xoaTK.Text = "Xóa tài khoản";
            btn_xoaTK.UseVisualStyleBackColor = true;
            btn_xoaTK.Click += btn_xoaTK_Click;
            // 
            // btn_suaTK
            // 
            btn_suaTK.Location = new Point(181, 31);
            btn_suaTK.Name = "btn_suaTK";
            btn_suaTK.Size = new Size(131, 29);
            btn_suaTK.TabIndex = 1;
            btn_suaTK.Text = "Sửa tài khoản";
            btn_suaTK.UseVisualStyleBackColor = true;
            btn_suaTK.Click += btn_suaTK_Click;
            // 
            // btn_themTK
            // 
            btn_themTK.Location = new Point(17, 28);
            btn_themTK.Name = "btn_themTK";
            btn_themTK.Size = new Size(132, 29);
            btn_themTK.TabIndex = 0;
            btn_themTK.Text = "Thêm tài khoản";
            btn_themTK.UseVisualStyleBackColor = true;
            btn_themTK.Click += btn_themTK_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_timkiem_tenTK);
            groupBox4.Location = new Point(624, 382);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 71);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btn_timkiem_tenTK
            // 
            btn_timkiem_tenTK.Location = new Point(50, 24);
            btn_timkiem_tenTK.Name = "btn_timkiem_tenTK";
            btn_timkiem_tenTK.Size = new Size(141, 29);
            btn_timkiem_tenTK.TabIndex = 0;
            btn_timkiem_tenTK.Text = "Tên tài khoản";
            btn_timkiem_tenTK.UseVisualStyleBackColor = true;
            btn_timkiem_tenTK.Click += btn_timkiem_tenTK_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(633, 327);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 4;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // frm_taikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(983, 519);
            Controls.Add(btn_lammoi);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frm_taikhoan";
            Text = "frm_taikhoan";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_taikhoan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgv_taikhoan;
        private GroupBox groupBox2;
        private ComboBox cbb_quyen;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_pass;
        private TextBox txt_tentk;
        private GroupBox groupBox3;
        private Button btn_xoaTK;
        private Button btn_suaTK;
        private Button btn_themTK;
        private Label label4;
        private TextBox txt_id;
        private GroupBox groupBox4;
        private Button btn_timkiem_tenTK;
        private Button btn_lammoi;
    }
}