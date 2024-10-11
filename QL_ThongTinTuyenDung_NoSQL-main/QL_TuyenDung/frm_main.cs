using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TuyenDung
{
    public partial class frm_main : Form
    {
        public string TaiKhoanQly { get; private set; }
        public string PhanQuyen { get; private set; }

        public frm_main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí bắt đầu ở giữa màn hình
            kiemtra_phanQuyen(PhanQuyen);

        }

        public frm_main(string name, string quyen)
        {
            this.TaiKhoanQly = name;
            this.PhanQuyen = quyen;
            InitializeComponent();
            toolStripStatusLabel1.Text = "Xin chào: " + name;
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí bắt đầu ở giữa màn hình

            kiemtra_phanQuyen(PhanQuyen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_congtytuyen frm = new frm_congtytuyen();
            frm.ShowDialog(this);
        }

        public void kiemtra_phanQuyen(string quyen)
        {
            if (PhanQuyen == "User")
            {
                btn_saoluuphuchoi.Enabled = false;
                btn_quanlytaikhoan.Enabled = false;
            }         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ungvien frm = new frm_ungvien();
            frm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_vieccantuyen frm = new frm_vieccantuyen();
            frm.ShowDialog(this);
        }

        private void btn_saoluuphuchoi_Click(object sender, EventArgs e)
        {
            frm_saoluu_phuchoi frm = new frm_saoluu_phuchoi();
            frm.ShowDialog(this);
        }

        private void btn_quanlytaikhoan_Click(object sender, EventArgs e)
        {
            frm_taikhoan frm = new frm_taikhoan();
            frm.ShowDialog(this);
        }
    }
}
