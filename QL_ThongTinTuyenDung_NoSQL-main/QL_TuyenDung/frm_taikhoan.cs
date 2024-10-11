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
using MongoDB.Driver;
using MongoDB.Bson;

namespace QL_TuyenDung
{
    public partial class frm_taikhoan : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        string tenColection = "login";

        public frm_taikhoan()
        {
            InitializeComponent();
            docDuLieuDatatable(tenColection);
            AddDataToComboBox();
            txt_id.ReadOnly = true;
        }

        public void docDuLieuDatatable(string colectionName)
        {
            DataTable dataTable;
            dataTable = xuly.LoadData(tenColection);
            dgv_taikhoan.DataSource = dataTable;
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dgv_taikhoan.Rows[e.RowIndex];
                txt_id.Text = rowDangChon.Cells[0].Value.ToString();
                txt_tentk.Text = rowDangChon.Cells[1].Value.ToString();
                txt_pass.Text = rowDangChon.Cells[2].Value.ToString();
                cbb_quyen.Text = rowDangChon.Cells[3].Value.ToString();
            }
        }


        private void AddDataToComboBox()
        {
            // Xóa tất cả các mục hiện có trong ComboBox (nếu cần)
            cbb_quyen.Items.Clear();
            cbb_quyen.Items.Add("Admin");
            cbb_quyen.Items.Add("User");
        }

        public BsonDocument TaoJSON()
        {
            BsonDocument document = new BsonDocument
            {
                { "_id", new BsonObjectId(ObjectId.GenerateNewId()) },
                { "TaiKhoanQly", txt_tentk.Text },
                { "MatKhauQly", txt_pass.Text },
                { "PhanQuyen", cbb_quyen.Text },
            };
            return document;
        }

        private void btn_themTK_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin tài khoản muốn thêm");
                return;
            }

            if (cbb_quyen.Text == "")
            {
                MessageBox.Show("Hãy chọn quyền");
                return;
            }

            try
            {
                BsonDocument bsonDocument = TaoJSON();
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Thêm tài khoản thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi thêm");
            }
        }

        private void btn_suaTK_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản muốn sửa");
                return;
            }

            if (cbb_quyen.Text == "")
            {
                MessageBox.Show("Hãy chọn quyền");
                return;
            }

            try
            {
                BsonDocument bsonDocument = TaoJSON();
                xuly.SuaDocumentTrongCollection(tenColection, txt_id.Text, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Sửa thông tin tài khoản thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void btn_xoaTK_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản muốn xóa");
                return;
            }

            try
            {
                xuly.XoaDocumentTrongCollection(tenColection, txt_id.Text);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Xóa tài khoản thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi xóa");
            }
        }

        private void btn_timkiem_tenTK_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text == "")
            {
                MessageBox.Show("Hàm nhập tên tài khoản để tìm");
                return;
            }

            dgv_taikhoan.DataSource = null;
            dgv_taikhoan.DataSource = xuly.TimKiemProperty(tenColection, "TaiKhoanQly", txt_tentk.Text);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            docDuLieuDatatable(tenColection);
        }
    }
}
