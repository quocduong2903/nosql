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
using MongoDB.Bson.Serialization;

namespace QL_TuyenDung
{
    public partial class frm_vieccantuyen : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        string tenColection = "congviec";
        string tenThuocTinh = "NhiemVu";
        public frm_vieccantuyen()
        {
            InitializeComponent();
            docDuLieuDatatable(tenColection);
            txt_idCV.ReadOnly = true;
        }

        public void docDuLieuDatatable(string colectionName)
        {
            DataTable dataTable;
            dataTable = xuly.LoadData(colectionName);

            dgv_congviec.DataSource = dataTable;

        }

        public void docDuLieuDatable_MangArray(string colectionName, string propertyName)
        {
            try
            {
                DataTable dataTable;
                dataTable = xuly.loadDataTable_PropertyArray(colectionName, propertyName, txt_idCV.Text);
                dgv_nhiemVu.DataSource = dataTable;
                dgv_nhiemVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                dgv_nhiemVu.DataSource = null;
                dgv_nhiemVu.Columns.Clear();
            }
        }

        private void dgv_congviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dgv_congviec.Rows[e.RowIndex];
                txt_idCV.Text = rowDangChon.Cells[0].Value.ToString();
                txt_macv.Text = rowDangChon.Cells[1].Value.ToString();
                txt_tencv.Text = rowDangChon.Cells[2].Value.ToString();
                txt_phongban.Text = rowDangChon.Cells[3].Value.ToString();
                txt_mota.Text = rowDangChon.Cells[4].Value.ToString();
                txt_yeucau.Text = rowDangChon.Cells[5].Value.ToString();

                // Lấy ngày tháng từ cột Index 6
                string ngayBatDau = rowDangChon.Cells[6].Value.ToString();
                // Chuyển đổi ngày tháng từ chuỗi sang DateTime
                DateTime ngayBDDateTime = DateTime.Parse(ngayBatDau);
                // Gán giá trị DateTime vào DateTimePicker
                dtb_ngaybatdau.Value = ngayBDDateTime;

                txt_luong.Text = rowDangChon.Cells[7].Value.ToString();

