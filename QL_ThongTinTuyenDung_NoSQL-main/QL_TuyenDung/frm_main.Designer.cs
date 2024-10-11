namespace QL_TuyenDung
{
    partial class frm_main
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btn_congtytuyen = new Button();
            btn_ungvien = new Button();
            btn_vieccantuyen = new Button();
            btn_saoluuphuchoi = new Button();
            btn_quanlytaikhoan = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 717);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1782, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(69, 20);
            toolStripStatusLabel1.Text = "Xin chào:";
            // 
            // btn_congtytuyen
            // 
            btn_congtytuyen.Location = new Point(73, 72);
            btn_congtytuyen.Name = "btn_congtytuyen";
            btn_congtytuyen.Size = new Size(220, 61);
            btn_congtytuyen.TabIndex = 3;
            btn_congtytuyen.Text = "Danh sách công ty cần tuyển";
            btn_congtytuyen.UseVisualStyleBackColor = true;
            btn_congtytuyen.Click += button1_Click;
            // 
            // btn_ungvien
            // 
            btn_ungvien.Location = new Point(624, 72);
            btn_ungvien.Name = "btn_ungvien";
            btn_ungvien.Size = new Size(175, 61);
            btn_ungvien.TabIndex = 5;
            btn_ungvien.Text = "Ung Vien";
            btn_ungvien.UseVisualStyleBackColor = true;
            btn_ungvien.Click += button3_Click;
            // 
            // btn_vieccantuyen
            // 
            btn_vieccantuyen.Location = new Point(348, 72);
            btn_vieccantuyen.Name = "btn_vieccantuyen";
            btn_vieccantuyen.Size = new Size(220, 61);
            btn_vieccantuyen.TabIndex = 6;
            btn_vieccantuyen.Text = "Việc cần tuyển";
            btn_vieccantuyen.UseVisualStyleBackColor = true;
            btn_vieccantuyen.Click += button4_Click;
            // 
            // btn_saoluuphuchoi
            // 
            btn_saoluuphuchoi.Location = new Point(348, 157);
            btn_saoluuphuchoi.Name = "btn_saoluuphuchoi";
            btn_saoluuphuchoi.Size = new Size(220, 61);
            btn_saoluuphuchoi.TabIndex = 4;
            btn_saoluuphuchoi.Text = "Sao lưu phục hồi";
            btn_saoluuphuchoi.UseVisualStyleBackColor = true;
            btn_saoluuphuchoi.Click += btn_saoluuphuchoi_Click;
            // 
            // btn_quanlytaikhoan
            // 
            btn_quanlytaikhoan.Location = new Point(73, 157);
            btn_quanlytaikhoan.Name = "btn_quanlytaikhoan";
            btn_quanlytaikhoan.Size = new Size(220, 61);
            btn_quanlytaikhoan.TabIndex = 7;
            btn_quanlytaikhoan.Text = "Quản lý tài khoản";
            btn_quanlytaikhoan.UseVisualStyleBackColor = true;
            btn_quanlytaikhoan.Click += btn_quanlytaikhoan_Click;
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 743);
            Controls.Add(btn_quanlytaikhoan);
            Controls.Add(btn_vieccantuyen);
            Controls.Add(btn_ungvien);
            Controls.Add(btn_saoluuphuchoi);
            Controls.Add(btn_congtytuyen);
            Controls.Add(statusStrip1);
            Name = "frm_main";
            Text = "frm_main";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btn_congtytuyen;
        private Button btn_ungvien;
        private Button btn_vieccantuyen;
        private Button btn_saoluuphuchoi;
        private Button btn_quanlytaikhoan;
    }
}