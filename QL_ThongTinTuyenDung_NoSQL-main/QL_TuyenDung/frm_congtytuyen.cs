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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace QL_TuyenDung
{
    public partial class frm_congtytuyen : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        string tenColection = "congty";
        string tenThuocTinh = "ListCV";
        BsonArray dsCV = new BsonArray();

        public frm_congtytuyen()
        {
            InitializeComponent();
            txt_id.ReadOnly = true;
            docDuLieuDatatable(tenColection);
            xuly.loadComboBox_Tu_Colection(cbb_motaCV, "congviec", "TenCV", "MaCV");

        }

        private void frm_congtytuyen_Load(object sender, EventArgs e)
        {

        }

        public void docDuLieuDatatable(string colectionName)
        {
            DataTable dataTable;
            dataTable = xuly.LoadData(colectionName);
            dgv_cty.DataSource = dataTable;
            dgv_cty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public BsonDocument TaoJSON(string chucnang)
        {
            BsonDocument document = new BsonDocument
            {
                { "_id", new BsonObjectId(ObjectId.GenerateNewId()) }, // Tạo một ObjectID ngẫu nhiên cho _id
                { "MaCTY", txt_macty.Text },
                { "TenCTY", txt_tencty.Text },
                { "DiaChi", txt_diachi.Text },
                { "SoDT", txt_sdt.Text },
                { "ListCV", new BsonArray() }
            };

            if (chucnang == "sua")
            {
                foreach (DataGridViewRow row in dgv_listCV.Rows)
                {
                    // Kiểm tra xem dòng có dữ liệu hợp lệ không (không trống)
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string maCV = row.Cells[0].Value.ToString();
                        string tenCV = row.Cells[1].Value.ToString();
                        BsonDocument cv = new BsonDocument
                        {
                            { "MaCV", maCV },
                            { "TenCV", tenCV }
                        };
                        document["ListCV"].AsBsonArray.Add(cv);
                    }
                }
            }
            else
            {
                BsonDocument cv = new BsonDocument
                {
                    { "MaCV", cbb_motaCV.SelectedValue.ToString() },
                    { "TenCV", cbb_motaCV.Text }
                };
                document["ListCV"].AsBsonArray.Add(cv);
            }



            return document;
        }


        private void btn_themcty_Click(object sender, EventArgs e)
        {
            try
            {
                BsonDocument bsonDocument = TaoJSON("them");
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Thêm thông tin công ty thành công");

            }
            catch
            {
                MessageBox.Show("Lỗi thêm");
            }
        }

        private void btn_xoacty_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Hãy chọn thông tin công ty muốn xóa");
                return;
            }

            try
            {
                xuly.XoaDocumentTrongCollection(tenColection, txt_id.Text);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Xóa công ty thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi xóa");
            }
        }

        private void btn_suacty_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Hãy chọn thông tin công ty muốn sửa");
                return;
            }
            try
            {
                BsonDocument bsonDocument = TaoJSON("sua");
                xuly.SuaDocumentTrongCollection(tenColection, txt_id.Text, bsonDocument);
                docDuLieuDatatable(tenColection);
                MessageBox.Show("Sửa thông tin công ty thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi sửa");
            }
        }

        private void dgv_cty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dgv_cty.Rows[e.RowIndex];
                txt_id.Text = rowDangChon.Cells[0].Value.ToString();
                txt_macty.Text = rowDangChon.Cells[1].Value.ToString();
                txt_tencty.Text = rowDangChon.Cells[2].Value.ToString();
                txt_diachi.Text = rowDangChon.Cells[3].Value.ToString();
                txt_sdt.Text = rowDangChon.Cells[4].Value.ToString();
            }
            docDuLieuDatable_MangArray(tenColection, tenThuocTinh)
;
        }

        public void docDuLieuDatable_MangArray(string colectionName, string propertyName)
        {
            try
            {
                DataTable dataTable;
                dataTable = xuly.loadDataTable_PropertyArray(colectionName, propertyName, txt_id.Text);
                dgv_listCV.DataSource = dataTable;
                dgv_listCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                dgv_listCV.DataSource = null;
                dgv_listCV.Columns.Clear();
            }
        }

        private void btn_themCV_CTY_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    BsonDocument newValue = new BsonDocument
                    {
                        { "MaCV", cbb_motaCV.SelectedValue.ToString() },
                        { "TenCV", cbb_motaCV.Text }
                    };

                    xuly.ThemElementVaoPropertyArray(tenColection, tenThuocTinh, txt_id.Text,
                        newValue);

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
                MessageBox.Show("Hãy chọn công việc cần tuyển cần thêm.");
            }
        }

        private void btn_suaCV_CTY_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    int index = dgv_listCV.CurrentRow.Index;

                    BsonDocument newValue = new BsonDocument
                    {
                        { "MaCV", cbb_motaCV.SelectedValue.ToString() },
                        { "TenCV", cbb_motaCV.Text }
                    };

                    xuly.SuaElementTuPropertyArray(tenColection, tenThuocTinh, txt_id.Text, index,
                        newValue);

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

        private void btn_xoaCV_CTY_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                int index = dgv_listCV.CurrentRow.Index;

                try
                {
                    xuly.xoaElement_tu_PropertyArray(tenColection, tenThuocTinh, txt_id.Text, index);

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

        private void btn_timkiem_TenCTY_Click(object sender, EventArgs e)
        {
            if (txt_tencty.Text == "")
            {
                MessageBox.Show("Hàm nhập tên công ty để tìm");
                return;
            }

            dgv_cty.DataSource = null;
            dgv_cty.DataSource = xuly.TimKiemProperty(tenColection, "TenCTY", txt_tencty.Text);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            docDuLieuDatatable(tenColection);
        }
    }
}
