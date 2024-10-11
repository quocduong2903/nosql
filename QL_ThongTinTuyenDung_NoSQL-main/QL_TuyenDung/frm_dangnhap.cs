using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Library;
using MongoDB.Bson;
using MongoDB.Driver;


namespace QL_TuyenDung
{
    public partial class frm_dangnhap : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL("QL_Tuyendung");


        public frm_dangnhap()
        {
            InitializeComponent();
            txt_mk.PasswordChar = '*';
            txt_mk.Text = "123456";
            txt_tk.Text = "admin1";
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;

            if (tk.Length == 0 || mk.Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            Xuly_NoSQL thongTinDangNhap = xuly.kiemTraDN(tk, mk);
            // Kiểm tra đăng nhập
            if (thongTinDangNhap == null)
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

            // Nếu đăng nhập thành công, tắt form hiện hành và mở form frm_main
            this.Hide();
            frm_main mainForm = new frm_main(thongTinDangNhap.TaiKhoanQly, thongTinDangNhap.PhanQuyen);
            mainForm.Show(); // Mở form frm_main
        }
    }
}
