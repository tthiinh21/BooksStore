using MongoDB.Bson;
using MongoDB.Driver;
using QL_TruongHoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TruongHoc.GUI
{
    public partial class fCustomers : Form
    {
        public fCustomers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");
                var customers = collection.Find(FilterDefinition<Customers>.Empty).ToList();
                dataGridView1.DataSource = customers.Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    Email = d.Email,
                    Phone = d.Phone,
                    Address = d.Address
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Name");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Email");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Phone");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Address");
            }

            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");
                var newCustomers = new Customers
                {
                    Name = textBox2.Text,
                    Email = textBox3.Text,
                    Phone = textBox7.Text,
                    Address = textBox6.Text
                };

                collection.InsertOne(newCustomers);
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData(); //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Name");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Email");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Phone");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Address");
            }
            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");

                var filter = Builders<Customers>.Filter.Eq(d => d.Id, textBox1.Text);
                var update = Builders<Customers>.Update
                    .Set(d => d.Name, textBox2.Text)
                    .Set(d => d.Email, textBox3.Text)
                    .Set(d => d.Phone, textBox7.Text)
                    .Set(d => d.Address, textBox6.Text);

                collection.UpdateOne(filter, update);
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadData();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();

                //dateTimePicker1.Value = dataGridView1.CurrentRow.Cells["LastModified"].Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới collection "products" trong MongoDB
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");

                // Tạo bộ lọc dựa trên ID sản phẩm
                var filter = Builders<Customers>.Filter.Eq(d => d.Id, textBox1.Text);

                // Thực hiện xóa
                var result = collection.DeleteOne(filter);

                // Kiểm tra kết quả xóa
                if (result.DeletedCount > 0)
                {
                    LoadData(); // Tải lại dữ liệu để cập nhật DataGridView
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới collection "products"
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");

                // Tạo bộ lọc tìm kiếm theo Id hoặc Title
                var filter = Builders<Customers>.Filter.Or(
                    //Builders<Books>.Filter.Eq(d => d.Id, textBox9.Text), // Tìm kiếm theo Id
                    Builders<Customers>.Filter.Regex(d => d.Name, new BsonRegularExpression(textBox9.Text, "i")), // Tìm kiếm theo Title (không phân biệt hoa thường)
                    Builders<Customers>.Filter.Regex(d => d.Email, new BsonRegularExpression(textBox9.Text, "i"))
                );

                // Tìm kiếm các sản phẩm thỏa mãn điều kiện
                var products = collection.Find(filter).ToList();

                // Hiển thị kết quả lên DataGridView
                dataGridView1.DataSource = products.Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    Email = d.Email,
                    Phone = d.Phone,
                    Address = d.Address
                }).ToList();

                if (products.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào thỏa mãn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
