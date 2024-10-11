namespace QL_TuyenDung
{
    partial class frm_saoluu_phuchoi
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
            btn_phuchoi = new Button();
            btn_saoluu = new Button();
            rtb_phuchoi = new RichTextBox();
            rtb_saoluu = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_phuchoi);
            groupBox1.Controls.Add(btn_saoluu);
            groupBox1.Controls.Add(rtb_phuchoi);
            groupBox1.Controls.Add(rtb_saoluu);
            groupBox1.Location = new Point(88, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao lưu phục hồi";
            // 
            // btn_phuchoi
            // 
            btn_phuchoi.Location = new Point(61, 222);
            btn_phuchoi.Name = "btn_phuchoi";
            btn_phuchoi.Size = new Size(94, 29);
            btn_phuchoi.TabIndex = 3;
            btn_phuchoi.Text = "Phục hồi";
            btn_phuchoi.UseVisualStyleBackColor = true;
            btn_phuchoi.Click += btn_phuchoi_Click;
            // 
            // btn_saoluu
            // 
            btn_saoluu.Location = new Point(61, 83);
            btn_saoluu.Name = "btn_saoluu";
            btn_saoluu.Size = new Size(94, 29);
            btn_saoluu.TabIndex = 2;
            btn_saoluu.Text = "Sao lưu";
            btn_saoluu.UseVisualStyleBackColor = true;
            btn_saoluu.Click += btn_saoluu_Click;
            // 
            // rtb_phuchoi
            // 
            rtb_phuchoi.Location = new Point(240, 184);
            rtb_phuchoi.Name = "rtb_phuchoi";
            rtb_phuchoi.Size = new Size(490, 120);
            rtb_phuchoi.TabIndex = 1;
            rtb_phuchoi.Text = "";
            // 
            // rtb_saoluu
            // 
            rtb_saoluu.Location = new Point(240, 36);
            rtb_saoluu.Name = "rtb_saoluu";
            rtb_saoluu.Size = new Size(490, 120);
            rtb_saoluu.TabIndex = 0;
            rtb_saoluu.Text = "";
            // 
            // frm_saoluu_phuchoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(960, 409);
            Controls.Add(groupBox1);
            Name = "frm_saoluu_phuchoi";
            Text = "frm_saoluu_phuchoi";
            Load += frm_saoluu_phuchoi_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_phuchoi;
        private Button btn_saoluu;
        private RichTextBox rtb_phuchoi;
        private RichTextBox rtb_saoluu;
    }
}