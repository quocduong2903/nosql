using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace WinForms_Library
{
    public class Xuly_NoSQL
    {
        public MongoClient client;
        public IMongoDatabase database;

        public string TaiKhoanQly { get; set; }
        public string PhanQuyen { get; set; }

        public Xuly_NoSQL(string databasename)
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase(databasename);

        }

        public Xuly_NoSQL()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("QL_Tuyendung");

        }




        public Xuly_NoSQL kiemTraDN(string username, string password)
        {
            var collection = database.GetCollection<BsonDocument>("login");

            // Tạo một BsonDocument để truy vấn dựa trên thông tin đăng nhập
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoanQly", username) &
                          Builders<BsonDocument>.Filter.Eq("MatKhauQly", password);

            // Tìm Document phù hợp
            var document = collection.Find(filter).FirstOrDefault();

            // Nếu document khác null, cập nhật thông tin đăng nhập trong đối tượng hiện tại
            if (document != null)
            {
                TaiKhoanQly = document["TaiKhoanQly"].AsString;
                PhanQuyen = document["PhanQuyen"].AsString;
                return this;
            }

            // Nếu không tìm thấy Document phù hợp, trả về null hoặc một giá trị thích hợp để biểu thị không đăng nhập thành công
            return null;
        }


        public DataTable LoadData(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var documents = collection.Find(new BsonDocument()).ToList();

            DataTable dataTable = new DataTable();

            // Tạo danh sách tên thuộc tính để bỏ qua
            List<string> excludedProperties = new List<string>
            {
                "NhiemVu", "ListCV" // Thêm các tên thuộc tính bạn muốn bỏ qua vào danh sách này
            };

            foreach (var data in documents)
            {
                // Nếu DataTable chưa có cột nào, hãy tạo cột dựa trên document đầu tiên
                if (dataTable.Columns.Count == 0)
                {
                    CreateColumnsFromDocument(dataTable, data, "", excludedProperties);
                }

                // Thêm dữ liệu từ Document vào DataTable
                var rowData = new List<object>();
                ExtractDataFromDocument(rowData, data, excludedProperties);
                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }

        public void CreateColumnsFromDocument(DataTable dataTable, BsonDocument document, string prefix, List<string> excludedProperties)
        {
            foreach (var element in document.Elements)
            {
                if (!excludedProperties.Contains(element.Name)) // Kiểm tra xem thuộc tính có trong danh sách bỏ qua không
                {
                    if (element.Value.IsBsonDocument)
                    {
                        // Nếu trường là một Document con, xử lý các trường con
                        var subDocument = element.Value.AsBsonDocument;
                        CreateColumnsFromDocument(dataTable, subDocument, prefix + element.Name + "_", excludedProperties);
                    }
                    else if (element.Value.IsBsonArray)
                    {
                        // Xử lý dữ liệu trong mảng
                        var array = element.Value.AsBsonArray;
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].IsBsonDocument)
                            {
                                // Xử lý các document con trong mảng
                                var subDocument = array[i].AsBsonDocument;
                                CreateColumnsFromDocument(dataTable, subDocument, prefix + element.Name + i + "_", excludedProperties);
                            }
                            else
                            {
                                // Xử lý các giá trị trong mảng (có thể là string, number, boolean, etc.)
                                dataTable.Columns.Add(prefix + element.Name + i, typeof(object));
                            }
                        }
                    }
                    else
                    {
                        // Kiểm tra xem cột đã tồn tại chưa trước khi thêm vào
                        if (!dataTable.Columns.Contains(prefix + element.Name))
                        {
                            dataTable.Columns.Add(prefix + element.Name, typeof(object));
                        }
                    }
                }
            }
        }

        public void ExtractDataFromDocument(List<object> rowData, BsonDocument document, List<string> excludedProperties)
        {
            foreach (var element in document.Elements)
            {
                if (!excludedProperties.Contains(element.Name)) // Kiểm tra xem thuộc tính có trong danh sách bỏ qua không
                {
                    if (element.Value.IsBsonDocument)
                    {
                        // Nếu trường là một Document con, xử lý các trường con
                        var subDocument = element.Value.AsBsonDocument;
                        ExtractDataFromDocument(rowData, subDocument, excludedProperties);
                    }
                    else if (element.Value.IsBsonArray)
                    {
                        // Xử lý dữ liệu trong mảng
                        var array = element.Value.AsBsonArray;
                        foreach (var arrayElement in array)
                        {
                            if (arrayElement.IsBsonDocument)
                            {
                                // Xử lý các document con trong mảng
                                var subDocument = arrayElement.AsBsonDocument;
                                ExtractDataFromDocument(rowData, subDocument, excludedProperties);
                            }
                            else
                            {
                                // Xử lý các giá trị trong mảng (có thể là string, number, boolean, etc.)
                                rowData.Add(arrayElement);
                            }
                        }
                    }
                    else
                    {
                        rowData.Add(element.Value);
                    }
                }
            }
        }





        public void ThemDocumentVaoCollection(string collectionName, BsonDocument document)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Thêm Document vào collection
            collection.InsertOne(document);
        }

        public void SuaDocumentTrongCollection(string collectionName, string documentId, BsonDocument newDocument)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Tạo một filter để xác định Document cần sửa dựa trên "_id" và giá trị documentId
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));

            // Loại bỏ trường "_id" từ newDocument trước khi cập nhật
            newDocument.Remove("_id");

            // Sử dụng phương thức ReplaceOne để thay thế Document đầu tiên phù hợp với filter bằng newDocument
            var result = collection.ReplaceOne(filter, newDocument);

            // Kiểm tra xem có Document nào bị sửa không
            if (result.ModifiedCount > 0)
            {
                // Sửa thành công
                MessageBox.Show("Document đã được sửa.");
            }
            else
            {
                // Không tìm thấy Document phù hợp để sửa
                MessageBox.Show("Không tìm thấy Document phù hợp để sửa.");
            }
        }


        public void XoaDocumentTrongCollection(string collectionName, string documentId)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Tạo một filter để xác định Document cần xóa dựa trên "_id" và giá trị documentId
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));

            // Sử dụng phương thức DeleteOne để xóa Document đầu tiên phù hợp với filter
            var result = collection.DeleteOne(filter);

            // Kiểm tra xem có Document nào bị xóa không
            if (result.DeletedCount > 0)
            {
                // Xóa thành công
                MessageBox.Show("Document đã được xóa.");
            }
            else
            {
                // Không tìm thấy Document phù hợp để xóa
                MessageBox.Show("Không tìm thấy Document phù hợp để xóa.");
            }
        }


        public DataTable loadDataTable_PropertyArray(string collectionName, string propertyName, string documentId)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                MessageBox.Show("Không có nhiệm vụ");
                return null;
            }

            DataTable dataTable = new DataTable();

            var propertyValue = document[propertyName];
            if (propertyValue.IsBsonArray)
            {
                var array = propertyValue.AsBsonArray;

                // Xác định các cột tự động dựa trên các thuộc tính trong đối tượng đầu tiên trong mảng (nếu có)
                if (array.Count > 0)
                {
                    var firstElement = array[0];
                    if (firstElement.IsBsonDocument)
                    {
                        var firstObject = firstElement.AsBsonDocument;
                        foreach (var property in firstObject)
                        {
                            dataTable.Columns.Add(property.Name, typeof(string));
                        }
                    }
                    else
                    {
                        // Nếu đối tượng đầu tiên không phải là BsonDocument, thêm một cột duy nhất
                        dataTable.Columns.Add(propertyName, typeof(string));
                    }
                }

                // Thêm dữ liệu từ mảng vào DataTable
                foreach (var arrayElement in array)
                {
                    if (arrayElement.IsBsonDocument)
                    {
                        var cvObject = arrayElement.AsBsonDocument;
                        var rowData = cvObject.Values.Select(val => val.AsString).ToArray();
                        dataTable.Rows.Add(rowData);
                    }
                    else
                    {
                        // Nếu phần tử không phải là BsonDocument, thêm giá trị vào cột duy nhất
                        dataTable.Rows.Add(arrayElement.AsString);
                    }
                }
            }

            return dataTable;
        }


        public void xoaElement_tu_PropertyArray(string collectionName, string propertyName, string documentId, int index)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                MessageBox.Show("Lỗi");
            }

            var propertyValue = document[propertyName];
            if (propertyValue.IsBsonArray)
            {
                var array = propertyValue.AsBsonArray;
                if (index >= 0 && index < array.Count)
                {
                    array.RemoveAt(index);

                    // Cập nhật document với mảng đã cập nhật
                    var update = Builders<BsonDocument>.Update.Set(propertyName, array);
                    collection.UpdateOne(filter, update);
                }
                else
                {
                    throw new Exception($"Index {index} is out of bounds for property {propertyName} of document with ID {documentId}");
                }
            }
            else
            {
                throw new Exception($"Property {propertyName} is not an array in document with ID {documentId}");
            }
        }

        public void SuaElementTuPropertyArray(string collectionName, string propertyName, string documentId, int index, BsonValue newValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                MessageBox.Show("Lỗi");
            }

            var propertyValue = document[propertyName];
            if (propertyValue.IsBsonArray)
            {
                var array = propertyValue.AsBsonArray;
                if (index >= 0 && index < array.Count)
                {
                    // Kiểm tra xem newValue có phải là BsonDocument hay không
                    if (newValue.IsBsonDocument)
                    {
                        // Nếu newValue là BsonDocument, thay đổi phần tử trong mảng bằng newValue
                        array[index] = newValue;
                    }
                    else
                    {
                        // Nếu newValue không phải là BsonDocument, tạo một đối tượng BsonDocument mới với giá trị là newValue và thay đổi phần tử trong mảng
                        var newElement = new BsonDocument { { "Value", newValue } };
                        array[index] = newElement;
                    }

                    // Cập nhật document với mảng đã cập nhật
                    var update = Builders<BsonDocument>.Update.Set(propertyName, array);
                    collection.UpdateOne(filter, update);
                }
                else
                {
                    throw new Exception($"Index {index} is out of bounds for property {propertyName} of document with ID {documentId}");
                }
            }
            else
            {
                throw new Exception($"Property {propertyName} is not an array in document with ID {documentId}");
            }
        }



        public void ThemElementVaoPropertyArray(string collectionName, string propertyName, string documentId, BsonValue newValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            var document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                MessageBox.Show("Lỗi");
            }

            var propertyValue = document[propertyName];
            if (propertyValue.IsBsonArray)
            {
                var array = propertyValue.AsBsonArray;

                if (newValue.IsBsonDocument)
                {
                    // Nếu newValue là một đối tượng BsonDocument, thêm nó vào mảng
                    array.Add(newValue);
                }
                else
                {
                    // Nếu newValue không phải là đối tượng BsonDocument, tạo một đối tượng BsonDocument mới và thêm nó vào mảng
                    var newElement = new BsonDocument { { "Value", newValue } };
                    array.Add(newElement);
                }

                // Cập nhật document với mảng đã cập nhật
                var update = Builders<BsonDocument>.Update.Set(propertyName, array);
                collection.UpdateOne(filter, update);
            }
            else
            {
                throw new Exception($"Property {propertyName} is not an array in document with ID {documentId}");
            }
        }


        public void loadComboBox_Tu_Colection(ComboBox comboBox, string collectionName, string namePropertyDisplay, string namePropertyValue)
        {
            // Lấy danh sách các bản ghi từ collection
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = collection.Find(filter).ToList();

            // Tạo danh sách giá trị cho ComboBox
            List<KeyValuePair<string, string>> comboBoxItems = new List<KeyValuePair<string, string>>();

            foreach (var document in documents)
            {
                string dis = document.GetValue(namePropertyDisplay).ToString();
                string val = document.GetValue(namePropertyValue).ToString();
                comboBoxItems.Add(new KeyValuePair<string, string>(val, dis));
            }

            // Đặt danh sách giá trị vào ComboBox
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = comboBoxItems;
        }

        public DataTable TimKiemProperty(string collectionName, string propertyName, string propertyValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Tạo một filter để tìm các tài liệu có thuộc tính propertyName chứa propertyValue
            var filter = Builders<BsonDocument>.Filter.Regex(propertyName, new BsonRegularExpression($"/{propertyValue}/i"));

            var documents = collection.Find(filter).ToList();

            DataTable dataTable = new DataTable();

            // Tạo danh sách tên thuộc tính để bỏ qua
            List<string> excludedProperties = new List<string>
            {
                "NhiemVu", "ListCV" // Thêm các tên thuộc tính bạn muốn bỏ qua vào danh sách này
            };

            foreach (var data in documents)
            {
                // Nếu DataTable chưa có cột nào, hãy tạo cột dựa trên document đầu tiên
                if (dataTable.Columns.Count == 0)
                {
                    CreateColumnsFromDocument(dataTable, data, "", excludedProperties);
                }

                // Thêm dữ liệu từ Document vào DataTable
                var rowData = new List<object>();
                ExtractDataFromDocument(rowData, data, excludedProperties);
                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }


    }
}
