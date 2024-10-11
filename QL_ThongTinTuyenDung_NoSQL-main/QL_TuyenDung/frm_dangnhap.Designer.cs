namespace QL_TuyenDung
{
    partial class frm_dangnhap
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
            btn_dangnhap = new Button();
            txt_mk = new TextBox();
            txt_tk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(208, 152);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(94, 29);
            btn_dangnhap.TabIndex = 19;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(211, 96);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(160, 27);
            txt_mk.TabIndex = 18;
            // 
            // txt_tk
            // 
            txt_tk.Location = new Point(211, 57);
            txt_tk.Name = "txt_tk";
            txt_tk.Size = new Size(160, 27);
            txt_tk.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 57);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 15;
            label1.Text = "Tài khoản";
            // 
            // frm_dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 232);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_mk);
            Controls.Add(txt_tk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_dangnhap";
            Text = "frm_dangnhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_dangnhap;
        private TextBox txt_mk;
        private TextBox txt_tk;
        private Label label2;
        private Label label1;
    }
}