                txt_tennguoiLH.Text = rowDangChon.Cells[8].Value.ToString();
                txt_soDT.Text = rowDangChon.Cells[9].Value.ToString();
                txt_email.Text = rowDangChon.Cells[10].Value.ToString();

            }
            docDuLieuDatable_MangArray(tenColection, tenThuocTinh);

        }

        private void dgv_nhiemVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dgv_nhiemVu.Rows[e.RowIndex];
                txt_nhiemvu.Text = rowDangChon.Cells[0].Value.ToString();


            }
        }

        private void btn_xoa_NV_Click(object sender, EventArgs e)
        {
            if (txt_nhiemvu.Text != "")
            {
                int index = dgv_nhiemVu.CurrentRow.Index;

                try
                {
                    xuly.xoaElement_tu_PropertyArray(tenColection, tenThuocTinh, txt_idCV.Text, index);

                    MessageBox.Show("Xóa thành công!");

                    docDuLieuDatable_MangArray(tenColection, tenThuocTinh);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi khi xóa
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                // Hiển thị thông báo cho người dùng nếu không có dòng nào được chọn trong dgv_nhiemVu
                MessageBox.Show("Chọn một dòng để xóa.");
            }
        }

        public List<string> getCongViec(DataGridView dataGridView)
        {
            List<string> congViecList = new List<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string congViec = row.Cells[0].Value.ToString(); // Lấy dữ liệu từ cột 0 (cột đầu tiên)
                    congViecList.Add(congViec);
                }
            }

            return congViecList;
        }

        public BsonDocument TaoJSON(string chucnang)
        {
            BsonArray nhiemVuArray = new BsonArray();

            if (chucnang == "sua")
            {
                foreach (DataGridViewRow row in dgv_nhiemVu.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string nhiemVu = row.Cells[0].Value.ToString();
                        nhiemVuArray.Add(nhiemVu);
                    }
                }
            }
            else
            {
                nhiemVuArray.Add(txt_nhiemvu.Text);
            }



            BsonDocument document = new BsonDocument
            {
                { "MaCV", txt_macv.Text },
                { "TenCV", txt_tencv.Text },
                { "PhongBan", txt_phongban.Text },
                { "MoTaCV", txt_mota.Text },
                { "YeuCau", txt_yeucau.Text },
                { "NgayBatDau", BsonDateTime.Create(dtb_ngaybatdau.Value) },
                { "LuongCoBan", Convert.ToDouble(txt_luong.Text) },
                { "NhiemVu", nhiemVuArray },
                {
                    "ThongTinLienHe", new BsonDocument
                    {
                        { "TenNguoiLienHe", txt_tennguoiLH.Text },
                        { "SoDT", txt_soDT.Text },
                        { "Email", txt_email.Text }
                    }
                }
            };

            return document;
        }


        private void btn_themNV_Click(object sender, EventArgs e)
        {
            if (txt_nhiemvu.Text != "")
            {
                try
                {
                    xuly.ThemElementVaoPropertyArray(tenColection, tenThuocTinh, txt_idCV.Text,
                        new BsonString(txt_nhiemvu.Text));

                    MessageBox.Show("Thêm công việc thành công!");

                    docDuLieuDatable_MangArray(tenColection, tenThuocTinh);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi khi xóa
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                // Hiển thị thông báo cho người dùng nếu không có dòng nào được chọn trong dgv_nhiemVu
                MessageBox.Show("Hãy điền tên nhiệm vụ cần thêm.");
            }
        }

        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            if (txt_nhiemvu.Text != "")
            {
                int index = dgv_nhiemVu.CurrentRow.Index;

                try
                {
                    xuly.SuaElementTuPropertyArray(tenColection, tenThuocTinh, txt_idCV.Text, index, new BsonString(txt_nhiemvu.Text));

                    MessageBox.Show("Sửa thành công!");

                    docDuLieuDatable_MangArray(tenColection, tenThuocTinh);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi khi xóa
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                // Hiển thị thông báo cho người dùng nếu không có dòng nào được chọn trong dgv_nhiemVu
                MessageBox.Show("Chọn một dòng để sửa.");
            }
        }

        private void btn_themcv_Click(object sender, EventArgs e)
        {
            if (txt_nhiemvu.Text == "")
            {
                MessageBox.Show("Hãy nhập 1 nhiệm vụ");
                return;
            }

            try
            {
                BsonDocument bsonDocument = TaoJSON("them");
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Thêm công việc thành công");

            }
            catch
            {
                MessageBox.Show("Lỗi thêm");
            }
        }

        private void btn_sua_cv_Click(object sender, EventArgs e)
        {
            if (txt_idCV.Text == "")
            {
                MessageBox.Show("Hãy chọn công việc muốn sửa");
                return;
            }
            try
            {
                BsonDocument bsonDocument = TaoJSON("sua");
                xuly.SuaDocumentTrongCollection(tenColection, txt_idCV.Text, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Sửa công việc thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void btn_xoacv_Click(object sender, EventArgs e)
        {
            if (txt_idCV.Text == "")
            {
                MessageBox.Show("Hãy chọn công việc muốn xóa");
                return;
            }

            try
            {
                xuly.XoaDocumentTrongCollection(tenColection, txt_idCV.Text);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Xóa công việc thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi xóa");
            }
        }

        private void btn_timkiem_TenCV_Click(object sender, EventArgs e)
        {
            if (txt_tencv.Text == "")
            {
                MessageBox.Show("Hàm nhập tên công việc để tìm");
                return;
            }

            dgv_congviec.DataSource = null;
            dgv_congviec.DataSource = xuly.TimKiemProperty(tenColection, "TenCV", txt_tencv.Text);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_idCV.Text = "";
            txt_macv.Text = "";
            txt_tencv.Text = "";
            txt_email.Text = "";
            txt_luong.Text = "";
            txt_mota.Text = "";
            txt_nhiemvu.Text = "";
            txt_phongban.Text = "";
            txt_soDT.Text = "";
            txt_tennguoiLH.Text = "";
            txt_yeucau.Text = "";
            docDuLieuDatatable(tenColection);
        }
    }
}
